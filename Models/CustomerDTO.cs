using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

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
        public string cityName { get; set; }


    }
   
}