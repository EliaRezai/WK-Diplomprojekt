public class Physio {
    public int Id { get; set; }

    [Required]
    public string Name { get; set; }

    [Required]
    public string Address { get; set; }

    public List<OpeningHour> OpeningHours { get; set; }

    public virtual ICollection<OpeningHour> SpecialOpeningHours { get; set; }
}
