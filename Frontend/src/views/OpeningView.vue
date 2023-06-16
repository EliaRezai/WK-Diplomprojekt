<template>
    <div class="openingView">
        
        <ul>
            <li>Im Backend das Modell erweitern, sodass Öffnungszeiten pro Wochentag gespeichert werden können.</li>
            <li>Im Backend das Modell erweitern, sodass einzelne Tage mit besonderen Öffnungszeiten gespeichert werden können.</li>
            <li>Daten im Backend seeden.</li>
            <li>Die Daten für das aktuelle Monat hier anzeigen.</li>
            <li>Für die Vergabe von besonderen Öffnungszeiten kann vielleicht die Kalenderansicht
                wie bei Termine verwalten verwendet werden, um ordinationsfreie Tage einfacher
                eingeben zu können.</li>
        </ul>
       
       
        <div class="opening-hours">
    <div class="opening-hours__left">
      <h1>Öffnungszeiten</h1>
      <ul>
        <li v-for="(day, index) in openingHours" :key="index">
          <span class="day">{{ day.name }}:</span>
          <span class="time">{{ day.open }} - {{ day.close }}</span>
        </li>
      </ul>
    </div>
    <div class="opening-hours__right">
      <h1>Kontakt</h1>
      <p>Telefon: +43 676 3285511</p>
      <p>Telefon: +43 676 8885341</p>
      <p>Email: marcela.nikolic@gmx.at</p>
    </div>
  </div>




    </div>
</template>


<style>
.opening-hours {
  display: flex;
  max-width: 800px;
  margin: 0 auto;
  padding: 20px;
  background-color: #f5f5f5;
}

.opening-hours__left {
  flex: 1;
}

.opening-hours__right {
  flex: 1;
  padding-left: 20px;
}

h1 {
  margin-bottom: 20px;
}

ul {
  list-style-type: none;
  padding: 0;
}

li {
  margin-bottom: 10px;
}

.day {
  font-weight: bold;
}

.time {
  margin-left: 10px;
}

h2 {
  margin-bottom: 10px;
}

p {
  margin: 0;
}
</style>

<script>
export default {
  data() {
    return {
      openingHours: [
        { name: "Montag", open: "09:00", close: "18:00" },
        { name: "Dienstag", open: "09:00", close: "18:00" },
        { name: "Mittwoch", open: "09:00", close: "18:00" },
        { name: "Donnerstag", open: "09:00", close: "18:00" },
        { name: "Freitag", open: "09:00", close: "18:00" },
        { name: "Samstag", open: "10:00", close: "15:00" },
        { name: "Sonntag", open: "geschlossen", close: "" },
      ],
    };
  },
};
</script>