using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFConfigurationTest
{
    [DbConfigurationType(typeof(TestContextConfiguration))]
    public class TestContext : DbContext
    {
        public TestContext()
            : base()
        { }
    }
}
