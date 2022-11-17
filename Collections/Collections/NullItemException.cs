using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{
    internal class NullItemException:Exception
    {
        public NullItemException(string message) : base(message)
        {

        }
    }
}
