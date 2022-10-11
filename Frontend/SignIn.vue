<template>
    <div class="login">
      <h1>LogIn Page</h1>
      
        <input type="email" v-model="email" class="input-100" maxlength="50" id="email" placeholder="Enter Email" required/>
        <input type="password" v-model="password" placeholder="Enter Password"/>
        <button v-on:click="signIn">Sign In</button>
        <p>
        <router-link to ="/sign-up">Sign Up</router-link>
        </p>
        <div class="text-center">
            <link rel="stylesheet" href="SignUpStyle.css">
        </div>
    </div>
    
  </template>
  
  <script>
  import axios from 'axios'
  export default {
    name: 'SignIN', 
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

           if(result.status==200 && result.data.length>0)
           {
            localStorage.getItem("user-info",JSON.stringify(result.data[0]))
            this.$router.push({name:'Home'})
           }
           console.warn(result)           
           
           }
    }
   
  };
  </script>