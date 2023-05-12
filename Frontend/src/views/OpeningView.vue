<template>
    <div class="openingView">
        <h1>Öffnungszeiten</h1>
        <h2>Todo</h2>
        <ul>
            <li>Im Backend das Modell erweitern, sodass Öffnungszeiten pro Wochentag gespeichert werden können.</li>
            <li>Im Backend das Modell erweitern, sodass einzelne Tage mit besonderen Öffnungszeiten gespeichert werden können.</li>
            <li>Daten im Backend seeden.</li>
            <li>Die Daten für das aktuelle Monat hier anzeigen.</li>
            <li>Für die Vergabe von besonderen Öffnungszeiten kann vielleicht die Kalenderansicht
                wie bei Termine verwalten verwendet werden, um ordinationsfreie Tage einfacher
                eingeben zu können.</li>
        </ul>
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

