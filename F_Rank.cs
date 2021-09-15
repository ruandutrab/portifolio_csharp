using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Portifolio_CSharp
{
    public partial class F_Rank : Form
    {
        public F_Rank()
        {
            InitializeComponent();
        }

        private void F_Rank_Load(object sender, EventArgs e)
        {
            List<Users> dados = new List<Users>();
            dados = Extender.SearchUsers();
            dgv_ranking.DataSource = dados.OrderByDescending(x => x.pontos).ThenBy(x => x.nome).ToList();
            dgv_ranking.Columns[0].Visible = false;
            dgv_ranking.Columns[1].HeaderText = "Nome";
            dgv_ranking.Columns[2].HeaderText = "Pontos";
            dgv_ranking.Columns[3].HeaderText = "Nível";
        }
    }
    
}
