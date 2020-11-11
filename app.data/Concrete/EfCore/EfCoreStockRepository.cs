using app.data.Abstract;
using app.entity;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Text;

namespace app.data.Concrete.EfCore
{
    public class EfCoreStockRepository : EfCoreGenericRepository<Portfolio, SPMContext>, IStockRepository
    {
        public List<Stock> GetAllStocks()
        {
            var client = new RestClient("https://api.collectapi.com/economy/hisseSenedi");
            var request = new RestRequest(Method.GET);
            request.AddHeader("authorization", "apikey 1sCiRpSsuTnwJUpefnlxRK:2uUiJjmcmnM4yURgmSswO5");
            request.AddHeader("content-type", "application/json");
            IRestResponse response = client.Execute(request);
            var jObj = JsonConvert.DeserializeObject(response.Content) as JObject;
            var jArr = jObj.GetValue("result");
            var stocks = jArr.ToObject<List<Stock>>();
            return stocks;
        }
    }
}
