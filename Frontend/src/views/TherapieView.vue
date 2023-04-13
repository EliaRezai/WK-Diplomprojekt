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
                    <button>Buchen</button>
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
                    <button>Buchen</button>
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
                    <button>Buchen</button>
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
                        <li><a href="#">Startseite</a></li>
                        <li><a href="#">Therapien</a></li>
                        <li><a href="#">Termin buchen</a></li>
                        <li><a href="#">Termin verwalten</a></li>
                        <li><a href="#">Login</a></li>

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

<style scoped>

.header {
  min-height: 100vh ;
  width: 100%;
  background-image: linear-gradient(rgba(4,9,30,0.7),
  rgba(4,9,30,0.7)), url("~@/assets/images/77.jpg");
  background-position: center;
  background-size: cover;
  position: relative;
}

nav{
  display: flex;
  padding: 2% 6%;
  justify-content: space-between;
  align-items: center;
}

nav img{
  width: 100px;
}

.nav-links{
  flex: 1;
  text-align: right;
}

.nav-links ul li{
  list-style: none;
  display: inline-block;
  padding: 8px 12px;
  position: relative;
}

.nav-links ul li a{
  color: antiquewhite;
  text-decoration: none;
  font-size: 13px;
}

.nav-links ul li::after{
  content:'';
  width: 0%;
  height: 2px;
  background: #89c0e3;
  display: block;
  margin: auto;
  transition: 0.5s;
}

.nav-links ul li:hover::after{
  width: 100%;
}

.text-box{
  width: 0%;
  color: aliceblue;
  position: absolute;
  top: 25%;
  left: 40%;
  transform: translate(-50%, -50%);
  text-align: center;
  
  }
  .text-box h1{
    font-size: 62px;
    
  }

  .text-box p{
    margin: 10px 0 40px;
    font-size: 14px;
    color: aliceblue;
  }

  .hero-btn{
    display: inline-block;
    text-decoration: none;
    color: #dee3e7;
    border: 1px solid #dadee1;
    padding: 12px 34px;
    font-size: 13px;
    background: transparent;
    position: relative;
    cursor: pointer;
  }
  .hero-btn:hover{
    border: #89c0e3;
    background: #89c0e3;
    transform: 2s;
  }

  nav.fa{
    display: block;
    color: #fff;
    margin: 10px;
    font-size: 22px;
    cursor: pointer;
  }

  .nav-links ul{
    padding: 30px;
  }
  @media(max-width: 700px){
      .text-box h1{
        font-size: 20px;
      }
      .nav-links{
        position: absolute;
        background: #89c0e3;
        height: 100vh;
        width: 200px;
        top: 0;
        right: 0;
        text-align: left;
        z-index: 2;

      }
  }

  

.testimonials{
  width: 80%;
  margin: auto;
  padding-top: 100px;
  text-align: center;
}

.testimonial-col{
  flex-basis: 44%;
  border-radius: 10px;
  margin-bottom: 5%;
  text-align: left;
  background: #89c0e3;
  padding: 25%;
  cursor: pointer;
  display: flex;
}

.testimonial-col img{
  height: 40px;
  margin-left: 5px;
  margin-right: 30px;
  border-radius: 50%;
}

.testimonial-col p{
  padding: 0;
}

.testimonial-col h3{
  margin-top: 15px;
  text-align: left;
}


/* fotter*/

.cta{
  margin: 100px auto;
  width: 80%;
  background-image: linear-gradient(rgba(0,0,0,0.7), rgba(0,0,0,0.7)), url("~@/assets/iamges/55.jpg") ;
  background-position: center;
  background-size: cover;
  border-radius: 10px;
  text-align: center;
  padding: 100px 0;
}

.cta h1{
  color: #edf0f3;
  margin-bottom: 40px;
  padding: 0;
}

@media(max-width: 700px){
  .cta h1{
    font-size: 24px;
  }
}

.footer{
  margin-top: 150px;
  width: 100%;
  padding: 100px 15%;
  color: #efefef;
  background-color: rgb(43, 38, 38);
  display: flex;
}

.footer div{
  text-align: center;
}

.col-2{
  flex-grow: 2;
}

.footer div h3{
  font-weight: 300;
  margin-bottom: 30px;
  letter-spacing: 1px;
}

.col-1 a{
  display: block;
  text-decoration: none;
  color: #dadee1;
  margin-bottom: 10px;
}

.col-3 a{
  display: block;
  text-decoration: none;
  color: #dadee1;
  margin-bottom: 10px;
}

.col-3 p{
  display: block;
  text-decoration: none;
  color: #dadee1;
  margin-bottom: 10px;
}

form input{
  width: 400px;
  height: 45px;
  border-radius: 4px;
  text-align: center;
  margin-top: 20px;
  margin-bottom: 40px;
  outline: none;
  border: none;
}

form button{
  background: transparent;
  border: 2px solid #fff;
  color: #fff;
  border-radius: 30px;
  padding: 10px 30px;
  font-size: 15px;
  cursor: pointer;
}



.footer h4{
  margin-bottom: 25px;
  margin-top: 25px;
  font-weight: 600;
}

.c{
  width: 100%;
  height: 100%;
  display: flex;
  align-items: center;
  flex-direction: column;
}

iframe{
  width: 100%;
  height: 500px;
  filter: invert(90%);
}

/*them2 herro*/

.herro{
  width: 100%;
  min-height: 100vh;
  padding-left: 12%;
  padding-right: 12%;
  box-sizing: border-box;
  text-align: center;
  color: #fff;
}

.row{
  margin-top: 80px;
  display: flex;
  flex-wrap: wrap;
  justify-content: space-around;
}

.col{
  flex-basis: 28%;
  box-sizing: border-box;
  text-align: center;
  position: relative;
  cursor: pointer;
  min-width: 230px;
  margin-bottom: 20px;
}

.profile{
  width: 100%;
  height: 100%;
  box-sizing: border-box;
  background: #1e2648;
  padding: 12px;

}

.profile img{
  width: 100%;
}

.profile h2{
  margin: 25px 0 10px;
  font-weight: 500;
}

.profile p{
  margin-bottom: 10px;
  color: #89c0e3;
}

/* -------------------- Praxis ------------*/

.sub-header{
  height: 50vh;
  width: 100%;
  background-image: linear-gradient(rgba(0,0,0,0.7), rgba(0,0,0,0.7)), url("~@/assets/images/44.jpg") ;
  background-position: center;
  background-size: cover;
  color: fff;
}

.sub-header h1{
  margin-top: 100px;
}

.about-us{
  width: 80%;
  margin: auto;
  padding-top: 80px;
  padding-bottom: 30px 2px;
}

.a-col img{
  width: 100%;
}

.a-col h1{
  padding-top: 0;
  padding-bottom: 1%;
}

.a-col p{
  padding-top: 15px 0 25px;
}

.red-btn{
  border: 1px solid #89c0e3;
  background: transparent;
  color: #25425b;
}

.red-btn:hover{
  color: #fff;
}


.container2{
  margin: 0;
  padding: 0;
  width: 100%;
  min-height: 100vh;
}

.container2 h1{
  padding: 50px 0;
  text-align: center;
}


.price-row{
  width: 90%;
  max-width: 1100px;
  margin: auto;
  display: grid;
  grid-template-columns: repeat(auto-fit, minmax(250px, 1fr));

}

.price-col:hover{
  filter: grayscale(0);
  cursor: pointer;
  transform: scale(1.1);
}


.price-col{
  background: #94a3e897;
  padding: 5% 15%;
  border-radius: 10px;
  color: #1e2648;
  text-align: center;
  margin: 0 10px;
  filter: grayscale(100%);
  transition: transform 0.5s;
}

.price-col p{
  font-size: 22px;
}

.price-col h3{
  font-size: 44px;
  margin: 20px 0 40px;
  font-weight: 500;
}

.price-col span{
  font-size: 16px;
}

.price-col ul{
  text-align: left;
  margin: 20px 0;
  color: #1e2648;
  list-style: none ;
}

.price-col ul li{
  margin: 15px 0;
}

.price-col ul li::before{
content: '.';
color: #25425b;
font-weight: bold;
margin-right: 8px;

}

.price-col button{
  width: 100%;
  padding: 14px 0;
  background: transparent;
  color: #1e2648;
  font-size: 15px;
  border: 1px solid #1e2648;
  border-radius: 6px;
  margin-top: 30px;
  cursor: pointer;  
}

.price-col button:hover{
  background: #89c0e3;
}

.h{
  width: 80%;
  margin: 100px auto 50px;
  display: grid;
  grid-template-columns: repeat(auto-fit, minmax(250px, 1fr));
  grid-gap: 30px;
}

.h img{
  width: 100%;
  height: 100%;
  cursor: pointer;
  transition: 0.4s;
}

.h img:hover{
  transform: scale(0.8) rotate(-15deg);
  border-radius: 20px;
  box-shadow: 0 32px 75px rgba(68,77,136,0.2) ;
}

.full-img{
  width: 100%;
  height: 100vh;
  background: rgba(0, 0,0, 0);
  position: fixed;
  top: 0;
  left: 0;
  display: flex;
  align-items: center;
  justify-content: center;
}

.full-img img{
  width: 90%;
  max-width: 500px;
}

.full-img span{
  position: absolute;
  top: 5%;
  right: 5%;
  font-size: 30px;
  color: #fff;
  cursor: pointer;
}

.t{
  width: 90%;
  max-width: 800px;
  margin: auto;
}

.tt{
  padding: 25%;
  background: #25425b;
  color: #fff;
  width: 100%;
  height: 350px;
  position: relative;
  box-shadow: 0 15px 20px rgba(0,0,0,0.2);
}

.ut{
  width: 80%;
  text-align: center;
  line-height: 30px;
  position: absolute;
  top: 50%;
  left: 50%;
  transform: translate(-50%,-50%);
  display: none;
}

.ut span{
  display: block;
  font-size: 13px;
  margin-top: 70px;
  font-weight: 500;
  text-transform: uppercase;
}

.pic{
  margin-top: 30px;
  display: flex;
  align-items: center;
  justify-content: center;
}

.user-pic{
  width: 65px;
  padding: 2px;
  border-radius: 80%;
  margin: 10px;
  cursor: pointer;
}

.ut.active-text{
  display: block;
}

.ut.active-text span{
font-size:medium;

}

.user-pic.active-pic{
  width: 100px;
  border: 3px solid #003cff;

}


</style>
