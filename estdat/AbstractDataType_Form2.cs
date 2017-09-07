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
    public partial class AbstractDataType_Form2 : Form
    {
        //Declaración de variables de clase privadas.
        private string VarDataType;
        private int column = 0;
        private int row = 0;
        private Validations Validation = new Validations();

        public AbstractDataType_Form2()
        {
            InitializeComponent();
        }

        public AbstractDataType_Form2(string dataType)
        {
            InitializeComponent();

           // MessageBox.Show(dataType);
            lblDataType.Text = "("+dataType+")";
            Catch_DataType(dataType);
        }
        //GUI methods.
        private void AbstractDataType_Form2_Load(object sender, EventArgs e)
        {
            Initialize_dGVElementos();
        }        

        private void btnCapturar_Click(object sender, EventArgs e)
        {
            Set_Element();
        }

        private void btnReiniciar_Click(object sender, EventArgs e)
        {
            Clear_dGVElementos();
        }

        private void txtElemento_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnCapturar.PerformClick();
            }
        }
        //End GUI methods.


        //Custom Methods
        private void Initialize_dGVElementos()
        {
            dGVElementos.Rows.Clear();

            dGVElementos.Rows.Add();
            dGVElementos.Rows.Add();
            dGVElementos.Rows.Add();

            dGVElementos.Rows[0].HeaderCell.Value = "0";
            dGVElementos.Rows[1].HeaderCell.Value = "1";
            dGVElementos.Rows[2].HeaderCell.Value = "2";

        }

        private void Catch_DataType(string dataType)
        {
            this.VarDataType = dataType;
        }

        private void Set_Element()
        {            
            if (Validation.DataType_Validation(txtElemento.Text, this.VarDataType))
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
                    dGVElementos.Focus();
                }
                if (row < 3)
                {
                    lblTextbox.Text = "Elemento [" + row + "," + column + "] = ";
                }

                txtElemento.Clear();
                txtElemento.Focus();
            }
            else
            {
                txtElemento.Clear();
                txtElemento.Focus();
                MessageBox.Show("Dato de tipo Incorrecto");
            }
            
        }

        public void Clear_dGVElementos()
        {
            Initialize_dGVElementos();
            this.column = 0;
            this.row = 0;
            
            lblTextbox.Text = "Elemento [0,0] = ";
            txtElemento.Clear();
            txtElemento.Focus();

            txtElemento.Enabled = true;
            btnCapturar.Enabled = true;
        }

        //End Custom Methods

    }
}
