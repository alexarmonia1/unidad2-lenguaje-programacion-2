namespace ejercicio_14
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
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            lblinicio = new Label();
            tabPage2 = new TabPage();
            lbldatos = new Label();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Location = new Point(103, 36);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(610, 353);
            tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(lblinicio);
            tabPage1.Location = new Point(4, 34);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(602, 315);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "inicio";
            tabPage1.UseVisualStyleBackColor = true;
            tabPage1.Click += tabPage1_Click;
            // 
            // lblinicio
            // 
            lblinicio.AutoSize = true;
            lblinicio.Location = new Point(128, 144);
            lblinicio.Name = "lblinicio";
            lblinicio.Size = new Size(312, 25);
            lblinicio.TabIndex = 0;
            lblinicio.Text = "Bienvenidos a la pestaña inicio de alex";
            lblinicio.Click += label1_Click;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(lbldatos);
            tabPage2.Location = new Point(4, 34);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(602, 315);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "datos";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // lbldatos
            // 
            lbldatos.AutoSize = true;
            lbldatos.Location = new Point(182, 100);
            lbldatos.Name = "lbldatos";
            lbldatos.Size = new Size(232, 75);
            lbldatos.TabIndex = 0;
            lbldatos.Text = "Aqui se muestran los datos:\r\nNombre: Alexander Acosta\r\nMatricula: sd-19-10375";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tabControl1);
            Name = "Form1";
            Text = "Form1";
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private Label lblinicio;
        private Label lbldatos;
    }
}
