<template>
  <div>
    <h1>Hello World!</h1>
  </div>
</template>

<script>
export default {
  name: 'HelloWorld',
  mounted()
{
    let user = localStorage.getItem('user-info')
    if(!user)
    {
        this.$router.push({name:'SignUp'})  
    }
}
}
</script>

<!-- Add "scoped" attribute to limit CSS to this component only -->
<style scoped>
h3 {
  margin: 40px 0 0;
}
ul {
  list-style-type: none;
  padding: 0;
}
li {
  display: inline-block;
  margin: 0 10px;
}
a {
  color: #42b983;
}
</style>
