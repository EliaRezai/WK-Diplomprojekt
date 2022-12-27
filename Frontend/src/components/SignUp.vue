<template>
    <HeadeR />
    <div class="register">
        <div class="header">
            <h1 style="font-size:45px ;">Registrieren</h1>
        </div>
        <hr
            style="width: 81.5vw; color:skyblue; margin-top:4px;margin-bottom:4vh; border-color: skyblue;border-width: 1px; font-size: 10px;" />
        <!--Register input-->
        <p style="font-size: x-large; color: black;">Name</p>
        <input type="name" v-model="name" class="" maxlength="50" id="email" placeholder="Name eingeben" required />
        <p style="font-size: x-large; color:black;">Email</p>
        <input type="email" v-model="email" class="" maxlength="50" id="email" placeholder="Email eingeben" required />
        <p style="font-size: x-large; color: black;">Sozialversicherungsnummer</p>
        <div id="demo">
        <input type="password" v-on:keypress="NumbersOnly" class="" maxlength="10" id="email" placeholder="Sozialversicherungsnummer eingeben" required />
        </div>
            <img style="position: absolute; margin-left: 58vw; width: 300px; height: 200px; margin-top: 14.5vw;" src="@/assets/undraw_medicine_b1ol.png" width="100" height="100"/>

        <!-- 
        <input type="checkbox" value="lsRememberMe" id="rememberMe"> 
            <label for="rememberMe">Remember me</label>
                <input type="submit" value="Login" onclick="lsRememberMe()">
        -->

       
        <button v-on:click="signUp">Sign Up</button>
        
        <div class="buttonzwei">
        <!--Router-Link der über router.js direkt zur Login-Seite führt (siehe router.js)-->
            <router-link to="/sign-in">Schon registriert?</router-link>
        
        </div>
    </div>
</template>

<!--Wichtig! <Im Script werden components erfasst die nicht nur auf JEDER page zu sehen sind sondern auch inputs wie name, email, password und methods-->
<!--methods: implementiert die funktion sich lokal über eine ebenfalls lokale json.datenbank zu registrieren, diese Daten werden dann in der lokalen Datenank gespeichert-->
<script>
import HeadeR from './Header.vue'
import axios from 'axios'
export default {
    name: 'SignUp',
    components: {
        HeadeR,
    },
    data() {
        return {
            name: '',
            email: '',
            password: ''
        }
    },
    methods: {
        async signUp() {
            let result = await axios.post("http://localhost:3000/user", {
                email: this.email,
                password: this.password,
                name: this.name
            });

            console.warn(result);
            if (result.status == 201) {
                localStorage.setItem("user-info", JSON.stringify(result.data))
                this.$router.push({ name: 'Home' })
            }

        }
    },
    mounted() {
        let user = localStorage.getItem('user-info')
        if (user) {
            this.$router.push({ name: 'Home' })
        }
    }
}




</script>
<!--Basic Styling-->
<style>
.header {

    color: black;
    overflow: auto;


}


.register {
    margin: auto;
    width: 80vw;
    display: flex;
    flex-direction: column;
    align-items: start;
    margin-bottom: 20vw;
}

.register input {
    width: 50.5vw;
}

.buttonzwei:hover {
    
    
   
    background: white;
    color: #0088ff;

    

}


</style>
