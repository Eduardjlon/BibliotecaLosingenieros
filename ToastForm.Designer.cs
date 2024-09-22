namespace BibliotecaLosingenieros2
{
    partial class ToastForm
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
            components = new System.ComponentModel.Container();
            flowLayoutPanel1 = new FlowLayoutPanel();
            label1 = new Label();
            ToastTimer = new System.Windows.Forms.Timer(components);
            ToastHide = new System.Windows.Forms.Timer(components);
            SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.BackColor = Color.FromArgb(128, 255, 128);
            flowLayoutPanel1.Location = new Point(-20, -24);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(65, 161);
            flowLayoutPanel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(51, 7);
            label1.Name = "label1";
            label1.Size = new Size(149, 28);
            label1.TabIndex = 1;
            label1.Text = "Libro solicitado";
            // 
            // ToastTimer
            // 
            ToastTimer.Enabled = true;
            ToastTimer.Interval = 10;
            ToastTimer.Tick += ToastTimer_Tick_1;
            // 
            // ToastHide
            // 
            ToastHide.Interval = 10;
            ToastHide.Tick += ToastHide_Tick_1;
            // 
            // ToastForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(206, 41);
            Controls.Add(label1);
            Controls.Add(flowLayoutPanel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ToastForm";
            Text = "ToastForm";
            Load += ToastForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private FlowLayoutPanel flowLayoutPanel1;
        private Label label1;
        private System.Windows.Forms.Timer ToastTimer;
        private System.Windows.Forms.Timer ToastHide;
    }
}