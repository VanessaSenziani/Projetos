namespace locadoraCarro
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblmarca = new System.Windows.Forms.Label();
            this.txtmarca = new System.Windows.Forms.TextBox();
            this.btpesquisar = new System.Windows.Forms.Button();
            this.grade = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.grade)).BeginInit();
            this.SuspendLayout();
            // 
            // lblmarca
            // 
            this.lblmarca.AutoSize = true;
            this.lblmarca.Location = new System.Drawing.Point(255, 41);
            this.lblmarca.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.lblmarca.Name = "lblmarca";
            this.lblmarca.Size = new System.Drawing.Size(171, 25);
            this.lblmarca.TabIndex = 0;
            this.lblmarca.Text = "Digite a marca:";
            // 
            // txtmarca
            // 
            this.txtmarca.Location = new System.Drawing.Point(471, 38);
            this.txtmarca.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.txtmarca.Name = "txtmarca";
            this.txtmarca.Size = new System.Drawing.Size(292, 31);
            this.txtmarca.TabIndex = 1;
            // 
            // btpesquisar
            // 
            this.btpesquisar.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btpesquisar.Location = new System.Drawing.Point(823, 15);
            this.btpesquisar.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.btpesquisar.Name = "btpesquisar";
            this.btpesquisar.Size = new System.Drawing.Size(204, 82);
            this.btpesquisar.TabIndex = 2;
            this.btpesquisar.Text = "Pesquisar";
            this.btpesquisar.UseVisualStyleBackColor = false;
            this.btpesquisar.Click += new System.EventHandler(this.Btpesquisar_Click);
            // 
            // grade
            // 
            this.grade.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.grade.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grade.Location = new System.Drawing.Point(16, 107);
            this.grade.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.grade.Name = "grade";
            this.grade.Size = new System.Drawing.Size(1241, 585);
            this.grade.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(1273, 707);
            this.Controls.Add(this.grade);
            this.Controls.Add(this.btpesquisar);
            this.Controls.Add(this.txtmarca);
            this.Controls.Add(this.lblmarca);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.grade)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblmarca;
        private System.Windows.Forms.TextBox txtmarca;
        private System.Windows.Forms.Button btpesquisar;
        private System.Windows.Forms.DataGridView grade;
    }
}

