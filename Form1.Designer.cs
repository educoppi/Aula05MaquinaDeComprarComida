namespace Aula05MaquinaDeComprarComida
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
            this.produto1 = new System.Windows.Forms.PictureBox();
            this.produto2 = new System.Windows.Forms.PictureBox();
            this.produto3 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label1000 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnComprar = new System.Windows.Forms.Button();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.lblProdutoSelecionado = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.lblProduto = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblPreco = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.produto1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.produto2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.produto3)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // produto1
            // 
            this.produto1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.produto1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.produto1.Image = ((System.Drawing.Image)(resources.GetObject("produto1.Image")));
            this.produto1.Location = new System.Drawing.Point(48, 12);
            this.produto1.Name = "produto1";
            this.produto1.Size = new System.Drawing.Size(110, 106);
            this.produto1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.produto1.TabIndex = 0;
            this.produto1.TabStop = false;
            this.produto1.Click += new System.EventHandler(this.produto1_Click);
            // 
            // produto2
            // 
            this.produto2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.produto2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.produto2.Image = ((System.Drawing.Image)(resources.GetObject("produto2.Image")));
            this.produto2.Location = new System.Drawing.Point(195, 12);
            this.produto2.Name = "produto2";
            this.produto2.Size = new System.Drawing.Size(110, 106);
            this.produto2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.produto2.TabIndex = 1;
            this.produto2.TabStop = false;
            this.produto2.Click += new System.EventHandler(this.produto2_Click);
            // 
            // produto3
            // 
            this.produto3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.produto3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.produto3.Image = ((System.Drawing.Image)(resources.GetObject("produto3.Image")));
            this.produto3.Location = new System.Drawing.Point(343, 12);
            this.produto3.Name = "produto3";
            this.produto3.Size = new System.Drawing.Size(110, 106);
            this.produto3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.produto3.TabIndex = 2;
            this.produto3.TabStop = false;
            this.produto3.Click += new System.EventHandler(this.produto3_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(-33, 170);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(551, 328);
            this.panel1.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Niagara Engraved", 30.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(187, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(195, 44);
            this.label1.TabIndex = 0;
            this.label1.Text = "Maquina de Comida";
            // 
            // label1000
            // 
            this.label1000.AutoSize = true;
            this.label1000.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1000.Location = new System.Drawing.Point(58, 131);
            this.label1000.Name = "label1000";
            this.label1000.Size = new System.Drawing.Size(87, 25);
            this.label1000.TabIndex = 4;
            this.label1000.Text = "R$ 5,00";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(204, 131);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 25);
            this.label3.TabIndex = 5;
            this.label3.Text = "R$ 4,50";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(353, 131);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 25);
            this.label4.TabIndex = 6;
            this.label4.Text = "R$ 4,00";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(45, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(156, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "1 - Selecione o produto";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(45, 83);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(110, 17);
            this.label5.TabIndex = 2;
            this.label5.Text = "2 - Insira o valor";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(45, 112);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(126, 17);
            this.label6.TabIndex = 3;
            this.label6.Text = "3 - Já pode comer!";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.lblPreco);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.lblProduto);
            this.panel2.Controls.Add(this.btnLimpar);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.lblProdutoSelecionado);
            this.panel2.Controls.Add(this.txtValor);
            this.panel2.Controls.Add(this.btnComprar);
            this.panel2.Location = new System.Drawing.Point(195, 102);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(204, 155);
            this.panel2.TabIndex = 4;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // btnComprar
            // 
            this.btnComprar.Location = new System.Drawing.Point(20, 117);
            this.btnComprar.Name = "btnComprar";
            this.btnComprar.Size = new System.Drawing.Size(75, 23);
            this.btnComprar.TabIndex = 0;
            this.btnComprar.Text = "COMPRAR";
            this.btnComprar.UseVisualStyleBackColor = true;
            this.btnComprar.Click += new System.EventHandler(this.btnComprar_Click_1);
            // 
            // txtValor
            // 
            this.txtValor.Location = new System.Drawing.Point(56, 91);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(100, 20);
            this.txtValor.TabIndex = 1;
            // 
            // lblProdutoSelecionado
            // 
            this.lblProdutoSelecionado.AutoSize = true;
            this.lblProdutoSelecionado.Location = new System.Drawing.Point(17, 24);
            this.lblProdutoSelecionado.Name = "lblProdutoSelecionado";
            this.lblProdutoSelecionado.Size = new System.Drawing.Size(109, 13);
            this.lblProdutoSelecionado.TabIndex = 2;
            this.lblProdutoSelecionado.Text = "Produto Selecionado:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(53, 66);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(70, 13);
            this.label8.TabIndex = 3;
            this.label8.Text = "Insira o valor:";
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(101, 117);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpar.TabIndex = 4;
            this.btnLimpar.Text = "LIMPAR";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // lblProduto
            // 
            this.lblProduto.AutoSize = true;
            this.lblProduto.Location = new System.Drawing.Point(124, 24);
            this.lblProduto.Name = "lblProduto";
            this.lblProduto.Size = new System.Drawing.Size(0, 13);
            this.lblProduto.TabIndex = 5;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(17, 37);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Preço: R$";
            // 
            // lblPreco
            // 
            this.lblPreco.AutoSize = true;
            this.lblPreco.Location = new System.Drawing.Point(74, 37);
            this.lblPreco.Name = "lblPreco";
            this.lblPreco.Size = new System.Drawing.Size(0, 13);
            this.lblPreco.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(487, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1000);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.produto3);
            this.Controls.Add(this.produto2);
            this.Controls.Add(this.produto1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.produto1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.produto2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.produto3)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox produto1;
        private System.Windows.Forms.PictureBox produto2;
        private System.Windows.Forms.PictureBox produto3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label1000;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblProdutoSelecionado;
        private System.Windows.Forms.TextBox txtValor;
        private System.Windows.Forms.Button btnComprar;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Label lblProduto;
        private System.Windows.Forms.Label lblPreco;
        private System.Windows.Forms.Label label7;
    }
}

