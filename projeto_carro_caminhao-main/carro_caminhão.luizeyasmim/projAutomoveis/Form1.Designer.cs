namespace projAutomoveis
{
    partial class frmmenu
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
            this.lblcabecalho = new System.Windows.Forms.Label();
            this.btnsair = new System.Windows.Forms.Button();
            this.btncarro = new System.Windows.Forms.Button();
            this.btncaminhao = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblcabecalho
            // 
            this.lblcabecalho.AutoSize = true;
            this.lblcabecalho.Font = new System.Drawing.Font("Bahnschrift Condensed", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcabecalho.Location = new System.Drawing.Point(47, 16);
            this.lblcabecalho.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblcabecalho.Name = "lblcabecalho";
            this.lblcabecalho.Size = new System.Drawing.Size(186, 58);
            this.lblcabecalho.TabIndex = 2;
            this.lblcabecalho.Text = "CADASTRO";
            // 
            // btnsair
            // 
            this.btnsair.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnsair.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsair.Location = new System.Drawing.Point(68, 279);
            this.btnsair.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnsair.Name = "btnsair";
            this.btnsair.Size = new System.Drawing.Size(136, 52);
            this.btnsair.TabIndex = 3;
            this.btnsair.Text = "Sair";
            this.btnsair.UseVisualStyleBackColor = false;
            this.btnsair.Click += new System.EventHandler(this.btnsair_Click);
            // 
            // btncarro
            // 
            this.btncarro.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btncarro.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Bold);
            this.btncarro.Location = new System.Drawing.Point(68, 165);
            this.btncarro.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btncarro.Name = "btncarro";
            this.btncarro.Size = new System.Drawing.Size(136, 52);
            this.btncarro.TabIndex = 1;
            this.btncarro.Text = "Carro";
            this.btncarro.UseVisualStyleBackColor = false;
            this.btncarro.Click += new System.EventHandler(this.btncarro_Click);
            // 
            // btncaminhao
            // 
            this.btncaminhao.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btncaminhao.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Bold);
            this.btncaminhao.Location = new System.Drawing.Point(68, 222);
            this.btncaminhao.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btncaminhao.Name = "btncaminhao";
            this.btncaminhao.Size = new System.Drawing.Size(136, 52);
            this.btncaminhao.TabIndex = 0;
            this.btncaminhao.Text = "Caminhão";
            this.btncaminhao.UseVisualStyleBackColor = false;
            this.btncaminhao.Click += new System.EventHandler(this.btncaminhao_Click);
            // 
            // frmmenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(287, 477);
            this.Controls.Add(this.btnsair);
            this.Controls.Add(this.lblcabecalho);
            this.Controls.Add(this.btncarro);
            this.Controls.Add(this.btncaminhao);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmmenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblcabecalho;
        private System.Windows.Forms.Button btnsair;
        private System.Windows.Forms.Button btncarro;
        private System.Windows.Forms.Button btncaminhao;
    }
}