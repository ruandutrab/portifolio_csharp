using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace Portifolio_CSharp
{
    public partial class F_telaPrincipal : Form
    {
        Thread startQuiz;
        public F_telaPrincipal()
        {
            InitializeComponent();
        }

        private void btn_quiz_Click(object sender, EventArgs e)
        {
            this.Hide();
            startQuiz = new Thread(novoForm);
            startQuiz.SetApartmentState(ApartmentState.STA);
            startQuiz.Start();
        }

        private void novoForm(object obj)
        {
            Application.Run(new F_Quiz());
        }
    }
}
