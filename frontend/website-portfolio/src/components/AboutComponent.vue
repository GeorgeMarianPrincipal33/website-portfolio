<template>
    <section>
    <div>
        <h2 class="about-h2">{{Title}}</h2>
     </div>
    <div class="about-div">
        <div class="about-div-left">
            <p class="about-description-left">{{employee.Description}}</p>
        </div>
        <div  class="about-div-right">
          <p>{{employee.Description2}}</p>
        </div>
    </div>
    <div>
        <button type="submit" class="buttons-about">
            <span>
                <a href="https://www.linkedin.com/">Linkedin profile</a>
            </span>
        </button>
    </div>

    </section>
</template>

<script>

export default {
    data() {
        return {
            Title: "About me",
            employee: {
                Description: "I have a commercial  experience providing front-end development, producing  high quality responsive websites and  exceptional user experience.",
                Description2: "A front-end developer’s role is to combine design and business logic to achieve a user-facing product. A wide skill set is necessary to produce a quality user experience that leads to meeting business goals.",
            },
        }
    },
}
</script>

<style>
 
.about-description-left {
    
    color: #33FFA9;
    font-family: "Roboto", Sans-serif;
    font-size: 24px;
    font-weight: normal;
    font-style: normal;
    line-height: 38px;
    flex-basis: 310px;
    text-align: left;
}

.about-h2 {
    color: white;
    margin-top: 3rem;
    font-family: "Roboto Mono", Sans-serif;
    font-size: 50px;
    font-weight: 500;
    font-style: normal;
    line-height: 1.2em;
    letter-spacing: -1px;
    
}

.about-div-left {
    width: 20%;
    align-content: center;
    align-self: center;
    margin-left: 20%;
    display: flex;
    align-items: flex-start;
}

.about-div-right {
    width: 40%;
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

.about-div {
    display: flex;
    flex-wrap: wrap;
    justify-content: space-between;
}

.buttons-about {
    height: 4rem;
    width: 16rem;
    text-align: center;
    font-size: 20px;
    background-color: rgb(51, 255, 169);
    color: black;
    border-radius: 15px;
    padding: 5px 32px;
    text-decoration: none;
    display: inline-block;
    cursor: pointer;
    font-family:-apple-system, BlinkMacSystemFont, 'Segoe UI', Roboto, Oxygen, Ubuntu, Cantarell, 'Open Sans', 'Helvetica Neue', sans-serif;
    box-shadow: 0 9px rgb(244, 244, 247);
    outline: none;
    margin-top: 3rem;
    left: 27%;
    color: white;
}


.buttons-about span {
  cursor: pointer;
  display: inline-block;
  position: relative;
  transition: 0.5s;
}
.buttons-about span:after {
  content: '\2193';
  opacity: 0;
  top: 0;
  right: -20px;
  transition: 0.5s;
}
.buttons-about:hover span {
  padding-right: 25px;
  color :rgb(35,39,45);
}
.buttons-about:hover span:after {
  opacity: 1;
  right: 0;
}

.buttons-about:active {
  box-shadow: 0 5px rgb(250, 250, 252);
  transform: translateY(4px);
}


</style>
