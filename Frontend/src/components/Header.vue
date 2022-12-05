<template>
    <div class="nav">
        <img src="@/assets/g2.png" width="100" height="100"/>

        <a href="#">Startseite</a>
        <a href="#">Praxis</a>
        <a href="#">Therapien</a>
        <a href="#">Öffnungzeiten</a>
        <a style="color: skyblue;" href="#">Registrierung</a>
    </div>

</template>
<script>

export default {
   name:'HeadeR',
}
</script>
<style>
.nav{
    
    overflow:hidden;
    display: flex;
    margin-left: 10vw;
    

}

.nav a {
    color: black;
    padding: 14px 16px;
    text-align: top;
    font-size: 17px;
    text-decoration: none;
    margin-right: -10px;
    overflow: hidden;
    margin-top:10px;
    margin-bottom:10vh;
    font-size: larger;
}

.nav a:hover{
    background: white;
    color: #0088ff;
}

</style>
