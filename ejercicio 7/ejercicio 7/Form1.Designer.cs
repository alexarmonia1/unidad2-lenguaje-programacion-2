namespace ejercicio_7
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
            txtelemento = new TextBox();
            btnagregar = new Button();
            lstelementos = new ListBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // txtelemento
            // 
            txtelemento.Location = new Point(177, 114);
            txtelemento.Name = "txtelemento";
            txtelemento.Size = new Size(150, 31);
            txtelemento.TabIndex = 0;
            // 
            // btnagregar
            // 
            btnagregar.Location = new Point(177, 161);
            btnagregar.Name = "btnagregar";
            btnagregar.Size = new Size(112, 34);
            btnagregar.TabIndex = 1;
            btnagregar.Text = "agregar";
            btnagregar.UseVisualStyleBackColor = true;
            btnagregar.Click += btnagregar_Click;
            // 
            // lstelementos
            // 
            lstelementos.FormattingEnabled = true;
            lstelementos.ItemHeight = 25;
            lstelementos.Location = new Point(177, 211);
            lstelementos.Name = "lstelementos";
            lstelementos.Size = new Size(424, 154);
            lstelementos.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(147, 74);
            label1.Name = "label1";
            label1.Size = new Size(214, 25);
            label1.TabIndex = 3;
            label1.Text = "Escriba el texto a agregar:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(lstelementos);
            Controls.Add(btnagregar);
            Controls.Add(txtelemento);
            Name = "Form1";
            Text = "agregar elementos a la lista";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtelemento;
        private Button btnagregar;
        private ListBox lstelementos;
        private Label label1;
    }
}
