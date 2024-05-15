using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConversãoBinairo.Models
{
    internal class Model_n1
    {
        public string valueInput { get; set; }
        public double valueFinal { get; private set; }
        public int number {  get; set; }

        public virtual void conversao()
        {

            #region Inverter

            char[] caracteres = valueInput.ToCharArray();
            Array.Reverse(caracteres);
            valueInput = new string(caracteres);

            MessageBox.Show(number.ToString() );

            #endregion

            double arm = 0;

            for(int i = 0 ; i < valueInput.Length; i++ )
            {
                int b = valueInput[i] - '0';

                 arm += b * Math.Pow(number, i) ;
            }
            

            valueFinal = arm;

        }
    }
}
