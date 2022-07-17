import { createStore } from "vuex";
import { payApiModule } from "./api.module";

export default createStore({
  modules: {
    payApi: payApiModule,
  },
  state: {},
  getters: {},
  mutations: {},
  actions: {},
});
