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
    [EnableCors(origins: "*", headers: "*", methods: "*")]
    public class CustomerController : ApiController
    {


        private CustomerDTO c = new CustomerDTO();
      
       
        public IHttpActionResult GetCustomers()
        {
            try
            {
                List<CustomerDTO> customer = c.getCustomerData();
               
                
                return Ok(customer);
                
             
            }
            catch (Exception e)
            {
                return InternalServerError(e);
            }

        }
        [System.Web.Http.HttpPost]
        
        public IHttpActionResult Post( CustomerDTO customer)
        {
            try
            {
              
                c.AddCustomer(customer);
                return Ok();
               
            }
            catch (Exception e)
            {
                return InternalServerError(e);
            }
        }

    }
    
}