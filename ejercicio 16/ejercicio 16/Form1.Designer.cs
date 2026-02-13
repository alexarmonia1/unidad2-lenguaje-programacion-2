namespace ejercicio_16
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
            txtpantalla = new TextBox();
            btn1 = new Button();
            btn2 = new Button();
            btn3 = new Button();
            btn4 = new Button();
            btn5 = new Button();
            btn6 = new Button();
            btn7 = new Button();
            btn8 = new Button();
            btn9 = new Button();
            btn0 = new Button();
            btnsuma = new Button();
            btnresta = new Button();
            btnmultiplicar = new Button();
            btndividir = new Button();
            btnigual = new Button();
            btnlimpiar = new Button();
            SuspendLayout();
            // 
            // txtpantalla
            // 
            txtpantalla.BackColor = SystemColors.InactiveCaptionText;
            txtpantalla.ForeColor = SystemColors.Window;
            txtpantalla.Location = new Point(35, 47);
            txtpantalla.Margin = new Padding(3, 2, 3, 2);
            txtpantalla.Name = "txtpantalla";
            txtpantalla.ReadOnly = true;
            txtpantalla.Size = new Size(512, 28);
            txtpantalla.TabIndex = 0;
            txtpantalla.TextAlign = HorizontalAlignment.Right;
            // 
            // btn1
            // 
            btn1.BackColor = Color.DimGray;
            btn1.ForeColor = Color.White;
            btn1.Location = new Point(35, 96);
            btn1.Margin = new Padding(3, 2, 3, 2);
            btn1.Name = "btn1";
            btn1.Size = new Size(123, 28);
            btn1.TabIndex = 1;
            btn1.Text = "1";
            btn1.UseVisualStyleBackColor = false;
            btn1.Click += btnNumero_Click;
            // 
            // btn2
            // 
            btn2.BackColor = Color.DimGray;
            btn2.ForeColor = Color.White;
            btn2.Location = new Point(164, 96);
            btn2.Margin = new Padding(3, 2, 3, 2);
            btn2.Name = "btn2";
            btn2.Size = new Size(123, 28);
            btn2.TabIndex = 2;
            btn2.Text = "2";
            btn2.UseVisualStyleBackColor = false;
            btn2.Click += btnNumero_Click;
            // 
            // btn3
            // 
            btn3.BackColor = Color.DimGray;
            btn3.ForeColor = Color.White;
            btn3.Location = new Point(294, 96);
            btn3.Margin = new Padding(3, 2, 3, 2);
            btn3.Name = "btn3";
            btn3.Size = new Size(123, 28);
            btn3.TabIndex = 3;
            btn3.Text = "3";
            btn3.UseVisualStyleBackColor = false;
            btn3.Click += btnNumero_Click;
            // 
            // btn4
            // 
            btn4.BackColor = Color.DimGray;
            btn4.ForeColor = Color.White;
            btn4.Location = new Point(35, 153);
            btn4.Margin = new Padding(3, 2, 3, 2);
            btn4.Name = "btn4";
            btn4.Size = new Size(123, 28);
            btn4.TabIndex = 4;
            btn4.Text = "4";
            btn4.UseVisualStyleBackColor = false;
            btn4.Click += btnNumero_Click;
            // 
            // btn5
            // 
            btn5.BackColor = Color.DimGray;
            btn5.ForeColor = Color.White;
            btn5.Location = new Point(164, 153);
            btn5.Margin = new Padding(3, 2, 3, 2);
            btn5.Name = "btn5";
            btn5.Size = new Size(123, 28);
            btn5.TabIndex = 5;
            btn5.Text = "5";
            btn5.UseVisualStyleBackColor = false;
            btn5.Click += btnNumero_Click;
            // 
            // btn6
            // 
            btn6.BackColor = Color.DimGray;
            btn6.ForeColor = Color.White;
            btn6.Location = new Point(294, 153);
            btn6.Margin = new Padding(3, 2, 3, 2);
            btn6.Name = "btn6";
            btn6.Size = new Size(123, 28);
            btn6.TabIndex = 6;
            btn6.Text = "6";
            btn6.UseVisualStyleBackColor = false;
            btn6.Click += btnNumero_Click;
            // 
            // btn7
            // 
            btn7.BackColor = Color.DimGray;
            btn7.ForeColor = Color.White;
            btn7.Location = new Point(35, 204);
            btn7.Margin = new Padding(3, 2, 3, 2);
            btn7.Name = "btn7";
            btn7.Size = new Size(123, 28);
            btn7.TabIndex = 7;
            btn7.Text = "7";
            btn7.UseVisualStyleBackColor = false;
            btn7.Click += btnNumero_Click;
            // 
            // btn8
            // 
            btn8.BackColor = Color.DimGray;
            btn8.ForeColor = Color.White;
            btn8.Location = new Point(164, 204);
            btn8.Margin = new Padding(3, 2, 3, 2);
            btn8.Name = "btn8";
            btn8.Size = new Size(123, 28);
            btn8.TabIndex = 8;
            btn8.Text = "8";
            btn8.UseVisualStyleBackColor = false;
            btn8.Click += btnNumero_Click;
            // 
            // btn9
            // 
            btn9.BackColor = Color.DimGray;
            btn9.ForeColor = Color.White;
            btn9.Location = new Point(294, 204);
            btn9.Margin = new Padding(3, 2, 3, 2);
            btn9.Name = "btn9";
            btn9.Size = new Size(123, 28);
            btn9.TabIndex = 9;
            btn9.Text = "9";
            btn9.UseVisualStyleBackColor = false;
            btn9.Click += btnNumero_Click;
            // 
            // btn0
            // 
            btn0.BackColor = Color.DimGray;
            btn0.ForeColor = Color.White;
            btn0.Location = new Point(35, 238);
            btn0.Margin = new Padding(3, 2, 3, 2);
            btn0.Name = "btn0";
            btn0.Size = new Size(109, 54);
            btn0.TabIndex = 10;
            btn0.Text = "0";
            btn0.UseVisualStyleBackColor = false;
            btn0.Click += btnNumero_Click;
            // 
            // btnsuma
            // 
            btnsuma.BackColor = Color.Gold;
            btnsuma.Font = new Font("Arial Rounded MT Bold", 9F);
            btnsuma.ForeColor = Color.White;
            btnsuma.Location = new Point(424, 96);
            btnsuma.Margin = new Padding(3, 2, 3, 2);
            btnsuma.Name = "btnsuma";
            btnsuma.Size = new Size(123, 28);
            btnsuma.TabIndex = 11;
            btnsuma.Text = "+";
            btnsuma.UseVisualStyleBackColor = false;
            btnsuma.Click += btnsuma_Click;
            // 
            // btnresta
            // 
            btnresta.BackColor = Color.Gold;
            btnresta.Font = new Font("Arial Rounded MT Bold", 9F);
            btnresta.ForeColor = Color.White;
            btnresta.Location = new Point(424, 153);
            btnresta.Margin = new Padding(3, 2, 3, 2);
            btnresta.Name = "btnresta";
            btnresta.Size = new Size(123, 28);
            btnresta.TabIndex = 12;
            btnresta.Text = "-";
            btnresta.UseVisualStyleBackColor = false;
            btnresta.Click += btnresta_Click;
            // 
            // btnmultiplicar
            // 
            btnmultiplicar.BackColor = Color.Gold;
            btnmultiplicar.Font = new Font("Arial Rounded MT Bold", 9F);
            btnmultiplicar.ForeColor = Color.White;
            btnmultiplicar.Location = new Point(424, 204);
            btnmultiplicar.Margin = new Padding(3, 2, 3, 2);
            btnmultiplicar.Name = "btnmultiplicar";
            btnmultiplicar.Size = new Size(123, 28);
            btnmultiplicar.TabIndex = 13;
            btnmultiplicar.Text = "x";
            btnmultiplicar.UseVisualStyleBackColor = false;
            btnmultiplicar.Click += btnmultiplicar_Click;
            // 
            // btndividir
            // 
            btndividir.BackColor = Color.FromArgb(224, 224, 224);
            btndividir.Font = new Font("Arial Rounded MT Bold", 9F);
            btndividir.ForeColor = Color.White;
            btndividir.Location = new Point(286, 248);
            btndividir.Margin = new Padding(3, 2, 3, 2);
            btndividir.Name = "btndividir";
            btndividir.Size = new Size(131, 44);
            btndividir.TabIndex = 14;
            btndividir.Text = "/";
            btndividir.UseVisualStyleBackColor = false;
            btndividir.Click += btndividir_Click;
            // 
            // btnigual
            // 
            btnigual.BackColor = Color.Gold;
            btnigual.Font = new Font("Arial Rounded MT Bold", 9F);
            btnigual.ForeColor = Color.White;
            btnigual.Location = new Point(424, 248);
            btnigual.Margin = new Padding(3, 2, 3, 2);
            btnigual.Name = "btnigual";
            btnigual.Size = new Size(123, 44);
            btnigual.TabIndex = 15;
            btnigual.Text = "=";
            btnigual.UseVisualStyleBackColor = false;
            btnigual.Click += btnigual_Click;
            // 
            // btnlimpiar
            // 
            btnlimpiar.BackColor = Color.FromArgb(224, 224, 224);
            btnlimpiar.Font = new Font("Arial Rounded MT Bold", 9F);
            btnlimpiar.ForeColor = Color.White;
            btnlimpiar.Location = new Point(164, 248);
            btnlimpiar.Margin = new Padding(3, 2, 3, 2);
            btnlimpiar.Name = "btnlimpiar";
            btnlimpiar.Size = new Size(123, 44);
            btnlimpiar.TabIndex = 16;
            btnlimpiar.Text = "C";
            btnlimpiar.UseVisualStyleBackColor = false;
            btnlimpiar.Click += btnlimpiar_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(11F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(562, 362);
            Controls.Add(btnlimpiar);
            Controls.Add(btnigual);
            Controls.Add(btndividir);
            Controls.Add(btnmultiplicar);
            Controls.Add(btnresta);
            Controls.Add(btnsuma);
            Controls.Add(btn0);
            Controls.Add(btn9);
            Controls.Add(btn8);
            Controls.Add(btn7);
            Controls.Add(btn6);
            Controls.Add(btn5);
            Controls.Add(btn4);
            Controls.Add(btn3);
            Controls.Add(btn2);
            Controls.Add(btn1);
            Controls.Add(txtpantalla);
            Font = new Font("Arial Rounded MT Bold", 9F);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Form1";
            Text = "calculadora basica";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtpantalla;
        private Button btn1;
        private Button btn2;
        private Button btn3;
        private Button btn4;
        private Button btn5;
        private Button btn6;
        private Button btn7;
        private Button btn8;
        private Button btn9;
        private Button btn0;
        private Button btnsuma;
        private Button btnresta;
        private Button btnmultiplicar;
        private Button btndividir;
        private Button btnigual;
        private Button btnlimpiar;
    }
}
