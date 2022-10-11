<template>
    <h1>Sign Up</h1>
    <div class="register">
        <input type="text" v-model="name" placeholder="Enter Name"/>
        <input type="email" v-model="email" class="input-100" maxlength="50" id="email" placeholder="Enter Email" required/>
        <input type="password" v-model="password" placeholder="Enter Password"/>
        <button v-on:click="signUp">Sign Up</button>
        <p>
        <router-link to ="/sign-in">Login</router-link>
        </p>
        <div class="text-center">
            <link rel="stylesheet" href="SignUpStyle.css">
 <span></span>
</div>
    </div>
</template>

<script>
import axios from 'axios'
export default {
    name: 'SignUp', 
    data()
    {
        return{
            name:'',
            email:'',
            password:''
        }
    },
    methods:{
       async signUp()
        {
           let result = await axios.post("http://localhost:3000/user",{
           email:this.email,
           password:this.password,
           name:this.name
           });

           console.warn(result);
           if(result.status==201)
           {
            localStorage.setItem("user-info",JSON.stringify(result.data))
            this.$router.push({name:'Home'})
           }
           
           }
    },
    mounted()
{
    let user = localStorage.getItem('user-info')
    if(user)
    {
        this.$router.push({name:'Home'})  
    }
}
}




</script>
<style>
    

    
</style>
