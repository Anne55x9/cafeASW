using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cafeASW
{
    public class Cortado : Kaffe
    {
        /// <summary>
        /// Prisen på Cortado.
        /// </summary>
        /// <returns></returns>
        public override int Pris()
        {
            return 25;
        }
    }
}
