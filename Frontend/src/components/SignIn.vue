<template>
  <HeadeR />
    <div class="login">
     
           
      <h1 style="font-size:45px ; color: black;">Login</h1>
        <hr
            style="width: 81.5vw; color:skyblue; margin-top:4px;margin-bottom:4vh; border-color: skyblue;border-width: 1px; font-size: 10px;" />
            
            <p style="font-size: x-large; color:black;">Email</p>
        <input type="email" v-model="email" class="input-100" maxlength="50" id="email" placeholder="Enter Email" required/>
        <p style="font-size: x-large; color: black;">Sozialversicherungsnummer</p>
        <input type="password" v-model="password" placeholder="Sozialversicherungsnummer"/>
        
        <img style="position: absolute; margin-left: 58vw; width: 300px; height: 200px; margin-top: 14.5vw;" src="@/assets/undraw_medicine_b1ol.png" width="100" height="100"/>
        
         <!--Chechbox input (Remember Me!)-->
         <div class="checkbox">
            <label for="checkbox" style="flex-direction: column;width: auto;display: inline-block;position: relative;top: 12.8px;left: 8.5px;">Angemeldet bleiben?</label>
            <input style="float: left;width: 20px;" id="checkbox" type="checkbox" :value="checkboxVal"
                :checked="booleanValue" v-on:input="checkboxVal = $event.target.value" />
        </div>

        <button v-on:click="signIn">Sign In</button>
        <p>
        <router-link to ="/sign-up">Noch nicht registriert?</router-link>
        </p>
        <div class="text-center">
            <link rel="stylesheet" href="SignUpStyle.css">
        </div>
    </div>
    
  </template>
  
  <script>
  
  import HeadeR from './Header.vue'
  import axios from 'axios'
  export default {
    name: 'SignIN', 
    components: {
        HeadeR
    },
    data()
    {
        return{
            email:'',
            password:''
        }
    },
    methods:{
       async login()
        {
           let result = await axios.get(`http://localhost:3000/user?email=${this.email}&password=${this.password}`)

           if(result.status==201 && result.data.length>0)
           {
            localStorage.getItem("user-info",JSON.stringify(result.data[0]))
            this.$router.push({name:'Home'})
           }
           console.warn(result)           
           
           }
    }
   
  };
  </script>



  <style>
  .login {
    margin: auto;
    width: 80vw;
    display: flex;
    flex-direction: column;
    align-items: start;
    margin-bottom: 15vw;
    }

    .login input {
      width: 50.5vw;
    }

    .checkbox {
    flex-direction: column;  
  display: inline-flexbox;
  width: auto;
}
</style>