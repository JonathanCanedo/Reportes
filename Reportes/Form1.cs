using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Reportes {
    public partial class Form1 : Form {
        public Form1()
        {
            InitializeComponent();
        }
        private int xClick = 0, yClick = 0;
        private string a = "Compras09#mm";
        private void btnSalir_Click(object sender, EventArgs e) {
            Entrar();
        }
        private void Entrar() {
            if (a == txtContra.Text) {
                this.Hide();
                Reporte rep = new Reporte();
                rep.ShowDialog();
            } else {
                MessageBox.Show("Contraseña incorrecta", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtContra.Text = "";
                txtContra.Focus();
            }
        }
        private void LogIn_Load(object sender, EventArgs e) {
            txtContra.Text = "contraseña";
            txtContra.Focus();
        }
        private void txtContra_KeyDown(object sender, KeyEventArgs e) {
            if (e.KeyValue == (char)Keys.Enter) {
                Entrar();
            }else { }
        }
        private void label1_MouseMove(object sender, MouseEventArgs e){
            if (e.Button != MouseButtons.Left) {
                xClick = e.X; yClick = e.Y;
            } else {
                this.Left = this.Left + (e.X - xClick); this.Top = this.Top + (e.Y - yClick);
            }
        }
        private void pictureBox3_Click(object sender, EventArgs e) {
            this.WindowState = FormWindowState.Minimized;
        }
        private void pictureBox2_Click(object sender, EventArgs e) {
            Application.Exit();
        }
    }
}
