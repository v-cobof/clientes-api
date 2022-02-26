<template>
  <div class="p-4 p-md-5 mb-4 text-white rounded bg-dark">
    <div class="col-md-6 px-0">
      <h1 class="display-4 fst-italic">Bem vindo a minha aplicação Vue.js!</h1>
      <p class="lead my-3">
        Ela realiza as operações CRUD em um banco de dados MongoDB através de uma API construída em
        C# e .NET 5.0
      </p>
      
      <router-link to="/clientes" class="btn btn-primary">Cadastrar Clientes</router-link>
      
    </div>
  </div>
</template>