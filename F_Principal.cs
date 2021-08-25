using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Portifolio_CSharp
{
    public partial class F_telaPrincipal : Form
    {

        public F_telaPrincipal()
        {
            InitializeComponent();
        }

        private void btn_quiz_Click(object sender, EventArgs e)
        {
            if(!string.IsNullOrEmpty(tb_jogador.Text))
            {
                new F_Quiz(this).Visible = true;
                Visible = false;
            }
            else
            {
                MessageBox.Show("O nome do jogador não pode ser vazio.");
            }
        }

        private void F_telaPrincipal_Load(object sender, EventArgs e)
        {
            Dictionary<string, string> niveisCb = new Dictionary<string, string>();
            niveisCb.Add("facil", "Fácil");
            niveisCb.Add("medio", "Médio");
            niveisCb.Add("dificil", "Difícil");
            cb_niveis.DataSource = new BindingSource(niveisCb, null);
            cb_niveis.DisplayMember = "Value";
            cb_niveis.ValueMember = "Key";

        }
    }
}
