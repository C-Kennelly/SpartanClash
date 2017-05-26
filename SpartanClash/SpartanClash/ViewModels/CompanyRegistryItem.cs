using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SpartanClash.Models;
namespace SpartanClash.ViewModels
{
    public class CompanyRegistryItem
    {
        public string companyName { get; }
        
        public CompanyRegistryItem(t_companies rawItem)
        {
            companyName = rawItem.company;
        }

    }
}