<template>
    <section>
        <div class="footer">
            <ul class="footer-ul">
                <pre>{{footerTitle}}</pre>
                <li style="float:left"><a class="footer-a" :href="facebookLink">Facebook</a></li> 
                <li style="float:left"><a class="footer-a" :href="instagramLink">Instagram</a></li> 
                <li style="float:left"><a class="footer-a" :href="linkedinLink">LinkedIn</a></li>
                <li style="float:left"><a class="footer-a" :href="githubLink">Github</a></li>
                <li style="float:left"><a class="footer-a" :href="emailLink">Email</a></li>
                <li style="float:right"><a class="footer-a©" href="#contact">2021 - Design by Team3 - Pricipan33</a></li> 
            </ul>
         </div>


    </section>
</template>


<script>
 import { parseColon } from "../scripts/parse";

export default {
    data() {
        return {
            footerTitle: "You can reach me by ",
            facebookLink: "",
            instagramLink: "",
            linkedinLink: "",
            githubLink: "",
            emailLink: "",
        }
    },

    props: ['contactDetails'], 

    methods: {
        isNull(link){
            if(link === 'null')
                return ''

            return link
        }
    },

    mounted() {
        const contactInfos = parseColon(this.contactDetails)
        
        this.facebookLink = this.isNull(contactInfos[0])
        this.instagramLink = this.isNull(contactInfos[1])
        this.emailLink = "mailto:" + this.isNull(contactInfos[2])
        this.linkedinLink = this.isNull(contactInfos[3])
        this.githubLink = this.isNull(contactInfos[4])
    }
}
</script>

<style>
pre {
    margin-right: 0;
    font-size: 50px;
    font-family: "Roboto Mono", Sans-serif;
    bottom: 9rem;
    left: 7rem;
    color: black;
}

.p-a {
    margin-right: 0;
    font-size: 50px;
    font-family: "Roboto Mono", Sans-serif;
    bottom: 6.5rem;
    left: 7rem;
    color: black;
}

.footer {
    flex-direction: row;
    width: 100%;
    left: 0;
    hyphens: manual;
    margin-top: 2rem;
}

.footer-ul {
    list-style-type: none;
    margin: 0;
    padding: 6rem;
    overflow: hidden;
    background-color: rgb(51,255,169);
}

.footer-a {
    color: rgb(39,80,68);
    font-family: "Roboto Mono", Sans-serif;
    font-size: 18px;
    font-weight: normal;
    font-style: normal;
    line-height: 21px;
    letter-spacing: -0.4px;
}

.footer-a© {
    color: rgb(39,80,68);
    font-size: 13px;
}






</style>