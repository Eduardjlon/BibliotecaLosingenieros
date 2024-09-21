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
            panelSideMenu.Margin = new Padding(3, 4, 3, 4);
            panelSideMenu.Name = "panelSideMenu";
            panelSideMenu.Size = new Size(211, 748);
            panelSideMenu.TabIndex = 14;
            // 
            // panelPrestamo
            // 
            panelPrestamo.BackColor = Color.FromArgb(64, 64, 64);
            panelPrestamo.Controls.Add(RealizarPrestamo);
            panelPrestamo.Controls.Add(btonPrestamo);
            panelPrestamo.Dock = DockStyle.Top;
            panelPrestamo.Location = new Point(0, 391);
            panelPrestamo.Margin = new Padding(3, 4, 3, 4);
            panelPrestamo.Name = "panelPrestamo";
            panelPrestamo.Size = new Size(211, 123);
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
            RealizarPrestamo.Location = new Point(0, 60);
            RealizarPrestamo.Margin = new Padding(3, 4, 3, 4);
            RealizarPrestamo.Name = "RealizarPrestamo";
            RealizarPrestamo.Padding = new Padding(40, 0, 0, 0);
            RealizarPrestamo.Size = new Size(211, 53);
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
            btonPrestamo.Margin = new Padding(3, 4, 3, 4);
            btonPrestamo.Name = "btonPrestamo";
            btonPrestamo.Padding = new Padding(11, 0, 0, 0);
            btonPrestamo.Size = new Size(211, 60);
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
            PanelLibros.Location = new Point(0, 258);
            PanelLibros.Margin = new Padding(3, 4, 3, 4);
            PanelLibros.Name = "PanelLibros";
            PanelLibros.Size = new Size(211, 133);
            PanelLibros.TabIndex = 3;
            // 
            // AdministrarLibros
            // 
            AdministrarLibros.BackColor = Color.FromArgb(64, 64, 64);
            AdministrarLibros.Dock = DockStyle.Top;
            AdministrarLibros.FlatAppearance.BorderSize = 0;
            AdministrarLibros.FlatStyle = FlatStyle.Flat;
            AdministrarLibros.ForeColor = Color.White;
            AdministrarLibros.Location = new Point(0, 60);
            AdministrarLibros.Margin = new Padding(3, 4, 3, 4);
            AdministrarLibros.Name = "AdministrarLibros";
            AdministrarLibros.Padding = new Padding(40, 0, 0, 0);
            AdministrarLibros.Size = new Size(211, 53);
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
            Libros.Margin = new Padding(3, 4, 3, 4);
            Libros.Name = "Libros";
            Libros.Padding = new Padding(11, 0, 0, 0);
            Libros.Size = new Size(211, 60);
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
            panelMiembros.Location = new Point(0, 193);
            panelMiembros.Margin = new Padding(3, 4, 3, 4);
            panelMiembros.Name = "panelMiembros";
            panelMiembros.Size = new Size(211, 65);
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
            AdminMiembros.Margin = new Padding(3, 4, 3, 4);
            AdminMiembros.Name = "AdminMiembros";
            AdminMiembros.Padding = new Padding(40, 0, 0, 0);
            AdminMiembros.Size = new Size(211, 53);
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
            btonMiembro.Location = new Point(0, 133);
            btonMiembro.Margin = new Padding(3, 4, 3, 4);
            btonMiembro.Name = "btonMiembro";
            btonMiembro.Padding = new Padding(11, 0, 0, 0);
            btonMiembro.Size = new Size(211, 60);
            btonMiembro.TabIndex = 1;
            btonMiembro.Text = "Miembros";
            btonMiembro.TextAlign = ContentAlignment.MiddleLeft;
            btonMiembro.UseVisualStyleBackColor = true;
            btonMiembro.Click += btonMiembro_Click;
            // 
            // panelLogo
            // 
            panelLogo.Dock = DockStyle.Top;
            panelLogo.Location = new Point(0, 0);
            panelLogo.Margin = new Padding(3, 4, 3, 4);
            panelLogo.Name = "panelLogo";
            panelLogo.Size = new Size(211, 133);
            panelLogo.TabIndex = 0;
            // 
            // Menu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1067, 748);
            Controls.Add(panelSideMenu);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MinimumSize = new Size(1083, 784);
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