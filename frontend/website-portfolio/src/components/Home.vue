<template>
<NavbarComponent></NavbarComponent>
<FooterComponent></FooterComponent>
</template>

<script>
import FooterComponent from './FooterComponent.vue'
import NavbarComponent from './NavbarComponent.vue'

export default {
    name: 'App',
    components: {
        NavbarComponent,
        FooterComponent,
    }

}
</script>

<style>

</style>