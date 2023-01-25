<script setup>
import Header from "./components/Header.vue"
</script>
<template>
    <div class="mainApp">
        <Header></Header>
        <main>
          <router-view></router-view>
        </main>
    </div>
</template>

<script>
export default {
    name: 'App',
    components: {
        Header
    },
};
</script>

<style scoped>

</style>
