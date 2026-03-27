namespace reportsForm
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
            btnGenerar = new Button();
            button1 = new Button();
            dgvReportes = new DataGridView();
            cmbReportes = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)dgvReportes).BeginInit();
            SuspendLayout();
            // 
            // btnGenerar
            // 
            btnGenerar.BackColor = Color.Cyan;
            btnGenerar.FlatStyle = FlatStyle.Popup;
            btnGenerar.Font = new Font("Verdana", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnGenerar.Location = new Point(885, 102);
            btnGenerar.Name = "btnGenerar";
            btnGenerar.Size = new Size(124, 80);
            btnGenerar.TabIndex = 3;
            btnGenerar.Text = "Mostrar";
            btnGenerar.UseVisualStyleBackColor = false;
            btnGenerar.Click += btnGenerar_Click_1;
            // 
            // button1
            // 
            button1.BackColor = Color.Red;
            button1.FlatStyle = FlatStyle.Popup;
            button1.Font = new Font("Verdana", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(885, 294);
            button1.Name = "button1";
            button1.Size = new Size(120, 80);
            button1.TabIndex = 4;
            button1.Text = "Salir";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // dgvReportes
            // 
            dgvReportes.BackgroundColor = SystemColors.WindowFrame;
            dgvReportes.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dgvReportes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvReportes.Location = new Point(27, 26);
            dgvReportes.Name = "dgvReportes";
            dgvReportes.Size = new Size(506, 384);
            dgvReportes.TabIndex = 5;
            dgvReportes.CellContentClick += dgvReportes_CellContentClick;
            // 
            // cmbReportes
            // 
            cmbReportes.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbReportes.FormattingEnabled = true;
            cmbReportes.Location = new Point(566, 38);
            cmbReportes.Name = "cmbReportes";
            cmbReportes.Size = new Size(238, 23);
            cmbReportes.TabIndex = 6;
            // 
            // Form1
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = SystemColors.InactiveCaption;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1062, 509);
            ControlBox = false;
            Controls.Add(cmbReportes);
            Controls.Add(dgvReportes);
            Controls.Add(button1);
            Controls.Add(btnGenerar);
            ForeColor = SystemColors.MenuText;
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dgvReportes).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Button btnGenerar;
        private Button button1;
        private DataGridView dgvReportes;
        private ComboBox cmbReportes;
    }
}
