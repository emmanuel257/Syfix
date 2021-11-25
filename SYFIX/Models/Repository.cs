using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SYFIX.Models
{
    public static class Repository
    {

        private static List<CustomerResponse> responses = new List<CustomerResponse>();

        public static IEnumerable<CustomerResponse> Responses => responses;

        public static void AddResponses(CustomerResponse response)
        {
            responses.Add(response);
        }
    }
}
