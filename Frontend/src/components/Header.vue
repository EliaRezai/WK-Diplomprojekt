<template>
    <div v-bind:class="{'header': fullHeight, 'headerSmall': !fullHeight}">
        <nav>
            <router-link to="/"><img src="@/assets/images/gros.png" /></router-link>
            <div class="nav-links" id="navLinks">
                <!-- <i class="fa fa-times" onclick="hideMenu()"></i> -->
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
                        <router-link v-on:click="fullHeight = false" to="/opening">Öffnungszeiten &amp; Kontakt</router-link>
                    </li>
                    <li>
                        <router-link v-on:click="fullHeight = false" to="/termin">Termin buchen</router-link>
                    </li>
                    <li>
                        <router-link v-on:click="fullHeight = false" to="/terminverwaltung">Termine verwalten</router-link>
                    </li>                    
                    <li>
                        <router-link v-on:click="fullHeight = false" to="/signin">Login</router-link>
                    </li>
                </ul>
            </div>
            <!-- <i class="fa fa-bars"></i> -->
        </nav>
    </div>

    
</template>
<script>
export default {
    setup() {
        
    },
    data() {
        return {
            fullHeight: false
        }
    },
    mounted() {
        this.fullHeight = this.$route.path == "/";

    },
    methods: {

    }

    

}
</script>
<style scoped>
.header {
    min-height: 100vh;
    width: 100%;
    background-image: linear-gradient(rgba(4, 9, 30, 0.7), rgba(4, 9, 30, 0.7)), url('@/assets/images/55.jpg');
    background-position: center;
    background-size: cover;
    position: relative;
}
.headerSmall {

    width: 100%;
    background-image: linear-gradient(rgba(4, 9, 30, 0.7), rgba(4, 9, 30, 0.7)), url('@/assets/images/55.jpg');
    background-position: center;
    background-size: cover;
    position: relative;    
}
nav {
    display: flex;
    padding: 2% 6%;
    justify-content: space-between;
    align-items: center;
}



nav.fa {
    display: block;
    color: #fff;
    margin: 10px;
    font-size: 22px;
    cursor: pointer;
}

.nav-links ul {
    padding: 30px;
}

.nav-links {
    flex: 1;
    text-align: right;
}

.nav-links ul li {
    list-style: none;
    display: inline-block;
    padding: 8px 12px;
    position: relative;
}

.nav-links ul li a {
    color: antiquewhite;
    text-decoration: none;
    font-size: 15px;
}

.nav-links ul li::after {
    content: '';
    width: 0%;
    height: 2px;
    background: #89c0e3;
    display: block;
    margin: auto;
    transition: 0.5s;
}

.nav-links ul li:hover::after {
    width: 100%;
}
</style>
