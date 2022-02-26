<template>
  <div class="container">
    <nav class="navbar navbar-expand-lg navbar-light bg-light mb-1">
      <div class="container-fluid">
        <router-link to="/" class="navbar-brand">VueCRUD</router-link>
        <ul class="navbar-nav">
          <li class="nav-item">
            <router-link to="/" class="nav-link" active-class="active">Home</router-link>
          </li>
          <li class="nav-item">
            <router-link to="/clientes" class="nav-link" active-class="active">Clientes</router-link>
          </li>
          <li class="nav-item">
            <router-link to="/sobre" class="nav-link"  active-class="active">Sobre</router-link>
          </li>
        </ul>
      </div>
    </nav>
    <router-view></router-view>
  </div>
</template>