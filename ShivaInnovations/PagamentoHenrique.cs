﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShivaInnovations
{
    public partial class PagamentoHenrique : Form
    {
        Pgto pgto;
        public PagamentoHenrique()
        {
            InitializeComponent();
            pgto = new Pgto();
        }

        private void Confirmar_Click(object sender, EventArgs e)
        {
            
            pgto.ShowDialog();

        }//Botão confirmar Pagamento Henrique

        private void Voltar_Click(object sender, EventArgs e)
        {
            var form = new Eventos();
            form.Hide();
            var form2 = new Eventos();
            this.Hide();  //vai “esconder” o formulário atual
        }//VOltar 
    }//Fim da classe
}//Fim do projeto
