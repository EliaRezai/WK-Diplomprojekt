<!-- eslint-disable vue/no-mutating-props -->
<script setup>
import axios from 'axios';
</script>

<template>
    <div class="confirmAppointment popup">
        <div class="popup-inner">
            <h2>Termin löschen</h2>
            <p>Soll der Termin mit {{ appointment.patientFirstname }} {{ appointment.patientLastname }}
                am {{ new Date(appointment.timestamp).toDateString() }}
                um {{ new Date(appointment.timestamp).toLocaleString('de-AT', { hour: '2-digit', minute: '2-digit' }) }}
                storniert werden?</p>
            <button class="btn3" @click="deleteAppointment()" type="button">Ja</button>
            <button class="btn4" @click="$emit('close')">Nein</button>
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
        async deleteAppointment() {
            try {
                await axios.delete(`appointment/${this.appointment.guid}`);
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
