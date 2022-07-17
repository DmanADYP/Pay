import api from "./base.api";
import { DataSrcInterface } from "@/public/interfaces/DataSrc.Interface";

class PayApiService {
  getAll() {
    return api.get("/DataSrc/GetAllData");
  }
  addData(dataObj: DataSrcInterface) {
    return api.post("/DataSrc/AddData", dataObj);
  }
}

export default new PayApiService();
