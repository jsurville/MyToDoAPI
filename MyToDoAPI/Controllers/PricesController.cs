using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;
using MyToDoAPI.Logic;
using MyToDoAPI.Resources;

namespace MyToDoAPI.Controllers
{
    [EnableCors(origins: "http://localhost:4200", headers: "Access-Control-Allow-Origin:*", methods: "*")]
    public class PricesController : ApiController
    {
        private PriceLogic _priceLogic;

        public PricesController()
        {
            _priceLogic = new PriceLogic();
        }
        // GET api/prices
        public HttpResponseMessage Get(HttpRequestMessage request)
        {
            var prices = _priceLogic.GetAll();

            return request.CreateResponse(HttpStatusCode.OK, new List<PriceResource>(prices.Select(
                p => new PriceResource(p)).ToList()));
        }

        // GET api/prices/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/prices
        public void Post([FromBody] string value)
        {
        }

        // PUT api/prices/5
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/prices/5
        public void Delete(int id)
        {
        }
    }
}
