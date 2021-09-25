<template>
<NavbarComponent></NavbarComponent>
<DetailsComponent></DetailsComponent>
<AboutComponent v-if="getData" :description="description"></AboutComponent>
<CredentialsComponent v-if="getData" :certifications="certifications" :placesOfWork="placesOfWork" :skills="skills"></CredentialsComponent>
<FooterComponent v-if="getData" :contactDetails="contactDetails"></FooterComponent>
</template>

<script>
import FooterComponent from './FooterComponent.vue'
import NavbarComponent from './NavbarComponent.vue'
import DetailsComponent from './DetailsComponent.vue'
import AboutComponent from './AboutComponent.vue'
import CredentialsComponent from './CredentialsComponent.vue'

import { getCV } from "../scripts/connection.js";

export default {
    name: 'App',
    components: {
        NavbarComponent,
        FooterComponent,
        DetailsComponent,
        AboutComponent,
        CredentialsComponent,
    },

    data(){
        return {
            description:'',
            contactDetails: '',
            certifications: '',
            placesOfWork: '',
            skils: '',
            getData: false,
        }
    },

    mounted() {
        getCV(4).then(response => {
            var result = response.data
            this.description = result.description 
            this.contactDetails = result.contactDetails 
            this.certifications = result.certifications 
            this.placesOfWork = result.placesOfWork 
            this.skils = result.skils 

            console.log(result)
            this.getData = true
        })
    }

}
</script>

<style>

</style>