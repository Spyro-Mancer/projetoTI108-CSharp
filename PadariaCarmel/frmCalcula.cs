﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PadariaCarmel
{
    public partial class frmCalcula : Form
    {
        public frmCalcula()
        {
            InitializeComponent();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtNum1.Text = "";
            txtNum2.Text = "";
            lblResposta.Text = "";
            rdbSoma.Checked = false;
            rdbSubtracao.Checked = false;
            rdbMultiplicacao.Checked = false;
            rdbDivisao.Checked = false;
            txtNum1.Focus();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            //declaração das vareáveis
            double num1, num2, resp=0;

            try
            {
                num1 = Convert.ToDouble(txtNum1.Text);
                num2 = Convert.ToDouble(txtNum2.Text);

                //estrutura de decisão
                if (rdbSoma.Checked)
                {
                    //somar
                    resp = num1 + num2;
                }
                if (rdbSubtracao.Checked)
                {
                    //subtrair
                    resp = num1 - num2;
                }
                if (rdbMultiplicacao.Checked)
                {
                    //multiplicar
                    resp = num1 * num2;
                }
                if (rdbDivisao.Checked)
                {
                    //dividir

                    if (num2 == 0)
                    {
                        MessageBox.Show("Impossível dividir por 0");
                        txtNum1.Text = "";
                        txtNum2.Text = "";
                        lblResposta.Text = "";
                        rdbDivisao.Checked = false;
                        //resp = Convert.ToString(lblResposta.Text "texto");
                        resp = 0;
                        txtNum1.Focus();
                    }
                    else
                    {
                        resp = num1 / num2;
                    }
                }
                if (rdbSoma.Checked || rdbSubtracao.Checked || rdbMultiplicacao.Checked || rdbDivisao.Checked)
                {
                    lblResposta.Text = resp.ToString();
                }
                else
                {
                    MessageBox.Show("Selecione uma Operação!",
                    "Mensagem do Sistema",
                     MessageBoxButtons.OK,
                     MessageBoxIcon.Warning,
                     MessageBoxDefaultButton.Button1);
                }

            }
            catch (Exception)
            {
                MessageBox.Show("Insira apenas números!");
                txtNum1.Text = "";
                txtNum2.Text = "";
                lblResposta.Text = "";
                txtNum1.Focus();
            }
        }
    }
}
