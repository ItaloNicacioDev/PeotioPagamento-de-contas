using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PeotioiPIM
{
    public partial class TelaPrincipal : Form
    {
        public TelaPrincipal()
        {
            InitializeComponent();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            Inicio inicio = new Inicio();
            inicio.ShowDialog();
            this.Close();
        }

        private void TelaPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void btnGerar_Click(object sender, EventArgs e)
        {
            Gerar_Holerite gerar_Holerite = new Gerar_Holerite();
           gerar_Holerite.ShowDialog();
            this.Close();
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            Consultar_Holerite consultar_Holerite =new Consultar_Holerite();
            consultar_Holerite.Show();

        }
    }
}
