using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConversãoBinairo.Converter
{
    internal class BinarioParaOctal:Models.Model_n1
    {
        public override void conversao()
        {
            number = 8;

            base.conversao();
        }
    }
}
