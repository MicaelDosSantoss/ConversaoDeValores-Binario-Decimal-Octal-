using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConversãoBinairo.Models
{
    internal class Model_Division
    {
        public string valueInput { get; set; }
        public string valueFinal { get; private set; }
        public int number { get; set; }

        public virtual void conversao()
        {
            int value = Convert.ToInt32(valueInput);
            
            while(value > 0)
            {
                valueFinal += (value % number).ToString();
                value = value / number;

            }
            
        }
        
        }
    }
