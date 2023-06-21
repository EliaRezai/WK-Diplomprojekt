<script setup>
import axios from 'axios';

</script>

<template>
    <h1>Terminübersicht für {{ patient.firstname }} {{ patient.lastname }}</h1>
    <p>Hier sehen Sie alle gebuchten Termine.
        Bitte speichern Sie die Seite <a v-bind:href="url">{{ url }}</a> in den Favoriten ab.
        Über diese Seite können Sie immer den Status Ihrer Termine nachsehen.</p>
    <div class="appointments">
        <ul>
            <li v-for="a in patient.appointments" v-bind:key="a.guid">
                {{ new Date(a.date).toLocaleDateString() }} {{ a.time }} Bestätigt: {{ a.confirmed ? "Ja" : "Nein" }}
            </li>
        </ul>
    </div>
</template>

<script>
export default {
    data() {
        return {
            patient: {},
            url: ""

        }
    },
    async mounted() {
        this.patient = (await axios.get(`patient/${this.patientGuid}`)).data;
        this.url = window.location.href;

    },
    computed: {
        patientGuid() { return this.$route.params.id; }
    }
}
</script>