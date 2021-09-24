<template>
<NavbarComponent></NavbarComponent>
<DetailsComponent></DetailsComponent>
<FooterComponent></FooterComponent>
</template>

<script>
import FooterComponent from './FooterComponent.vue'
import NavbarComponent from './NavbarComponent.vue'
import DetailsComponent from './DetailsComponent.vue'

export default {
    name: 'App',
    components: {
        NavbarComponent,
        FooterComponent,
        DetailsComponent,
    }

}
</script>

<style>

</style>