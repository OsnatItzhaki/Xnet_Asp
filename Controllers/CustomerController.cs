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


        private Customer c = new Customer();
        //public IHttpActionResult GetCustomerXmlFile(int isxml)
        //{
        //    try
        //    {
        //        c.CreateXml();

        //        return Ok();
        //    }
        //    catch(Exception e)
        //    {
        //        return InternalServerError(e);
        //    }
        //}
        public IHttpActionResult GetCustomers()
        {
            try
            {
                //c.getCustomerData();
                using (var context = new testsEntities())
                {

                    var customer = (from c in context.Customers
                                    
                                    select new CustomerDTO
                                    {
                                        fullName = c.fullName,
                                        fullNameEng = c.fullNameEng,
                                        dateBirth = (DateTime)c.dateBirth,
                                        identityCard = c.identityCard,
                                        cityCode = c.City.code,
                                        cityName=c.City.description,
                                        bank = (int)c.bank,
                                        bankBranches = (int)c.bankBranches,
                                        BankAccountNumber= (int)c.BankAccountNumber,
                                    }).ToList();




                    //var customer = query.ToList<Customer>();
                    return Ok(customer);
                }
                //List<Client> clientList = ChangingWindow.getAllClient();


            }
            catch (Exception e)
            {
                return InternalServerError(e);
            }

        }
        [System.Web.Http.HttpPost]
        //[FromBody] CustomerDTO customer
        public IHttpActionResult Post( CustomerDTO customer)
        {
            try
            {
              
                c.AddCustomer(customer);
                return Ok();
                //return Ok("לקוח חדש נוצר בהצלחה");
            }
            catch (Exception e)
            {
                return InternalServerError(e);
            }
        }

    }
    
}