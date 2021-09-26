<template>
    <section>
        <div class="navbar">
            <ul>
                <li><router-link to="/home"><a class="navbar-item">George</a></router-link></li>
                <li><router-link to="/Leon"><a class="navbar-item">Leon</a></router-link></li>
                <li><router-link to="/Catalin"><a class="navbar-item">Catalin</a></router-link></li>
                <li><router-link to="/Dragos"><a class="navbar-item">Dragos</a></router-link></li>

                <router-link to="/">
                    <li style="float:right"><a href="#contact">Sign-Out</a></li> 
                </router-link>
                <li style="float:right"><a href="#news">Work</a></li>
                <li style="float:right"><a href="#about">About</a></li>
                <li style="float:right"><a class="active" href="#home">Home</a></li>
            </ul>
         </div>
    </section>
</template>


<script>
 
export default {
    data() {
        return {
            navbarName: "George",
        }
    }
}
</script>

<style>
.navbar {
    flex-direction: row;
    position: fixed;
    width: 100%;
    top: 0;
    left: 0;
}

ul {
    list-style-type: none;
    margin: 0;
    padding: 0;
    overflow: hidden;
    background-color: rgb(35,39,45);
}



li {
    float: left;
}



li:last-child {
    border-right: none;
}



li a {
    display: block;
    color: white;
    text-align: center;
    padding: 14px 16px;
    text-decoration: none;
}



li a:hover:not(.active) {
    color: rgb(51,255,169);

}



.active {
    color: rgb(51,255,169);
}

.navbar-item {
    display: block;
    color: white;
    text-align: center;
    padding: 14px 16px;
    text-decoration: none;
    top: 0;
}


</style>