using BibliotecaHerecia.Miembros;
using BibliotecaHerecia.Libros;
using BibliotecaHerecia.Prestamos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BibliotecaHerecia
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void btnAdminMiembros_Click(object sender, EventArgs e)
        {
            Form verMiembrosForm = new VerMiembros();
            verMiembrosForm.Show();
        }

        private void btnAdminLibros_Click(object sender, EventArgs e)
        {
            Form verLibrosForm = new VerLibros();
            verLibrosForm.Show();
        }

        private void btnRealizarPrestamo_Click(object sender, EventArgs e)
        {
            Form realizarPrestamoForm = new RealizarPrestamo();
            realizarPrestamoForm.Show();
        }

        private void Libros_Click(object sender, EventArgs e)
        {

        }
        // Quedice ai no se inglesh
        private void btonMiembro_Click(object sender, EventArgs e)
        {

        }

        private void Menu_Load(object sender, EventArgs e)
        {

        }
        // a ver si funciona xd
        private void AdminMiembros_Click(object sender, EventArgs e)
        {
            panelContenedor.Controls.Clear(); 

            Form verMiembrosForm = new VerMiembros();
            verMiembrosForm.TopLevel = false; 
            verMiembrosForm.FormBorderStyle = FormBorderStyle.None;
            verMiembrosForm.Dock = DockStyle.Fill;

            panelContenedor.Controls.Add(verMiembrosForm);
            verMiembrosForm.Show(); 
        }

        private void AdministrarLibros_Click(object sender, EventArgs e)
        {
            panelContenedor.Controls.Clear();

            Form verLibrosForm = new VerLibros(); 
            verLibrosForm.TopLevel = false; 
            verLibrosForm.FormBorderStyle = FormBorderStyle.None; 
            verLibrosForm.Dock = DockStyle.Fill; 

            panelContenedor.Controls.Add(verLibrosForm); 
            verLibrosForm.Show(); 
        }

        private void RealizarPrestamo_Click(object sender, EventArgs e)
        {
            
            panelContenedor.Controls.Clear();

            Form realizarPrestamoForm = new RealizarPrestamo();
            realizarPrestamoForm.TopLevel = false; 
            realizarPrestamoForm.FormBorderStyle = FormBorderStyle.None; 
            realizarPrestamoForm.Dock = DockStyle.Fill; 

           
            panelContenedor.Controls.Add(realizarPrestamoForm);
            realizarPrestamoForm.Show();
        }

        private void panelContenedor_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
