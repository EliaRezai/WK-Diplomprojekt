<template>
    <div class="openingView">
        
       
       
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
  export default {
  data() {
    return {
      openingHours: [
        { name: "Montag", open: "07:30", close: "15:00" },
        { name: "Dienstag", open: "07:30", close: "15:00" },
        { name: "Mittwoch", open: "07:30", close: "15:00" },
        { name: "Donnerstag", open: "07:30", close: "15:00" },
        { name: "Freitag", open: "07:30", close: "15:00" },
        { name: "Samstag", open: "geschlossen", close: "" },
        { name: "Sonntag", open: "geschlossen", close: "" },
      ],
    };
  },
  };
  
  </script>
  
  
  <style>
  .opening-hours {
  display: flex;
  max-width: 800px;
  margin: 0 auto;
  padding: 20px;
  margin-top: 5px;
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