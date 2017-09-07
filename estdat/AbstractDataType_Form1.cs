using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace estdat
{
    public partial class AbstractDataType_Form1 : Form
    {
        public AbstractDataType_Form1()
        {
            InitializeComponent();
        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            new AbstractDataType_Form2(selected_RadioButton()).ShowDialog(); 
        }

        private string selected_RadioButton()
        {
            string result = null;
            result = radBtnInt.Checked == true ? "int" : result;
            result = radBtnFloat.Checked == true ? "float" : result;
            result = radBtnBool.Checked == true ? "bool" : result;
            result = radBtnChar.Checked == true ? "char" : result;
            result = radBtnObject.Checked == true ? "object" : result;
            result = radBtnADT1.Checked == true ? "ADT1" : result;
            result = radBtnADT2.Checked == true ? "ADT2" : result;
            //MessageBox.Show(result);
            return result;
        }
    }
}
