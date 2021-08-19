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
    public partial class F_Quiz : Form
    {
        Form principal;
        public F_Quiz(Form fromPrincipal)
        {
            InitializeComponent();
            principal = fromPrincipal;
        }

        private void F_Quiz_Load(object sender, EventArgs e)
        {
            List<string> l_Pergunta = new List<string>();    
        }

        private void F_Quiz_FormClosed(object sender, FormClosedEventArgs e)
        {
            principal.Visible = true;
            Visible = false;
        }
    }
}
