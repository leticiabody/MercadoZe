namespace MercadoZe.View.TelaUsuario
{
    partial class Tela_Alterar_usuario
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            groupBox1 = new GroupBox();
            button1 = new Button();
            comboBox1 = new ComboBox();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(130, 85);
            label1.Name = "label1";
            label1.Size = new Size(161, 30);
            label1.TabIndex = 0;
            label1.Text = "Alterar Usuário";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(74, 156);
            label2.Name = "label2";
            label2.Size = new Size(56, 21);
            label2.TabIndex = 1;
            label2.Text = "Nome:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(79, 203);
            label3.Name = "label3";
            label3.Size = new Size(51, 21);
            label3.TabIndex = 2;
            label3.Text = "email:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(32, 64);
            label4.Name = "label4";
            label4.Size = new Size(43, 21);
            label4.TabIndex = 3;
            label4.Text = "Tipo:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(130, 158);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(215, 23);
            textBox1.TabIndex = 5;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(130, 201);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(215, 23);
            textBox2.TabIndex = 6;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(comboBox1);
            groupBox1.Controls.Add(label4);
            groupBox1.Location = new Point(46, 264);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(344, 228);
            groupBox1.TabIndex = 7;
            groupBox1.TabStop = false;
            groupBox1.Text = "Informações";
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(310, 511);
            button1.Name = "button1";
            button1.Size = new Size(80, 40);
            button1.TabIndex = 8;
            button1.Text = "Alterar";
            button1.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(81, 62);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(150, 23);
            comboBox1.TabIndex = 4;
            // 
            // Tela_Alterar_usuario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(439, 628);
            Controls.Add(button1);
            Controls.Add(groupBox1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Tela_Alterar_usuario";
            Text = "Tela_Alterar_usuario";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox textBox1;
        private TextBox textBox2;
        private GroupBox groupBox1;
        private Button button1;
        private ComboBox comboBox1;
    }
}