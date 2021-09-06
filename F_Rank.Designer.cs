
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgv_ranking = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ranking)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dgv_ranking);
            this.panel1.Location = new System.Drawing.Point(0, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(552, 450);
            this.panel1.TabIndex = 0;
            // 
            // dgv_ranking
            // 
            this.dgv_ranking.AllowUserToAddRows = false;
            this.dgv_ranking.AllowUserToDeleteRows = false;
            this.dgv_ranking.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_ranking.Location = new System.Drawing.Point(12, 11);
            this.dgv_ranking.Name = "dgv_ranking";
            this.dgv_ranking.ReadOnly = true;
            this.dgv_ranking.RowTemplate.Height = 25;
            this.dgv_ranking.Size = new System.Drawing.Size(530, 427);
            this.dgv_ranking.TabIndex = 0;
            // 
            // F_Rank
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(554, 451);
            this.Controls.Add(this.panel1);
            this.Name = "F_Rank";
            this.Text = "F_Rank";
            this.Load += new System.EventHandler(this.F_Rank_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ranking)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgv_ranking;
    }
}