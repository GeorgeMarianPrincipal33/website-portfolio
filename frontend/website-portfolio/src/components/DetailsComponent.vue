<template>
    <section>
        <pre class="details-title">{{ employee.title }}</pre>
        <pre class="details-h2">{{ employee.details }}</pre>
        <div>
            <p>Facebook</p>
            <p>Instagram</p>
            <p>GitHub</p>
            <p>Behance</p>
        </div>
        <button type="submit" id="contact" class="buttons-home" @click="contactUs">
            <span>Contact us</span>
        </button>
        <img class="profile-photo" src="../assets/logo.png" name="file_name">
    </section>
</template>


<script>

export default {
    data() {
        return {
            employee: {
                title: `Bring your \n brand to life \n with our \n help`,
                icon: "",
                details: "In your role as a professional web developer, you’re \n up for just about any website-building challenge.",                
            }
        }        
    },
    methods: {
        contactUs() {
            window.scrollTo(window.scrollX, window.scrollY + 200);            
        },
    },

}
</script>


<style>

.profile-photo {
    position: fixed;
    right: 25%;
    margin-top: 10rem;
}


.details-title {
    color: white;
    position: fixed;
    left: 20%;
    font-size: 4rem;
}

.details-h2 {
    color: white;
    left: 22%;
    font-size: 1rem;
    position: fixed;
    margin-top: 25rem;
}


.buttons-home {
    height: 3rem;
    width: 12rem;
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
    position: fixed;
    margin-top: 30rem;
    left: 27%;
    color: white;
}


.buttons-home span {
  cursor: pointer;
  display: inline-block;
  position: relative;
  transition: 0.5s;
}
.buttons-home span:after {
  content: '\2193';
  position: absolute;
  opacity: 0;
  top: 0;
  right: -20px;
  transition: 0.5s;
}
.buttons-home:hover span {
  padding-right: 25px;
  color :rgb(35,39,45);
}
.buttons-home:hover span:after {
  opacity: 1;
  right: 0;
}

.buttons-home:active {
  box-shadow: 0 5px rgb(250, 250, 252);
  transform: translateY(4px);
}


@media (max-width: 1250px) {
    .details-title {
      flex-direction: column;
    }
    .details-h2 {
      flex-direction: column;
    }
    .label {
      width: auto;
    }
    section {
      width: 50%;
    }
  }

</style>