<template>
<NavbarComponent></NavbarComponent>
<DetailsComponent></DetailsComponent>
<AboutComponent></AboutComponent>
<FooterComponent></FooterComponent>
</template>

<script>
import FooterComponent from './FooterComponent.vue'
import NavbarComponent from './NavbarComponent.vue'
import DetailsComponent from './DetailsComponent.vue'
import AboutComponent from './AboutComponent.vue'


export default {
    name: 'App',
    components: {
        NavbarComponent,
        FooterComponent,
        DetailsComponent,
        AboutComponent,
    }

}
</script>

<style>

</style>