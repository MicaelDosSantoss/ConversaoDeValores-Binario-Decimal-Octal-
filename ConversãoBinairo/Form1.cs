using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ConversãoBinairo.Converter;


namespace ConversãoBinairo
{

    
    public partial class form1 : Form
    {
        public form1()
        {
       
            InitializeComponent();
        }

        private void Executar_Click(object sender, EventArgs e)
        {
            int value_Combo = comboBox1.SelectedIndex;


            switch (value_Combo)
            {
                case 0:
                    BinarioParaDecimal binarioParaDecimal = new BinarioParaDecimal();
                    binarioParaDecimal.valueInput = Input.Text;
                    binarioParaDecimal.conversao();

                    Result.Text = binarioParaDecimal.valueFinal.ToString();
                    break;
                 case 1:
                      DecimalParaBinario DecimalParaBinario = new DecimalParaBinario();
                      DecimalParaBinario.valueInput = Input.Text;
                      DecimalParaBinario.conversao();

                      Result.Text = DecimalParaBinario.valueFinal;
                      break; 
                case 2:
                      BinarioParaOctal BinarioParaOctal = new BinarioParaOctal();
                      BinarioParaOctal.valueInput = Input.Text;
                      BinarioParaOctal.conversao();

                      Result.Text = BinarioParaOctal.valueFinal.ToString();
                      break;

                case 3:
                          DecimalParaDecimal decimalParaDecimal = new DecimalParaDecimal();
                          decimalParaDecimal.valueInput = Input.Text;
                          decimalParaDecimal.conversao();

                          Result.Text = decimalParaDecimal.valueFinal.ToString();
                          break;
                case 4:
                    DecimalParaOctal decimalParaOctal = new DecimalParaOctal();
                    decimalParaOctal.valueInput = Input.Text;
                    decimalParaOctal .conversao();

                    Result.Text = decimalParaOctal.valueFinal;
                    break;
                case 5:
                    OctalParaBinario octalParaBinario = new OctalParaBinario();
                    octalParaBinario.inputValue = Input.Text;
                    octalParaBinario.conversao();

                    Result.Text = octalParaBinario.inputFinal;

                    break;
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
