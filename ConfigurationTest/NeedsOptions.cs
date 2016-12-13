using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConfigurationTest
{
    public class NeedsOptions
    {
        public NeedsOptions(NestedOptions options)
        {
            this.Options = options;
        }

        public NestedOptions Options { get; private set; }
    }
}
