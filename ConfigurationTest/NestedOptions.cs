using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConfigurationTest
{
    public class NestedOptions
    {
        public string One { get; set; }

        public string Two { get; set; }

        public Foo Foo { get; set; }
    }

    public class Foo
    {
        public string Bar { get; set; }
    }
}
