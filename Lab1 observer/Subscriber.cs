using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1_observer
{
    interface Subscriber
    {
        void Update(Publisher sender, Object context);
    }
}
