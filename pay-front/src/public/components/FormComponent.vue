<template>
  <div>
    <b-form @submit="onSubmit" @reset="onReset">
      <b-form-group
        id="value-group"
        label="Enter palindrome"
        label-for="input-value"
      >
        <b-form-input
          id="input-value"
          v-model="form.value"
          placeholder="palindrome"
          required
        ></b-form-input>
      </b-form-group>

      <b-button type="submit" variant="primary">Submit</b-button>
      <b-button type="reset" variant="danger">Reset</b-button>
    </b-form>
  </div>
</template>

<script lang="ts">
import { Options, Vue } from "vue-class-component";
import { DataSrcInterface } from "@/public/interfaces/DataSrc.Interface";
import { Store, useStore } from "vuex";

@Options({})
export default class FormComponent extends Vue {
  store: Store<any> = useStore();

  form = {
    value: "",
  };

  async getAllData(): Promise<void> {
    this.store.dispatch("payApi/getAll");
  }

  onSubmit(event: any) {
    event.preventDefault();
    const datObj: DataSrcInterface = { value: this.form.value };

    this.store.dispatch("payApi/addNew", datObj);
  }
  onReset(event: any) {
    event.preventDefault();
    this.form.value = "";
  }
}
</script>
