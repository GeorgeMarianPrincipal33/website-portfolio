import { createApp } from 'vue';
import { createRouter, createWebHistory } from 'vue-router';
import App from './App.vue';
import Home from './components/Home.vue';
import Login from './components/Login.vue';




const routes = [
     { path: '/home', component: Home },
     { path: '/', component:  Login },

];

const router = createRouter({
    routes: routes,
    history: createWebHistory(),
});


const app = createApp(App);
app.use(router)
app.mount('#app')