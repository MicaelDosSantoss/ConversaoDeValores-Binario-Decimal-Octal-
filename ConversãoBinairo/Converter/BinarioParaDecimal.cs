using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using ConversãoBinairo;

namespace ConversãoBinairo.Converter
{
    internal class BinarioParaDecimal : Models.Model_n1
    {
        
        public override void conversao()
        {
            number = 2;
            
            base.conversao();
        }
    }
}
