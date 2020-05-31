using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Publisher
{
   public class Publisher
    {
        public event iteratie eveniment;

        public void DeclansareEveniment()
        {
            for (int i = 1; i <= 10; i = i + 2)
            {
                if (eveniment != null)     // verificam existenta metodelor subscriber
                    eveniment(i);          // declansam evenimentul
            }
        }

    }
}
