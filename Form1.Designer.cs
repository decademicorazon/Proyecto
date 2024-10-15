namespace Proyecto
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
            label1 = new Label();
            txtUsuario = new TextBox();
            label2 = new Label();
            txtClave = new TextBox();
            butEntrar = new Button();
            axWindowsMediaPlayer1 = new AxWMPLib.AxWindowsMediaPlayer();
            ((System.ComponentModel.ISupportInitialize)axWindowsMediaPlayer1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(106, 117);
            label1.Name = "label1";
            label1.Size = new Size(72, 25);
            label1.TabIndex = 0;
            label1.Text = "Usuario";
            // 
            // txtUsuario
            // 
            txtUsuario.Location = new Point(194, 117);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(150, 31);
            txtUsuario.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(77, 185);
            label2.Name = "label2";
            label2.Size = new Size(101, 25);
            label2.TabIndex = 2;
            label2.Text = "Contraseña";
            // 
            // txtClave
            // 
            txtClave.Location = new Point(194, 185);
            txtClave.Name = "txtClave";
            txtClave.Size = new Size(150, 31);
            txtClave.TabIndex = 3;
            // 
            // butEntrar
            // 
            butEntrar.Location = new Point(607, 323);
            butEntrar.Name = "butEntrar";
            butEntrar.Size = new Size(112, 34);
            butEntrar.TabIndex = 5;
            butEntrar.Text = "Entrar";
            butEntrar.UseVisualStyleBackColor = true;
            butEntrar.Click += butEntrar_Click;
            // 
            // axWindowsMediaPlayer1
            // 
            axWindowsMediaPlayer1.Enabled = true;
            axWindowsMediaPlayer1.Location = new Point(632, 23);
            axWindowsMediaPlayer1.Name = "axWindowsMediaPlayer1";
            axWindowsMediaPlayer1.OcxState = (AxHost.State)resources.GetObject("axWindowsMediaPlayer1.OcxState");
            axWindowsMediaPlayer1.Size = new Size(75, 32);
            axWindowsMediaPlayer1.TabIndex = 6;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(axWindowsMediaPlayer1);
            Controls.Add(butEntrar);
            Controls.Add(txtClave);
            Controls.Add(label2);
            Controls.Add(txtUsuario);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)axWindowsMediaPlayer1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtUsuario;
        private Label label2;
        private TextBox txtClave;
        private Button butEntrar;
        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer1;
    }
}
