<script setup>
import axios from 'axios';
import ConfirmAppointment from '../components/ConfirmAppointment.vue';
import DeleteAppointment from '../components/DeleteAppointment.vue';
</script>

<template>
  <div class="terminverwaltungView">
    <ConfirmAppointment :appointment="popup.appointment" v-if="popup.type == 'confirm'" @close="loadCalendar()">
    </ConfirmAppointment>
    <DeleteAppointment :appointment="popup.appointment" v-if="popup.type == 'delete'" @close="loadCalendar()">
    </DeleteAppointment>
    <div class="calendarHeader">
      <div class="headerArrow" v-on:click="changeMonth(-1)">&#x2B9C;</div>
      <h3 class="headerMonth">{{ months[currentMonth] }} {{ currentYear }}</h3>
      <div class="headerArrow" v-on:click="changeMonth(1)">&#x2B9E;</div>
    </div>
    <div class="kalender">
      <div class="headerCell">Montag</div>
      <div class="headerCell">Dienstag</div>
      <div class="headerCell">Mittwoch</div>
      <div class="headerCell">Donnerstag</div>
      <div class="headerCell">Freitag</div>
      <div class="headerCell">Samstag</div>
      <div class="headerCell">Sonntag</div>
      <div v-for="d in days" v-bind:key="d.timestamp" v-bind:class="{
          dayCell: true,
          disabled: d.month != currentMonth,
          weekend: !d.isWorkingDay,
          holiday: d.isPublicHoliday,
          today: d.timestamp == today,

        }">


        <div class="dayHeader">
          <div class="dayNumber">
            {{ d.day }}<span v-if="d.month != currentMonth">.{{ d.month }}.</span>

          </div>
          <div class="holidayName">{{ d.schoolHolidayName }}</div>

        </div>
        <div class="appointments">
          <div class="appointment" v-for="a in d.appointments" v-bind:key="a.guid">
            <div class="appointmentData" :class="{notConfirmed: !a.confirmed}">
              {{ new Date(a.timestamp).toLocaleString('de-AT', { hour: '2-digit', minute: '2-digit' }) }} -
              {{ new Date(a.end).toLocaleString('de-AT', { hour: '2-digit', minute: '2-digit' }) }}
              {{ a.patientFirstname }} {{ a.patientLastname }}
            </div>
            <div class="appointmentButtons">
              <span @click="showPopup(a, 'confirm')" title="Termin bestätigen"><i class="fa-solid fa-circle-check"></i></span>
              <span @click="showPopup(a, 'delete')" title="Termin stornieren"><i class="fa-solid fa-ban"></i></span>
            </div>
          </div>
        </div>
      </div>
    </div>
  </div>
</template>



<style scoped>
.calendarHeader {
  display: flex;
  gap: 1em;
  align-items: center;
}

.calendarHeader h3 {
  margin: 0;
  padding: 0;
}

.headerArrow {
  cursor: pointer;
  font-size: 200%;
}

.headerMonth {
  flex: 8em 0 0;
}

.holidayName {
  overflow: hidden;
  white-space: nowrap;
  font-size: 80%;
}

.kalender {
  display: grid;
  width: 100%;
  grid-template-columns: repeat(5, minmax(0, 1fr)) repeat(2, minmax(0, 0.5fr));
  grid-template-rows: auto repeat(6, minmax(3em, auto));
}

.headerCell {
  overflow: hidden;
  font-weight: bolder;
  border: 1px solid hsl(0, 0%, 85%);
}

.dayCell {
  border: 1px solid hsl(0, 0%, 85%);
  padding: 0.2em;
}

.dayCell:hover {
  border: 2px solid hsl(0, 0%, 10%);
}

.disabled {
  color: hsl(0, 0%, 70%);
}

.weekend {
  background-color: hsl(0, 0%, 97%);
}

.holiday {
  background-color: hsl(0, 100%, 95%);
}

.today {
  border: 2px solid hsl(0, 0%, 10%);
}

.dayHeader {
  display: flex;
  flex-wrap: wrap;
  align-items: center;
}

.dayNumber {
  font-weight: bolder;
  flex-grow: 1;
}

.appointments {
  font-size: 80%;
}

.appointment {
  cursor: pointer;
  display: flex;
}

.appointment:hover {
  background-color: linen;
}

.appointmentData {
  flex-grow: 1;
}

.appointmentButtons {
  display: flex;
  gap: 0.5rem;
  font-size: 150%;
  line-height: 120%;
}

.fa-circle-check {
  color:green;
}

.fa-ban {
  color:red;
}

.notConfirmed {
  color:gray;
}
</style>

<script>

export default {
  data() {
    return {
      months: ['', 'Jänner', 'Februar', 'März', 'April', 'Mai', 'Juni', 'Juli', 'August', 'September', 'Oktober', 'November', 'Dezember'],
      currentYear: 2023,
      currentMonth: 4,
      today: Math.floor(Date.now() / 86_400_000) * 86_400_000,
      days: [],
      popup: {},
    };
  },
  components: {},
  async mounted() {
    // this.currentYear = new Date().getFullYear();
    // this.currentMonth = new Date().getMonth() + 1;
    await this.loadCalendar();
  },
  methods: {
    async loadCalendar() {
      this.popup = {};
      try {
        const res = await axios.get(`calendar/${this.currentYear}/${this.currentMonth}`);
        this.days = res.data;
      } catch (e) {
        alert(JSON.stringify(e));
      }
    },
    async changeMonth(step) {
      const newMonth = Math.max(2001 * 12, Math.min(2100 * 12, this.currentYear * 12 + (this.currentMonth - 1) + step));
      this.currentYear = Math.floor(newMonth / 12);
      this.currentMonth = (newMonth % 12) + 1;
      await this.loadCalendar();
    },
    showPopup(appointment, type) {
      this.popup = { type, appointment };
    }
  },
};
</script>

