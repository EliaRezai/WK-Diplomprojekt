<script setup>
import axios from 'axios';
</script>

<template>
<span>
    <div class="loginView">
        <div v-if="!authenticated">
            <div class="formRow">
                <label>Username:</label>
                <input class="form-control" v-model="model.username" type="text" />
            </div>
            <div class="formRow">
                <label>Password:</label>
                <input class="form-control" v-model="model.password" type="password" />
            </div>
            <div>
                <button class="btn btn-outline-primary" v-on:click="sendLoginData()">Submit</button>
            </div>
        </div>
        <div v-if="authenticated">User {{ userdata.username }} ist angemeldet. Du kannst jetzt die <router-link to="/terminverwaltung">Termine verwalten</router-link>.</div>
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
    </span>
</template>

<style scoped>

</style>

<script>
export default {
    setup() {},
    data() {
        return {
            message: '',
            model: {
                username: 'admin',
                password: '1111',
            },
        };
    },
    mounted() {
        this.message = '';
    },
    methods: {
        async sendLoginData() {
            try {
                const userdata = (await axios.post('user/login', this.model)).data;
                axios.defaults.headers.common['Authorization'] = `Bearer ${userdata.token}`;
                this.$store.commit('authenticate', userdata);
                this.message = `User ${userdata.username} logged in.`;
            } catch (e) {
                if (e.response.status == 401) {
                    alert('Login failed. Invalid credentials.');
                }
            }
        },
    },
    computed: {
        authenticated() {
            return this.$store.state.userdata.username ? true : false;
        },
        userdata() {
            return this.$store.state.userdata;
        },
    },
};
</script>