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
            dgv_ranking.DataSource = dados;
        }
    }
    
}
