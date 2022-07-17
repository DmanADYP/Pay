<template>
  <!-- <div>
    <b-jumbotron
      header="BootstrapVue"
      lead="Bootstrap v4 Components for Vue.js 2"
    >
      <p>For more information visit website</p>
      <b-button variant="primary" href="#">More Info</b-button>
    </b-jumbotron>
  </div> -->
  <div class="home">
    <FormComponent />
    <ListComponent />
  </div>
</template>

<script lang="ts">
import { Options, Vue } from "vue-class-component";
import FormComponent from "@/public/components/FormComponent.vue"; // @ is an alias to /src
import ListComponent from "@/public/components/ListComponent.vue";

@Options({
  components: {
    FormComponent,
    ListComponent,
  },
})
export default class HomeView extends Vue {}
</script>
