namespace marathon_skills_2021.forms
{
    partial class FormAuth
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAuth));
            this.pictureBoxBackGround = new System.Windows.Forms.PictureBox();
            this.labelMarathon = new System.Windows.Forms.Label();
            this.pictureBoxTimer = new System.Windows.Forms.PictureBox();
            this.labelBefore = new System.Windows.Forms.Label();
            this.labelTimer = new System.Windows.Forms.Label();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.labelPlease = new System.Windows.Forms.Label();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.labelPassword = new System.Windows.Forms.Label();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.labelEmail = new System.Windows.Forms.Label();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonLogin = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBackGround)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTimer)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxBackGround
            // 
            this.pictureBoxBackGround.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.pictureBoxBackGround.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxBackGround.Name = "pictureBoxBackGround";
            this.pictureBoxBackGround.Size = new System.Drawing.Size(790, 50);
            this.pictureBoxBackGround.TabIndex = 0;
            this.pictureBoxBackGround.TabStop = false;
            // 
            // labelMarathon
            // 
            this.labelMarathon.AutoSize = true;
            this.labelMarathon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.labelMarathon.Font = new System.Drawing.Font("Rockwell", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMarathon.ForeColor = System.Drawing.Color.White;
            this.labelMarathon.Location = new System.Drawing.Point(405, 9);
            this.labelMarathon.Name = "labelMarathon";
            this.labelMarathon.Size = new System.Drawing.Size(357, 35);
            this.labelMarathon.TabIndex = 1;
            this.labelMarathon.Text = "MARATHON SKILLS 2021";
            // 
            // pictureBoxTimer
            // 
            this.pictureBoxTimer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.pictureBoxTimer.Location = new System.Drawing.Point(0, 450);
            this.pictureBoxTimer.Name = "pictureBoxTimer";
            this.pictureBoxTimer.Size = new System.Drawing.Size(790, 60);
            this.pictureBoxTimer.TabIndex = 3;
            this.pictureBoxTimer.TabStop = false;
            // 
            // labelBefore
            // 
            this.labelBefore.AutoSize = true;
            this.labelBefore.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.labelBefore.Font = new System.Drawing.Font("Rockwell", 22F);
            this.labelBefore.ForeColor = System.Drawing.Color.White;
            this.labelBefore.Location = new System.Drawing.Point(10, 457);
            this.labelBefore.Name = "labelBefore";
            this.labelBefore.Size = new System.Drawing.Size(234, 35);
            this.labelBefore.TabIndex = 4;
            this.labelBefore.Text = "Before the start:";
            // 
            // labelTimer
            // 
            this.labelTimer.AutoSize = true;
            this.labelTimer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.labelTimer.Font = new System.Drawing.Font("Rockwell", 22F);
            this.labelTimer.ForeColor = System.Drawing.Color.White;
            this.labelTimer.Location = new System.Drawing.Point(250, 457);
            this.labelTimer.Name = "labelTimer";
            this.labelTimer.Size = new System.Drawing.Size(0, 35);
            this.labelTimer.TabIndex = 5;
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // labelPlease
            // 
            this.labelPlease.AutoSize = true;
            this.labelPlease.BackColor = System.Drawing.SystemColors.Control;
            this.labelPlease.Font = new System.Drawing.Font("Rockwell", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPlease.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.labelPlease.Location = new System.Drawing.Point(6, 156);
            this.labelPlease.Name = "labelPlease";
            this.labelPlease.Size = new System.Drawing.Size(763, 27);
            this.labelPlease.TabIndex = 76;
            this.labelPlease.Text = "Please log in to the system using your email address and password.\r\n";
            this.labelPlease.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Location = new System.Drawing.Point(302, 248);
            this.textBoxPassword.Margin = new System.Windows.Forms.Padding(5);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.Size = new System.Drawing.Size(214, 23);
            this.textBoxPassword.TabIndex = 81;
            this.textBoxPassword.WordWrap = false;
            // 
            // labelPassword
            // 
            this.labelPassword.AutoSize = true;
            this.labelPassword.Font = new System.Drawing.Font("Rockwell", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.labelPassword.Location = new System.Drawing.Point(187, 248);
            this.labelPassword.Margin = new System.Windows.Forms.Padding(5);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(109, 23);
            this.labelPassword.TabIndex = 80;
            this.labelPassword.Text = "Password:";
            this.labelPassword.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.Location = new System.Drawing.Point(302, 215);
            this.textBoxEmail.Margin = new System.Windows.Forms.Padding(5);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(214, 23);
            this.textBoxEmail.TabIndex = 79;
            this.textBoxEmail.WordWrap = false;
            // 
            // labelEmail
            // 
            this.labelEmail.AutoSize = true;
            this.labelEmail.Font = new System.Drawing.Font("Rockwell", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.labelEmail.Location = new System.Drawing.Point(226, 215);
            this.labelEmail.Margin = new System.Windows.Forms.Padding(5);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(70, 23);
            this.labelEmail.TabIndex = 78;
            this.labelEmail.Text = "Email:";
            this.labelEmail.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonCancel
            // 
            this.buttonCancel.AutoEllipsis = true;
            this.buttonCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCancel.Font = new System.Drawing.Font("Rockwell", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCancel.ForeColor = System.Drawing.Color.White;
            this.buttonCancel.Location = new System.Drawing.Point(389, 300);
            this.buttonCancel.Margin = new System.Windows.Forms.Padding(4);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(140, 48);
            this.buttonCancel.TabIndex = 83;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = false;
            this.buttonCancel.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // buttonLogin
            // 
            this.buttonLogin.AutoEllipsis = true;
            this.buttonLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLogin.Font = new System.Drawing.Font("Rockwell", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLogin.ForeColor = System.Drawing.Color.White;
            this.buttonLogin.Location = new System.Drawing.Point(235, 300);
            this.buttonLogin.Margin = new System.Windows.Forms.Padding(4);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new System.Drawing.Size(140, 48);
            this.buttonLogin.TabIndex = 82;
            this.buttonLogin.Text = "Login";
            this.buttonLogin.UseVisualStyleBackColor = false;
            this.buttonLogin.Click += new System.EventHandler(this.buttonLogin_Click);
            // 
            // FormAuth
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(774, 501);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonLogin);
            this.Controls.Add(this.textBoxPassword);
            this.Controls.Add(this.labelPassword);
            this.Controls.Add(this.textBoxEmail);
            this.Controls.Add(this.labelEmail);
            this.Controls.Add(this.labelPlease);
            this.Controls.Add(this.labelTimer);
            this.Controls.Add(this.labelBefore);
            this.Controls.Add(this.pictureBoxTimer);
            this.Controls.Add(this.labelMarathon);
            this.Controls.Add(this.pictureBoxBackGround);
            this.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(790, 540);
            this.MinimumSize = new System.Drawing.Size(790, 540);
            this.Name = "FormAuth";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Marathon 2021 - Authorization";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormAuth_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBackGround)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTimer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxBackGround;
        private System.Windows.Forms.Label labelMarathon;
        private System.Windows.Forms.PictureBox pictureBoxTimer;
        private System.Windows.Forms.Label labelBefore;
        private System.Windows.Forms.Label labelTimer;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Label labelPlease;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.Label labelPassword;
        private System.Windows.Forms.TextBox textBoxEmail;
        private System.Windows.Forms.Label labelEmail;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonLogin;
    }
}

