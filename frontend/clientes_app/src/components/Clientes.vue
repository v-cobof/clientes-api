<template>
  <form>
    <div class="form-group mb-3">
      <label for="nome">Nome</label>
      <input type="hidden" id="id" name="id" />
      <input
        type="text"
        class="form-control"
        v-model="cliente.nome"
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
        v-model="cliente.telefone"
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
        v-model="cliente.endereco"
        id="endereco"
        name="endereco"
        placeholder="Digite o endereço"
      />
    </div>

    <button v-on:click="salvar()" type="button" class="btn btn-primary mb-2">
      Enviar
    </button>

    <div style="color: red">
      {{ mensagem }}
    </div>
  </form>

  <br />

  <table class="table table-hover">
    <thead>
      <tr>
        <th>Id</th>
        <th>Nome</th>
        <th>Telefone</th>
        <th>Endereço</th>
        <th colspan="2"></th>
      </tr>
    </thead>
    <tbody>
      <tr v-for="cliente in clientes" v-bind:key="cliente.id">
        <td>{{ cliente.id }}</td>
        <td>{{ cliente.nome }}</td>
        <td>{{ cliente.telefone }}</td>
        <td>{{ cliente.endereco }}</td>
        <td>
          <button class="btn btn-primary" v-on:click="editar(cliente)">
            Editar
          </button>
        </td>
        <td>
          <button class="btn btn-danger" v-on:click="excluir(cliente.id)">
            Excluir
          </button>
        </td>
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
      cliente: {nome: "", telefone: "", endereco: ""},
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
      // se o objeto existir, chamo alterar e termino
      if (this.cliente.id) {
        this.alterar();
        return;
      }

      axios
        .post(`http://localhost:24219/api/Clientes`, /*{
          nome: document.getElementById("nome").value,
          telefone: document.getElementById("telefone").value,
          endereco: document.getElementById("endereco").value,
        }*/
        this.cliente).then(() => {
          this.lista();
          document.getElementById("nome").value = "";
          document.getElementById("telefone").value = "";
          document.getElementById("endereco").value = "";
        });
    },
    editar(cliente) {
      document.getElementById("nome").value = cliente.nome;
      document.getElementById("telefone").value = cliente.telefone;
      document.getElementById("endereco").value = cliente.endereco;
      this.cliente = cliente;
    },
    alterar() {
      this.cliente.nome = document.getElementById("nome").value;
      this.cliente.telefone = document.getElementById("telefone").value;
      this.cliente.endereco = document.getElementById("endereco").value;

      axios
        .put(
          `http://localhost:24219/api/Clientes/${this.cliente.id}`,
          this.cliente
        )
        .then(() => {
          this.lista();
          this.cliente = {nome: "", telefone: "", endereco: ""},
          document.getElementById("nome").value = "";
          document.getElementById("telefone").value = "";
          document.getElementById("endereco").value = "";
        });
    },

    excluir(id) {
      if (confirm("Confirma a exclusão ?")) {
        axios.delete(`http://localhost:24219/api/Clientes/${id}`).then(() => {
          this.lista();
        });
      }
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
