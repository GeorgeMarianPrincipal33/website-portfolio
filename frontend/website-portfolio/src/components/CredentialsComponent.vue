<template>
    <section>
        <div>
            <h1 class="credentials-title">{{title}}</h1>
            <h1 class="university">{{univeristy}}</h1>
            <h1 class="university-duration">{{universityDuration}}</h1>
            <h1 class="university">{{universitySpecialization}}</h1>
        </div>
        <div class="credentials-div">
            <div class="credentials-div-left">
                <ul >
                    <li v-for="job in jobs" :key="job.company">
                        <p class="credentials-p">{{job.company}}</p>
                        <p class="credentials-p-s">{{job.duration}}</p>
                    </li>
                </ul>
            </div>
            <div class="credentials-div-right">
                 <ul >
                    <li v-for="job in jobs" :key="job.company">
                        <p class="credentials-p">{{job.position}}</p>
                    </li>
                </ul>
            </div>

            <div style="width: 100%">
                <h1 class="skills">Skills</h1>
                <ul>
                    <li class="skill-array" v-for="skill in skillSet" :key="skill">
                        <div style="width:100%">
                            {{skill}}
                        </div>
                    </li>
                </ul>
            </div>
        </div>
    </section>
</template>

<script>
 import { parseColon, parseComplex } from "../scripts/parse";

export default {
    data() {
        return {
            title: "Places of work/ Diplomas",
            section1: "Apple",
            section2: "Google",
            section3: "Freelance",
            section4: "Jerry.ai",
            subsection1: "10.2017 — Present / London, UK",
            subsection2: "11.2014 — 05.2017 / Remote & Palo Alto, CA",
            subsection3: "04.2012 — 11.2014 / Remote, World",
            subsection4: "08.2006 — 04.2012 / Wroclaw, Pl",
            domain1:"Front/ Back developer",
            domain2:"Front developer",
            domain3:"Front/ Back developer",
            domain4:"Front developer",


            univeristy: "",
            universityDuration: "",
            universitySpecialization: "",

            jobs: [],
            skillSet: []
        }    
    },

    props: ['certifications', 'placesOfWork', 'skills'],

    mounted() {
        const education = parseColon(this.certifications)
        this.univeristy = education[0]
        this.universityDuration = education[1]
        this.universitySpecialization = education[2]

        this.jobs = parseComplex(this.placesOfWork)
        this.skillSet = parseColon(this.skills)
    }
}
</script>

<style>

.credentials-title {
    font-family: "Roboto Mono", Sans-serif;
    font-size: 50px;
    font-weight: 500;
    font-style: normal;
    line-height: 1.2em;
    letter-spacing: -1px;
    color: white;
    margin-top: 4rem;
}

.credentials-div-left {
    width: 40%;
    align-content: center;
    align-self: center;
    margin-left: 20%;
    display: flex;
    align-items: flex-start;


}

.credentials-div-right {
    width: 20%;
    display: flex;
    align-items: flex-start;
    color:white;
    font-family: "Roboto", Sans-serif;
    font-size: 24px;
    font-weight: normal;
    font-style: normal;
    line-height: 38px;
    margin-right: 20%;
}

.credentials-div {
    display: flex;
    flex-wrap: wrap;
    justify-content: space-between;
}

.credentials-p {
    color: white;
    font-family: "Roboto", Sans-serif;
    font-size: 24px;
    font-weight: normal;
    font-style: normal;
    line-height: 38px;
}

.credentials-p-s {
    font-family: "Roboto", Sans-serif;
    font-size: 20px;
    font-weight: normal;
    font-style: normal;
    line-height: 32px;
    color: #919396;
    margin: 7px 0px 0px 0px;
    text-align: left;
}

.university {
    color: white;
    font-family: "Roboto", Sans-serif;
    font-size: 24px;
    font-weight: normal;
    font-style: normal;
    line-height: 38px;
}

.university-duration {
    font-family: "Roboto", Sans-serif;
    font-size: 20px;
    font-weight: normal;
    font-style: normal;
    line-height: 32px;
    color: #919396;
    margin: 7px 0px 0px 0px;
}

.skills {
    color: white;
    font-family: "Roboto", Sans-serif;
    font-size: 24px;
    font-weight: normal;
    font-style: normal;
    line-height: 38px;
    text-align: center;
}

.skill-array {
    font-family: "Roboto", Sans-serif;
    font-size: 20px;
    font-weight: normal;
    font-style: normal;
    line-height: 32px;
    color: #919396;
    margin: 7px 0px 0px 0px;
    text-align: center;
    margin-left: 20%;
}

</style>
