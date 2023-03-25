<template>
    <div class="terminView">
        <!-- Load Font Awesome Icon Library -->
        <link rel="stylesheet" href="https://cdnjs.cloudflare.com/ajax/libs/font-awesome/4.7.0/css/font-awesome.min.css" />

        <div class="description">
            <p>
                Sehr geehrte Patienten! In der folgenden Tabelle sehen Sie Termine, welche für Sie zu Verfügung stehen.
                Der Button Termin ermöglicht es Ihnen, eine zeitliche Auswahl zu treffen.
                Haben Sie sich für einen Termin entschieden, drücken Sie auf den Button "Reservieren" in der Zeile des
                gewünschten Termins.
            </p>
        </div>
        <div class="appointmentForm">
            <div class="block">
                <div class="label">Vorname:</div>
                <div class="control">
                    <input type="text" required maxlength="255" minlength="1" v-model="model.patientFirstname" />
                    <span class="validationError" v-if="validation.patientFirstname">{{ validation.patientFirstname
                    }}</span>
                </div>
            </div>
            <div class="block">
                <div class="label">Nachname:</div>
                <div class="control">
                    <input type="text" required maxlength="255" minlength="1" v-model="model.patientLastname" />
                    <span class="validationError" v-if="validation.patientLastname">{{ validation.patientLastname }}</span>
                </div>
            </div>
            <div class="block">
                <div class="label">Straße:</div>
                <div class="control">
                    <input type="text" required maxlength="255" minlength="1" v-model="model.patientStreet" />
                    <span class="validationError" v-if="validation.patientStreet">{{ validation.patientStreet }}</span>
                </div>
            </div>

            <div class="inline">
                <div class="block">
                    <div class="label">PLZ:</div>
                    <div class="control">
                        <input type="number" min="1000" max="9999" v-model="model.patientZip" />
                        <span class="validationError" v-if="validation.patientZip">{{ validation.patientZip }}</span>
                    </div>
                </div>
                <div class="block">
                    <div class="label">Ort:</div>
                    <div class="control">
                        <input type="text" required maxlength="255" minlength="1" v-model="model.patientCity" />
                        <span class="validationError" v-if="validation.patientCity">{{ validation.patientCity }}</span>
                    </div>
                </div>
            </div>
            <div class="block">

                <div class="label">E-Mail:</div>
                <div class="control">
                    <input type="email" required maxlength="255" minlength="1" v-model="model.patientEmail" />
                    <span class="validationError" v-if="validation.patientEmail">{{ validation.patientEmail }}</span>
                </div>
            </div>
            <div class="block">

                <div class="label">Telefon:</div>
                <div class="control">
                    <input type="tel" required maxlength="255" minlength="1" v-model="model.patientPhone" />
                    <span class="validationError" v-if="validation.patientPhone">{{ validation.patientPhone }}</span>
                </div>
            </div>

            <div class="block">

                <div class="label">Datum:</div>
                <div class="control">
                    <input type="date" min="" max="" v-model="model.date" />
                    <span class="validationError" v-if="validation.date">{{ validation.date }}</span>
                </div>
            </div>

            <div class="block">

                <div class="label">Uhrzeit:</div>
                <div class="control">
                    <input type="time" min="07:30" max="18:30" step="600" v-model="model.time" />
                    <span class="validationError" v-if="validation.time">{{ validation.time }}</span>
                </div>
            </div>
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
            model: {},
            validation: {}
        };
    },

    mounted() {
        this.initForm();
    },

    methods: {
        initForm() {
            this.model = {};
            this.model.date = new Date(Date.now() + 86_400_000).toISOString().substring(0, 10);
            this.model.time = "07:30";            
        },
        async sendReservation() {
            try {
                this.validation = {};
                this.model.time = `${this.model.time.substring(0, 5)}:00`;
                await axios.post('appointment', this.model);
                alert("Danke für Ihre Reservierung!");
                this.initForm();
            }
            catch (e) {
                if (e.response?.status == 400) {
                    if (typeof e.response.data.errors === "object")
                        this.validation = Object.keys(e.response.data.errors).reduce((prev, key) => {
                            const newKey = key.charAt(0).toLowerCase() + key.slice(1);
                            prev[newKey] = e.response.data.errors[key][0];
                            return prev;
                        }, {});
                    else
                        alert(e.response.data);
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

.terminView {
    margin-top: 5px;
    background-color: #eee;
    border-style: solid;
    border-width: 1px;
    border-color: rgb(86, 83, 83);
    margin-left: 10px;
    margin-right: 10px;
    display: flex;
    flex-direction: column;
    padding: 0.5rem;
}

@media (min-width: 40rem) {
    .appointmentForm {
        display: grid;
        grid-template-columns: repeat(2, 1fr);
        column-gap: 1rem;
        row-gap: 0.5rem;
        width: 100%;
        max-width: 70rem;
        align-self: center;
    }
}

.appointmentForm .block {
    display: flex;
    flex-direction: column;
}

.appointmentForm .inline {
    display: flex;
    flex-direction: row;
    column-gap: 0.5rem;
}

.appointmentForm .inline div:nth-child(2) {
    flex-grow: 1;
}

.appointmentForm input {
    width: 100%;
}

.appointmentForm button {
    grid-column: span 2;
}

.validationError {
    color: red;
    font-size: 80%;
}
</style>





