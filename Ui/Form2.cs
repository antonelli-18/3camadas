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



namespace Projeto3Camadas.Ui
{
    public partial class Form2 : Form
    {

        LoginBLL loginBLL = new LoginBLL();
        LoginDTO loginDTO = new LoginDTO();

        public Form2()
        {
            InitializeComponent();
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            loginDTO.Nomeusuario = txt_login.Text;
            loginDTO.Senha = txt_senha.Text;


            if (loginBLL.RealizarLogin(loginDTO) == true)
            {
                Form1 form = new Form1();
                form.ShowDialog();
            }


        }
    }
}
