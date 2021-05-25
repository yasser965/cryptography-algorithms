namespace cryptography
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
            this.txt_input = new System.Windows.Forms.TextBox();
            this.btn_one = new System.Windows.Forms.Button();
            this.txt_output = new System.Windows.Forms.TextBox();
            this.cipher_title = new System.Windows.Forms.Label();
            this.txt_key = new System.Windows.Forms.TextBox();
            this.lbl_plain = new System.Windows.Forms.Label();
            this.lbl_key = new System.Windows.Forms.Label();
            this.lbl_cipher = new System.Windows.Forms.Label();
            this.railfence_title = new System.Windows.Forms.Label();
            this.btn_two = new System.Windows.Forms.Button();
            this.des_input = new System.Windows.Forms.TextBox();
            this.des_output = new System.Windows.Forms.TextBox();
            this.des_key = new System.Windows.Forms.TextBox();
            this.rsa_input = new System.Windows.Forms.TextBox();
            this.rsa_title = new System.Windows.Forms.Label();
            this.btn_three = new System.Windows.Forms.Button();
            this.rsa_output = new System.Windows.Forms.TextBox();
            this.rfence_title = new System.Windows.Forms.Label();
            this.rfence_input = new System.Windows.Forms.TextBox();
            this.btn_four = new System.Windows.Forms.Button();
            this.rfence_output = new System.Windows.Forms.TextBox();
            this.btn_caeser_decrypt = new System.Windows.Forms.Button();
            this.btn_des_decrypt = new System.Windows.Forms.Button();
            this.btn_rsa_decrypt = new System.Windows.Forms.Button();
            this.btn_rf_decrypt = new System.Windows.Forms.Button();
            this.caeser_decrypted = new System.Windows.Forms.TextBox();
            this.des_decrypted = new System.Windows.Forms.TextBox();
            this.rsa_decrypted = new System.Windows.Forms.TextBox();
            this.rf_decrypted = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txt_input
            // 
            this.txt_input.Location = new System.Drawing.Point(118, 99);
            this.txt_input.Name = "txt_input";
            this.txt_input.Size = new System.Drawing.Size(100, 23);
            this.txt_input.TabIndex = 0;
            this.txt_input.TextChanged += new System.EventHandler(this.txt_input_TextChanged);
            // 
            // btn_one
            // 
            this.btn_one.Location = new System.Drawing.Point(130, 196);
            this.btn_one.Name = "btn_one";
            this.btn_one.Size = new System.Drawing.Size(75, 23);
            this.btn_one.TabIndex = 2;
            this.btn_one.Text = "Encrypt";
            this.btn_one.UseVisualStyleBackColor = true;
            this.btn_one.Click += new System.EventHandler(this.btn_one_Click);
            // 
            // txt_output
            // 
            this.txt_output.Location = new System.Drawing.Point(118, 235);
            this.txt_output.Name = "txt_output";
            this.txt_output.Size = new System.Drawing.Size(100, 23);
            this.txt_output.TabIndex = 3;
            // 
            // cipher_title
            // 
            this.cipher_title.AutoSize = true;
            this.cipher_title.Location = new System.Drawing.Point(130, 64);
            this.cipher_title.Name = "cipher_title";
            this.cipher_title.Size = new System.Drawing.Size(76, 15);
            this.cipher_title.TabIndex = 4;
            this.cipher_title.Text = "caeser cipher";
            // 
            // txt_key
            // 
            this.txt_key.Location = new System.Drawing.Point(118, 152);
            this.txt_key.Name = "txt_key";
            this.txt_key.Size = new System.Drawing.Size(100, 23);
            this.txt_key.TabIndex = 5;
            // 
            // lbl_plain
            // 
            this.lbl_plain.AutoSize = true;
            this.lbl_plain.Location = new System.Drawing.Point(47, 102);
            this.lbl_plain.Name = "lbl_plain";
            this.lbl_plain.Size = new System.Drawing.Size(56, 15);
            this.lbl_plain.TabIndex = 6;
            this.lbl_plain.Text = "plain text";
            this.lbl_plain.Click += new System.EventHandler(this.label2_Click);
            // 
            // lbl_key
            // 
            this.lbl_key.AutoSize = true;
            this.lbl_key.Location = new System.Drawing.Point(47, 152);
            this.lbl_key.Name = "lbl_key";
            this.lbl_key.Size = new System.Drawing.Size(25, 15);
            this.lbl_key.TabIndex = 7;
            this.lbl_key.Text = "key";
            // 
            // lbl_cipher
            // 
            this.lbl_cipher.AutoSize = true;
            this.lbl_cipher.Location = new System.Drawing.Point(47, 238);
            this.lbl_cipher.Name = "lbl_cipher";
            this.lbl_cipher.Size = new System.Drawing.Size(63, 15);
            this.lbl_cipher.TabIndex = 8;
            this.lbl_cipher.Text = "cipher text";
            // 
            // railfence_title
            // 
            this.railfence_title.AutoSize = true;
            this.railfence_title.Location = new System.Drawing.Point(325, 65);
            this.railfence_title.Name = "railfence_title";
            this.railfence_title.Size = new System.Drawing.Size(27, 15);
            this.railfence_title.TabIndex = 9;
            this.railfence_title.Text = "DES";
            // 
            // btn_two
            // 
            this.btn_two.Location = new System.Drawing.Point(309, 197);
            this.btn_two.Name = "btn_two";
            this.btn_two.Size = new System.Drawing.Size(75, 23);
            this.btn_two.TabIndex = 10;
            this.btn_two.Text = "Encrypt";
            this.btn_two.UseVisualStyleBackColor = true;
            this.btn_two.Click += new System.EventHandler(this.button1_Click);
            // 
            // des_input
            // 
            this.des_input.Location = new System.Drawing.Point(295, 99);
            this.des_input.Name = "des_input";
            this.des_input.Size = new System.Drawing.Size(100, 23);
            this.des_input.TabIndex = 11;
            // 
            // des_output
            // 
            this.des_output.Location = new System.Drawing.Point(295, 236);
            this.des_output.Name = "des_output";
            this.des_output.Size = new System.Drawing.Size(100, 23);
            this.des_output.TabIndex = 12;
            // 
            // des_key
            // 
            this.des_key.Location = new System.Drawing.Point(295, 153);
            this.des_key.Name = "des_key";
            this.des_key.Size = new System.Drawing.Size(100, 23);
            this.des_key.TabIndex = 13;
            // 
            // rsa_input
            // 
            this.rsa_input.Location = new System.Drawing.Point(470, 99);
            this.rsa_input.Name = "rsa_input";
            this.rsa_input.Size = new System.Drawing.Size(100, 23);
            this.rsa_input.TabIndex = 14;
            // 
            // rsa_title
            // 
            this.rsa_title.AutoSize = true;
            this.rsa_title.Location = new System.Drawing.Point(496, 66);
            this.rsa_title.Name = "rsa_title";
            this.rsa_title.Size = new System.Drawing.Size(28, 15);
            this.rsa_title.TabIndex = 15;
            this.rsa_title.Text = "RSA";
            // 
            // btn_three
            // 
            this.btn_three.Location = new System.Drawing.Point(483, 198);
            this.btn_three.Name = "btn_three";
            this.btn_three.Size = new System.Drawing.Size(75, 23);
            this.btn_three.TabIndex = 16;
            this.btn_three.Text = "Encrypt";
            this.btn_three.UseVisualStyleBackColor = true;
            this.btn_three.Click += new System.EventHandler(this.btn_three_Click);
            // 
            // rsa_output
            // 
            this.rsa_output.Location = new System.Drawing.Point(470, 237);
            this.rsa_output.Name = "rsa_output";
            this.rsa_output.Size = new System.Drawing.Size(100, 23);
            this.rsa_output.TabIndex = 17;
            // 
            // rfence_title
            // 
            this.rfence_title.AutoSize = true;
            this.rfence_title.Location = new System.Drawing.Point(660, 66);
            this.rfence_title.Name = "rfence_title";
            this.rfence_title.Size = new System.Drawing.Size(55, 15);
            this.rfence_title.TabIndex = 18;
            this.rfence_title.Text = "rail fence";
            // 
            // rfence_input
            // 
            this.rfence_input.Location = new System.Drawing.Point(639, 99);
            this.rfence_input.Name = "rfence_input";
            this.rfence_input.Size = new System.Drawing.Size(100, 23);
            this.rfence_input.TabIndex = 19;
            // 
            // btn_four
            // 
            this.btn_four.Location = new System.Drawing.Point(653, 198);
            this.btn_four.Name = "btn_four";
            this.btn_four.Size = new System.Drawing.Size(75, 23);
            this.btn_four.TabIndex = 20;
            this.btn_four.Text = "Encrypt";
            this.btn_four.UseVisualStyleBackColor = true;
            this.btn_four.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // rfence_output
            // 
            this.rfence_output.Location = new System.Drawing.Point(639, 232);
            this.rfence_output.Name = "rfence_output";
            this.rfence_output.Size = new System.Drawing.Size(100, 23);
            this.rfence_output.TabIndex = 21;
            // 
            // btn_caeser_decrypt
            // 
            this.btn_caeser_decrypt.Location = new System.Drawing.Point(130, 305);
            this.btn_caeser_decrypt.Name = "btn_caeser_decrypt";
            this.btn_caeser_decrypt.Size = new System.Drawing.Size(75, 23);
            this.btn_caeser_decrypt.TabIndex = 22;
            this.btn_caeser_decrypt.Text = "decrypt";
            this.btn_caeser_decrypt.UseVisualStyleBackColor = true;
            this.btn_caeser_decrypt.Click += new System.EventHandler(this.btn_caeser_decrypt_Click);
            // 
            // btn_des_decrypt
            // 
            this.btn_des_decrypt.Location = new System.Drawing.Point(309, 305);
            this.btn_des_decrypt.Name = "btn_des_decrypt";
            this.btn_des_decrypt.Size = new System.Drawing.Size(75, 23);
            this.btn_des_decrypt.TabIndex = 23;
            this.btn_des_decrypt.Text = "decrypt";
            this.btn_des_decrypt.UseVisualStyleBackColor = true;
            this.btn_des_decrypt.Click += new System.EventHandler(this.btn_des_decrypt_Click);
            // 
            // btn_rsa_decrypt
            // 
            this.btn_rsa_decrypt.Location = new System.Drawing.Point(483, 305);
            this.btn_rsa_decrypt.Name = "btn_rsa_decrypt";
            this.btn_rsa_decrypt.Size = new System.Drawing.Size(75, 23);
            this.btn_rsa_decrypt.TabIndex = 24;
            this.btn_rsa_decrypt.Text = "decrypt";
            this.btn_rsa_decrypt.UseVisualStyleBackColor = true;
            this.btn_rsa_decrypt.Click += new System.EventHandler(this.btn_rsa_decrypt_Click);
            // 
            // btn_rf_decrypt
            // 
            this.btn_rf_decrypt.Location = new System.Drawing.Point(653, 304);
            this.btn_rf_decrypt.Name = "btn_rf_decrypt";
            this.btn_rf_decrypt.Size = new System.Drawing.Size(75, 23);
            this.btn_rf_decrypt.TabIndex = 25;
            this.btn_rf_decrypt.Text = "decrypt";
            this.btn_rf_decrypt.UseVisualStyleBackColor = true;
            this.btn_rf_decrypt.Click += new System.EventHandler(this.btn_rf_decrypt_Click);
            // 
            // caeser_decrypted
            // 
            this.caeser_decrypted.Location = new System.Drawing.Point(118, 365);
            this.caeser_decrypted.Name = "caeser_decrypted";
            this.caeser_decrypted.Size = new System.Drawing.Size(100, 23);
            this.caeser_decrypted.TabIndex = 26;
            // 
            // des_decrypted
            // 
            this.des_decrypted.Location = new System.Drawing.Point(295, 364);
            this.des_decrypted.Name = "des_decrypted";
            this.des_decrypted.Size = new System.Drawing.Size(100, 23);
            this.des_decrypted.TabIndex = 27;
            // 
            // rsa_decrypted
            // 
            this.rsa_decrypted.Location = new System.Drawing.Point(470, 364);
            this.rsa_decrypted.Name = "rsa_decrypted";
            this.rsa_decrypted.Size = new System.Drawing.Size(100, 23);
            this.rsa_decrypted.TabIndex = 28;
            // 
            // rf_decrypted
            // 
            this.rf_decrypted.Location = new System.Drawing.Point(639, 363);
            this.rf_decrypted.Name = "rf_decrypted";
            this.rf_decrypted.Size = new System.Drawing.Size(100, 23);
            this.rf_decrypted.TabIndex = 29;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(47, 367);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 15);
            this.label1.TabIndex = 30;
            this.label1.Text = "plain text";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(262, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(227, 15);
            this.label2.TabIndex = 31;
            this.label2.Text = "Tanta university - network security project";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rf_decrypted);
            this.Controls.Add(this.rsa_decrypted);
            this.Controls.Add(this.des_decrypted);
            this.Controls.Add(this.caeser_decrypted);
            this.Controls.Add(this.btn_rf_decrypt);
            this.Controls.Add(this.btn_rsa_decrypt);
            this.Controls.Add(this.btn_des_decrypt);
            this.Controls.Add(this.btn_caeser_decrypt);
            this.Controls.Add(this.rfence_output);
            this.Controls.Add(this.btn_four);
            this.Controls.Add(this.rfence_input);
            this.Controls.Add(this.rfence_title);
            this.Controls.Add(this.rsa_output);
            this.Controls.Add(this.btn_three);
            this.Controls.Add(this.rsa_title);
            this.Controls.Add(this.rsa_input);
            this.Controls.Add(this.des_key);
            this.Controls.Add(this.des_output);
            this.Controls.Add(this.des_input);
            this.Controls.Add(this.btn_two);
            this.Controls.Add(this.railfence_title);
            this.Controls.Add(this.lbl_cipher);
            this.Controls.Add(this.lbl_key);
            this.Controls.Add(this.lbl_plain);
            this.Controls.Add(this.txt_key);
            this.Controls.Add(this.cipher_title);
            this.Controls.Add(this.txt_output);
            this.Controls.Add(this.btn_one);
            this.Controls.Add(this.txt_input);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_input;
        private System.Windows.Forms.Button btn_one;
        private System.Windows.Forms.TextBox txt_output;
        private System.Windows.Forms.Label cipher_title;
        private System.Windows.Forms.TextBox txt_key;
        private System.Windows.Forms.Label lbl_plain;
        private System.Windows.Forms.Label lbl_key;
        private System.Windows.Forms.Label lbl_cipher;
        private System.Windows.Forms.Label railfence_title;
        private System.Windows.Forms.Button btn_two;
        private System.Windows.Forms.TextBox des_input;
        private System.Windows.Forms.TextBox des_output;
        private System.Windows.Forms.TextBox des_key;
        private System.Windows.Forms.TextBox rsa_input;
        private System.Windows.Forms.Label rsa_title;
        private System.Windows.Forms.Button btn_three;
        private System.Windows.Forms.TextBox rsa_output;
        private System.Windows.Forms.Label rfence_title;
        private System.Windows.Forms.TextBox rfence_input;
        private System.Windows.Forms.Button btn_four;
        private System.Windows.Forms.TextBox rfence_output;
        private System.Windows.Forms.Button btn_caeser_decrypt;
        private System.Windows.Forms.Button btn_des_decrypt;
        private System.Windows.Forms.Button btn_rsa_decrypt;
        private System.Windows.Forms.Button btn_rf_decrypt;
        private System.Windows.Forms.TextBox caeser_decrypted;
        private System.Windows.Forms.TextBox des_decrypted;
        private System.Windows.Forms.TextBox rsa_decrypted;
        private System.Windows.Forms.TextBox rf_decrypted;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

