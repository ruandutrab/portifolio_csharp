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

    public partial class F_Quiz : Form
    {
        Form principal;
        List<Pergunta> quiz = new List<Pergunta>();
        int pontos = 0;
        int indexQuestao = 0;
        int qtdeDados;
        public F_Quiz(Form fromPrincipal)
        {
            InitializeComponent();
            principal = fromPrincipal;

        }

        private void F_Quiz_Load(object sender, EventArgs e)
        {            
            if (!File.Exists(Extender.fileQuizPath))
            {
                Extender.EscrevePerguntas(quiz);
                pnl_adicionarQuestoes.Visible = true;
            } 
            
            if (new FileInfo(Extender.fileQuizPath).Length < 10)
            {
                 pnl_adicionarQuestoes.Visible = true;
                 return;
            }

            dadosQuestao(); //Recarrega as informações com questões e respostas.
            qtdeDados = quiz.Count;
            qtdeDados -= 1;
        }
        private void dadosQuestao() // Metodo para gerar novas perguntas.
        {
            List<Pergunta> dadosQuiz = Extender.LeituraDasPerguntas();
            quiz = dadosQuiz;
            lb_questao.Text = dadosQuiz[indexQuestao].questao;
            rb_resposta1.Text = dadosQuiz[indexQuestao].pergunta1;
            rb_resposta2.Text = dadosQuiz[indexQuestao].pergunta2;
            rb_resposta3.Text = dadosQuiz[indexQuestao].pergunta3;
            rb_resposta4.Text = dadosQuiz[indexQuestao].pergunta4;
        }

        private void F_Quiz_FormClosed(object sender, FormClosedEventArgs e)
        {
            principal.Visible = true;
            Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var addQuestion = MessageBox.Show("Deseja adicionar novas Questões?", "Adicionar Questões", MessageBoxButtons.YesNo);
            if (addQuestion == DialogResult.Yes)
            {
                pnl_finalQuiz.Visible = false;
                pnl_adicionarQuestoes.Visible = true;
            }
            quiz.Clear();
        }
        private void btn_salvar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tb_respostaCerta.Text))
            {
                MessageBox.Show("Selecione uma resposta certa.");
                return;
            }
            quiz.Add(new Pergunta() {
            questao = tb_questao.Text,
            pergunta1 = tb_resposta1.Text,
            pergunta2 = tb_resposta2.Text,
            pergunta3 = tb_resposta3.Text,
            pergunta4 = tb_resposta4.Text,
            respostaCerta = tb_respostaCerta.Text
            });
            Extender.EscrevePerguntas(quiz);
            tb_questao.Clear();
            tb_resposta1.Clear();
            tb_resposta2.Clear();
            tb_resposta3.Clear();
            tb_resposta4.Clear();
            tb_respostaCerta.Clear();
            tb_questao.Focus();
        }

        private void btn_sair_Click(object sender, EventArgs e)
        {
            pnl_adicionarQuestoes.Visible = false;
            pnl_finalQuiz.Visible = true;
        }

        private void btn_resposta1_Certa_Click(object sender, EventArgs e) => tb_respostaCerta.Text = tb_resposta1.Text;

        private void btn_resposta2_Certa_Click(object sender, EventArgs e) => tb_respostaCerta.Text = tb_resposta2.Text;

        private void btn_resposta3_Certa_Click(object sender, EventArgs e) => tb_respostaCerta.Text = tb_resposta3.Text;

        private void btn_resposta4_Certa_Click(object sender, EventArgs e) => tb_respostaCerta.Text = tb_resposta4.Text;

        private void btn_proximaQuestao_Click(object sender, EventArgs e)
        {
            btn_addQuestao.Visible = false;
            CalcularResposta();
            if(indexQuestao >= qtdeDados)
            {
                MessageBox.Show("Acabou");
                pnl_perguntas.Visible = false;
                return;
            }
            indexQuestao++;
            dadosQuestao();
        }
        private void CalcularResposta()
        {
            string certaResposta = quiz[indexQuestao].respostaCerta;
            if(rb_resposta1.Text == certaResposta && rb_resposta1.Checked == true)
            {
                MessageBox.Show("Certa!");
                pontos += 1;
            } 
            else if (rb_resposta2.Text == certaResposta && rb_resposta2.Checked == true)
            {
                MessageBox.Show("Certa!");
                pontos += 1;
            }
            else if (rb_resposta3.Text == certaResposta && rb_resposta3.Checked == true)
            {
                MessageBox.Show("Certa!");
                pontos += 1;
            }
            else if (rb_resposta4.Text == certaResposta && rb_resposta4.Checked == true)
            {
                MessageBox.Show("Certa!");
                pontos += 1;
            }
            lb_pontos.Text = pontos.ToString();
        }
    }
}
