using Pay.API.Models;

namespace Pay.API.Interfaces
{
    public interface IDataSrc
    {
        public Task<DataSrcModel> GetData(Guid Id);

        public Task<ICollection<DataSrcModel>> GetAllData();

        public Task<DataSrcModel> AddData(DataSrcModel dataSrcModel);

        public Task<int> RemoveData(Guid Id);

        public Task<bool> UpdateData(Guid Id, string value);

        public Task<bool> IsPalindrome(string value);
    }
}