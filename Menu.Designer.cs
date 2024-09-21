namespace BibliotecaHerecia
{
    partial class Menu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            panelSideMenu = new Panel();
            panelPrestamo = new Panel();
            RealizarPrestamo = new Button();
            btonPrestamo = new Button();
            PanelLibros = new Panel();
            AdministrarLibros = new Button();
            Libros = new Button();
            panelMiembros = new Panel();
            AdminMiembros = new Button();
            btonMiembro = new Button();
            panelLogo = new Panel();
            panelSideMenu.SuspendLayout();
            panelPrestamo.SuspendLayout();
            PanelLibros.SuspendLayout();
            panelMiembros.SuspendLayout();
            SuspendLayout();
            // 
            // panelSideMenu
            // 
            panelSideMenu.AutoScroll = true;
            panelSideMenu.BackColor = Color.Black;
            panelSideMenu.Controls.Add(panelPrestamo);
            panelSideMenu.Controls.Add(PanelLibros);
            panelSideMenu.Controls.Add(panelMiembros);
            panelSideMenu.Controls.Add(btonMiembro);
            panelSideMenu.Controls.Add(panelLogo);
            panelSideMenu.Dock = DockStyle.Left;
            panelSideMenu.Location = new Point(0, 0);
            panelSideMenu.Name = "panelSideMenu";
            panelSideMenu.Size = new Size(185, 561);
            panelSideMenu.TabIndex = 14;
            // 
            // panelPrestamo
            // 
            panelPrestamo.BackColor = Color.FromArgb(64, 64, 64);
            panelPrestamo.Controls.Add(RealizarPrestamo);
            panelPrestamo.Controls.Add(btonPrestamo);
            panelPrestamo.Dock = DockStyle.Top;
            panelPrestamo.Location = new Point(0, 294);
            panelPrestamo.Name = "panelPrestamo";
            panelPrestamo.Size = new Size(185, 92);
            panelPrestamo.TabIndex = 0;
            // 
            // RealizarPrestamo
            // 
            RealizarPrestamo.Dock = DockStyle.Top;
            RealizarPrestamo.FlatAppearance.BorderSize = 0;
            RealizarPrestamo.FlatAppearance.MouseDownBackColor = Color.Red;
            RealizarPrestamo.FlatAppearance.MouseOverBackColor = Color.Blue;
            RealizarPrestamo.FlatStyle = FlatStyle.Flat;
            RealizarPrestamo.ForeColor = Color.White;
            RealizarPrestamo.Location = new Point(0, 45);
            RealizarPrestamo.Name = "RealizarPrestamo";
            RealizarPrestamo.Padding = new Padding(35, 0, 0, 0);
            RealizarPrestamo.Size = new Size(185, 40);
            RealizarPrestamo.TabIndex = 1;
            RealizarPrestamo.Text = "Realizar Prestamo";
            RealizarPrestamo.TextAlign = ContentAlignment.MiddleLeft;
            RealizarPrestamo.UseVisualStyleBackColor = true;
            // 
            // btonPrestamo
            // 
            btonPrestamo.BackColor = Color.Black;
            btonPrestamo.Dock = DockStyle.Top;
            btonPrestamo.FlatAppearance.BorderSize = 0;
            btonPrestamo.FlatAppearance.MouseDownBackColor = Color.Red;
            btonPrestamo.FlatAppearance.MouseOverBackColor = Color.Blue;
            btonPrestamo.FlatStyle = FlatStyle.Flat;
            btonPrestamo.ForeColor = Color.White;
            btonPrestamo.Location = new Point(0, 0);
            btonPrestamo.Name = "btonPrestamo";
            btonPrestamo.Padding = new Padding(10, 0, 0, 0);
            btonPrestamo.Size = new Size(185, 45);
            btonPrestamo.TabIndex = 0;
            btonPrestamo.Text = "Prestamos";
            btonPrestamo.TextAlign = ContentAlignment.MiddleLeft;
            btonPrestamo.UseVisualStyleBackColor = false;
            // 
            // PanelLibros
            // 
            PanelLibros.BackColor = Color.FromArgb(64, 64, 64);
            PanelLibros.Controls.Add(AdministrarLibros);
            PanelLibros.Controls.Add(Libros);
            PanelLibros.Dock = DockStyle.Top;
            PanelLibros.Location = new Point(0, 194);
            PanelLibros.Name = "PanelLibros";
            PanelLibros.Size = new Size(185, 100);
            PanelLibros.TabIndex = 3;
            // 
            // AdministrarLibros
            // 
            AdministrarLibros.BackColor = Color.FromArgb(64, 64, 64);
            AdministrarLibros.Dock = DockStyle.Top;
            AdministrarLibros.FlatAppearance.BorderSize = 0;
            AdministrarLibros.FlatStyle = FlatStyle.Flat;
            AdministrarLibros.ForeColor = Color.White;
            AdministrarLibros.Location = new Point(0, 45);
            AdministrarLibros.Name = "AdministrarLibros";
            AdministrarLibros.Padding = new Padding(35, 0, 0, 0);
            AdministrarLibros.Size = new Size(185, 40);
            AdministrarLibros.TabIndex = 1;
            AdministrarLibros.Text = "Administrar Libros";
            AdministrarLibros.TextAlign = ContentAlignment.MiddleLeft;
            AdministrarLibros.UseVisualStyleBackColor = false;
            // 
            // Libros
            // 
            Libros.BackColor = Color.Black;
            Libros.Dock = DockStyle.Top;
            Libros.FlatAppearance.BorderSize = 0;
            Libros.FlatAppearance.MouseDownBackColor = Color.Red;
            Libros.FlatAppearance.MouseOverBackColor = Color.Blue;
            Libros.FlatStyle = FlatStyle.Flat;
            Libros.ForeColor = Color.White;
            Libros.Location = new Point(0, 0);
            Libros.Name = "Libros";
            Libros.Padding = new Padding(10, 0, 0, 0);
            Libros.Size = new Size(185, 45);
            Libros.TabIndex = 0;
            Libros.Text = "Libros";
            Libros.TextAlign = ContentAlignment.MiddleLeft;
            Libros.UseVisualStyleBackColor = false;
            Libros.Click += Libros_Click;
            // 
            // panelMiembros
            // 
            panelMiembros.BackColor = Color.FromArgb(64, 64, 64);
            panelMiembros.Controls.Add(AdminMiembros);
            panelMiembros.Dock = DockStyle.Top;
            panelMiembros.Location = new Point(0, 145);
            panelMiembros.Name = "panelMiembros";
            panelMiembros.Size = new Size(185, 49);
            panelMiembros.TabIndex = 2;
            // 
            // AdminMiembros
            // 
            AdminMiembros.Dock = DockStyle.Top;
            AdminMiembros.FlatAppearance.BorderSize = 0;
            AdminMiembros.FlatAppearance.MouseDownBackColor = Color.Red;
            AdminMiembros.FlatAppearance.MouseOverBackColor = Color.Blue;
            AdminMiembros.FlatStyle = FlatStyle.Flat;
            AdminMiembros.ForeColor = Color.White;
            AdminMiembros.Location = new Point(0, 0);
            AdminMiembros.Name = "AdminMiembros";
            AdminMiembros.Padding = new Padding(35, 0, 0, 0);
            AdminMiembros.Size = new Size(185, 40);
            AdminMiembros.TabIndex = 0;
            AdminMiembros.Text = "Administrar Miembro";
            AdminMiembros.TextAlign = ContentAlignment.MiddleLeft;
            AdminMiembros.UseVisualStyleBackColor = true;
            // 
            // btonMiembro
            // 
            btonMiembro.Dock = DockStyle.Top;
            btonMiembro.FlatAppearance.BorderSize = 0;
            btonMiembro.FlatStyle = FlatStyle.Flat;
            btonMiembro.ForeColor = Color.White;
            btonMiembro.Location = new Point(0, 100);
            btonMiembro.Name = "btonMiembro";
            btonMiembro.Padding = new Padding(10, 0, 0, 0);
            btonMiembro.Size = new Size(185, 45);
            btonMiembro.TabIndex = 1;
            btonMiembro.Text = "Miembros";
            btonMiembro.TextAlign = ContentAlignment.MiddleLeft;
            btonMiembro.UseVisualStyleBackColor = true;
            // 
            // panelLogo
            // 
            panelLogo.Dock = DockStyle.Top;
            panelLogo.Location = new Point(0, 0);
            panelLogo.Name = "panelLogo";
            panelLogo.Size = new Size(185, 100);
            panelLogo.TabIndex = 0;
            // 
            // Menu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(934, 561);
            Controls.Add(panelSideMenu);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 2, 3, 2);
            MinimumSize = new Size(950, 600);
            Name = "Menu";
            Text = "Menu";
            panelSideMenu.ResumeLayout(false);
            panelPrestamo.ResumeLayout(false);
            PanelLibros.ResumeLayout(false);
            panelMiembros.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Panel panelSideMenu;
        private Panel panelMiembros;
        private Button AdminMiembros;
        private Button btonMiembro;
        private Panel panelLogo;
        private Panel PanelLibros;
        private Button Libros;
        private Button AdministrarLibros;
        private Panel panelPrestamo;
        private Button RealizarPrestamo;
        private Button btonPrestamo;
    }
}