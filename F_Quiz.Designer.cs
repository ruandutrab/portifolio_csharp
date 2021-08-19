
namespace Portifolio_CSharp
{
    partial class F_Quiz
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tb_perguntas = new System.Windows.Forms.TextBox();
            this.cb_pergunta1 = new System.Windows.Forms.CheckBox();
            this.cb_pergunta2 = new System.Windows.Forms.CheckBox();
            this.cb_pergunta3 = new System.Windows.Forms.CheckBox();
            this.cb_pergunta4 = new System.Windows.Forms.CheckBox();
            this.btn_voltar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tb_perguntas
            // 
            this.tb_perguntas.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.tb_perguntas.Location = new System.Drawing.Point(12, 12);
            this.tb_perguntas.Multiline = true;
            this.tb_perguntas.Name = "tb_perguntas";
            this.tb_perguntas.Size = new System.Drawing.Size(275, 92);
            this.tb_perguntas.TabIndex = 0;
            // 
            // cb_pergunta1
            // 
            this.cb_pergunta1.AutoSize = true;
            this.cb_pergunta1.Location = new System.Drawing.Point(12, 110);
            this.cb_pergunta1.Name = "cb_pergunta1";
            this.cb_pergunta1.Size = new System.Drawing.Size(80, 19);
            this.cb_pergunta1.TabIndex = 1;
            this.cb_pergunta1.Text = "Pergunta1";
            this.cb_pergunta1.UseVisualStyleBackColor = true;
            // 
            // cb_pergunta2
            // 
            this.cb_pergunta2.AutoSize = true;
            this.cb_pergunta2.Location = new System.Drawing.Point(12, 135);
            this.cb_pergunta2.Name = "cb_pergunta2";
            this.cb_pergunta2.Size = new System.Drawing.Size(80, 19);
            this.cb_pergunta2.TabIndex = 2;
            this.cb_pergunta2.Text = "Pergunta2";
            this.cb_pergunta2.UseVisualStyleBackColor = true;
            // 
            // cb_pergunta3
            // 
            this.cb_pergunta3.AutoSize = true;
            this.cb_pergunta3.Location = new System.Drawing.Point(12, 160);
            this.cb_pergunta3.Name = "cb_pergunta3";
            this.cb_pergunta3.Size = new System.Drawing.Size(80, 19);
            this.cb_pergunta3.TabIndex = 3;
            this.cb_pergunta3.Text = "Pergunta3";
            this.cb_pergunta3.UseVisualStyleBackColor = true;
            // 
            // cb_pergunta4
            // 
            this.cb_pergunta4.AutoSize = true;
            this.cb_pergunta4.Location = new System.Drawing.Point(12, 185);
            this.cb_pergunta4.Name = "cb_pergunta4";
            this.cb_pergunta4.Size = new System.Drawing.Size(80, 19);
            this.cb_pergunta4.TabIndex = 4;
            this.cb_pergunta4.Text = "Pergunta4";
            this.cb_pergunta4.UseVisualStyleBackColor = true;
            // 
            // btn_voltar
            // 
            this.btn_voltar.Location = new System.Drawing.Point(453, 416);
            this.btn_voltar.Name = "btn_voltar";
            this.btn_voltar.Size = new System.Drawing.Size(75, 23);
            this.btn_voltar.TabIndex = 5;
            this.btn_voltar.Text = "Voltar";
            this.btn_voltar.UseVisualStyleBackColor = true;
            // 
            // F_Quiz
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(554, 451);
            this.Controls.Add(this.btn_voltar);
            this.Controls.Add(this.cb_pergunta4);
            this.Controls.Add(this.cb_pergunta3);
            this.Controls.Add(this.cb_pergunta2);
            this.Controls.Add(this.cb_pergunta1);
            this.Controls.Add(this.tb_perguntas);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "F_Quiz";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "F_Quiz";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.F_Quiz_FormClosed);
            this.Load += new System.EventHandler(this.F_Quiz_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_perguntas;
        private System.Windows.Forms.CheckBox cb_pergunta1;
        private System.Windows.Forms.CheckBox cb_pergunta2;
        private System.Windows.Forms.CheckBox cb_pergunta3;
        private System.Windows.Forms.CheckBox cb_pergunta4;
        private System.Windows.Forms.Button btn_voltar;
    }
}