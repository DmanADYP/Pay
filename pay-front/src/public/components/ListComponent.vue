<template>
  <div>
    <b-table striped hover :items="items" :fields="fields"></b-table>
  </div>
</template>

<script lang="ts">
import { Options, Vue } from "vue-class-component";
import { DataSrcInterface } from "@/public/interfaces/DataSrc.Interface";
import { Store, useStore } from "vuex";

@Options({})
export default class ListComponent extends Vue {
  store: Store<any> = useStore();
  unsubscribe: any;
  fields = ["id", "value", "isPalindrome"];
  items: DataSrcInterface[] = [];
  unmounted(): void {
    this.unsubscribe();
  }

  mounted(): void {
    this.store.dispatch("payApi/getAll");
    this.unsubscribe = this.store.subscribe((mutation: any, state: any) => {
      if (mutation.type === "payApi/getAllData") {
        this.items = state.payApi.data;
      }
    });
  }
}
</script>
