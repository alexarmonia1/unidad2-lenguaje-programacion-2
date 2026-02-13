namespace ejercicio_15
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
            txtcontenido = new TextBox();
            btnabrir = new Button();
            btnguardar = new Button();
            openFileDialog1 = new OpenFileDialog();
            saveFileDialog1 = new SaveFileDialog();
            SuspendLayout();
            // 
            // txtcontenido
            // 
            txtcontenido.Location = new Point(286, 126);
            txtcontenido.Multiline = true;
            txtcontenido.Name = "txtcontenido";
            txtcontenido.ScrollBars = ScrollBars.Vertical;
            txtcontenido.Size = new Size(150, 46);
            txtcontenido.TabIndex = 0;
            // 
            // btnabrir
            // 
            btnabrir.Location = new Point(225, 215);
            btnabrir.Name = "btnabrir";
            btnabrir.Size = new Size(112, 34);
            btnabrir.TabIndex = 1;
            btnabrir.Text = "abrir";
            btnabrir.UseVisualStyleBackColor = true;
            btnabrir.Click += btnabrir_Click;
            // 
            // btnguardar
            // 
            btnguardar.Location = new Point(370, 215);
            btnguardar.Name = "btnguardar";
            btnguardar.Size = new Size(112, 34);
            btnguardar.TabIndex = 2;
            btnguardar.Text = "guardar";
            btnguardar.UseVisualStyleBackColor = true;
            btnguardar.Click += btnguardar_Click;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnguardar);
            Controls.Add(btnabrir);
            Controls.Add(txtcontenido);
            Name = "Form1";
            Text = "abrir y guardar archivos";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtcontenido;
        private Button btnabrir;
        private Button btnguardar;
        private OpenFileDialog openFileDialog1;
        private SaveFileDialog saveFileDialog1;
    }
}
