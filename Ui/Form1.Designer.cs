namespace Projeto3Camadas
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
            this.label1 = new System.Windows.Forms.Label();
            this.txt_id = new System.Windows.Forms.TextBox();
            this.txt_preco = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_nome = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_cadastrar = new System.Windows.Forms.Button();
            this.btn_editar = new System.Windows.Forms.Button();
            this.btn_excluir = new System.Windows.Forms.Button();
            this.dtg_pagamentos = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_pagamentos)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(97, 104);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Codigo Pagamento";
            // 
            // txt_id
            // 
            this.txt_id.Location = new System.Drawing.Point(100, 120);
            this.txt_id.Name = "txt_id";
            this.txt_id.Size = new System.Drawing.Size(107, 20);
            this.txt_id.TabIndex = 1;
            // 
            // txt_preco
            // 
            this.txt_preco.Location = new System.Drawing.Point(585, 120);
            this.txt_preco.Name = "txt_preco";
            this.txt_preco.Size = new System.Drawing.Size(129, 20);
            this.txt_preco.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(582, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Preço";
            // 
            // txt_nome
            // 
            this.txt_nome.Location = new System.Drawing.Point(263, 120);
            this.txt_nome.Name = "txt_nome";
            this.txt_nome.Size = new System.Drawing.Size(248, 20);
            this.txt_nome.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(260, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Nome do Funcionário";
            // 
            // btn_cadastrar
            // 
            this.btn_cadastrar.Location = new System.Drawing.Point(100, 167);
            this.btn_cadastrar.Name = "btn_cadastrar";
            this.btn_cadastrar.Size = new System.Drawing.Size(107, 23);
            this.btn_cadastrar.TabIndex = 6;
            this.btn_cadastrar.Text = "Cadastrar";
            this.btn_cadastrar.UseVisualStyleBackColor = true;
            this.btn_cadastrar.Click += new System.EventHandler(this.btn_cadastrar_Click);
            // 
            // btn_editar
            // 
            this.btn_editar.Location = new System.Drawing.Point(354, 167);
            this.btn_editar.Name = "btn_editar";
            this.btn_editar.Size = new System.Drawing.Size(107, 23);
            this.btn_editar.TabIndex = 7;
            this.btn_editar.Text = "Editar";
            this.btn_editar.UseVisualStyleBackColor = true;
            this.btn_editar.Click += new System.EventHandler(this.btn_editar_Click);
            // 
            // btn_excluir
            // 
            this.btn_excluir.Location = new System.Drawing.Point(607, 167);
            this.btn_excluir.Name = "btn_excluir";
            this.btn_excluir.Size = new System.Drawing.Size(107, 23);
            this.btn_excluir.TabIndex = 8;
            this.btn_excluir.Text = "Excluir";
            this.btn_excluir.UseVisualStyleBackColor = true;
            this.btn_excluir.Click += new System.EventHandler(this.btn_excluir_Click);
            // 
            // dtg_pagamentos
            // 
            this.dtg_pagamentos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtg_pagamentos.Location = new System.Drawing.Point(100, 229);
            this.dtg_pagamentos.Name = "dtg_pagamentos";
            this.dtg_pagamentos.Size = new System.Drawing.Size(614, 168);
            this.dtg_pagamentos.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(829, 457);
            this.Controls.Add(this.dtg_pagamentos);
            this.Controls.Add(this.btn_excluir);
            this.Controls.Add(this.btn_editar);
            this.Controls.Add(this.btn_cadastrar);
            this.Controls.Add(this.txt_nome);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_preco);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_id);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtg_pagamentos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_id;
        private System.Windows.Forms.TextBox txt_preco;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_nome;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_cadastrar;
        private System.Windows.Forms.Button btn_editar;
        private System.Windows.Forms.Button btn_excluir;
        private System.Windows.Forms.DataGridView dtg_pagamentos;
    }
}

