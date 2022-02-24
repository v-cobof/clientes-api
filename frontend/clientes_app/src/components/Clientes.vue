<template>
  <form>
    <div class="form-group mb-3">
      <label for="nome">Nome</label>
      <input type="hidden" id="id" name="id" />
      <input
        type="text"
        class="form-control"
        id="nome"
        name="nome"
        placeholder="Digite o nome"
      />
    </div>

    <div class="form-group mb-3">
      <label for="telefone">Telefone</label>
      <input
        type="tel"
        class="form-control"
        id="telefone"
        name="telefone"
        placeholder="Digite o telefone"
      />
    </div>

    <div class="form-group mb-3">
      <label for="endereco">Endereço</label>
      <input
        type="text"
        class="form-control"
        id="endereco"
        name="endereco"
        placeholder="Digite o endereço"
      />
    </div>

    <button v-on:click="salvar()" type="button" class="btn btn-primary">
      Enviar
    </button>

    <div style="color: red">
      {{ mensagem }}
    </div>
  </form>

  <table class="table">
    <thead>
      <tr>
        <th>Id</th>
        <th>Nome</th>
        <th>Telefone</th>
        <th>Endereço</th>
      </tr>
    </thead>
    <tbody>
      <tr v-for="cliente in clientes" v-bind:key="cliente.id">
        <td>{{ cliente.id }}</td>
        <td>{{ cliente.nome }}</td>
        <td>{{ cliente.telefone }}</td>
        <td>{{ cliente.endereco }}</td>
      </tr>
    </tbody>
  </table>
</template>

<script>
import axios from "axios";
let escopoClientes = null;

export default {
  name: "ClientesTabela",
  props: {
    msg: String,
  },

  data: () => {
    return {
      clientes: [],
      mensagem: "",
    };
  },

  methods: {
    lista() {
      axios.get(`http://localhost:24219/api/Clientes`).then((res) => {
        escopoClientes.clientes = res.data;
      });
    },
    salvar() {
      axios.post(`http://localhost:24219/api/Clientes`, 
      {
        nome: document.getElementById("nome").value,
        telefone: document.getElementById("telefone").value,
        endereco: document.getElementById("endereco").value
      }).then(() => {
          this.lista()
      })

    },
  },

  created() {
    escopoClientes = this;
    escopoClientes.lista();
  },

};
</script>

<!-- Add "scoped" attribute to limit CSS to this component only -->
<style scoped>
</style>
