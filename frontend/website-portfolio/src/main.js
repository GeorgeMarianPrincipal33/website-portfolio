import { createApp } from 'vue';
import { createRouter, createWebHistory } from 'vue-router';
import App from './App.vue';
import Home from './components/Home.vue';
import Login from './components/Login.vue';
import Leon from './components/Leon.vue';
import Catalin from './components/Catalin.vue';
import Dragos from './components/Dragos.vue';



const routes = [
     { path: '/home', component: Home },
     { path: '/Leon', component: Leon },
     { path: '/Catalin', component: Catalin },
     { path: '/Dragos', component: Dragos },
     { path: '/', component:  Login },

];

const router = createRouter({
    routes: routes,
    history: createWebHistory(),
});


const app = createApp(App);
app.use(router)
app.mount('#app')

