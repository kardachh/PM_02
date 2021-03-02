namespace marathon_skills_2021.forms
{
    partial class FormRunnerMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormRunnerMenu));
            this.pictureBoxBackGround = new System.Windows.Forms.PictureBox();
            this.labelMarathon = new System.Windows.Forms.Label();
            this.pictureBoxTimer = new System.Windows.Forms.PictureBox();
            this.labelBefore = new System.Windows.Forms.Label();
            this.labelTimer = new System.Windows.Forms.Label();
            this.buttonBack = new System.Windows.Forms.Button();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.labelRunnerRegistration = new System.Windows.Forms.Label();
            this.buttonRegistration = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.buttonListOfCharities = new System.Windows.Forms.Button();
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
            // buttonBack
            // 
            this.buttonBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonBack.Font = new System.Drawing.Font("Rockwell", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBack.ForeColor = System.Drawing.Color.White;
            this.buttonBack.Location = new System.Drawing.Point(13, 6);
            this.buttonBack.Margin = new System.Windows.Forms.Padding(4);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(99, 35);
            this.buttonBack.TabIndex = 8;
            this.buttonBack.Text = "< Back";
            this.buttonBack.UseVisualStyleBackColor = false;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // labelRunnerRegistration
            // 
            this.labelRunnerRegistration.AutoSize = true;
            this.labelRunnerRegistration.Font = new System.Drawing.Font("Rockwell", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRunnerRegistration.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.labelRunnerRegistration.Location = new System.Drawing.Point(300, 103);
            this.labelRunnerRegistration.Name = "labelRunnerRegistration";
            this.labelRunnerRegistration.Size = new System.Drawing.Size(177, 31);
            this.labelRunnerRegistration.TabIndex = 94;
            this.labelRunnerRegistration.Text = "Runner Menu";
            this.labelRunnerRegistration.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonRegistration
            // 
            this.buttonRegistration.AutoEllipsis = true;
            this.buttonRegistration.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonRegistration.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRegistration.Font = new System.Drawing.Font("Rockwell", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRegistration.ForeColor = System.Drawing.Color.White;
            this.buttonRegistration.Location = new System.Drawing.Point(16, 166);
            this.buttonRegistration.Margin = new System.Windows.Forms.Padding(4);
            this.buttonRegistration.Name = "buttonRegistration";
            this.buttonRegistration.Size = new System.Drawing.Size(370, 50);
            this.buttonRegistration.TabIndex = 95;
            this.buttonRegistration.Text = "Registration for the marathon";
            this.buttonRegistration.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.AutoEllipsis = true;
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Rockwell", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(16, 224);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(370, 50);
            this.button1.TabIndex = 95;
            this.button1.Text = "Editing a profile";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.AutoEllipsis = true;
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Rockwell", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(197, 282);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(370, 50);
            this.button2.TabIndex = 95;
            this.button2.Text = "Contacts";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            this.button3.AutoEllipsis = true;
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Rockwell", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(391, 166);
            this.button3.Margin = new System.Windows.Forms.Padding(4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(370, 50);
            this.button3.TabIndex = 95;
            this.button3.Text = "My results";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // buttonListOfCharities
            // 
            this.buttonListOfCharities.AutoEllipsis = true;
            this.buttonListOfCharities.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonListOfCharities.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonListOfCharities.Font = new System.Drawing.Font("Rockwell", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonListOfCharities.ForeColor = System.Drawing.Color.White;
            this.buttonListOfCharities.Location = new System.Drawing.Point(391, 224);
            this.buttonListOfCharities.Margin = new System.Windows.Forms.Padding(4);
            this.buttonListOfCharities.Name = "buttonListOfCharities";
            this.buttonListOfCharities.Size = new System.Drawing.Size(370, 50);
            this.buttonListOfCharities.TabIndex = 95;
            this.buttonListOfCharities.Text = "My sponsor";
            this.buttonListOfCharities.UseVisualStyleBackColor = false;
            // 
            // FormRunnerMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(774, 501);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.buttonListOfCharities);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.buttonRegistration);
            this.Controls.Add(this.labelRunnerRegistration);
            this.Controls.Add(this.buttonBack);
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
            this.Name = "FormRunnerMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Marathon 2021 - Runner Menu";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormAbout_FormClosed);
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
        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Label labelRunnerRegistration;
        private System.Windows.Forms.Button buttonRegistration;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button buttonListOfCharities;
    }
}

