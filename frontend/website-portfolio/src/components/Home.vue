<template>
<NavbarComponent></NavbarComponent>
<DetailsComponent></DetailsComponent>
<AboutComponent></AboutComponent>
<CredentialsComponent></CredentialsComponent>
<FooterComponent></FooterComponent>
</template>

<script>
import FooterComponent from './FooterComponent.vue'
import NavbarComponent from './NavbarComponent.vue'
import DetailsComponent from './DetailsComponent.vue'
import AboutComponent from './AboutComponent.vue'
import CredentialsComponent from './CredentialsComponent.vue'



export default {
    name: 'App',
    components: {
        NavbarComponent,
        FooterComponent,
        DetailsComponent,
        AboutComponent,
        CredentialsComponent,
    }

}
</script>

<style>

</style>