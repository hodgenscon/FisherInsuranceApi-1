using System;
using System.Collections.Generic;

namespace FisherInsuranceApi.Models
{
    public class Application
    {
        public int Id { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public List<Asset> AssetsToCover { get; set; }

        public string Status { get; set; }
    }

}