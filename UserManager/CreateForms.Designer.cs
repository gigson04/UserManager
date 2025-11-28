namespace UserManager
{
    partial class CreateForms
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
            txtEmail = new TextBox();
            txtUsername = new TextBox();
            txtPassword = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            btnSave = new Button();
            label4 = new Label();
            SuspendLayout();
            // 
            // txtEmail
            // 
            txtEmail.BackColor = Color.AliceBlue;
            txtEmail.Font = new Font("Times New Roman", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtEmail.Location = new Point(152, 85);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(336, 35);
            txtEmail.TabIndex = 0;
            // 
            // txtUsername
            // 
            txtUsername.BackColor = SystemColors.MenuBar;
            txtUsername.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtUsername.Location = new Point(152, 124);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(336, 39);
            txtUsername.TabIndex = 1;
            // 
            // txtPassword
            // 
            txtPassword.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPassword.Location = new Point(152, 167);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(336, 39);
            txtPassword.TabIndex = 2;
            txtPassword.UseSystemPasswordChar = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(64, 99);
            label1.Name = "label1";
            label1.Size = new Size(44, 16);
            label1.TabIndex = 3;
            label1.Text = "Email:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Tahoma", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(64, 140);
            label2.Name = "label2";
            label2.Size = new Size(76, 16);
            label2.TabIndex = 4;
            label2.Text = "Username:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Tahoma", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(64, 184);
            label3.Name = "label3";
            label3.Size = new Size(75, 16);
            label3.TabIndex = 5;
            label3.Text = "Password:";
            // 
            // btnSave
            // 
            btnSave.BackColor = SystemColors.HotTrack;
            btnSave.Cursor = Cursors.No;
            btnSave.Font = new Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSave.ForeColor = Color.Cornsilk;
            btnSave.Location = new Point(441, 281);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(114, 35);
            btnSave.TabIndex = 6;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Tahoma", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(35, 33);
            label4.Name = "label4";
            label4.Size = new Size(174, 33);
            label4.TabIndex = 7;
            label4.Text = "Create User";
            // 
            // CreateForms
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(567, 328);
            Controls.Add(label4);
            Controls.Add(btnSave);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtPassword);
            Controls.Add(txtUsername);
            Controls.Add(txtEmail);
            Name = "CreateForms";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtEmail;
        private TextBox txtUsername;
        private TextBox txtPassword;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button btnSave;
        private Label label4;
    }
}
