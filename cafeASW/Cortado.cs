using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cafeASW
{
    public class Cortado : Kaffe, Imælk
    {
        /// <summary>
        /// Vi tilføjer 25 ml mælk til cortado.
        /// </summary>
        /// <returns></returns>
        public int MlMælk()
        {
            return 25;
        }

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
