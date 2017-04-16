using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Vidly.Models
{
    public class CustomerFormViewModel
    {
        public List<MembershipType> MembershipTypes { get; set; }

        public Customer Customer { get; set; }
    }
}