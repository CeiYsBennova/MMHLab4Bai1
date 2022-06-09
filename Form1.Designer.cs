namespace MMHLab31
{
    partial class Form1
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
            this.InputText = new System.Windows.Forms.TextBox();
            this.testTextBox = new System.Windows.Forms.TextBox();
            this.MD5TextBox = new System.Windows.Forms.TextBox();
            this.Sha1TextBox = new System.Windows.Forms.TextBox();
            this.Sha2TextBox = new System.Windows.Forms.TextBox();
            this.Sha384TextBox = new System.Windows.Forms.TextBox();
            this.Sha512TextBox = new System.Windows.Forms.TextBox();
            this.InputTypeComboBox = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.MD5CalButton = new System.Windows.Forms.Button();
            this.Sha1CalButton = new System.Windows.Forms.Button();
            this.Sha2CalButton = new System.Windows.Forms.Button();
            this.Sha384CalButton = new System.Windows.Forms.Button();
            this.Sha3512CalButton = new System.Windows.Forms.Button();
            this.Clearbutton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // InputText
            // 
            this.InputText.Location = new System.Drawing.Point(187, 21);
            this.InputText.Name = "InputText";
            this.InputText.Size = new System.Drawing.Size(577, 22);
            this.InputText.TabIndex = 1;
            this.InputText.TextChanged += new System.EventHandler(this.InputText_TextChanged);
            // 
            // testTextBox
            // 
            this.testTextBox.Location = new System.Drawing.Point(288, 72);
            this.testTextBox.Name = "testTextBox";
            this.testTextBox.Size = new System.Drawing.Size(476, 22);
            this.testTextBox.TabIndex = 2;
            this.testTextBox.TextChanged += new System.EventHandler(this.testTextBox_TextChanged);
            // 
            // MD5TextBox
            // 
            this.MD5TextBox.Location = new System.Drawing.Point(187, 118);
            this.MD5TextBox.Name = "MD5TextBox";
            this.MD5TextBox.ReadOnly = true;
            this.MD5TextBox.Size = new System.Drawing.Size(577, 22);
            this.MD5TextBox.TabIndex = 3;
            // 
            // Sha1TextBox
            // 
            this.Sha1TextBox.Location = new System.Drawing.Point(187, 158);
            this.Sha1TextBox.Name = "Sha1TextBox";
            this.Sha1TextBox.ReadOnly = true;
            this.Sha1TextBox.Size = new System.Drawing.Size(577, 22);
            this.Sha1TextBox.TabIndex = 4;
            // 
            // Sha2TextBox
            // 
            this.Sha2TextBox.Location = new System.Drawing.Point(187, 206);
            this.Sha2TextBox.Name = "Sha2TextBox";
            this.Sha2TextBox.ReadOnly = true;
            this.Sha2TextBox.Size = new System.Drawing.Size(577, 22);
            this.Sha2TextBox.TabIndex = 5;
            // 
            // Sha384TextBox
            // 
            this.Sha384TextBox.Location = new System.Drawing.Point(187, 256);
            this.Sha384TextBox.Name = "Sha384TextBox";
            this.Sha384TextBox.ReadOnly = true;
            this.Sha384TextBox.Size = new System.Drawing.Size(577, 22);
            this.Sha384TextBox.TabIndex = 6;
            // 
            // Sha512TextBox
            // 
            this.Sha512TextBox.Location = new System.Drawing.Point(187, 306);
            this.Sha512TextBox.Name = "Sha512TextBox";
            this.Sha512TextBox.ReadOnly = true;
            this.Sha512TextBox.Size = new System.Drawing.Size(577, 22);
            this.Sha512TextBox.TabIndex = 7;
            // 
            // InputTypeComboBox
            // 
            this.InputTypeComboBox.FormattingEnabled = true;
            this.InputTypeComboBox.Items.AddRange(new object[] {
            "Text string",
            "Hex string",
            "File"});
            this.InputTypeComboBox.Location = new System.Drawing.Point(12, 19);
            this.InputTypeComboBox.Name = "InputTypeComboBox";
            this.InputTypeComboBox.Size = new System.Drawing.Size(121, 24);
            this.InputTypeComboBox.TabIndex = 8;
            this.InputTypeComboBox.SelectedIndexChanged += new System.EventHandler(this.InputTypeComboBox_SelectedIndexChanged);
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(187, 72);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(95, 24);
            this.comboBox2.TabIndex = 9;
            // 
            // MD5CalButton
            // 
            this.MD5CalButton.Location = new System.Drawing.Point(13, 118);
            this.MD5CalButton.Name = "MD5CalButton";
            this.MD5CalButton.Size = new System.Drawing.Size(120, 23);
            this.MD5CalButton.TabIndex = 10;
            this.MD5CalButton.Text = "MD5";
            this.MD5CalButton.UseVisualStyleBackColor = true;
            this.MD5CalButton.Click += new System.EventHandler(this.MD5CalButton_Click);
            // 
            // Sha1CalButton
            // 
            this.Sha1CalButton.Location = new System.Drawing.Point(13, 157);
            this.Sha1CalButton.Name = "Sha1CalButton";
            this.Sha1CalButton.Size = new System.Drawing.Size(120, 23);
            this.Sha1CalButton.TabIndex = 11;
            this.Sha1CalButton.Text = "SHA1";
            this.Sha1CalButton.UseVisualStyleBackColor = true;
            this.Sha1CalButton.Click += new System.EventHandler(this.Sha1CalButton_Click);
            // 
            // Sha2CalButton
            // 
            this.Sha2CalButton.Location = new System.Drawing.Point(13, 205);
            this.Sha2CalButton.Name = "Sha2CalButton";
            this.Sha2CalButton.Size = new System.Drawing.Size(120, 23);
            this.Sha2CalButton.TabIndex = 12;
            this.Sha2CalButton.Text = "SHA256";
            this.Sha2CalButton.UseVisualStyleBackColor = true;
            this.Sha2CalButton.Click += new System.EventHandler(this.Sha2CalButton_Click);
            // 
            // Sha384CalButton
            // 
            this.Sha384CalButton.Location = new System.Drawing.Point(13, 256);
            this.Sha384CalButton.Name = "Sha384CalButton";
            this.Sha384CalButton.Size = new System.Drawing.Size(120, 23);
            this.Sha384CalButton.TabIndex = 13;
            this.Sha384CalButton.Text = "SHA384";
            this.Sha384CalButton.UseVisualStyleBackColor = true;
            this.Sha384CalButton.Click += new System.EventHandler(this.Sha384CalButton_Click);
            // 
            // Sha3512CalButton
            // 
            this.Sha3512CalButton.Location = new System.Drawing.Point(13, 306);
            this.Sha3512CalButton.Name = "Sha3512CalButton";
            this.Sha3512CalButton.Size = new System.Drawing.Size(120, 23);
            this.Sha3512CalButton.TabIndex = 14;
            this.Sha3512CalButton.Text = "SHA3-512";
            this.Sha3512CalButton.UseVisualStyleBackColor = true;
            this.Sha3512CalButton.Click += new System.EventHandler(this.Sha512CalButton_Click);
            // 
            // Clearbutton
            // 
            this.Clearbutton.Location = new System.Drawing.Point(644, 363);
            this.Clearbutton.Name = "Clearbutton";
            this.Clearbutton.Size = new System.Drawing.Size(120, 23);
            this.Clearbutton.TabIndex = 15;
            this.Clearbutton.Text = "Clear";
            this.Clearbutton.UseVisualStyleBackColor = true;
            this.Clearbutton.Click += new System.EventHandler(this.Clearbutton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 411);
            this.Controls.Add(this.Clearbutton);
            this.Controls.Add(this.Sha3512CalButton);
            this.Controls.Add(this.Sha384CalButton);
            this.Controls.Add(this.Sha2CalButton);
            this.Controls.Add(this.Sha1CalButton);
            this.Controls.Add(this.MD5CalButton);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.InputTypeComboBox);
            this.Controls.Add(this.Sha512TextBox);
            this.Controls.Add(this.Sha384TextBox);
            this.Controls.Add(this.Sha2TextBox);
            this.Controls.Add(this.Sha1TextBox);
            this.Controls.Add(this.MD5TextBox);
            this.Controls.Add(this.testTextBox);
            this.Controls.Add(this.InputText);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox InputText;
        private System.Windows.Forms.TextBox testTextBox;
        private System.Windows.Forms.TextBox MD5TextBox;
        private System.Windows.Forms.TextBox Sha1TextBox;
        private System.Windows.Forms.TextBox Sha2TextBox;
        private System.Windows.Forms.TextBox Sha384TextBox;
        private System.Windows.Forms.TextBox Sha512TextBox;
        private System.Windows.Forms.ComboBox InputTypeComboBox;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Button MD5CalButton;
        private System.Windows.Forms.Button Sha1CalButton;
        private System.Windows.Forms.Button Sha2CalButton;
        private System.Windows.Forms.Button Sha384CalButton;
        private System.Windows.Forms.Button Sha3512CalButton;
        private System.Windows.Forms.Button Clearbutton;
    }
}

