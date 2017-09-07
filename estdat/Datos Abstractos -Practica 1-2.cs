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
    public partial class Datos_Abstractos__Practica_1_2 : Form
    {
        //Declaración de variables de clase privadas.
        private int column = 0;
        private int row = 0; 

        public Datos_Abstractos__Practica_1_2()
        {
            InitializeComponent();
        }

        public Datos_Abstractos__Practica_1_2(string dataType)
        {
            InitializeComponent();

           // MessageBox.Show(dataType);
            lblDataType.Text = "("+dataType+")";
        }

        private void Datos_Abstractos__Practica_1_2_Load(object sender, EventArgs e)
        {
            Initialize_dGVElementos();
        }

        private void Initialize_dGVElementos()
        {
            dGVElementos.Rows.Add();
            dGVElementos.Rows.Add();
            dGVElementos.Rows.Add();

            dGVElementos.Rows[0].HeaderCell.Value = "0";
            dGVElementos.Rows[1].HeaderCell.Value = "1";
            dGVElementos.Rows[2].HeaderCell.Value = "2";            
            
        }

        private void btnCapturar_Click(object sender, EventArgs e)
        {
            Capturar();
        }

        private void Capturar()
        {
            dGVElementos[column, row].Value = txtElemento.Text;
            column++;
            if (column == 3)
            {
                row++;
                column = 0;
            }
            if (row == 3)
            {
                txtElemento.Enabled = false;
                btnCapturar.Enabled = false;
            }
            if (row < 3)
            {
                lblTextbox.Text = "Elemento [" + row + "," + column + "] = ";
            }

            txtElemento.Clear();
            txtElemento.Focus();
        }
    }
}
