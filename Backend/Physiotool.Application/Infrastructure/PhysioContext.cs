using Bogus;
using Bogus.DataSets;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Physiotool.Application.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Physiotool.Application.Infrastructure
{
    public class PhysioContext : DbContext
    {
        public DbSet<User> Users => Set<User>();
        public DbSet<Patient> Patients => Set<Patient>();
        public DbSet<Appointment> Appointments => Set<Appointment>();
        public DbSet<AppointmentState> AppointmentStates => Set<AppointmentState>();
        public DbSet<DeletedAppointmentState> DeletedAppointmentStates => Set<DeletedAppointmentState>();
        public DbSet<ConfirmedAppointmentState> ConfirmedAppointmentStates => Set<ConfirmedAppointmentState>();

        public PhysioContext(DbContextOptions<PhysioContext> opt) : base(opt)
        { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AppointmentState>().HasDiscriminator(a => a.Name);
            foreach (var entityType in modelBuilder.Model.GetEntityTypes())
            {
                foreach (var key in entityType.GetForeignKeys())
                    key.DeleteBehavior = DeleteBehavior.Restrict;

                foreach (var prop in entityType.GetDeclaredProperties())
                {
                    if (prop.Name == "Guid")
                    {
                        modelBuilder.Entity(entityType.ClrType).HasAlternateKey("Guid");
                        prop.ValueGenerated = Microsoft.EntityFrameworkCore.Metadata.ValueGenerated.OnAdd;
                    }
                    if (prop.ClrType == typeof(string) && prop.GetMaxLength() is null) prop.SetMaxLength(255);
                    if (prop.ClrType == typeof(DateTime)) prop.SetPrecision(3);
                    if (prop.ClrType == typeof(DateTime?)) prop.SetPrecision(3);
                }
            }
        }

        /// <summary>
        /// Initialize the database with some values (holidays, ...).
        /// Unlike Seed, this method is also called in production.
        /// </summary>
        private void Initialize()
        {
            var users = new List<User>
            {
                new User(username: "admin", initialPassword: "1111")
            };
            Users.AddRange(users);
            SaveChanges();
        }

        /// <summary>
        /// Creates the database. Called once at application startup.
        /// </summary>
        public void CreateDatabase(bool isDevelopment)
        {
            if (isDevelopment) { Database.EnsureDeleted(); }
            // EnsureCreated only creates the model if the database does not exist or it has no
            // tables. Returns true if the schema was created.  Returns false if there are
            // existing tables in the database. This avoids initializing multiple times.
            if (Database.EnsureCreated()) { Initialize(); }
            if (isDevelopment) Seed();
        }

        /// <summary>
        /// Generates random values for testing the application. This method is only called in development mode.
        /// </summary>
        private void Seed()
        {
            Randomizer.Seed = new Random(1511);
            var faker = new Faker("de");
            var patients = SeedPatients(faker);
            SeedAppointments(faker, patients);
        }

        private List<Patient> SeedPatients(Faker faker)
        {
            // Demopatienten erstellen
            var patients = new Faker<Patient>("de").CustomInstantiator(f =>
            {
                return new Patient(
                    firstname: f.Name.FirstName(),
                    lastname: f.Name.LastName(),
                    street: f.Address.StreetAddress(),
                    zip: f.Random.Int(100, 999) * 10,
                    city: f.Address.City(),
                    email: f.Internet.Email(),
                    phone: f.Phone.PhoneNumber())
                { Guid = faker.Random.Guid() };
            })
            .Generate(200)
            .GroupBy(p => p.Email).Select(g => g.First())
            .ToList();
            Patients.AddRange(patients);
            SaveChanges();
            return patients;
        }

        private List<Appointment> SeedAppointments(Faker faker, List<Patient> patients)
        {
            // Termine zu den Patienten erstellen. Dafür erstellen wir 100 Termine und weisen sie
            // jeweils einen zufälligen Patienten zu.
            var appointments = new Faker<Appointment>("de").CustomInstantiator(f =>
            {
                // Ein Termin wird zwischen 1.1. letzten Jahres bis 1 Monat im Voraus erstellt. 1.9.2021 und 1.6.2023 erstellt.
                var today = DateTime.UtcNow.Date;
                var date = f.Date.Between(new DateTime(today.Year - 1, 1, 1), today.AddDays(31)).Date;
                if (date.DayOfWeek == DayOfWeek.Saturday || date.DayOfWeek == DayOfWeek.Sunday)
                    date = date.AddDays(2);
                // Termine nur zu vollen 1/4 Stunden erstellen.
                var time = TimeSpan.FromMinutes(8 * 60 + f.Random.Int(0, 32) * 15);
                // 1 - 3 Tage vor dem Termin ist die Anmeldung.
                var appointmentCreated = (date + time).AddSeconds(-f.Random.Int(24 * 3600, 72 * 3600));

                var appointmentState = f.Random.Int(1, 3) switch
                {
                    2 => new ConfirmedAppointmentState(
                        created: appointmentCreated.AddMinutes(f.Random.Int(30, 5 * 1440)),
                        duration: TimeSpan.FromMinutes(f.Random.Int(2, 8) * 15), infotext: f.Lorem.Sentence(4).OrNull(f, 0.5f)),
                    3 => new DeletedAppointmentState(appointmentCreated.AddMinutes(f.Random.Int(30, 5 * 1440))),
                    _ => new AppointmentState(appointmentCreated)
                };
                return new Appointment(
                        date: date, time: time, patient: f.Random.ListItem(patients), created: appointmentCreated,
                        appointmentState: appointmentState)
                { Guid = faker.Random.Guid() };
            })
            .Generate(1000)
            .ToList();
            Appointments.AddRange(appointments);
            SaveChanges();
            return appointments;
        }
    }
}