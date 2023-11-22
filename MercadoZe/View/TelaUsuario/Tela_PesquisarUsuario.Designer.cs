namespace MercadoZe.View.TelaUsuario
{
    partial class Tela_PesquisarUsuario
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
            textBox1 = new TextBox();
            button1 = new Button();
            dateTimePicker1 = new DateTimePicker();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label7 = new Label();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            groupBox1 = new GroupBox();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(114, 38);
            label1.Name = "label1";
            label1.Size = new Size(170, 25);
            label1.TabIndex = 1;
            label1.Text = "Pesquisar Usuario";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(59, 124);
            label2.Name = "label2";
            label2.Size = new Size(57, 15);
            label2.TabIndex = 2;
            label2.Text = "Matricula";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(127, 120);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(146, 23);
            textBox1.TabIndex = 3;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(289, 121);
            button1.Name = "button1";
            button1.Size = new Size(57, 22);
            button1.TabIndex = 4;
            button1.Text = "Buscar";
            button1.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(104, 453);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(261, 23);
            dateTimePicker1.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(186, 425);
            label3.Name = "label3";
            label3.Size = new Size(108, 15);
            label3.TabIndex = 6;
            label3.Text = "Ultima atualização";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(28, 25);
            label4.Name = "label4";
            label4.Size = new Size(43, 15);
            label4.TabIndex = 7;
            label4.Text = "Nome:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(28, 84);
            label5.Name = "label5";
            label5.Size = new Size(44, 15);
            label5.TabIndex = 8;
            label5.Text = "E-mail:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(28, 145);
            label7.Name = "label7";
            label7.Size = new Size(42, 15);
            label7.TabIndex = 10;
            label7.Text = "Senha:";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(78, 22);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(146, 23);
            textBox2.TabIndex = 11;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(78, 81);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(146, 23);
            textBox3.TabIndex = 12;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(78, 137);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(146, 23);
            textBox4.TabIndex = 13;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(textBox4);
            groupBox1.Controls.Add(textBox3);
            groupBox1.Controls.Add(textBox2);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Location = new Point(49, 192);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(296, 207);
            groupBox1.TabIndex = 14;
            groupBox1.TabStop = false;
            groupBox1.Text = "Informa";
            // 
            // Tela_PesquisarUsuario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(374, 543);
            Controls.Add(groupBox1);
            Controls.Add(label3);
            Controls.Add(dateTimePicker1);
            Controls.Add(button1);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Tela_PesquisarUsuario";
            Text = "Tela_PesquisarUsuario";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox textBox1;
        private Button button1;
        private DateTimePicker dateTimePicker1;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label7;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private GroupBox groupBox1;
    }
}