namespace UserManager
{
    partial class ListForm
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
            dgViewUsers = new DataGridView();
            label1 = new Label();
            btnNew = new Button();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)dgViewUsers).BeginInit();
            SuspendLayout();
            // 
            // dgViewUsers
            // 
            dgViewUsers.BackgroundColor = SystemColors.Control;
            dgViewUsers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgViewUsers.Location = new Point(42, 54);
            dgViewUsers.Name = "dgViewUsers";
            dgViewUsers.Size = new Size(465, 231);
            dgViewUsers.TabIndex = 0;
    
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(42, 18);
            label1.Name = "label1";
            label1.Size = new Size(147, 33);
            label1.TabIndex = 1;
            label1.Text = "List Users";
            // 
            // btnNew
            // 
            btnNew.BackColor = SystemColors.ControlLightLight;
            btnNew.Cursor = Cursors.No;
            btnNew.Font = new Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnNew.ForeColor = SystemColors.ActiveCaptionText;
            btnNew.Location = new Point(393, 18);
            btnNew.Name = "btnNew";
            btnNew.Size = new Size(114, 35);
            btnNew.TabIndex = 7;
            btnNew.Text = "New";
            btnNew.UseVisualStyleBackColor = false;
            btnNew.Click += btnNew_Click;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.HotTrack;
            button1.Cursor = Cursors.No;
            button1.Font = new Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.Cornsilk;
            button1.Location = new Point(393, 291);
            button1.Name = "button1";
            button1.Size = new Size(114, 35);
            button1.TabIndex = 8;
            button1.Text = "Details";
            button1.UseVisualStyleBackColor = false;
            // 
            // ListForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(567, 328);
            Controls.Add(button1);
            Controls.Add(btnNew);
            Controls.Add(label1);
            Controls.Add(dgViewUsers);
            Name = "ListForm";
            Text = "ListForm";
            Load += ListForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgViewUsers).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgViewUsers;
        private Label label1;
        private Button btnNew;
        private Button button1;
    }
}