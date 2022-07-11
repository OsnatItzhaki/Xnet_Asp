//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace XnetTest.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Customer
    {
        public int customerId { get; set; }
        public string fullName { get; set; }
        public string fullNameEng { get; set; }
        public Nullable<System.DateTime> dateBirth { get; set; }
        public string identityCard { get; set; }
        public Nullable<int> cityCode { get; set; }
        public Nullable<int> bank { get; set; }
        public Nullable<int> bankBranches { get; set; }
        public Nullable<int> BankAccountNumber { get; set; }
    
        public virtual City City { get; set; }
        public virtual City City1 { get; set; }

        public void AddCustomer(CustomerDTO customer)
        {
            using (var context = new testsEntities())
            {
                context.AddClient_sp(customer.fullName, customer.fullNameEng, customer.dateBirth, customer.identityCard, customer.cityCode, customer.bank, customer.bankBranches, customer.BankAccountNumber);

            }
        }
    }
}
