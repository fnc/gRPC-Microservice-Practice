using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Microservice.Person.Models
{
    public class MongoDBConfig
    {
        public string Url { get; set; }
        public string AdminUsername { get; set; }
        public string AdminPassword { get; set; }

    }
}
