namespace TextFileChallengeApp
{
    partial class TextFileChallenge
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
            this.saveListButton = new System.Windows.Forms.Button();
            this.addUserButton = new System.Windows.Forms.Button();
            this.isAliveCheckbox = new System.Windows.Forms.CheckBox();
            this.isAliveLabel = new System.Windows.Forms.Label();
            this.ageNumbericUpDown = new System.Windows.Forms.NumericUpDown();
            this.ageLabel = new System.Windows.Forms.Label();
            this.lastNameTextbox = new System.Windows.Forms.TextBox();
            this.lastNameLabel = new System.Windows.Forms.Label();
            this.firstNameTextbox = new System.Windows.Forms.TextBox();
            this.firstNameLabel = new System.Windows.Forms.Label();
            this.usersListBox = new System.Windows.Forms.ListBox();
            this.headerLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ageNumbericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // saveListButton
            // 
            this.saveListButton.Location = new System.Drawing.Point(43, 456);
            this.saveListButton.Name = "saveListButton";
            this.saveListButton.Size = new System.Drawing.Size(390, 64);
            this.saveListButton.TabIndex = 23;
            this.saveListButton.Text = "Save List";
            this.saveListButton.UseVisualStyleBackColor = true;
            // 
            // addUserButton
            // 
            this.addUserButton.Location = new System.Drawing.Point(43, 386);
            this.addUserButton.Name = "addUserButton";
            this.addUserButton.Size = new System.Drawing.Size(390, 64);
            this.addUserButton.TabIndex = 22;
            this.addUserButton.Text = "Add User";
            this.addUserButton.UseVisualStyleBackColor = true;
            // 
            // isAliveCheckbox
            // 
            this.isAliveCheckbox.AutoSize = true;
            this.isAliveCheckbox.Location = new System.Drawing.Point(197, 325);
            this.isAliveCheckbox.Name = "isAliveCheckbox";
            this.isAliveCheckbox.Size = new System.Drawing.Size(18, 17);
            this.isAliveCheckbox.TabIndex = 21;
            this.isAliveCheckbox.UseVisualStyleBackColor = true;
            // 
            // isAliveLabel
            // 
            this.isAliveLabel.AutoSize = true;
            this.isAliveLabel.Location = new System.Drawing.Point(43, 315);
            this.isAliveLabel.Name = "isAliveLabel";
            this.isAliveLabel.Size = new System.Drawing.Size(56, 17);
            this.isAliveLabel.TabIndex = 20;
            this.isAliveLabel.Text = "Is Alive:";
            // 
            // ageNumbericUpDown
            // 
            this.ageNumbericUpDown.Location = new System.Drawing.Point(197, 249);
            this.ageNumbericUpDown.Name = "ageNumbericUpDown";
            this.ageNumbericUpDown.Size = new System.Drawing.Size(89, 22);
            this.ageNumbericUpDown.TabIndex = 19;
            // 
            // ageLabel
            // 
            this.ageLabel.AutoSize = true;
            this.ageLabel.Location = new System.Drawing.Point(43, 251);
            this.ageLabel.Name = "ageLabel";
            this.ageLabel.Size = new System.Drawing.Size(37, 17);
            this.ageLabel.TabIndex = 18;
            this.ageLabel.Text = "Age:";
            // 
            // lastNameTextbox
            // 
            this.lastNameTextbox.Location = new System.Drawing.Point(197, 182);
            this.lastNameTextbox.Name = "lastNameTextbox";
            this.lastNameTextbox.Size = new System.Drawing.Size(236, 22);
            this.lastNameTextbox.TabIndex = 17;
            // 
            // lastNameLabel
            // 
            this.lastNameLabel.AutoSize = true;
            this.lastNameLabel.Location = new System.Drawing.Point(43, 185);
            this.lastNameLabel.Name = "lastNameLabel";
            this.lastNameLabel.Size = new System.Drawing.Size(80, 17);
            this.lastNameLabel.TabIndex = 16;
            this.lastNameLabel.Text = "Last Name:";
            // 
            // firstNameTextbox
            // 
            this.firstNameTextbox.Location = new System.Drawing.Point(197, 117);
            this.firstNameTextbox.Name = "firstNameTextbox";
            this.firstNameTextbox.Size = new System.Drawing.Size(236, 22);
            this.firstNameTextbox.TabIndex = 15;
            // 
            // firstNameLabel
            // 
            this.firstNameLabel.AutoSize = true;
            this.firstNameLabel.Location = new System.Drawing.Point(43, 120);
            this.firstNameLabel.Name = "firstNameLabel";
            this.firstNameLabel.Size = new System.Drawing.Size(80, 17);
            this.firstNameLabel.TabIndex = 14;
            this.firstNameLabel.Text = "First Name:";
            // 
            // usersListBox
            // 
            this.usersListBox.FormattingEnabled = true;
            this.usersListBox.ItemHeight = 16;
            this.usersListBox.Location = new System.Drawing.Point(474, 120);
            this.usersListBox.Name = "usersListBox";
            this.usersListBox.Size = new System.Drawing.Size(405, 388);
            this.usersListBox.TabIndex = 13;
            // 
            // headerLabel
            // 
            this.headerLabel.AutoSize = true;
            this.headerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.headerLabel.Location = new System.Drawing.Point(35, 29);
            this.headerLabel.Name = "headerLabel";
            this.headerLabel.Size = new System.Drawing.Size(546, 69);
            this.headerLabel.TabIndex = 12;
            this.headerLabel.Text = "Text File Challenge";
            // 
            // TextFileChallenge
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(914, 549);
            this.Controls.Add(this.saveListButton);
            this.Controls.Add(this.addUserButton);
            this.Controls.Add(this.isAliveCheckbox);
            this.Controls.Add(this.isAliveLabel);
            this.Controls.Add(this.ageNumbericUpDown);
            this.Controls.Add(this.ageLabel);
            this.Controls.Add(this.lastNameTextbox);
            this.Controls.Add(this.lastNameLabel);
            this.Controls.Add(this.firstNameTextbox);
            this.Controls.Add(this.firstNameLabel);
            this.Controls.Add(this.usersListBox);
            this.Controls.Add(this.headerLabel);
            this.Name = "TextFileChallenge";
            this.Text = "Text File Challenge by Tim Corey";
            ((System.ComponentModel.ISupportInitialize)(this.ageNumbericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button saveListButton;
        private System.Windows.Forms.Button addUserButton;
        private System.Windows.Forms.CheckBox isAliveCheckbox;
        private System.Windows.Forms.Label isAliveLabel;
        private System.Windows.Forms.NumericUpDown ageNumbericUpDown;
        private System.Windows.Forms.Label ageLabel;
        private System.Windows.Forms.TextBox lastNameTextbox;
        private System.Windows.Forms.Label lastNameLabel;
        private System.Windows.Forms.TextBox firstNameTextbox;
        private System.Windows.Forms.Label firstNameLabel;
        private System.Windows.Forms.ListBox usersListBox;
        private System.Windows.Forms.Label headerLabel;
    }
}

