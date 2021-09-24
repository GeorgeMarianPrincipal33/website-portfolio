<template>
    <section>
        <div>
            <h1 class="credentials-title">{{title}}</h1>
        </div>
        <div class="credentials-div">
            <div class="credentials-div-left">
              <ul>
                <p class="credentials-p">{{section1}}</p>
                <p class="credentials-p-s">{{subsection1}}</p>
                <p class="credentials-p">{{section2}}</p>
                <p class="credentials-p-s">{{subsection2}}</p>
                <p class="credentials-p">{{section3}}</p>
                <p class="credentials-p-s">{{subsection3}}</p>
                <p class="credentials-p">{{section4}}</p>
                <p class="credentials-p-s">{{subsection4}}</p>
              </ul>
            </div>
            <div class="credentials-div-right">
             <ul>
                 <p class="credentials-p">{{domain1}}</p>
                 <br>
                 <p class="credentials-p">{{domain2}}</p>
                 <br>
                 <p class="credentials-p">{{domain3}}</p>
                 <br>
                 <p class="credentials-p">{{domain4}}</p>
             </ul>
            </div>
        </div>
    </section>
</template>

<script>

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
        }    
    },
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

</style>
