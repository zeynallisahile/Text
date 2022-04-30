using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp10
{
     class Coverter
    {
        public  double Exchange(Currency e,double azn)
            {
            if (e is Currency)
            {
                switch (e)
                {
                    case Currency.Usd:
                        return azn * 0.59;
                    case Currency.Eur:
                        return azn * 0.53;
                    case Currency.TRY:
                        return azn * 8.73;
                    case Currency.Rub:
                        return azn * 52.21;
                    default:
                        return -1;                      
                }
            }
            return -1;
        }
    }
 }

