using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Projeto3Camadas.Code.BLL;
using Projeto3Camadas.Code.DTO;

namespace Projeto3Camadas
{
    public partial class Form1 : Form
    {

        Pagamento_BLL pagBLL = new Pagamento_BLL();
        Pagamento_DTO pagDTO = new Pagamento_DTO();

        public Form1()
        {
            InitializeComponent();
        }

        private void btn_cadastrar_Click(object sender, EventArgs e)
        {
            pagDTO.Namefuncionario = txt_nome.Text;
            pagDTO.Preco = double.Parse(txt_preco.Text);

            pagBLL.Inserir(pagDTO);

            MessageBox.Show("Cadastro OK!", "Folha de Pagamento");

            pagBLL.Listar();

        }

        private void btn_editar_Click(object sender, EventArgs e)
        {
            pagDTO.Id = txt_id.Text;
            pagDTO.Namefuncionario = txt_nome.Text;
            pagDTO.Preco = double.Parse(txt_preco.Text);

            pagBLL.Editar(pagDTO);

            MessageBox.Show("Mudança OK!", "Folha de Pagamento");

            pagBLL.Listar();
        }

        private void btn_excluir_Click(object sender, EventArgs e)
        {
            pagDTO.Id = txt_id.Text;

            pagBLL.Exclui(pagDTO);

            MessageBox.Show("Mudança OK!", "Folha de Pagamento");

            pagBLL.Listar();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dtg_pagamentos.DataSource = pagBLL.Listar();
        }
    }
}
