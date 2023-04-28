<!-- eslint-disable vue/no-mutating-props -->
<script setup>
import axios from 'axios';
</script>

<template>
    <div class="confirmAppointment popup">
        <div class="popup-inner">
            <h2>Termin bestätigen</h2>
            <p>für {{ appointment.patientFirstname }} {{ appointment.patientLastname }}
                am {{ new Date(appointment.timestamp).toDateString() }}
                um {{ new Date(appointment.timestamp).toLocaleString('de-AT', { hour: '2-digit', minute: '2-digit' }) }}
            </p>
            <div>
                <label style="margin-right: 13px;" for="duration">Termin Dauer:</label>
                <select v-model="appointment.duration" id="duration">
                    <option value="00:30:00">30 Minuten</option>
                    <option value="00:45:00">45 Minuten</option>
                    <option value="01:00:00">60 Minuten</option>
                </select>
            </div>
            <div>
                <label>Zusätzliche Information:</label>
                <input type="text" v-model="appointment.infotext">
            </div>
            <button class="btn3" @click="saveForm()" type="button">Speichern</button>
            <button class="btn4" @click="$emit('close')">Abbrechen</button>
        </div>
    </div>
</template>

<style scoped>
.popup {
    position: fixed;
    top: 0;
    left: 0;
    width: 100%;
    height: 100%;
    background: rgba(0, 0, 0, 0.5);
    display: flex;
    justify-content: center;
    align-items: center;
}

input {
    border: 1px solid black;
}

.popup-inner {
    background: white;
    padding: 20px;
    border-radius: 5px;
    text-align: center;
}

.btn1,
.btn3 {
    background-color: #2196f3;
    /* Blaue Farbe */
    border: none;
    color: white;
    padding: 8px 16px;
    text-align: center;
    text-decoration: none;
    display: inline-block;
    font-size: 10px;
    margin: 4px 2px;
    cursor: pointer;
    border-radius: 4px;
    transition: all 0.3s ease;

}

.btn4,
.btn2 {
    background-color: #f32128;
    /* Rote Farbe */
    border: none;
    color: white;
    padding: 8px 16px;
    text-align: center;
    text-decoration: none;
    display: inline-block;
    font-size: 10px;
    margin: 4px 2px;
    cursor: pointer;
    border-radius: 4px;
    transition: all 0.3s ease;

}

.btn1:hover,
.btn3:hover {
    background-color: #0d8bf5;
    /* Dunklere blaue Farbe bei Hover */
}

.btn4:hover,
.btn2:hover {
    background-color: #ed5356;
    /* Dunklere rote Farbe bei Hover */
}

@media only screen and (max-width: 600px) {

    .btn1,
    .btn2,
    .btn3 {
        padding: 10px 20px;
        /* Kleinere Größe bei kleineren Bildschirmen */
    }
}
</style>
<script>
export default {
    data() {
        return {

        }
    },
    props: {
        appointment: Object
    },
    methods: {
        async saveForm() {
            try {
                await axios.post(`appointment/confirm/${this.appointment.guid}`, this.appointment);
            }
            catch (e) {
                console.log(e);
                if (e.response) alert(JSON.stringify(e.response.data));
                else alert("Fehler beim Speichern der Termindaten.");
            }
            this.$emit("close");
        }
    }

}
</script>
