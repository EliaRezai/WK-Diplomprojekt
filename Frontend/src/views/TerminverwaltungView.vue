<script setup>
import axios from 'axios';
</script>

<template>
    <div class="terminverwaltungView">
        <h2>Todo</h2>
        <ul>
            <li>Dies ist die Admin Oberfläche für den angemeldeten User.</li>
            <li>Beim Klick auf den Termin kann die Dauer festgelegt werden. Im Backend wird
                der AppointmentState auf Confirmed gesetzt.
            </li>
            <li>Der Termin kann auch gelöscht werden (wenn der Patient storniert)</li>
        </ul>
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
            <div
                v-for="d in days"
                v-bind:key="d.timestamp"
                v-bind:class="{
                    dayCell: true,
                    disabled: d.month != currentMonth,
                    weekend: !d.isWorkingDay,
                    holiday: d.isPublicHoliday,
                    today: d.timestamp == today,
                    
                }"
                
            >
            
            
                <div class="dayHeader">
                    <div class="dayNumber">
                        {{ d.day }}<span v-if="d.month != currentMonth">.{{ d.month }}.</span>
                        
                    </div>
                    <div class="holidayName">{{ d.schoolHolidayName }}</div>
                    
                </div>
                <div class="appointments">
                    <div class="appointment" v-for="a in d.appointments" v-bind:key="a.guid">
                        {{ new Date(a.timestamp).toLocaleString('de-AT', { hour: '2-digit', minute: '2-digit' }) }}
                        {{ a.patientFirstname }} {{ a.patientLastname }}

                        
                    </div>
                    
                </div>

             <!-- Popup Buttons -->   
            <button class="btn1" @click="showPopup">Daten hinzufügen</button>
            <button class="btn2" @click="showDeletePopup">Daten löschen</button>
            </div>
        </div>
        

<!-- Hier wird ein Popup aufgerufen um Daten zu löschen, über das Backend sollten die Daten aus der Datenbank entfernt werden -->
    <div v-if="popupDelete" class="popup">
      <div class="popup-inner">
        <h2>Daten löschen</h2>

<form @submit.prevent="deleteForm">
        
         <div>
            <p>Geben sie die ID des zu löschenden Termins ein</p>
            <label style="margin-left: 62px;" for="name">Appointment-ID:</label>
            <input id="name" v-model="formData.AppointmendID" type="text">
          </div>
    
          <div>
            <label for="name">Zusätzliche Information:</label>
            <input id="name" v-model="formData.Infos" type="text">
          </div>

          <button class="btn3" type="submit">Löschen</button>
        </form>

        <button class="btn4" @click="closeDeletePopup">Abbrechen</button>

        
      </div>
    </div>

<!-- Hier wird ein Popup aufgerufen um zusätzliche Daten bzw. Dauer eines Termines festzulegen, über das Backend sollten die Daten gespeichert werden -->
    <div v-if="popupVisible" class="popup"> 
      <div class="popup-inner">
        <h2>Daten hinzufügen</h2>

<form @submit.prevent="submitForm">
        <div>
    <label style="margin-right: 13px;" for="duration">Termin Dauer:</label>
    <select v-model="duration" id="duration">
      <option value="30">30 Minuten</option>
      <option value="45">45 Minuten</option>
      <option value="60">60 Minuten</option>
    </select>
  </div>

         <div>
            <label style="margin-left: 62px;" for="name">Appointment-ID:</label>
            <input id="name" v-model="formData.AppointmendID" type="text">
          </div>
    
          <div>
            <label for="name">Zusätzliche Information:</label>
            <input id="name" v-model="formData.Infos" type="text">
          </div>

          <button class="btn3" type="submit">Speichern</button>
        </form>

        <button class="btn4" @click="closePopup">Abbrechen</button>

        
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
}

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

.popup-inner {
  background: white;
  padding: 20px;
  border-radius: 5px;
  text-align: center;
}

.btn1, .btn3 {
  background-color: #2196f3; /* Blaue Farbe */
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

.btn4, .btn2 {
  background-color: #f32128; /* Rote Farbe */
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

.btn1:hover, .btn3:hover{
  background-color: #0d8bf5; /* Dunklere blaue Farbe bei Hover */
}

.btn4:hover, .btn2:hover{
  background-color: #ed5356; /* Dunklere rote Farbe bei Hover */
}

@media only screen and (max-width: 600px) {
  .btn1, .btn2, .btn3{
    padding: 10px 20px; /* Kleinere Größe bei kleineren Bildschirmen */
  }
}
</style>

<script>

export default {
    data() {
        return {
            months: ['', 'Jänner', 'Februar', 'März', 'April', 'Mai', 'Juni', 'Juli', 'August', 'September', 'Oktober', 'November', 'Dezember'],
            currentYear: 2021,
            currentMonth: 1,
            today: Math.floor(Date.now() / 86_400_000) * 86_400_000,
            days: [],
            popupVisible: false,
      formData: {
        Termindauer: '',
        AppointmendID: '',
        Infos: '',

      },
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

       

      async deleteForm() {
        if (confirm('Sind Sie sicher, dass Sie die Daten löschen möchten?')) {
            // Hier wird die Funktion zum Löschen der Daten aufgerufen
          // Zum Beispiel: this.$axios.delete(`/api/data/${this.dataId}`)
      axios.delete('/api/data', this.formData) // Hier muss die URL zur API stehen
        .then(response => {
          console.log(response.data); // Hier wird die Antwort der API verarbeitet
          this.closePopup(); // Das Popup wird nach dem Speichern geschlossen
        })
        .catch(error => {
          console.log(error);
        });
        }
      },

       //Frühere Methode zum löschen von Daten! 
       //----------------------------------------------------------------------------------------------------------
      // async deleteData() {
      //  if (confirm('Sind Sie sicher, dass Sie die Daten löschen möchten?')) {
          // Hier wird die Funktion zum Löschen der Daten aufgerufen
          // Zum Beispiel: this.$axios.delete(`/api/data/${this.dataId}`)
      //    this.closePopup();
      //  axios.delete('/api/data') // Hier muss die URL zur API stehen
      
      //  .then(response => {
      //    console.log(response.data); // Hier wird die Antwort der API verarbeitet
      //  })
      //  .catch(error => {
      //    console.log(error);
      //  });
      //  }
      // },
     //-----------------------------------------------------------------------------------------------------------
     showPopup() {
      this.popupVisible = true;
    },
    closePopup() {
      this.popupVisible = false;
    },
    showDeletePopup() {
        this.popupVisible = true;
    },
    closeDeletePopup() {
      this.popupVisible = false;
    },

     submitForm() {
      axios.post('/api/data', this.formData) // Hier muss die URL zur API stehen
        .then(response => {
          console.log(response.data); // Hier wird die Antwort der API verarbeitet
          this.closePopup(); // Das Popup wird nach dem Speichern geschlossen
        })
        .catch(error => {
          console.log(error);
        });
    
    },
},
};
</script>

