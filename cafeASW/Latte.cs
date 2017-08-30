using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cafeASW
{
    public class Latte : Kaffe, Imælk
    {
        public int MlMælk()
        {
            return 200;
        }

        public override int Pris()
        {
            return 40;
        }
    }
}
