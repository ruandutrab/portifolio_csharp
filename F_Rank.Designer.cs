
namespace Portifolio_CSharp
{
    partial class F_Rank
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_rankVelha = new System.Windows.Forms.Button();
            this.btn_rankForca = new System.Windows.Forms.Button();
            this.btn_rankQuiz = new System.Windows.Forms.Button();
            this.btn_rankDificil = new System.Windows.Forms.Button();
            this.btn_rankMedio = new System.Windows.Forms.Button();
            this.btn_rankFacil = new System.Windows.Forms.Button();
            this.dgv_ranking = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ranking)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_rankVelha);
            this.panel1.Controls.Add(this.btn_rankForca);
            this.panel1.Controls.Add(this.btn_rankQuiz);
            this.panel1.Controls.Add(this.btn_rankDificil);
            this.panel1.Controls.Add(this.btn_rankMedio);
            this.panel1.Controls.Add(this.btn_rankFacil);
            this.panel1.Controls.Add(this.dgv_ranking);
            this.panel1.Location = new System.Drawing.Point(0, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(552, 450);
            this.panel1.TabIndex = 0;
            // 
            // btn_rankVelha
            // 
            this.btn_rankVelha.Location = new System.Drawing.Point(431, 196);
            this.btn_rankVelha.Name = "btn_rankVelha";
            this.btn_rankVelha.Size = new System.Drawing.Size(112, 23);
            this.btn_rankVelha.TabIndex = 6;
            this.btn_rankVelha.Text = "Velha";
            this.btn_rankVelha.UseVisualStyleBackColor = true;
            // 
            // btn_rankForca
            // 
            this.btn_rankForca.Location = new System.Drawing.Point(431, 167);
            this.btn_rankForca.Name = "btn_rankForca";
            this.btn_rankForca.Size = new System.Drawing.Size(112, 23);
            this.btn_rankForca.TabIndex = 5;
            this.btn_rankForca.Text = "Forca";
            this.btn_rankForca.UseVisualStyleBackColor = true;
            // 
            // btn_rankQuiz
            // 
            this.btn_rankQuiz.Location = new System.Drawing.Point(431, 138);
            this.btn_rankQuiz.Name = "btn_rankQuiz";
            this.btn_rankQuiz.Size = new System.Drawing.Size(112, 23);
            this.btn_rankQuiz.TabIndex = 4;
            this.btn_rankQuiz.Text = "Quiz";
            this.btn_rankQuiz.UseVisualStyleBackColor = true;
            this.btn_rankQuiz.Click += new System.EventHandler(this.btn_rankQuiz_Click);
            // 
            // btn_rankDificil
            // 
            this.btn_rankDificil.Location = new System.Drawing.Point(431, 69);
            this.btn_rankDificil.Name = "btn_rankDificil";
            this.btn_rankDificil.Size = new System.Drawing.Size(112, 23);
            this.btn_rankDificil.TabIndex = 3;
            this.btn_rankDificil.Text = "Difícil";
            this.btn_rankDificil.UseVisualStyleBackColor = true;
            this.btn_rankDificil.Click += new System.EventHandler(this.btn_rankDificil_Click);
            // 
            // btn_rankMedio
            // 
            this.btn_rankMedio.Location = new System.Drawing.Point(431, 40);
            this.btn_rankMedio.Name = "btn_rankMedio";
            this.btn_rankMedio.Size = new System.Drawing.Size(112, 23);
            this.btn_rankMedio.TabIndex = 2;
            this.btn_rankMedio.Text = "Médio";
            this.btn_rankMedio.UseVisualStyleBackColor = true;
            this.btn_rankMedio.Click += new System.EventHandler(this.btn_rankMedio_Click);
            // 
            // btn_rankFacil
            // 
            this.btn_rankFacil.Location = new System.Drawing.Point(431, 11);
            this.btn_rankFacil.Name = "btn_rankFacil";
            this.btn_rankFacil.Size = new System.Drawing.Size(112, 23);
            this.btn_rankFacil.TabIndex = 1;
            this.btn_rankFacil.Text = "Fácil";
            this.btn_rankFacil.UseVisualStyleBackColor = true;
            this.btn_rankFacil.Click += new System.EventHandler(this.btn_rankFacil_Click);
            // 
            // dgv_ranking
            // 
            this.dgv_ranking.AllowUserToAddRows = false;
            this.dgv_ranking.AllowUserToDeleteRows = false;
            this.dgv_ranking.AllowUserToResizeColumns = false;
            this.dgv_ranking.AllowUserToResizeRows = false;
            this.dgv_ranking.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_ranking.BackgroundColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe MDL2 Assets", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_ranking.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_ranking.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_ranking.Location = new System.Drawing.Point(11, 11);
            this.dgv_ranking.Name = "dgv_ranking";
            this.dgv_ranking.ReadOnly = true;
            this.dgv_ranking.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgv_ranking.RowHeadersVisible = false;
            this.dgv_ranking.RowTemplate.Height = 25;
            this.dgv_ranking.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_ranking.Size = new System.Drawing.Size(413, 427);
            this.dgv_ranking.TabIndex = 0;
            // 
            // F_Rank
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(554, 451);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "F_Rank";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ranking Geral";
            this.Load += new System.EventHandler(this.F_Rank_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ranking)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgv_ranking;
        private System.Windows.Forms.Button btn_rankVelha;
        private System.Windows.Forms.Button btn_rankForca;
        private System.Windows.Forms.Button btn_rankQuiz;
        private System.Windows.Forms.Button btn_rankDificil;
        private System.Windows.Forms.Button btn_rankMedio;
        private System.Windows.Forms.Button btn_rankFacil;
    }
}