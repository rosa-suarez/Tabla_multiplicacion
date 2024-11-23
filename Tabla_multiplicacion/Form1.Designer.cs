namespace Tabla_multiplicacion
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
            panel1 = new Panel();
            richTextBoxresultados = new RichTextBox();
            buttonver = new Button();
            textBoxnum = new TextBox();
            labelnumero = new Label();
            labeltitulo = new Label();
            labelnombre = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(255, 192, 192);
            panel1.Controls.Add(labelnombre);
            panel1.Controls.Add(richTextBoxresultados);
            panel1.Controls.Add(buttonver);
            panel1.Controls.Add(textBoxnum);
            panel1.Controls.Add(labelnumero);
            panel1.Controls.Add(labeltitulo);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(776, 426);
            panel1.TabIndex = 0;
            // 
            // richTextBoxresultados
            // 
            richTextBoxresultados.Location = new Point(289, 114);
            richTextBoxresultados.Name = "richTextBoxresultados";
            richTextBoxresultados.Size = new Size(204, 255);
            richTextBoxresultados.TabIndex = 4;
            richTextBoxresultados.Text = "";
            // 
            // buttonver
            // 
            buttonver.Location = new Point(76, 226);
            buttonver.Name = "buttonver";
            buttonver.Size = new Size(112, 34);
            buttonver.TabIndex = 3;
            buttonver.Text = "ver tabla";
            buttonver.UseMnemonic = false;
            buttonver.UseVisualStyleBackColor = true;
            buttonver.Click += buttonver_Click;
            // 
            // textBoxnum
            // 
            textBoxnum.Location = new Point(76, 171);
            textBoxnum.Name = "textBoxnum";
            textBoxnum.Size = new Size(150, 31);
            textBoxnum.TabIndex = 2;
            // 
            // labelnumero
            // 
            labelnumero.AutoSize = true;
            labelnumero.Font = new Font("Sylfaen", 11F, FontStyle.Regular, GraphicsUnit.Point);
            labelnumero.Location = new Point(56, 114);
            labelnumero.Name = "labelnumero";
            labelnumero.Size = new Size(190, 28);
            labelnumero.TabIndex = 1;
            labelnumero.Text = "¿Qué tabla quieres?";
            labelnumero.UseMnemonic = false;
            // 
            // labeltitulo
            // 
            labeltitulo.AutoSize = true;
            labeltitulo.Font = new Font("Stencil", 14F, FontStyle.Regular, GraphicsUnit.Point);
            labeltitulo.Location = new Point(56, 45);
            labeltitulo.Name = "labeltitulo";
            labeltitulo.Size = new Size(345, 33);
            labeltitulo.TabIndex = 0;
            labeltitulo.Text = "Tablas de multiplicar";
            // 
            // labelnombre
            // 
            labelnombre.AutoSize = true;
            labelnombre.BackColor = Color.FromArgb(255, 128, 128);
            labelnombre.Location = new Point(535, 383);
            labelnombre.Name = "labelnombre";
            labelnombre.Size = new Size(221, 25);
            labelnombre.TabIndex = 5;
            labelnombre.Text = "Rosa Lizeth Suárez Medina";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            Name = "Form1";
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label labeltitulo;
        private TextBox textBoxnum;
        private Label labelnumero;
        private RichTextBox richTextBoxresultados;
        private Button buttonver;
        private Label labelnombre;
    }
}
