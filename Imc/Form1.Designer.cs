namespace Imc
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lblTitulo = new System.Windows.Forms.Label();
            this.txtPeso = new System.Windows.Forms.TextBox();
            this.grbOperacao = new System.Windows.Forms.GroupBox();
            this.lblAltura = new System.Windows.Forms.Label();
            this.lblPeso = new System.Windows.Forms.Label();
            this.txtAltura = new System.Windows.Forms.TextBox();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.lblImc = new System.Windows.Forms.Label();
            this.lblResultado = new System.Windows.Forms.Label();
            this.grbOperacao.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.BackColor = System.Drawing.Color.Transparent;
            this.lblTitulo.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.Gray;
            this.lblTitulo.Location = new System.Drawing.Point(-4, 2);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(242, 102);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "IMC  DOS BODYBILDER\r\n\r\n\r\n";
            // 
            // txtPeso
            // 
            this.txtPeso.Location = new System.Drawing.Point(64, 19);
            this.txtPeso.Name = "txtPeso";
            this.txtPeso.Size = new System.Drawing.Size(47, 20);
            this.txtPeso.TabIndex = 3;
            // 
            // grbOperacao
            // 
            this.grbOperacao.BackColor = System.Drawing.Color.Transparent;
            this.grbOperacao.Controls.Add(this.lblAltura);
            this.grbOperacao.Controls.Add(this.lblPeso);
            this.grbOperacao.Controls.Add(this.txtAltura);
            this.grbOperacao.Controls.Add(this.txtPeso);
            this.grbOperacao.ForeColor = System.Drawing.Color.White;
            this.grbOperacao.Location = new System.Drawing.Point(107, 82);
            this.grbOperacao.Name = "grbOperacao";
            this.grbOperacao.Size = new System.Drawing.Size(200, 100);
            this.grbOperacao.TabIndex = 4;
            this.grbOperacao.TabStop = false;
            this.grbOperacao.Text = "Operecao";
            this.grbOperacao.Enter += new System.EventHandler(this.grbOperacao_Enter);
            // 
            // lblAltura
            // 
            this.lblAltura.AutoSize = true;
            this.lblAltura.Location = new System.Drawing.Point(6, 84);
            this.lblAltura.Name = "lblAltura";
            this.lblAltura.Size = new System.Drawing.Size(50, 13);
            this.lblAltura.TabIndex = 6;
            this.lblAltura.Text = "ALTURA";
            // 
            // lblPeso
            // 
            this.lblPeso.AutoSize = true;
            this.lblPeso.Location = new System.Drawing.Point(6, 22);
            this.lblPeso.Name = "lblPeso";
            this.lblPeso.Size = new System.Drawing.Size(36, 13);
            this.lblPeso.TabIndex = 5;
            this.lblPeso.Text = "PESO";
            // 
            // txtAltura
            // 
            this.txtAltura.Location = new System.Drawing.Point(64, 80);
            this.txtAltura.Name = "txtAltura";
            this.txtAltura.Size = new System.Drawing.Size(47, 20);
            this.txtAltura.TabIndex = 4;
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(106, 188);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(201, 39);
            this.btnCalcular.TabIndex = 5;
            this.btnCalcular.Text = "CALCULAR SE VOCE E FRANGO OU NAO.";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // lblImc
            // 
            this.lblImc.AutoSize = true;
            this.lblImc.Location = new System.Drawing.Point(110, 283);
            this.lblImc.Name = "lblImc";
            this.lblImc.Size = new System.Drawing.Size(26, 13);
            this.lblImc.TabIndex = 6;
            this.lblImc.Text = "IMC";
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Location = new System.Drawing.Point(103, 324);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(0, 13);
            this.lblResultado.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(420, 394);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.lblImc);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.grbOperacao);
            this.Controls.Add(this.lblTitulo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grbOperacao.ResumeLayout(false);
            this.grbOperacao.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.TextBox txtPeso;
        private System.Windows.Forms.GroupBox grbOperacao;
        private System.Windows.Forms.Label lblAltura;
        private System.Windows.Forms.Label lblPeso;
        private System.Windows.Forms.TextBox txtAltura;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Label lblImc;
        private System.Windows.Forms.Label lblResultado;
    }
}

