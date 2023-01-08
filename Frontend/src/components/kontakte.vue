<template>
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <link rel="stylesheet" href="https://www.ionos.at/digitalguidepath/to/font-awesome/css/font-awesome.min.css">
    <link rel="stylesheet" href="https://stackpath.bootstrapcdn.com/font-
    awesome/4.7.0/css/font-awesome.min.css">
    <div class="sub-header">
      <nav>
        <a href="HelloWorld.vue">
          <img src="@/assets/gros.png">
        </a>
        <div class="nav-links" id="navLinks">
          <i class="fa fa-times" onclick="hideMenu()"></i>        
          <ul>
            <li>
              <a href="">Startseite</a>
            </li>
            <li>
              <a href="Praxi.vue">Praxis</a>
            </li>
            <li>
              <a href="">Therapien</a>
            </li>
            <li>
              <a href="">Öffnungszeiten</a>
            </li>
            <li>
              <a href="">Termine</a>
            </li>
            <li>
              <a href="">Login</a>
            </li>
          </ul>
        </div>
        <i class="fa fa-bars" onclick="showMenu()"></i>
      </nav>
      <div class="text-box">
        <h1>Kontakte</h1>
      </div>
      
    </div>
  
   <!---------- kontakt Seite ----->
  <div class="row3">
    <div class="col3">
      <h1>Öffnungszeiten</h1>
  
     <br> 
      <h5>Montag</h5>
      <p>9:00 bis 19:00</p>
      <h5>Dienstag</h5>
      <p>9:00 bis 19:00</p>
      <h5>Mittwoch</h5>
      <p>9:00 bis 19:00</p>
      <h5>Donnerstag</h5>
      <p>9:00 bis 19:00</p>
      <h5>Freitag</h5>
      <p>9:00 bis 11:00</p>
  
  
  
    </div>
    <div class="col3">
      <img src="@/assets/88.png" class="feature-img">
      <img src="@/assets/00.png" class="thumbnail-img">
  
  
    </div>
  
  </div>
  
   
  
   <div class="footer">
    <div class="col-1">
      <h3>Wichtige Links</h3>
      <a href="#">Startseite</a>
      <a href="#">Praxis</a>
      <a href="#">Therapien</a>
      <a href="#">Öffnungszeiten</a>
      
    </div>
  
    <div class="col-2">
      <h3>NEWSLETTER</h3>
      <form>
        <input type="email" placeholder = "Ihre Email Adresse" required>
        <br/>
        <button type="submit">Senden</button>
      </form>
    </div>
  
    <div class="col-3">
      <h3>
        Kontakte
      </h3> 
  
      <p>
        Alte Poststraße 14e <br> Maria Ellend 2402 Österreich
        <br> +43 676 3285511
      </p>
  
    </div>
    
  </div>
  </template>
  
  <script>
  
  export default {
    name: 'HelloWorld', 
    components:{
    },
  
  }
  
  
  </script>
  
  <!-- Add "scoped" attribute to limit CSS to this component only -->
  <style scoped>
  *{
    margin: 0;
    padding: 0;
    font-family: Verdana, Geneva, Tahoma, sans-serif;
  }
  
  .row3{
    display: flex;
    flex-wrap: wrap;
  
  }
  
  .col3{
    flex-basis: 50%;
    position: relative;
  }
  
  .feature-img{
    width: 100%;
    margin-top: 10px;
  }
  
  .thumbnail-img{
    width: 280px;
    position: absolute;
    bottom: 10px;
    left: 0;
    border-radius: 10px;
    box-shadow: 5px 8px 10px rgba(0, 0, 0, 0.1);
  }
  
  .col3 h1{
  
    margin-top: 50px;
    font-size: 40px;
    font-weight: 600;
    text-align: center;
    color: rgb(60, 59, 59);
  
  
  }
  
  .col3 h5{
  
  margin-top: 30px;
  font-size: 30px;
  font-weight: 400;
  text-align: center;
  color: rgb(42, 132, 211);
  
  
  }
  
  .col3 p{
  
  font-size: 15px;
  font-weight: 300;
  text-align: center;
  
  
  }
  .header {
    min-height: 100vh ;
    width: 100%;
    background-image: linear-gradient(rgba(4,9,30,0.7),
    rgba(4,9,30,0.7)), url("@/assets/55.jpg");
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
    width: 90%;
    color: aliceblue;
    position: absolute;
    top: 50%;
    left: 50%;
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
  
    
  /* ----------- course -------------*/
  
  .course{
    width: 90%;
    margin: auto;
    text-align: center;
    padding-top: 100px;
  }
  
  h1{
    font-size: 36px;
    font-weight: 600;
  }
  
  p{
    color: #777;
    font-size: 14px;
    font-weight: 300;
    line-height: 22px;
    padding: 10px;
  }
  
  .row{
    margin-top: 5%;
    display: flex;
    justify-content: space-between;
  }
  
  .course-col{
    flex-basis: 31%;
    background: #a6d7e27c;
    border-radius: 10px;
    margin-bottom: 5%;
    padding: 20px 12px;
    box-sizing: border-box;
    transform: 1s;
  }
  
  h3{
    text-align: center;
    font-weight: 600;
    margin: 10px 0;
  }
  
  .course-col:hover{
    box-shadow: 0 0 20px rgba(172, 205, 234, 0.817);
  }
  
  @media(max-width: 700px){
    .row{
      flex-direction: column;
    }
  }
  
  /* ------- campus -------*/
  
  .campus{
    width: 80%;
    margin: auto;
    text-align: center;
    padding: 50px;
  }
  
  .campus-col{
    flex-basis: 32%;
    border-radius: 10px;
    margin-bottom: 30px;
    position: relative;
    overflow: hidden;
  }
  
  .campus-col img{
    /*------
    widows: 100%;----*/
    width: 100%;
  
  }
  
  .layer{
    background: transparent;
    height: 100%;
    width: 100%;
    position: absolute;
    top: 0;
    left: 0;
    transition: 0.5s;
  }
  
  .layer:hover{
    background: rgba(179, 207, 245, 0.58);
  }
  
  .layer h3{
    width: 100%;
    font-weight: 500;
    color: #fff;
    font-size: 26px;
    bottom: 0;
    left: 50%;
    transform: translateX(-50%);
    position: absolute;
  }
  
  .layer:hover h3{
    bottom: 49%;
    opacity: 1;
  }
  
  /* facilitis */
  
  .facilities{
    width: 80%;
    margin: auto;
    text-align: center;
    padding-top: 100px;
  }
  
  .facilities-col{
    flex-basis: 31%;
    border-radius: 10px;
    margin-bottom: 5%;
    text-align: left;
  }
  
  .facilities-col img{
    width: 100%;
    border-radius: 10px;
  }
  
  .facilities-col p{
    padding: 0;
  }
  
  .facilities-col h3{
    margin-top: 16px;
    margin-bottom: 15px;
    text-align: left;
  }
  
  /*------------------- t -------*/
  
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
    background-image: linear-gradient(rgba(0,0,0,0.7), rgba(0,0,0,0.7)), url("@/assets/55.jpg") ;
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
  
  .sub-header{
    height: 50vh;
    width: 100%;
    background-image: linear-gradient(rgba(0,0,0,0.7), rgba(0,0,0,0.7)), url("@/assets/44.jpg") ;
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
  
  .container2 h2{
    color:#89c0e3;
    font-size: 30px;
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
  
  .price-col{
    background: #303756;
    padding: 5% 15%;
    border-radius: 10px;
    color: #dadee1;
    text-align: center;
    margin: 0 10px;
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
    color: #ddd;
    list-style: none ;
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
    .nav-links ul{
      padding: 30px;
    }
  </style>