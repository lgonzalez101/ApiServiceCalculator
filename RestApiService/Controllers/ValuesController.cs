using RestApiService.Areas.HelpPage.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace RestApiService.Controllers
{
    public class ValuesController : ApiController
    {
        // GET api/values
        public ResultadoModel Get()
        {            
            return new ResultadoModel { Resultado = "Hola Mundo" };
        }

        // GET api/values/5
        public ResultadoModel Get(int val)
        {           
            return new ResultadoModel();
        }

        // POST api/values
        public ResultadoModel Post(ResultadoModel value)
        {
            try
            {
                string result = new DataTable().Compute(value.Resultado, null).ToString();
                return new ResultadoModel { Resultado = result };
            }
            catch (Exception e)
            {
                return new ResultadoModel { Resultado = "0" };
            }
          
        }

        // PUT api/values/5
        public void Put(int id, [FromBody]string value)
        {

        }

        // DELETE api/values/5
        public void Delete(int id)
        {
        }
    }
}
