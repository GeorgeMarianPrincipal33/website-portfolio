<template>
<section>
<h1 class= "titlu">{{Titlu}}</h1>
<div class="input-div-a">
    <input class="inputs" type="text" placeholder="username">
</div>
<div class="input-div">
    <input class="inputs" type="text" placeholder="password">
</div>
<div class="button-div">
  <router-link to="/Home">
    <button class="buttons">
      <span>{{Login}}</span>
    </button>
  </router-link>
</div>
<div class="link-div">
    <a class="link" href="">{{Forgot}}</a>
</div>
</section>
    
</template>

<script>
    export default {
        data () {
            return {
                Titlu: "Website-Portfolio",
                Login: "Log in",
                Register: "Register",
                Forgot: "Forgot your password?"
            }
        }
    }



</script>

<style >

.titlu {
  display: flex;
  align-items: center;
  justify-content: center;
  position: relative;
  margin: 20px auto;
  width: 400px;
  height: 100px;
  background: white;
  border-radius: 150px;
  font-family: 'Montserrat', sans-serif;
  font-weight: lighter;
  letter-spacing: 2px;
  transition: 1s box-shadow;
  background: linear-gradient(90deg, rgb(9, 80, 56) 0%, rgb(238, 238, 240) 100%);
  color:black;
  font-size: 25px;
}

.titlu:hover {
  box-shadow: 0 5px 35px 0px rgba(0,0,0,.1);
}
.titlu:hover::before, .titlu:hover::after {
  display: block;
  content: '';
  position: absolute;
  width: 250px;
  height: 100px;
  background: whitesmoke;
  border-radius: 150px;
  z-index: -1;
  animation: 1s clockwise infinite;
}
.titlu:hover:after {
  background: rgb(51,255,169);
  animation: 2s counterclockwise infinite;
}
@keyframes clockwise {
  0% {
    top: -5px;
    left: 0;
  }
  12% {
    top: -2px;
    left: 2px;
  }
  25% {
    top: 0;
    left: 5px;    
  }
  37% {
    top: 2px;
    left: 2px;
  }
  50% {
    top: 5px;
    left: 0;    
  }
  62% {
    top: 2px;
    left: -2px;
  }
  75% {
    top: 0;
    left: -5px;
  }
  87% {
    top: -2px;
    left: -2px;
  }
  100% {
    top: -5px;
    left: 0;    
  }
}
@keyframes counterclockwise {
  0% {
    top: -5px;
    right: 0;
  }
  12% {
    top: -2px;
    right: 2px;
  }
  25% {
    top: 0;
    right: 5px;    
  }
  37% {
    top: 2px;
    right: 2px;
  }
  50% {
    top: 5px;
    right: 0;    
  }
  62% {
    top: 2px;
    right: -2px;
  }
  75% {
    top: 0;
    right: -5px;
  }
  87% {
    top: -2px;
    right: -2px;
  }
  100% {
    top: -5px;
    right: 0;    
  }
}

.input-div-a {
    margin-top: 10rem;
}

.input-div {
}

.button-div {
    margin-top: 4rem;    
}

.buttons {
    height: 3rem;
    width: 10rem;
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
    color: white;
}


.buttons span {
  cursor: pointer;
  display: inline-block;
  position: relative;
  transition: 0.5s;
}
.buttons span:after {
  content: '\00bb';
  position: absolute;
  opacity: 0;
  top: 0;
  right: -20px;
  transition: 0.5s;
}
.buttons:hover span {
  padding-right: 25px;
  color :rgb(35,39,45);
}
.buttons:hover span:after {
  opacity: 1;
  right: 0;
}

.buttons:active {
  box-shadow: 0 5px rgb(250, 250, 252);
  transform: translateY(4px);
}

.inputs {
    width: 30%;
    height: 4rem;
    text-align: center;
    padding: 12px 20px;
    margin: 8px 0;
    display: inline-block;
    border: 1px solid #ccc;
    box-sizing: border-box;
    border-radius: 15px;
    font-size:large;
}

.link {
    color: whitesmoke;
}

.link:hover {
    color:rgb(51, 255, 169)
}

.link-div {
    margin-top: 2rem;
}

</style>
