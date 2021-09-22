<template>
<section>
<h1 class= "Titlu_Login">{{Titlu}}</h1>
<div class="input-div-a">
    <input class="inputs" type="text" placeholder="username">
</div>
<div class="input-div">
    <input class="inputs" type="text" placeholder="password">
</div>
<div class="button-div">
    <button class="buttons">{{Login}}</button>
    <button class="buttons">{{Register}}</button>
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
                Titlu: "WEBSITE-PORTFOLIO",
                Login: "Log in",
                Register: "Register",
                Forgot: "Forgot your password?"
            }
        }
    }



</script>

<style >

.Titlu_Login {
    color: rgb(51, 255, 169);
    font-size: 30px;
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
    width: 9rem;
    text-align: center;
    font-size: 15px;
    background-color: rgb(51, 255, 169);
    color: black;
    border-radius: 15px;
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
