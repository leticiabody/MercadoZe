namespace MercadoZe.View.TelasClientes
{
    partial class Cadastro_de_cliente
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
            tbx_nomeCliente = new TextBox();
            tbx_emailCliente = new TextBox();
            label4 = new Label();
            tbx_foneCliente = new MaskedTextBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(160, 30);
            label1.Name = "label1";
            label1.Size = new Size(192, 25);
            label1.TabIndex = 0;
            label1.Text = "Cadastro de Clientes";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(49, 90);
            label2.Name = "label2";
            label2.Size = new Size(53, 20);
            label2.TabIndex = 1;
            label2.Text = "Nome:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(53, 151);
            label3.Name = "label3";
            label3.Size = new Size(49, 20);
            label3.TabIndex = 2;
            label3.Text = "email:";
            // 
            // tbx_nomeCliente
            // 
            tbx_nomeCliente.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            tbx_nomeCliente.Location = new Point(53, 113);
            tbx_nomeCliente.Name = "tbx_nomeCliente";
            tbx_nomeCliente.Size = new Size(381, 29);
            tbx_nomeCliente.TabIndex = 3;
            // 
            // tbx_emailCliente
            // 
            tbx_emailCliente.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            tbx_emailCliente.Location = new Point(53, 174);
            tbx_emailCliente.Name = "tbx_emailCliente";
            tbx_emailCliente.Size = new Size(381, 29);
            tbx_emailCliente.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(53, 257);
            label4.Name = "label4";
            label4.Size = new Size(58, 20);
            label4.TabIndex = 5;
            label4.Text = "Celular:";
            // 
            // tbx_foneCliente
            // 
            tbx_foneCliente.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            tbx_foneCliente.Location = new Point(53, 292);
            tbx_foneCliente.Mask = "(999) 00000-0000";
            tbx_foneCliente.Name = "tbx_foneCliente";
            tbx_foneCliente.Size = new Size(165, 27);
            tbx_foneCliente.TabIndex = 6;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(319, 334);
            button1.Name = "button1";
            button1.Size = new Size(99, 31);
            button1.TabIndex = 7;
            button1.Text = "Cadastrar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Cadastro_de_cliente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(491, 414);
            Controls.Add(button1);
            Controls.Add(tbx_foneCliente);
            Controls.Add(label4);
            Controls.Add(tbx_emailCliente);
            Controls.Add(tbx_nomeCliente);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Cadastro_de_cliente";
            Text = "Cadastro_de_cliente";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox tbx_nomeCliente;
        private TextBox tbx_emailCliente;
        private Label label4;
        private MaskedTextBox tbx_foneCliente;
        private Button button1;
    }
}