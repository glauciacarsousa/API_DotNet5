using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoTelas
{
    public partial class frmInicial : Form
    {
        public frmInicial()
        {
            InitializeComponent();

            txtCpf.Enabled = true;
            txtEmail.Enabled = true;
            txtIdade.Enabled = true;
            txtNome.Enabled = true;
            txtSobren.Enabled = true;
            txtEnd.Enabled = true;
            maskedTextBoxFONE.Enabled = true;
            comboBoxCidade.Enabled = true;



        }

        private void SairClick(object sender, EventArgs e)
        {
            Close();
        }

        private void btnPessoais_Click(object sender, EventArgs e)
        {

            DadosPessoais dados = new DadosPessoais();
            dados.ShowDialog();

        }

        private void btnOutrasInfos_Click(object sender, EventArgs e)
        {
            OutrasInfos infos = new OutrasInfos();
            infos.ShowDialog();
        }
    }
}
