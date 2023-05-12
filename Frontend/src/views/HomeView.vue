<template>
    <div class="homeView">
        <div class="text-box">
            <h1>Ihre Physiotherapie Innere Stadt</h1>
            <p>
                Die Physiotherapeuten unserer Wiener Praxis verfolgen das Ziel, die Bewegungs- und Funktionsfähigkeit deiner Gelenke und des gesamten Bewegungsapparates bei <br />
                Beschwerden, Schmerzen oder nach Verletzungen und Unfällen zu verbessern bzw. wiederherzustellen.
            </p>
            <a href="" class="hero-btn">PHSIOTHRAPIE BEGINNEN</a>
        </div>

        <div class="c">
            <p></p>
            <iframe
            src="https://www.google.com/maps/embed?pb=!1m18!1m12!1m3!1d2663.9423364842696!2d16.691406176224405!3d48.111348071240634!2m3!1f0!2f0!3f0!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0x476c57a2c8280e4d%3A0x1567ee56dd0dcc07!2sAlte%20Poststra%C3%9Fe%2014%2C%202402!5e0!3m2!1sde!2sat!4v1681374680397!5m2!1sde!2sat" 
                width="600"
                height="450"
                style="border: 0"
                allowfullscreen=""
                loading="lazy"
                referrerpolicy="no-referrer-when-downgrade"
            ></iframe>
        </div>

      

        <!---------------- facilities ------------->

        <div class="facilities">
            <h1>Wir aktivieren deine körpereigenen Heilkräfte</h1>
            <p>
                und helfen deinem Körper, sich selbst zu heilen. Die Physiotherapeuten setzen durch natürliche Reize die körpereigenen Heilkräfte in Gang und leiten dadurch den Heilungsprozess ein
                oder beschleunigen diesen.
            </p>

            <div class="row">
                <div class="facilities-col">
                    <img src="@/assets/images/44.jpg" />
                    <h3>Physio Übungen</h3>
                    <p>
                        die du begleitend zur Behandlung in unserer Praxis in Wien zu Hause durchführen kannst. Unser Team ist darauf spezialisiert, nicht nur eine kurzfristige Erleichterung zu
                        verschaffen, sondern dich dabei zu unterstützen, langfristig schmerzen
                    </p>
                </div>
                <div class="facilities-col">
                    <img src="@/assets/images/77.jpg" />
                    <h3>Individuellbehandlung</h3>
                    <p>
                        Am Beginn der Physiotherapie steht eine persönliche Befunderhebung und detaillierte Diagnose , in welcher der Therapeut/die Therapeutin alle relevanten Informationen sammelt.
                    </p>
                </div>
                <div class="facilities-col">
                    <img src="@/assets/images/011.jpg" />
                    <h3>Hilfe zur Selbsthilfe</h3>
                    <p>Als verantwortungsvolle Therapeuten machen wir unsere Patienten nicht von uns abhängig, sondern zeigen Mittel und Wege auf, wie du dir selbst helfen kannst.</p>
                </div>
            </div>
        </div>

          <!--Course-->

          <div class="course">
            <h1>
                Das Ziel unserer Physiotherapie
            </h1>
            <p>
                Unser Team geht es an Spezialisten der Ursache deiner Probleme auf den Grund und sorgt in der angenehmen Atmosphäre unserer Praxis mit individuellen<br />
                Behandlungsmethoden dafür, dass du dich schon bald wieder weitgehend beschwerdefrei bewegen kannst.
            </p>
            <div class="row">
                <div class="course-col">
                    <h3>Termin buchen</h3>
                    <p>Buche jetzt ein Termin und nur nach wenigen Therapie-Einheiten wirst du bereits spürbare Ergebnisse wahrnehmen</p>
                </div>
                <div class="course-col">
                    <h3>Tipps zu Übungen</h3>
                    <p>Um beste Ergebnisse bei der Genesung zu erzielen, gehen wir nach einem Behandlungskonzept vor, das auf zwei wesentlichen Säulen beruht.</p>
                </div>
                <div class="course-col">
                    <h3>Wichtige Infos</h3>
                    <p>Die Aktivierung der körpereigenen Heilkräfte Die Unterstützung der Regeneration durch selbstständige Durchführung</p>
                </div>
            </div>
        </div>


        <div class="cta">
            <h1>Buchen Sie sich Ihren freien Termin</h1>
            <a href="" class="hero-btn">Termin buchen</a>
        </div>

        <!------- footer ------>

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
    </div>
</template>

