using Microsoft.AspNetCore.Mvc;
using Pay.API.Interfaces;
using Pay.API.Models;

namespace Pay.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class DataSrcController : ControllerBase
    {
        private readonly ILogger<DataSrcController> _logger;
        private readonly IDataSrc _dataSrc;

        public DataSrcController(ILogger<DataSrcController> logger, IDataSrc dataSrc)
        {
            _logger = logger;
            _dataSrc = dataSrc;
        }

        [HttpGet]
        [Route("GetData/{id}")]
        public async Task<DataSrcModel> GetData(Guid id)
        {
            try
            {
                return await _dataSrc.GetData(id);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.Message);
                throw;
            }
        }

        [HttpGet]
        [Route("GetAllData")]
        public async Task<ICollection<DataSrcModel>> GetAllData()
        {
            try
            {
                return await _dataSrc.GetAllData();
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.Message);
                throw;
            }
        }

        [HttpPost]
        [Route("AddData")]
        public async Task<DataSrcModel> UpdateData(DataSrcModel dataSrcModel)
        {
            try
            {
                return await _dataSrc.AddData(dataSrcModel);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.Message);
                throw;
            }
        }

        [HttpPut]
        [Route("UpdateData")]
        public async Task<bool> UpdateData(Guid id, string value)
        {
            try
            {
                return await _dataSrc.UpdateData(id, value);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.Message);
                throw;
            }
        }

        [HttpDelete]
        [Route("DeleteData/{id}")]
        public async Task<int> DeleteData(Guid id)
        {
            try
            {
                return await _dataSrc.RemoveData(id);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.Message);
                throw;
            }
        }

        [HttpGet]
        [Route("IsPalindrome/{value}")]
        public async Task<bool> IsPalindrome(string value)
        {
            try
            {
                return await _dataSrc.IsPalindrome(value);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.Message);
                throw;
            }
        }
    }
}