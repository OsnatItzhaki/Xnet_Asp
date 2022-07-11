using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Http.Cors;
using System.Web.Mvc;
using XnetTest.Models;

namespace XnetTest.Controllers
{
    public class CityController : ApiController
    {
        [EnableCors(origins: "*", headers: "*", methods: "*")]
        public IHttpActionResult GetCities()
        {
            try
            {
                using (var context = new testsEntities())
                {
                    var cities = (from c in context.Cities

                                    select new CityDTO
                                    {
                                        code=c.code,
                                        description=c.description
                                    }).ToList();




                    //var customer = query.ToList<Customer>();
                    return Ok(cities);
                }
                //List<Client> clientList = ChangingWindow.getAllClient();


            }
            catch (Exception e)
            {
                return InternalServerError(e);
            }

        }

    }
}