using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConversãoBinairo.Converter
{
    internal class OctalParaBinario
    {
        public string inputValue { get; set; }
        public string inputFinal { get; private set; }

        public void conversao()
        {
            for (int i = 0; i < inputValue.Length; i++)
            {
                char c = inputValue[i];

                switch (c)
                {
                    case '0':
                        inputFinal += "000";
                        break;
                    case '1':
                        inputFinal += "001";
                        break;
                    case '2':
                        inputFinal += "010";
                        break;
                    case '3':
                        inputFinal += "011";
                        break;
                    case '4':
                        inputFinal += "100";
                        break;
                    case '5':
                        inputFinal += "101";
                        break;
                    case '6':
                        inputFinal += "110";
                        break;
                    case '7':
                        inputFinal += "111";
                        break;

                };
            }
        }

    }
}
