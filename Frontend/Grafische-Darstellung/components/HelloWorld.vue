<template>
  <HeadeR />
  <div class="hello">

    <img style="position: absolute; margin-left: 58vw; width: 480px; height: 370px; margin-top: 0.5vw;" 
    src="@/assets/0.png" width="100" height="100"/>

    <h2>Physio Austria</h2> 
    <h4>Wir sind der Bundesverband der <br />
    Physiotherapeut*innen Österreichs.</h4>

    <p>Hallo. Ich bin ein kleiner Blindtext. Und zwar schon so lange ich denken kann.<br /> 
      Es war nicht leicht zu verstehen, was es bedeutet, ein blinder Text zu sein:<br />  
      Man ergibt keinen Sinn. Wirklich keinen Sinn. Man wird zusammenhangslos eingeschoben <br />  
      und rumgedreht – und oftmals gar nicht erst gelesen. Aber bin ich allein deshalb ein <br />  
      schlechterer Text als andere? Na gut, ich werde nie in den Bestsellerlisten stehen.<br /> 
       Aber andere Texte schaffen das auch nicht. Und darum stört es mich nicht<br /> 
        besonders blind zu sein. Und sollten Sie diese Zeilen noch immer lesen, so habe ich <br /> 
      als kleiner Blindtext etwas geschafft, wovon all die richtigen und wichtigen Texte meist nur träumen.
    </p>    
  
    
  </div>
   
</template>

<script>
import HeadeR from './Header.vue'
export default {
  name: 'HelloWorld',
  components:{
    HeadeR,
  },
}
</script>

<!-- Add "scoped" attribute to limit CSS to this component only -->
<style scoped>

h2 {
    color: rgb(7, 7, 10);
    padding: 24px 26px;
    text-align: top;
    text-decoration: none;
}
h4 {
    color: rgb(7, 7, 10);
    padding: 24px 26px;
    text-align: top;
    text-decoration: none;
}
p {
    color: #030f1a;
    font-size: 17px;
    text-decoration: none;
    margin-right: 10px;
    padding: 24px 26px;

}
</style>
