<template>
    <section>
        <div class="footer">
            <ul class="footer-ul">
                <p>I’m available for freelance </p>
                <br>
                <p class="p-a">work, you can reach me by  </p>
                <li style="float:left"><a class="footer-a" href="#contact">Facebook</a></li> 
                <li style="float:left"><a class="footer-a" href="#contact">#Instagram</a></li> 
                <li style="float:left"><a class="footer-a" href="#news">Email</a></li>
                <li style="float:right"><a class="footer-a©" href="#contact">2021 - Design by Team3 - Pricipan33</a></li> 

            
            </ul>
         </div>


    </section>
</template>


<script>
 
export default {
    data() {
        return {
        }
    }
}
</script>

<style>
p {
    margin-right: 0;
    font-size: 50px;
    font-family: "Roboto Mono", Sans-serif;
    position: fixed;
    bottom: 9rem;
    left: 7rem;
    color: black;
}

.p-a {
    margin-right: 0;
    font-size: 50px;
    font-family: "Roboto Mono", Sans-serif;
    position: fixed;
    bottom: 6.5rem;
    left: 7rem;
    color: black;
}

.footer {
    flex-direction: row;
    position: fixed;
    width: 100%;
    padding: 100;
    bottom: 0;
    left: 0;
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