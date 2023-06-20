<template>
      <div class="description">
        <h1>Terminverwaltung</h1>
      <p>
        Sehr geehrte Patienten! In der folgenden Tabelle sehen Sie Termine,
        welche für Sie zu Verfügung stehen. Der Button Termin ermöglicht es
        Ihnen, eine zeitliche Auswahl zu treffen. Haben Sie sich für einen
        Termin entschieden, drücken Sie auf den Button "Reservieren" in der
        Zeile des gewünschten Termins.
      </p>
    </div>
  <div class="terminView">
    <!-- Load Font Awesome Icon Library -->
    <link
      rel="stylesheet"
      href="https://cdnjs.cloudflare.com/ajax/libs/font-awesome/4.7.0/css/font-awesome.min.css"
    />


    <div class="appointmentForm">
      <div class="block">
        <div class="label">Vorname:</div>
        <div class="control">
          <input
            type="text"
            required
            maxlength="255"
            minlength="1"
            v-model="model.patientFirstname"
          />
          <span class="validationError" v-if="validation.patientFirstname">{{
            validation.patientFirstname
          }}</span>
        </div>
      </div>
      <div class="block">
        <div class="label">Nachname:</div>
        <div class="control">
          <input
            type="text"
            required
            maxlength="255"
            minlength="1"
            v-model="model.patientLastname"
          />
          <span class="validationError" v-if="validation.patientLastname">{{
            validation.patientLastname
          }}</span>
        </div>
      </div>
      <div class="block">
        <div class="label">Straße:</div>
        <div class="control">
          <input
            type="text"
            required
            maxlength="255"
            minlength="1"
            v-model="model.patientStreet"
          />
          <span class="validationError" v-if="validation.patientStreet">{{
            validation.patientStreet
          }}</span>
        </div>
      </div>

      <div class="inline">
        <div class="block">
          <div class="label">PLZ:</div>
          <div class="control">
            <input
              type="number"
              min="1000"
              max="9999"
              v-model="model.patientZip"
            />
            <span class="validationError" v-if="validation.patientZip">{{
              validation.patientZip
            }}</span>
          </div>
        </div>
        <div class="block">
          <div class="label">Ort:</div>
          <div class="control">
            <input
              type="text"
              required
              maxlength="255"
              minlength="1"
              v-model="model.patientCity"
            />
            <span class="validationError" v-if="validation.patientCity">{{
              validation.patientCity
            }}</span>
          </div>
        </div>
      </div>
      <div class="block">
        <div class="label">E-Mail:</div>
        <div class="control">
          <input
            type="email"
            required
            maxlength="255"
            minlength="1"
            v-model="model.patientEmail"
          />
          <span class="validationError" v-if="validation.patientEmail">{{
            validation.patientEmail
          }}</span>
        </div>
      </div>
      <div class="block">
        <div class="label">Telefon:</div>
        <div class="control">
          <input
            type="tel"
            required
            maxlength="255"
            minlength="1"
            v-model="model.patientPhone"
          />
          <span class="validationError" v-if="validation.patientPhone">{{
            validation.patientPhone
          }}</span>
        </div>
      </div>

      <div class="block">
        <div class="label">Datum:</div>
        <div class="control">
          <input
            type="date"
            min=""
            max=""
            v-model="model.date"
            @change="updateList()"
          />
          <span class="validationError" v-if="validation.date">{{
            validation.date
          }}</span>
        </div>
      </div>

      <div class="block"></div>

      <!-- <button v-on:click="sendReservation()">Senden</button> -->
    </div>
  </div>

  
  <div
    style="
     text-align: center;
  position: relative;
  cursor: pointer;
  min-width: 230px;
  margin-bottom: 20px;
      margin-left: 20px;
      margin-right: 20px;
      margin-top: 7px;
      display: flex;
      place-content: space-between;
      padding: 10px;
      top: 50%;
     widows: 50%;
  background: #fff;
  border-style: solid;
  border-color: #19293696;
    "
    v-for="appointment in appointmentsAvailable"
  >
    <div>
      <p>{{ appointment.substring(0, 5) }}</p>
    </div>

    <button  style="  grid-column: span 2;
  display: inline-block;
text-decoration: none;
color: #192936;
border: 1px solid #52a1e2;
padding: 10px 14px;
font-size: 13px;
background: transparent;
position: relative;
cursor: pointer;"
      type="button"
      class="btn btn-outline-dark"
      v-on:click="sendReservation()"
    >
      Termin Buchen
    </button>
  </div>
  <div class="newfooter">
        <link rel="stylesheet" href=https://cdnjs.cloudflare.com/ajax/libs/font-awesome/6.4.0/css/all.min.css />
        <div class="newcontainer">
            <div class="newrow">

                <div class="newfooter-col">
                    <h4>Links</h4>
                    <ul>
                    <li>
                        <router-link v-on:click="fullHeight = true" to="/">Startseite</router-link>
                    </li>
                    <li>
                        <router-link v-on:click="fullHeight = false" to="/praxis">Praxis</router-link>
                    </li>
                    <li>
                        <router-link v-on:click="fullHeight = false" to="/therapie">Therapien</router-link>
                    </li>
                    <li>
                        <router-link v-on:click="fullHeight = false" to="/termin">Termin buchen</router-link>
                    </li>
                </ul>
                </div>

                <div class="newfooter-col">
                    <h4>Adresse</h4>
                    <ul>
                        <li><a href="#">Alte Poststraße 14e</a></li>
                        <li><a href="#">Maria Ellend </a></li>
                        <li><a href="#">2402</a></li>
                        <li><a href="#">Österreich</a></li>
                       
                                   
                     </ul>
                </div>

                <div class="newfooter-col">
                    <h4>Kontakte</h4>
                    <ul>
                        <li><a href="#">+43 676 3285511</a></li>
                        <li><a href="#">+43 676 8885341</a></li>

                        <li><a href="#">marcela.nikolic@gmx.at</a></li>
                                      
                    </ul>
                </div>

                <div class="newfooter-col">
                    <h4>follow us</h4>
                    <div class="social-links">

                        <a href="#"><i class="fab fa-facebook-f"></i></a> 
                        <a href="#"><i class="fab fa-twitter"></i></a> 
                        <a href="#"><i class="fab fa-instagram"></i></a> 
                        <a href="#"><i class="fab fa-linkedin-in"></i></a> 

                    </div>
                   
                </div>

            </div>
        </div>
    </div>
</template>

<script>
import DatePicker from "vue-datepicker-next";
import "vue-datepicker-next/index.css";
import axios from "axios";
export default {
  data() {
    return {
      appointments: [],
      model: {},
      validation: {},
      appointmentsAvailable: [],
    };
  },

  mounted() {
    this.initForm();
  },
  components: {
    DatePicker,
  },
  methods: {
    updateList() {
      console.log(this.model.date);
      axios
        .get(
          "appointment/available?day=" +
            this.model.date +
            ""
        )
        .then((response) =>
          console.log((this.appointmentsAvailable = response.data))
        );
    },
    disabledTime(date) {
      return (
        date < new Date(date.getTime()).setHours(8, 0, 0, 0) ||
        date > new Date(date.getTime()).setHours(18, 0, 0, 0)
      );
    },
    initForm() {
      this.model = {};
      this.model.date = new Date(Date.now() + 86_400_000)
        .toISOString()
        .substring(0, 10);
      this.model.time = "07:30";
    },

    async sendReservation() {
      try {
        this.validation = {};
        this.model.time = `${this.model.time.substring(0, 5)}:00`;
        const result = (await axios.post("appointment", this.model)).data;
        this.$router.push({ path: `/patient/${result.patientGuid}`});
      } catch (e) {
        if (e.response?.status == 400) {
          if (typeof e.response.data.errors === "object")
            this.validation = Object.keys(e.response.data.errors).reduce(
              (prev, key) => {
                const newKey = key.charAt(0).toLowerCase() + key.slice(1);
                prev[newKey] = e.response.data.errors[key][0];
                return prev;
              },
              {}
            );
          else alert(e.response.data);
        } else {
          alert(`Server responded with Status ${e.response?.status}`);
        }
      }
    },
  },
};
</script>




