using controlefinanceiro.Models;

using ControleFinanceiro.Controllers;
using Microsoft.VisualBasic.ApplicationServices;
using ReaLTaiizor.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;
using System.Windows.Forms;

namespace controlefinanceiro.Views
{
    public partial class frmAddTransaction : Form
    {
        public frmAddTransaction(Models.Usuario user)
        {

            InitializeComponent();
            configureDatePickers();
            configureForm(user);
            valueTransaction.KeyPress += new KeyPressEventHandler(valueTransaction_KeyPress);
            btnDeleteTransaction.Visible = false;
        }

        public frmAddTransaction(Models.Usuario user, Transacao tr)
        {
            InitializeComponent();
            configureDatePickers();
            configureForm(user, tr);
            valueTransaction.KeyPress += new KeyPressEventHandler(valueTransaction_KeyPress);
            btnDeleteTransaction.Visible = true;
        }


        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (idTransaction.Text == "")
                {
                    DashboardController.AdicionarTransacao(
                        Convert.ToInt32(userID.Text),
                        Convert.ToInt32(category.SelectedValue.ToString()),
                        Convert.ToDecimal(valueTransaction.Text),
                        DateTransaction.Value,
                        descriptionTransaction.Text,
                        typeTransaction.SelectedValue.ToString()
                    );
                    MessageBox.Show("Transaction Successfully Added");
                    this.DialogResult = DialogResult.OK;
                }
                else
                {
                    DashboardController.EditarTransacao(
                        Convert.ToInt32(idTransaction.Text),
                        Convert.ToInt32(userID.Text),
                        Convert.ToInt32(category.SelectedValue.ToString()),
                        Convert.ToDecimal(valueTransaction.Text),
                        DateTransaction.Value,
                        descriptionTransaction.Text,
                        typeTransaction.SelectedValue.ToString()
                    );
                    MessageBox.Show("Transaction Successfully Edited");
                    this.DialogResult = DialogResult.OK;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Invalid Value, verify and try again", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void configureDatePickers()
        {
            DateTransaction.Value = DateTime.Now;
            DateTransaction.Format = DateTimePickerFormat.Custom;
            DateTransaction.CustomFormat = "dd/MM/yyyy";
        }

        private void configureForm(Usuario usuario)
        {

            List<Models.Categoria> categoria = DashboardController.ListarCategorias();
            category.DataSource = categoria;
            category.DisplayMember = "Nome";
            category.ValueMember = "Id";

            userID.Text = usuario.Id.ToString();
            List<string> tipos = new List<string> { "Entrada", "Saída" };
            typeTransaction.DataSource = tipos;

        }

        private void configureForm(Usuario user, Transacao tr)
        {
            List<Models.Categoria> categoria = DashboardController.ListarCategorias();
            category.DataSource = categoria;
            category.DisplayMember = "Nome";
            category.ValueMember = "Id";
            userID.Text = user.Id.ToString();
            List<string> tipos = new List<string> { "Entrada", "Saída" };
            typeTransaction.DataSource = tipos;

            if (tr.Tipo == "Entrada")
            {
                typeTransaction.SelectedIndex = 0;
            }
            else
            {
                typeTransaction.SelectedIndex = 1;
            }


            foreach (Models.Categoria cat in categoria)
            {
                if (cat.Nome == tr.Categoria.Nome)
                {
                    category.SelectedValue = cat.Id;
                    break;
                }
            }


            idTransaction.Text = tr.Id.ToString();
            DateTransaction.Value = tr.Data;
            valueTransaction.Text = tr.Valor.ToString();
            descriptionTransaction.Text = tr.Descricao;
        }

        private void valueTransaction_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.') && (e.KeyChar != ','))
            {
                e.Handled = true;
            }


            if ((e.KeyChar == '.' || e.KeyChar == ',') && ((sender as BigTextBox).Text.IndexOf('.') > -1 || (sender as BigTextBox).Text.IndexOf(',') > -1))
            {
                e.Handled = true;
            }
        }

        private void idTransaction_TextChanged(object sender, EventArgs e)
        {

        }

        private void valueTransaction_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnDeleteTransaction_Click(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(idTransaction.Text))
                {
                    int transactionId = Convert.ToInt32(idTransaction.Text);
                    DashboardController.RemoveTransaction(transactionId);
                    MessageBox.Show("Transaction Successfully Deleted");
                    this.DialogResult = DialogResult.OK;



                }
                else
                {
                    MessageBox.Show("No transaction selected to delete.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
