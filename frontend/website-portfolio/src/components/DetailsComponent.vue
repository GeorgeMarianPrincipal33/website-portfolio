<template>
    <section>
      <div>
        <img class="profile-photo" src="../assets/logo.png" name="file_name">
      </div>
        <div>
        <button type="submit" id="contact" class="buttons-home" @click="contactUs">
            <span>Contact</span>
        </button>
        </div>
    </section>
</template>


<script>

export default {
    data() {
        return {
            employee: {
                title: `Bring your \n brand to life \n with our \n help`,
                icon: "",          
            }
        }        
    },

    methods: {
        contactUs() {
            window.scrollTo(window.scrollX, window.scrollY + 2000);            
        },
    },

}
</script>


<style>

.details-ul {
  flex-direction: row;
  margin-left: 40%;
}

.details-li {
  justify-content: space-between;
}

.profile-photo {
}


.details-title {
    color: white;
    left: 20%;
    font-size: 4rem;
}

.details-h2 {
    color: white;
    left: 22%;
    font-size: 1rem;
    margin-top: 5rem;
}


.buttons-home {
    height: 3rem;
    width: 13rem;
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


.buttons-home span {
  cursor: pointer;
  display: inline-block;
  position: relative;
  transition: 0.5s;
}
.buttons-home span:after {
  content: '\2193';
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
  }

</style>