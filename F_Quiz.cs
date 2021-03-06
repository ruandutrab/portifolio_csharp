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
        F_telaPrincipal f_principal;
        List<Pergunta> quiz = new List<Pergunta>();
        List<Users> usersList = new List<Users>();
        int pontoFinal = 0;
        int indexQuestao = 0;
        int qtdeDados;
        string nivel;
        public F_Quiz(Form fromPrincipal, F_telaPrincipal t_p)
        {
            InitializeComponent();
            principal = fromPrincipal;
            f_principal = t_p;
        }

        private void F_Quiz_Load(object sender, EventArgs e)
        {
            nivel = f_principal.cb_niveis.SelectedValue.ToString();
            if(nivel == "facil")
            {
                rb_resposta3.Visible = false;
                rb_resposta4.Visible = false;
            } 
            else if(nivel == "medio")
            {
                rb_resposta4.Visible = false;
            }
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
            BotoesAux();

            List<Pergunta> dadosQuiz = Extender.LeituraDasPerguntas();
            quiz = dadosQuiz;
            lb_questao.Text = dadosQuiz[indexQuestao].questao;
            rb_resposta1.Text = dadosQuiz[indexQuestao].pergunta1;
            rb_resposta2.Text = dadosQuiz[indexQuestao].pergunta2;
            rb_resposta3.Text = dadosQuiz[indexQuestao].pergunta3;
            rb_resposta4.Text = dadosQuiz[indexQuestao].pergunta4;
            int n = 0;
            Random nd = new Random();
            n = nd.Next(1, 3);
            if (rb_resposta3.Visible == false && dadosQuiz[indexQuestao].respostaCerta == rb_resposta3.Text)
            {
                if(n == 1)
                {
                    rb_resposta1.Text = dadosQuiz[indexQuestao].respostaCerta;
                }
                else
                {
                    rb_resposta2.Text = dadosQuiz[indexQuestao].respostaCerta;
                }
            }
            else if (rb_resposta4.Visible == false && dadosQuiz[indexQuestao].respostaCerta == rb_resposta4.Text)
            {
                if (n == 1)
                {
                    rb_resposta1.Text = dadosQuiz[indexQuestao].respostaCerta;
                }
                else
                {
                    rb_resposta2.Text = dadosQuiz[indexQuestao].respostaCerta;
                }
            }
        }

        private void BotoesAux()
        {
            if (pontoFinal < 5)
            {
                btn_pular.Enabled = false;
                btn_elimitarResposta.Enabled = false;
                btn_dicaResposta.Enabled = false;
            } 
            else
            {
                btn_pular.Enabled = true;
                btn_elimitarResposta.Enabled = true;
                btn_dicaResposta.Enabled = true;
            }
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
  
        }
        private void btn_salvar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tb_respostaCerta.Text))
            {
                MessageBox.Show("Selecione uma resposta certa.");
                return;
            }
            if (string.IsNullOrEmpty(tb_dicaResposta.Text))
            {
                MessageBox.Show("Escreva uma dica para essa questão.");
                return;
            }
            quiz.Add(new Pergunta() {
            questao = tb_questao.Text,
            pergunta1 = tb_resposta1.Text,
            pergunta2 = tb_resposta2.Text,
            pergunta3 = tb_resposta3.Text,
            pergunta4 = tb_resposta4.Text,
            respostaCerta = tb_respostaCerta.Text,
            dicaResposta = tb_dicaResposta.Text
            });
            Extender.EscrevePerguntas(quiz);
            tb_questao.Clear();
            tb_resposta1.Clear();
            tb_resposta2.Clear();
            tb_resposta3.Clear();
            tb_resposta4.Clear();
            tb_respostaCerta.Clear();
            tb_dicaResposta.Clear();
            tb_questao.Focus();
        }

        private void btn_sair_Click(object sender, EventArgs e)
        {
            pnl_adicionarQuestoes.Visible = false;
            pnl_finalQuiz.Visible = true;
            dadosQuestao();
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
                pnl_perguntas.Visible = false;
                List<Users> users = new List<Users>();
                usersList = Extender.SearchUsers();
                if (new FileInfo(Extender.fileUsersPath).Length > 5)
                {
                    users = usersList;
                }
                if (usersList != null)
                {
                    for (int i = 0; i < usersList.Count; i++)
                    {
                        if (usersList[i].nome == f_principal.tb_jogador.Text)
                        {
                            if (pontoFinal < usersList[i].pontos) pontoFinal = usersList[i].pontos;
                            users.Add(new Users()
                            {
                                id = usersList[i].id,
                                nome = usersList[i].nome,
                                pontos = pontoFinal,
                                dificuldade = nivel,
                                jogo = "quiz"

                            });
                            usersList.RemoveAt(i);
                            Extender.WriteUsers(users.OrderBy(x => x.id).ToList());
                            return;
                        }
                    }
                }
                users.Add(new Users()
                    {
                        id = users.Count,
                        nome = f_principal.tb_jogador.Text,
                        pontos = pontoFinal,
                        dificuldade = nivel,
                        jogo = "quiz"

                });
                    Extender.WriteUsers(users);
                    return;
            }
            indexQuestao++;
            dadosQuestao();
            rb_resposta1.Enabled = true;
            rb_resposta2.Enabled = true;
            rb_resposta3.Enabled = true;
            rb_resposta4.Enabled = true;
        }
        private void CalcularResposta()
        {
            string certaResposta = quiz[indexQuestao].respostaCerta;
            if (rb_resposta1.Text == certaResposta && rb_resposta1.Checked == true) pontoFinal += 1;
            else if (rb_resposta2.Text == certaResposta && rb_resposta2.Checked == true) pontoFinal += 1;
            else if (rb_resposta3.Text == certaResposta && rb_resposta3.Checked == true) pontoFinal += 1;
            else if (rb_resposta4.Text == certaResposta && rb_resposta4.Checked == true) pontoFinal += 1;
            lb_pontos.Text = pontoFinal.ToString();
        }

        private void btn_finalReiniciar_Click(object sender, EventArgs e)
        {
            indexQuestao = 0;
            pontoFinal = 0;
            pnl_perguntas.Visible = true;
            dadosQuestao();

        }

        private void btn_finalSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_finalizar_Click(object sender, EventArgs e)
        {// Botão de finalizar!
            if(pontoFinal >= 5)
            {
                pnl_perguntas.Visible = false;
                List<Users> users = new List<Users>();
                usersList = Extender.SearchUsers();
                if (new FileInfo(Extender.fileUsersPath).Length > 5)
                {
                    users = usersList;
                }
                if (usersList != null)
                {
                    for (int i = 0; i < usersList.Count; i++)
                    {
                        if (usersList[i].nome == f_principal.tb_jogador.Text)
                        {
                            if (pontoFinal < usersList[i].pontos) pontoFinal = usersList[i].pontos;
                            users.Add(new Users()
                            {
                                id = usersList[i].id,
                                nome = usersList[i].nome,
                                pontos = pontoFinal,
                                dificuldade = nivel,
                                jogo = "quiz"

                            });
                            usersList.RemoveAt(i);
                            Extender.WriteUsers(users.OrderBy(x => x.id).ToList());
                            return;
                        }
                    }
                }
                users.Add(new Users()
                {
                    id = users.Count,
                    nome = f_principal.tb_jogador.Text,
                    pontos = pontoFinal,
                    dificuldade = nivel,
                    jogo = "quiz"

                });
                Extender.WriteUsers(users);
            } else
            {
                pnl_perguntas.Visible = false;
            }
        }

        private void btn_pular_Click(object sender, EventArgs e)
        {//Pula questão.

            if (indexQuestao >= qtdeDados)
            {
                MessageBox.Show("Você não pode pular a última questão.");
                return;
            }
            pontoFinal -= 5;
            indexQuestao++;
            dadosQuestao();
        }

        private void btn_elimitarResposta_Click(object sender, EventArgs e)
        {//Elimina duas resposta.
            Random n_random = new Random();
            int question1;
            int question2;
            question1 =  n_random.Next(1, 3);
            question2 = n_random.Next(3, 5);
            pontoFinal -= 5;
            if(question1 == 1)
            {
                if(rb_resposta1.Text == quiz[indexQuestao].respostaCerta)
                {
                    rb_resposta2.Enabled = false;
                } 
                else
                {
                    rb_resposta1.Enabled = false;
                }
            }
            else if(question1 == 2)
            {
                if(rb_resposta2.Text == quiz[indexQuestao].respostaCerta)
                {
                    rb_resposta1.Enabled = false;
                }
                else
                {
                    rb_resposta2.Enabled = false;
                }
            }
            if(question2 == 3)
            {
                if(rb_resposta3.Text == quiz[indexQuestao].respostaCerta)
                {
                    rb_resposta4.Enabled = false;
                }
                else
                {
                    rb_resposta3.Enabled = false;
                }
            }
            else if (question2 == 4)
            {
                if(rb_resposta4.Text == quiz[indexQuestao].respostaCerta)
                {
                    rb_resposta3.Enabled = false;
                }
                else
                {
                    rb_resposta4.Enabled = false;
                }
            }
        }
        private void btn_dicaResposta_Click(object sender, EventArgs e)
        {
            // Dica de resposta.
            MessageBox.Show(quiz[indexQuestao].dicaResposta);
        }
    }
}
