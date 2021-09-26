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
    name: 'Leon',
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
            skills: '',
            getData: false,
        }
    },

    mounted() {
        getCV(6).then(response => {
            var result = response.data
            this.description = result.description 
            this.contactDetails = result.contactDetails 
            this.certifications = result.certifications 
            this.placesOfWork = result.placesOfWork 
            this.skills = result.skills 

            console.log(result)
            this.getData = true
        })
    }

}
</script>

<style>

</style>