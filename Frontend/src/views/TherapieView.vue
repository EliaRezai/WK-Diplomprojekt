<template>
    <div class="therapieView">
        <div class="about-us">
            <div class="row">
                <div class="a-col">
                    <h1>Professionelle Massage in wiener Innenstadt</h1>
                    <p>
                      Durch Massagen in der wiener innenstadt Physiotherapie lassen sich
                      muskuläre Verspannungen, Verklebungen, oder Verhärtungen lösen.
                      Dadurch verbessert sich dein körperliches Wohlbefinden, der Verspannungsschmerzen lässt nach 
                      und du kannst wieder besser schlafen.

                    </p>
                    <br />
                </div>
            </div>
        </div>

        
        <div class="h">
            <img src="@/assets/images/0.jpg" onclick="oprnFullImg(this.src)"/>
            <img src="@/assets/images/01.jpg" onclick="oprnFullImg(this.src)"/>
            <img src="@/assets/images/44.jpg" onclick="oprnFullImg(this.src)"/>
            <img src="@/assets/images/05.jpg" onclick="oprnFullImg(this.src)"/>
            <img src="@/assets/images/06.png" onclick="oprnFullImg(this.src)"/>
            <img src="@/assets/images/012.png" onclick="oprnFullImg(this.src)"/>
            <img src="@/assets/images/77.jpg" onclick="oprnFullImg(this.src)"/>
            <img src="@/assets/images/66.jpg" onclick="oprnFullImg(this.src)"/>
        </div>

        <br />

        <div class="container2">
            <h1>Suche dein Passender Traphie aus</h1>
            <div class="price-row">
                <div class="price-col">
                    <p>Packet 1</p>
                    <h3>70€ <span>/ Sitzung</span></h3>
                    <ul>
                        <li>Professionelle Massage</li>
                        <li>Die Rückenmassage</li>
                        <li>Die Sportmassage</li>
                        <li>Triggerpunktmassage</li>
                        <li>Die klassische Massage</li>
                        <li>Die Lymphdrainage</li>
                    </ul>
                    <button>
                        <router-link v-on:click="fullHeight = false" to="/termin">Termin buchen</router-link>
                    </button>
                </div>
                <div class="price-col">
                    <p>Packet 2</p>
                    <h3>100€ <span>/ Sitzung</span></h3>
                    <ul>
                        <li>Osteopathie</li>
                        <li>Das Muskuloskelettale</li>
                        <li>Das Viscerale System</li>
                        <li>Das Craniosacrale</li>
                        <li>Die klassische Massage</li>
                        <li>45 - Minuten</li>
                    </ul>
                    <button>
                        <router-link v-on:click="fullHeight = false" to="/termin">Termin buchen</router-link>
                    </button>
                </div>
                <div class="price-col">
                    <p>Packet 3</p>
                    <h3>120€ <span>/ Sitzung</span></h3>
                    <ul>
                        <li>Personal Training</li>
                        <li>Muskelaufbau</li>
                        <li>Konditionstraining</li>
                        <li>Koordinationstraining</li>
                        <li>Die klassische Massage</li>
                        <li>45 Minuten</li>
                    </ul>
                                        
                    <button>
                        <router-link v-on:click="fullHeight = false" to="/termin">Termin buchen</router-link>
                    </button>
                </div>
            </div>
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

<script>


export default {
    components: {},
};


</script>

