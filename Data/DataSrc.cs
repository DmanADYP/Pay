using Pay.API.Interfaces;
using Pay.API.Models;

namespace Pay.API.Data
{
    public class DataSrc : IDataSrc
    {
        private List<DataSrcModel> DataObj = new List<DataSrcModel>();

        public Task<DataSrcModel> GetData(Guid Id)
        {
            DataSrcModel result = DataObj.First(w => w.Id == Id);
            return Task.FromResult(result);
        }

        public Task<ICollection<DataSrcModel>> GetAllData()
        {
            ICollection<DataSrcModel> results = DataObj.ToList();

            return Task.FromResult(results);
        }

        public Task<DataSrcModel> AddData(DataSrcModel dataSrcModel)
        {
            DataObj.Add(dataSrcModel);

            return Task.FromResult(dataSrcModel);
        }

        public Task<int> RemoveData(Guid Id)
        {
            return Task.FromResult(DataObj.RemoveAll(w => w.Id == Id));
        }

        public Task<bool> UpdateData(Guid Id, string value)
        {
            DataSrcModel result = DataObj.First(w => w.Id == Id);
            if (result == null) return Task.FromResult(false);
            result.Value = value;
            return Task.FromResult(true);
        }

        public Task<bool> IsPalindrome(string value)
        {
            char[] charArray = value.ToLower().ToCharArray();
            Array.Reverse(charArray);
            string reverse = new string(charArray);

            if (value.ToLower().Equals(reverse))
            {
                return Task.FromResult(true);
            }

            return Task.FromResult(false);
        }
    }
}