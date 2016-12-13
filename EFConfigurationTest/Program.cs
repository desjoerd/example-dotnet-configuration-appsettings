using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFConfigurationTest
{
    class Program
    {
        static void Main(string[] args)
        {
            var testContext = new System.Data.Entity.Infrastructure.DbContextInfo(typeof(TestContext), new System.Data.Entity.Infrastructure.DbConnectionInfo());
        }
    }
}
