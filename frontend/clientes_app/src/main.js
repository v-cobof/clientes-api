import { createApp } from 'vue'
import App from './App.vue'

import Clientes from './components/Clientes.vue'
import Home from './components/HomePage.vue'
import Sobre from './components/SobrePage.vue'

import { createWebHistory, createRouter } from 'vue-router'

const routes = [
    { path: "/", component: Home },
    { path: "/clientes", component: Clientes },
    { path: "/sobre", component: Sobre }
]

const router = createRouter({
    history: createWebHistory(),
    routes,
})

createApp(App).use(router).mount('#app')


