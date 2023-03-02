<template>
  <div class="terminView">
    <!-- Load Font Awesome Icon Library -->
    <link
      rel="stylesheet"
      href="https://cdnjs.cloudflare.com/ajax/libs/font-awesome/4.7.0/css/font-awesome.min.css"
    />

    <div class="row">
      <div class="description">
        <p>
          Sehr geehrte Patienten! In der folgenden Tabelle sehen Sie Termine,
          welche für Sie zu Verfügung stehen. Der Button Termin ermöglicht es
          Ihnen, eine zeitliche Auswahl zu treffen. Haben Sie sich für einen
          Termin entschieden, drücken Sie auf den Button "Reservieren" in der
          Zeile des gewünschten Termins.
        </p>
      </div>

      <form to="">
        <label for="appointment-time">Wähle einen Termin:</label>

        <!-- <select id="appointment-time" name="appointment-time" v-model="selectedAppointment">
      <option v-for="appointment in appointments" :key="appointment">{{ appointment }}</option>
    </select>
    -->
        <label for="date"> Datum:</label>

        <input type="date" id="date" name="trip-start" min="" max="" />

        <label for="date">Uhrzeit:</label>

        <input type="time" min="07:30:00" max="18:30:00" step="600" />

        <label for="first-name">Vorname:</label>
        <input
          type="text"
          id="first-name"
          name="first-name"
          v-model="firstName"
        />

        <label for="last-name">Nachname:</label>
        <input type="text" id="last-name" name="last-name" v-model="lastName" />

        <label for="email">E-Mail:</label>
        <input type="email" id="email" name="email" v-model="email" />

        <input type="submit" value="Reservieren" @click.prevent="submit" />
      </form>
    </div>
  </div>
</template>

<script>
import axios from "axios";
export default {
  data() {
    return {
      appointments: [],
      selectedAppointment: "",
      firstName: "",
      lastName: "",
      email: "",
    };
  },

  mounted() {
    let start = new Date();
    let end = new Date();
    end.setMonth(end.getMonth() + 6);

    while (start < end) {
      let appointment =
        start.toLocaleDateString() + " " + start.toLocaleTimeString();
      this.appointments.push(appointment);
      start.setHours(start.getHours() + 1);
    }

    document.getElementById("date").valueAsDate = new Date();
  },

  methods: {
    submit() {
      alert(
        "Reservierung erfolgreich!\n\n" +
          "Termin: " +
          this.selectedAppointment +
          "\n" +
          "Vorname: " +
          this.firstName +
          "\n" +
          "Nachname: " +
          this.lastName +
          "\n" +
          "E-Mail: " +
          this.email
      );

      axios.post('/setAppointment', "test").then(response => console.log(response));
    },
  },
};
</script>





<style scoped>
.p {
  text-align: center;
  margin-top: 20px;
  display: inline;
  width: 100px;
  height: 100px;
  padding: 5px;
}

.row {
  margin-top: 5px;
  background-color: #eee;
  border-style: solid;
  text-align: center;
  border-width: 1px;
  border-color: rgb(86, 83, 83);
  margin-left: 10px;
  margin-right: 10px;
}
</style>





