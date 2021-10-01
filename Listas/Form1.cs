using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Listas
{
    public partial class lstMenor : Form
    {
        public lstMenor()
        {
            InitializeComponent();
        }

        /*--------Variables=--------*/
        //int numero;


        /*Combo box*/
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int numero = Convert.ToInt32(comboBox1.Text);

            if(numero <= 50)
            {
                Menor.Items.Add(comboBox1.Text);
            }if(numero > 50 && numero < 120)
            {
                lstInter.Items.Add(comboBox1.Text);
            }if(numero > 121)
            {
                Mayor.Items.Add(comboBox1.Text);
            }
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            Menor.Items.Clear();
            lstInter.Items.Clear();
            Mayor.Items.Clear();
        }

        private void lstMenor_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Hello World");
        }
    }
}
