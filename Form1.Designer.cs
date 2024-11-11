namespace CursoC_
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            PanelP = new Panel();
            TitleVersion = new Label();
            Default1 = new Button();
            Dllbtn = new Button();
            Scriptbtn = new Button();
            Default = new Button();
            Ticketbtn = new Button();
            Autologobtn = new Button();
            logo = new PictureBox();
            label1 = new Label();
            btnCerrar = new PictureBox();
            MinimizeBtn = new PictureBox();
            panel1 = new Panel();
            PanelP.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)logo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnCerrar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)MinimizeBtn).BeginInit();
            SuspendLayout();
            // 
            // PanelP
            // 
            PanelP.BackColor = Color.White;
            PanelP.Controls.Add(TitleVersion);
            PanelP.Controls.Add(Default1);
            PanelP.Controls.Add(Dllbtn);
            PanelP.Controls.Add(Scriptbtn);
            PanelP.Controls.Add(Default);
            PanelP.Controls.Add(Ticketbtn);
            PanelP.Controls.Add(Autologobtn);
            PanelP.Controls.Add(logo);
            PanelP.Controls.Add(label1);
            PanelP.Location = new Point(19, 28);
            PanelP.Name = "PanelP";
            PanelP.Size = new Size(755, 545);
            PanelP.TabIndex = 0;
            // 
            // TitleVersion
            // 
            TitleVersion.Font = new Font("Corbel", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TitleVersion.ForeColor = SystemColors.AppWorkspace;
            TitleVersion.Location = new Point(318, 503);
            TitleVersion.Name = "TitleVersion";
            TitleVersion.Size = new Size(118, 33);
            TitleVersion.TabIndex = 9;
            TitleVersion.Text = "Ver. Alpha";
            // 
            // Default1
            // 
            Default1.BackColor = SystemColors.ButtonFace;
            Default1.Cursor = Cursors.No;
            Default1.FlatAppearance.BorderSize = 0;
            Default1.FlatStyle = FlatStyle.Flat;
            Default1.Location = new Point(423, 394);
            Default1.Name = "Default1";
            Default1.Size = new Size(231, 84);
            Default1.TabIndex = 8;
            Default1.UseVisualStyleBackColor = false;
            // 
            // Dllbtn
            // 
            Dllbtn.BackColor = Color.FromArgb(3, 145, 254);
            Dllbtn.Cursor = Cursors.Hand;
            Dllbtn.FlatAppearance.BorderSize = 0;
            Dllbtn.FlatStyle = FlatStyle.Flat;
            Dllbtn.Font = new Font("Inter", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Dllbtn.ForeColor = Color.White;
            Dllbtn.Image = (Image)resources.GetObject("Dllbtn.Image");
            Dllbtn.ImageAlign = ContentAlignment.MiddleLeft;
            Dllbtn.Location = new Point(423, 288);
            Dllbtn.Name = "Dllbtn";
            Dllbtn.Padding = new Padding(15, 0, 0, 0);
            Dllbtn.Size = new Size(231, 84);
            Dllbtn.TabIndex = 7;
            Dllbtn.Text = "DLL INSTALL";
            Dllbtn.UseVisualStyleBackColor = false;
            Dllbtn.Click += Dllbtn_Click;
            // 
            // Scriptbtn
            // 
            Scriptbtn.BackColor = Color.FromArgb(3, 145, 254);
            Scriptbtn.Cursor = Cursors.Hand;
            Scriptbtn.FlatAppearance.BorderSize = 0;
            Scriptbtn.FlatStyle = FlatStyle.Flat;
            Scriptbtn.Font = new Font("Inter", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Scriptbtn.ForeColor = Color.White;
            Scriptbtn.Image = (Image)resources.GetObject("Scriptbtn.Image");
            Scriptbtn.ImageAlign = ContentAlignment.MiddleLeft;
            Scriptbtn.Location = new Point(423, 178);
            Scriptbtn.Name = "Scriptbtn";
            Scriptbtn.Padding = new Padding(15, 0, 0, 0);
            Scriptbtn.Size = new Size(231, 84);
            Scriptbtn.TabIndex = 6;
            Scriptbtn.Text = "SCRIPT INICIO";
            Scriptbtn.UseVisualStyleBackColor = false;
            Scriptbtn.Click += Scriptbtn_Click;
            // 
            // Default
            // 
            Default.BackColor = SystemColors.ButtonFace;
            Default.Cursor = Cursors.No;
            Default.FlatAppearance.BorderSize = 0;
            Default.FlatStyle = FlatStyle.Flat;
            Default.Location = new Point(98, 394);
            Default.Name = "Default";
            Default.Size = new Size(231, 84);
            Default.TabIndex = 4;
            Default.UseVisualStyleBackColor = false;
            // 
            // Ticketbtn
            // 
            Ticketbtn.BackColor = Color.FromArgb(3, 145, 254);
            Ticketbtn.Cursor = Cursors.Hand;
            Ticketbtn.FlatAppearance.BorderSize = 0;
            Ticketbtn.FlatStyle = FlatStyle.Flat;
            Ticketbtn.Font = new Font("Inter", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Ticketbtn.ForeColor = SystemColors.ButtonHighlight;
            Ticketbtn.Image = (Image)resources.GetObject("Ticketbtn.Image");
            Ticketbtn.ImageAlign = ContentAlignment.MiddleLeft;
            Ticketbtn.Location = new Point(98, 288);
            Ticketbtn.Name = "Ticketbtn";
            Ticketbtn.Padding = new Padding(15, 0, 0, 0);
            Ticketbtn.Size = new Size(231, 84);
            Ticketbtn.TabIndex = 3;
            Ticketbtn.Text = "Ticket Printer";
            Ticketbtn.UseVisualStyleBackColor = false;
            Ticketbtn.Click += Ticketbtn_Click;
            // 
            // Autologobtn
            // 
            Autologobtn.BackColor = Color.FromArgb(3, 145, 254);
            Autologobtn.Cursor = Cursors.Hand;
            Autologobtn.FlatAppearance.BorderSize = 0;
            Autologobtn.FlatStyle = FlatStyle.Flat;
            Autologobtn.Font = new Font("Inter", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Autologobtn.ForeColor = Color.White;
            Autologobtn.Image = (Image)resources.GetObject("Autologobtn.Image");
            Autologobtn.ImageAlign = ContentAlignment.MiddleLeft;
            Autologobtn.Location = new Point(98, 178);
            Autologobtn.Name = "Autologobtn";
            Autologobtn.Padding = new Padding(15, 0, 0, 0);
            Autologobtn.Size = new Size(231, 84);
            Autologobtn.TabIndex = 2;
            Autologobtn.Text = "AUTOLOGON";
            Autologobtn.UseVisualStyleBackColor = false;
            Autologobtn.Click += Autologobtn_Click;
            // 
            // logo
            // 
            logo.ErrorImage = null;
            logo.Image = (Image)resources.GetObject("logo.Image");
            logo.InitialImage = null;
            logo.Location = new Point(405, 3);
            logo.Name = "logo";
            logo.Size = new Size(300, 113);
            logo.SizeMode = PictureBoxSizeMode.AutoSize;
            logo.TabIndex = 1;
            logo.TabStop = false;
            // 
            // label1
            // 
            label1.BackColor = Color.FromArgb(3, 145, 254);
            label1.Font = new Font("League Gothic", 47.9999924F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(-7, -19);
            label1.Name = "label1";
            label1.Size = new Size(336, 135);
            label1.TabIndex = 0;
            label1.Text = "MENU PRINCIPAL";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            label1.Click += label1_Click;
            // 
            // btnCerrar
            // 
            btnCerrar.BackColor = Color.Transparent;
            btnCerrar.Cursor = Cursors.Hand;
            btnCerrar.Image = (Image)resources.GetObject("btnCerrar.Image");
            btnCerrar.Location = new Point(776, 6);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(16, 16);
            btnCerrar.SizeMode = PictureBoxSizeMode.AutoSize;
            btnCerrar.TabIndex = 3;
            btnCerrar.TabStop = false;
            btnCerrar.Click += btnCerrar_Click;
            // 
            // MinimizeBtn
            // 
            MinimizeBtn.Cursor = Cursors.Hand;
            MinimizeBtn.Image = (Image)resources.GetObject("MinimizeBtn.Image");
            MinimizeBtn.Location = new Point(754, 6);
            MinimizeBtn.Name = "MinimizeBtn";
            MinimizeBtn.Size = new Size(16, 16);
            MinimizeBtn.TabIndex = 4;
            MinimizeBtn.TabStop = false;
            MinimizeBtn.Click += MinimizeBtn_Click;
            // 
            // panel1
            // 
            panel1.Location = new Point(-2, -1);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 30);
            panel1.TabIndex = 5;
            panel1.MouseDown += panel1_MouseDown;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(3, 145, 254);
            ClientSize = new Size(800, 600);
            Controls.Add(MinimizeBtn);
            Controls.Add(btnCerrar);
            Controls.Add(PanelP);
            Controls.Add(panel1);
            ForeColor = SystemColors.ControlText;
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            Text = "Fondo";
            PanelP.ResumeLayout(false);
            PanelP.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)logo).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnCerrar).EndInit();
            ((System.ComponentModel.ISupportInitialize)MinimizeBtn).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Panel PanelP;
        private Label label1;
        private PictureBox logo;
        private Button Autologobtn;
        private PictureBox btnCerrar;
        private Button Ticketbtn;
        private Button Default;
        private Button Scriptbtn;
        private Button Dllbtn;
        private Button Default1;
        private PictureBox MinimizeBtn;
        private Panel panel1;
        private Label TitleVersion;
    }
}
