
namespace Portifolio_CSharp
{
    partial class F_telaPrincipal
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_quiz = new System.Windows.Forms.Button();
            this.btn_jogoVelha = new System.Windows.Forms.Button();
            this.bnt_forca = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cb_niveis = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_jogador = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btn_quiz
            // 
            this.btn_quiz.Location = new System.Drawing.Point(12, 150);
            this.btn_quiz.Name = "btn_quiz";
            this.btn_quiz.Size = new System.Drawing.Size(91, 23);
            this.btn_quiz.TabIndex = 0;
            this.btn_quiz.Text = "Jogo de Quiz";
            this.btn_quiz.UseVisualStyleBackColor = true;
            this.btn_quiz.Click += new System.EventHandler(this.btn_quiz_Click);
            // 
            // btn_jogoVelha
            // 
            this.btn_jogoVelha.Location = new System.Drawing.Point(12, 226);
            this.btn_jogoVelha.Name = "btn_jogoVelha";
            this.btn_jogoVelha.Size = new System.Drawing.Size(91, 23);
            this.btn_jogoVelha.TabIndex = 1;
            this.btn_jogoVelha.Text = "Jogo da Velha";
            this.btn_jogoVelha.UseVisualStyleBackColor = true;
            // 
            // bnt_forca
            // 
            this.bnt_forca.Location = new System.Drawing.Point(12, 190);
            this.bnt_forca.Name = "bnt_forca";
            this.bnt_forca.Size = new System.Drawing.Size(91, 23);
            this.bnt_forca.TabIndex = 2;
            this.bnt_forca.Text = "Jogo da Forca";
            this.bnt_forca.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe Script", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(159, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(215, 80);
            this.label1.TabIndex = 3;
            this.label1.Text = "JOGOS";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // cb_niveis
            // 
            this.cb_niveis.FormattingEnabled = true;
            this.cb_niveis.Location = new System.Drawing.Point(401, 226);
            this.cb_niveis.Name = "cb_niveis";
            this.cb_niveis.Size = new System.Drawing.Size(121, 23);
            this.cb_niveis.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(401, 208);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "Níveis de Dificuldade";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(401, 150);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 15);
            this.label3.TabIndex = 6;
            this.label3.Text = "Nome do Jogador";
            // 
            // tb_jogador
            // 
            this.tb_jogador.Location = new System.Drawing.Point(401, 168);
            this.tb_jogador.Name = "tb_jogador";
            this.tb_jogador.Size = new System.Drawing.Size(121, 23);
            this.tb_jogador.TabIndex = 7;
            // 
            // F_telaPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(554, 451);
            this.Controls.Add(this.tb_jogador);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cb_niveis);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bnt_forca);
            this.Controls.Add(this.btn_jogoVelha);
            this.Controls.Add(this.btn_quiz);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MinimizeBox = false;
            this.Name = "F_telaPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Jogos";
            this.Load += new System.EventHandler(this.F_telaPrincipal_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_quiz;
        private System.Windows.Forms.Button btn_jogoVelha;
        private System.Windows.Forms.Button bnt_forca;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cb_niveis;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tb_jogador;
    }
}

