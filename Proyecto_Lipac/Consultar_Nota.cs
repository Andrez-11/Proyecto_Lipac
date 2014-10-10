using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_Lipac
{
    public partial class Consultar_Nota : Form
    {
        public Consultar_Nota()
        {
            InitializeComponent();
        }

        private void Consultar_Nota_Load(object sender, EventArgs e)
        {

        }

        private void Consultar_Nota_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Consultar_Nota_Detalle detalle = new Consultar_Nota_Detalle();
            detalle.Show();
            this.Hide();
        }
    }
}
