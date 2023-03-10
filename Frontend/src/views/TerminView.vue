<template>
    <div class="terminView">
        <!-- Load Font Awesome Icon Library -->
        <link rel="stylesheet" href="https://cdnjs.cloudflare.com/ajax/libs/font-awesome/4.7.0/css/font-awesome.min.css" />

        <div class="row">
            <div class="description">
                <p>
                    Sehr geehrte Patienten! In der folgenden Tabelle sehen Sie Termine, welche für Sie zu Verfügung stehen. Der Button Termin ermöglicht es Ihnen, eine zeitliche Auswahl zu treffen.
                    Haben Sie sich für einen Termin entschieden, drücken Sie auf den Button "Reservieren" in der Zeile des gewünschten Termins.
                </p>
            </div>
                <label for="appointment-time">Wähle einen Termin:</label>

                <!-- <select id="appointment-time" name="appointment-time" v-model="selectedAppointment">
      <option v-for="appointment in appointments" :key="appointment">{{ appointment }}</option>
    </select>
    -->
                <label for="date"> Datum:</label>

                <input type="date" id="date" name="trip-start" min="" max="" v-model="model.date" />

                <label for="date">Uhrzeit:</label>

                <input type="time" min="07:30:00" max="18:30:00" step="600" v-model="model.time" />

                <label for="first-name">Vorname:</label>
                <input type="text" id="first-name" name="first-name" v-model="model.patientFirstname" />

                <label for="last-name">Nachname:</label>
                <input type="text" id="last-name" name="last-name" v-model="model.patientLastname" />

                <label for="email">E-Mail:</label>
                <input type="email" id="email" name="email" v-model="model.patientEmail" />

                <button v-on:click="sendReservation()">Senden</button>
        </div>
    </div>
</template>

<script>
import axios from 'axios';
export default {
    data() {
        return {
            appointments: [],
            model: {}
        };
    },

    mounted() {
        let start = new Date();
        let end = new Date();
        end.setMonth(end.getMonth() + 6);

        while (start < end) {
            let appointment = start.toLocaleDateString() + ' ' + start.toLocaleTimeString();
            this.appointments.push(appointment);
            start.setHours(start.getHours() + 1);
        }

        document.getElementById('date').valueAsDate = new Date();
    },

    methods: {
        async sendReservation() {
          try {
            await axios.post('appointment', this.model);
          }
          catch (e) {
            if (e.response?.status == 400) {
              // TODO: Validation
              alert(JSON.stringify(e.response.data));
            }
            else {
              alert(`Server responded with Status ${e.response?.status}`);
            }
          }
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





