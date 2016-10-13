using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Certificacao70483.DelegateMulticast
{
    class UseAction
    {
        public UseAction()
        {
            Action<int, int> calc = (i, i1) =>
            {
                Console.WriteLine(i + i1);

            };

            calc(24,52);
        }
    }
}
