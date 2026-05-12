namespace Forms
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
            btnTeste = new Button();
            txtBox1 = new TextBox();
            lbl1 = new Label();
            btn2 = new Button();
            btnParImpar = new Button();
            SuspendLayout();
            // 
            // btnTeste
            // 
            btnTeste.BackColor = SystemColors.ActiveCaption;
            btnTeste.Location = new Point(83, 53);
            btnTeste.Name = "btnTeste";
            btnTeste.Size = new Size(206, 23);
            btnTeste.TabIndex = 0;
            btnTeste.Text = "Clique Aqui para Exibir o Número";
            btnTeste.UseVisualStyleBackColor = false;
            btnTeste.Click += Button1_Click;
            // 
            // txtBox1
            // 
            txtBox1.BackColor = SystemColors.Highlight;
            txtBox1.BorderStyle = BorderStyle.FixedSingle;
            txtBox1.ForeColor = SystemColors.InactiveCaption;
            txtBox1.Location = new Point(83, 24);
            txtBox1.Name = "txtBox1";
            txtBox1.Size = new Size(100, 23);
            txtBox1.TabIndex = 1;
            txtBox1.TextChanged += txtBox1_TextChanged;
            // 
            // lbl1
            // 
            lbl1.AutoSize = true;
            lbl1.BackColor = SystemColors.Info;
            lbl1.BorderStyle = BorderStyle.FixedSingle;
            lbl1.ForeColor = SystemColors.ActiveCaptionText;
            lbl1.Location = new Point(120, 108);
            lbl1.Name = "lbl1";
            lbl1.Size = new Size(112, 17);
            lbl1.TabIndex = 2;
            lbl1.Text = "Número/ Condição";
            lbl1.Click += lbl1_Click;
            // 
            // btn2
            // 
            btn2.Location = new Point(404, 73);
            btn2.Name = "btn2";
            btn2.Size = new Size(94, 23);
            btn2.TabIndex = 3;
            btn2.Text = "Troca de Cor";
            btn2.UseVisualStyleBackColor = true;
            btn2.Click += button1_Click_1;
            // 
            // btnParImpar
            // 
            btnParImpar.BackColor = SystemColors.ControlDarkDark;
            btnParImpar.Location = new Point(83, 82);
            btnParImpar.Name = "btnParImpar";
            btnParImpar.Size = new Size(206, 23);
            btnParImpar.TabIndex = 4;
            btnParImpar.Text = "Teste se o número é Par ou Ímpar";
            btnParImpar.UseVisualStyleBackColor = false;
            btnParImpar.Click += btnParImpar_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnParImpar);
            Controls.Add(btn2);
            Controls.Add(lbl1);
            Controls.Add(txtBox1);
            Controls.Add(btnTeste);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnTeste;
        private TextBox txtBox1;
        private Label lbl1;
        private Button btn2;
        private Button btnParImpar;
    }
}
