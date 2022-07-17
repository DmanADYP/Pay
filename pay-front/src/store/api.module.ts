import PayApiService from "@/public/services/pay.api";
import { DataSrcInterface } from "@/public/interfaces/DataSrc.Interface";
const initialState = { errStatus: "", data: [] };

export const payApiModule = {
  refName: "payApi",
  namespaced: true,
  state: initialState,
  actions: {
    getAll(context: any) {
      return PayApiService.getAll().then(
        (datObj) => {
          context.commit("getAllData", datObj.data);
          return Promise.resolve(datObj);
        },
        (error) => {
          context.commit("errorCatch");
          return Promise.reject(error);
        }
      );
    },
    addNew(context: any, payload: DataSrcInterface) {
      return PayApiService.addData(payload).then(
        (datObj) => {
          context.dispatch("getAll");
          return Promise.resolve(datObj);
        },
        (error) => {
          context.commit("errorCatch");
          return Promise.reject(error);
        }
      );
    },
  },
  mutations: {
    getAllData(state: any, dataObj: DataSrcInterface[]) {
      state.data = dataObj;
    },
    errorCatch(state: any, data: any) {
      state.errStatus = data;
    },
  },
};
