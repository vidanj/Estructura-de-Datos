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
    public partial class Datos_Abstractos___Practica_1 : Form
    {
        public Datos_Abstractos___Practica_1()
        {
            InitializeComponent();
        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            new Datos_Abstractos__Practica_1_2(selected_RadioButton()).ShowDialog(); 
        }

        private string selected_RadioButton()
        {
            string result = null;
            result = radioButton1.Checked == true ? "int" : result;
            result = radioButton2.Checked == true ? "float" : result;
            result = radioButton3.Checked == true ? "bool" : result;
            result = radioButton4.Checked == true ? "char" : result;
            result = radioButton5.Checked == true ? "object" : result;
            result = radioButton6.Checked == true ? "ADT1" : result;
            result = radioButton7.Checked == true ? "ADT2" : result;
            //MessageBox.Show(result);
            return result;
        }
    }
}
