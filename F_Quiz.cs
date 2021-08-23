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
        List<QuizeInfo> quizLista = new List<QuizeInfo>();
        string arquivo_quiz = string.Empty;
        string _Resposta = string.Empty;
        int _questaoAtual = 0;

        Form principal;
        public F_Quiz(Form fromPrincipal)
        {
            InitializeComponent();
            principal = fromPrincipal;
        }

        private void F_Quiz_Load(object sender, EventArgs e)
        {
            //obtem caminho completo do arquivo quiz1.txt
            string arquivo = "";
            string caminho = Environment.CurrentDirectory;
            caminho = caminho.Replace("\\bin\\Debug", "");
            caminho = caminho + "\\Quizzes\\quiz1.txt";
            //
            OpenFileDialog ofd1 = new OpenFileDialog();
            ofd1.CheckPathExists = true;
            ofd1.Title = "Selecionar Quiz";
            ofd1.InitialDirectory = caminho;
            ofd1.Filter = "Texto (*.TXT;*.RTF)|*.TXT|" + "Todos (*.*)|*.*";
            ofd1.CheckFileExists = true;
            ofd1.CheckPathExists = true;
            if (ofd1.ShowDialog() == System.Windows.Forms.DialogResult.OK
                && ofd1.FileName.Contains(".txt"))
            {
                arquivo = ofd1.FileName;
            }
            else
            {
                MessageBox.Show("Formato de arquivo inválido...");
                return;
            }
            //atribuir o nome do arquivo obtido
            arquivo_quiz = arquivo;
            //Carrega a Quiz
            CarregaQuiz(arquivo_quiz);
            //Exibe a primeira questão
            ExibirQuestao(0);
            //Desabilita o botão prôximo
            PicProximo.Image = PicDisabled.Image;
            //oculta o panel final
            pl_final.Left = pnl_perguntas.Left;
            pl_final.Visible = false;
            this.Focus();
        }

        private void F_Quiz_FormClosed(object sender, FormClosedEventArgs e)
        {
            principal.Visible = true;
            Visible = false;
        }

        public void CarregaQuiz(string nomeArquivo)
        {
            QuizeInfo quizinfo;
            string Linha = string.Empty;
            bool IsPrimeiraLinha = true;
            string[] Linhas = { };
            quizLista.Clear();
            if (File.Exists(nomeArquivo))
            {
                try
                {
                    using (StreamReader sr = new StreamReader(nomeArquivo))
                    {
                        //le o arquivo ate o fim
                        while (!sr.EndOfStream)
                        {
                            Linha = sr.ReadLine().Trim();
                            if (Linha.Length > 0)
                            {
                                //se achou primeira linha obtem o titulo da questão
                                if (IsPrimeiraLinha)
                                {
                                    //Define o titulo
                                    Text = Linha;
                                    //proxima linha
                                    Linha = sr.ReadLine().Trim();
                                }
                                //Não mais primeira linha
                                IsPrimeiraLinha = false;
                                if (!IsPrimeiraLinha)
                                {
                                    //cria um novo objeto quizinfo
                                    quizinfo = new QuizeInfo();
                                    //Divide a linha
                                    Linhas = Linha.Split('|');
                                    //Cria um array de respostas
                                    quizinfo.InitArray();
                                    //Define a questão
                                    quizinfo.Questao = Linhas[0];
                                    //Define as respostas para a questão
                                    quizinfo.respostas[0] = Linhas[1].Trim();
                                    quizinfo.respostas[1] = Linhas[2].Trim();
                                    quizinfo.respostas[2] = Linhas[3].Trim();
                                    //Define a resposta correta
                                    quizinfo.respostaCorreta = Linhas[4].Trim().ToUpper();
                                    //Preenche a informação da quiz
                                    quizLista.Add(quizinfo);
                                    //Limpa o array
                                    Array.Clear(Linhas, 0, Linhas.Length);
                                }
                            }
                        }
                        sr.Close();
                    }
                }
                catch { }
            }
        }
        void ExibirQuestao(int index)
        {
            QuizeInfo q;
            //Carrega a questaão
            q = quizLista[index];
            //Define as labels
            lb_teste.Text = (index + 1) + "/" + quizLista.Count.ToString();
            lb_pergunta.Text = q.Questao;
            //Define as respostas
            opcaoA.Text = "(A) " + q.respostas[0];
            opcaoB.Text = "(B) " + q.respostas[1];
            opcaoC.Text = "(C) " + q.respostas[2];
        }

        private void PicProximo_Click(object sender, EventArgs e)
        {
            _questaoAtual++;
            //Reseta o indice das questões
            if (_questaoAtual > quizLista.Count() - 1)
            {
                _questaoAtual = quizLista.Count() - 1;
                //Encerra a quiz
                CalcularRepostas();
                pnl_perguntas.Visible = false;
                pl_final.Visible = true;
            }
            ExibirQuestao(_questaoAtual);
            //Reseta o botão de resposta
            ResetarResposta();
        }

        public void ResetarResposta()
        {
            RadioButton rb = new RadioButton();
            string _escolha = _Resposta;
            if (_escolha == "A")
            {
                rb = opcaoA;
            }
            if (_escolha == "B")
            {
                rb = opcaoB;
            }
            if (_escolha == "C")
            {
                rb = opcaoC;
            }
            rb.Checked = false;
            rb.ForeColor = Color.Black;
            PicProximo.Enabled = false;
            PicProximo.Image = PicDisabled.Image;
        }

        public void CalcularRepostas()
        {
            int x = 0;
            int Placar = 0;
            double resultado = 0.0;
            while (x < quizLista.Count)
            {
                if (quizLista[x].respostaCorreta.Equals(quizLista[x].SelecionarResposta))
                {
                    Placar += 1;
                }
                x++;
            }
            resultado = (Placar * 100) / (int)quizLista.Count();
            //Exibe o resultado 
            lb_resultado.Text = Placar.ToString() + "/" + quizLista.Count().ToString();
            lb_resultado2.Text = "Seu Placar é  : " + resultado.ToString() + "%";
        }

        public void SelecionarResposta(RadioButton rb)
        {
            opcaoA.ForeColor = Color.Black;
            opcaoB.ForeColor = Color.Black;
            opcaoC.ForeColor = Color.Black;
            //Destaca a resposta selecionada
            rb.ForeColor = Color.Blue;
        }

        private void optA_Click(object sender, EventArgs e)
        {
            RadioButton rb = (RadioButton)sender;
            _Resposta = (string)rb.Tag;
            quizLista[_questaoAtual].SelecionarResposta = _Resposta;
            PicProximo.Enabled = true;
            PicProximo.Image = picEnabled.Image;
            SelecionarResposta(rb);
        }

    }
}
