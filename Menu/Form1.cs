using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Menu
{
    public partial class Form1 : Form 
    {
        Cadastar cad;
        Atualizar atu;
        Consultar con;
        Excluir exc;
        public Form1()
        {
            InitializeComponent();
            cad = new Cadastar();
            atu = new Atualizar();
            con = new Consultar();
            exc = new Excluir();
        }

        private void Cadastrar_Click(object sender, EventArgs e)
        {
            Visible = false;
            cad.ShowDialog();
            Visible = true;

        }//Fim do botão cadastar

        private void Consultar_Click(object sender, EventArgs e)
        {
            Visible = false;
            con.ShowDialog();
            Visible = true;

        }//Fim do botão Consultar

        private void Atualizar_Click(object sender, EventArgs e)
        {
            Visible = false;
            atu.ShowDialog();
            Visible = true;

        }//Fim do botão atualizar

        private void Excluir_Click(object sender, EventArgs e)
        {
            Visible = false;
            exc.ShowDialog();
            Visible = true;

        }//fim do botão excluir
    }//fim da classe
}//fim do ´projeto
