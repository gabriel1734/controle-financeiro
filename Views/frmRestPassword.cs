﻿using controlefinanceiro.Controllers;
using controlefinanceiro.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace controlefinanceiro.Views
{
    public partial class frmResetPassword : Form
    {
        private Usuario usuario;
        public frmResetPassword(Usuario user)
        {
            InitializeComponent();
            this.usuario = user;
            _ = txtPassword.UseSystemPasswordChar;
            _ = txtConfirmPassword.UseSystemPasswordChar;
        }


        private void btnReset_Click(object sender, EventArgs e)
        {
            try
            {
                UsuarioController.setNewPassword(txtPassword.Text, txtConfirmPassword.Text, usuario);
                MessageBox.Show("Password changed successfully!!!");
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Password change failed or password don't match, try again", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void valueTransaction_TextChanged(object sender, EventArgs e)
        {

        }

        private void purpleLabel1_Click(object sender, EventArgs e)
        {

        }
    }
}
