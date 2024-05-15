namespace ConversãoBinairo
{
    partial class form1
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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.Input = new System.Windows.Forms.TextBox();
            this.Result = new System.Windows.Forms.Label();
            this.Executar = new System.Windows.Forms.Button();
            this.Limpar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Binário para Decimal",
            "Decimal para Binário",
            "Binario para Octal",
            "Decimal para Decimal",
            "Decimal para Octal",
            "Octal para Binario"});
            this.comboBox1.Location = new System.Drawing.Point(12, 83);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(243, 21);
            this.comboBox1.TabIndex = 0;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // Input
            // 
            this.Input.Location = new System.Drawing.Point(12, 57);
            this.Input.Name = "Input";
            this.Input.Size = new System.Drawing.Size(509, 20);
            this.Input.TabIndex = 1;
            // 
            // Result
            // 
            this.Result.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Result.ForeColor = System.Drawing.Color.Chartreuse;
            this.Result.Location = new System.Drawing.Point(12, 131);
            this.Result.Name = "Result";
            this.Result.Size = new System.Drawing.Size(509, 132);
            this.Result.TabIndex = 2;
            // 
            // Executar
            // 
            this.Executar.Location = new System.Drawing.Point(15, 325);
            this.Executar.Name = "Executar";
            this.Executar.Size = new System.Drawing.Size(188, 84);
            this.Executar.TabIndex = 3;
            this.Executar.Text = "Executar";
            this.Executar.UseVisualStyleBackColor = true;
            this.Executar.Click += new System.EventHandler(this.Executar_Click);
            // 
            // Limpar
            // 
            this.Limpar.Location = new System.Drawing.Point(309, 325);
            this.Limpar.Name = "Limpar";
            this.Limpar.Size = new System.Drawing.Size(188, 84);
            this.Limpar.TabIndex = 4;
            this.Limpar.Text = "Limpar";
            this.Limpar.UseVisualStyleBackColor = true;
            // 
            // form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(527, 450);
            this.Controls.Add(this.Limpar);
            this.Controls.Add(this.Executar);
            this.Controls.Add(this.Result);
            this.Controls.Add(this.Input);
            this.Controls.Add(this.comboBox1);
            this.Name = "form1";
            this.Text = "Conversão";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox Input;
        private System.Windows.Forms.Label Result;
        private System.Windows.Forms.Button Executar;
        private System.Windows.Forms.Button Limpar;
    }
}

