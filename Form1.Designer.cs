
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
            this.btn_config = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_quiz
            // 
            this.btn_quiz.Location = new System.Drawing.Point(12, 151);
            this.btn_quiz.Name = "btn_quiz";
            this.btn_quiz.Size = new System.Drawing.Size(91, 23);
            this.btn_quiz.TabIndex = 0;
            this.btn_quiz.Text = "Jogo de Quiz";
            this.btn_quiz.UseVisualStyleBackColor = true;
            this.btn_quiz.Click += new System.EventHandler(this.btn_quiz_Click);
            // 
            // btn_jogoVelha
            // 
            this.btn_jogoVelha.Location = new System.Drawing.Point(12, 234);
            this.btn_jogoVelha.Name = "btn_jogoVelha";
            this.btn_jogoVelha.Size = new System.Drawing.Size(91, 23);
            this.btn_jogoVelha.TabIndex = 1;
            this.btn_jogoVelha.Text = "Jogo da Velha";
            this.btn_jogoVelha.UseVisualStyleBackColor = true;
            // 
            // bnt_forca
            // 
            this.bnt_forca.Location = new System.Drawing.Point(12, 194);
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
            // btn_config
            // 
            this.btn_config.Location = new System.Drawing.Point(12, 287);
            this.btn_config.Name = "btn_config";
            this.btn_config.Size = new System.Drawing.Size(91, 23);
            this.btn_config.TabIndex = 4;
            this.btn_config.Text = "Configurações";
            this.btn_config.UseVisualStyleBackColor = true;
            // 
            // F_telaPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(554, 451);
            this.Controls.Add(this.btn_config);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bnt_forca);
            this.Controls.Add(this.btn_jogoVelha);
            this.Controls.Add(this.btn_quiz);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MinimizeBox = false;
            this.Name = "F_telaPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Jogos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_quiz;
        private System.Windows.Forms.Button btn_jogoVelha;
        private System.Windows.Forms.Button bnt_forca;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_config;
    }
}

