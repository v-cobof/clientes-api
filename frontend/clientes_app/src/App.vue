<template>
  <div class="container">
    <nav class="navbar navbar-expand-lg navbar-light bg-light mb-1">
      <div class="container-fluid">
        <a class="navbar-brand" href="#">MyCRUD</a>

        <ul class="navbar-nav">
          <li class="nav-item">
            <a class="nav-link active" aria-current="page" href="#">Aula</a>
          </li>
          <li class="nav-item">
            <a class="nav-link" href="#">Features</a>
          </li>
        </ul>
      </div>
    </nav>

    <div class="p-4 p-md-5 mb-4 text-white rounded bg-dark">
      <div class="col-md-6 px-0">
        <h1 class="display-4 fst-italic">
          Bem vindo a minha aplicação com Vue!
        </h1>
        <p class="lead my-3">
          Ela faz um CRUD em um banco de dados MongoDB através de uma API feita em .NET 5.0
        </p>
        <p class="lead mb-0">
          <a href="https://github.com/v-cobof/clientes-app" target="_blank" class="text-white fw-bold">Ver repositório</a>
        </p>
      </div>
    </div>

    <hr />
    <Clientes />
  </div>
</template>

<script>
import Clientes from "./components/Clientes.vue";

export default {
  name: "App",
  components: {
    Clientes,
  },
};
</script>

<style>
</style>
