using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Xml;
using XmlFileApp;


namespace XnetTest.Models
{
    public class CustomerDTO
    {
        //public int customerId { get; set; }
        public string fullName { get; set; }
        public string fullNameEng { get; set; }
        public DateTime dateBirth { get; set; }
        public string identityCard { get; set; }
        public int cityCode { get; set; }
        public int bank { get; set; }
        public int bankBranches { get; set; }
        public int BankAccountNumber { get; set; }

        public  List<CustomerDTO> getCustomerData()
        {
            using (var context = new testsEntities())
            {
                
                List<CustomerDTO> customer = new List<CustomerDTO>();

                customer = (from c in context.Customers

                            select new CustomerDTO
                            {
                                fullName = c.fullName,
                                fullNameEng = c.fullNameEng,
                                dateBirth = (DateTime)c.dateBirth,
                                identityCard = c.identityCard,
                                cityCode = c.City.code,
                                cityName = c.City.description,
                                bank = (int)c.bank,
                                bankBranches = (int)c.bankBranches,
                                BankAccountNumber = (int)c.BankAccountNumber,
                            }).ToList();
                var json = JsonConvert.SerializeObject(customer);

                

                //כתיבה

                //TableToXmlFile.CustomerXml(json.ToString());
                //ההפניה לפרוצדורה זו נפלה ולכן כתבתי את  קוד הפרוצדורה כאן
                //XmlDocument doc = JsonConvert.DeserializeXmlNode("{\"Customer\":" + json + "}", "Customers");
                //string path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\test.xml";
                //doc.Save(path);

                //קריאה

                //ReadXmlFile.ReadFile();

                return customer;
            }
            }

        public string cityName { get; set; }

        public  void AddCustomer(CustomerDTO customer)
        {
            using (var context = new testsEntities())
            {
                context.AddClient_sp(customer.fullName, customer.fullNameEng, customer.dateBirth, customer.identityCard, customer.cityCode, customer.bank, customer.bankBranches, customer.BankAccountNumber);

            }
        }
    }
   
}