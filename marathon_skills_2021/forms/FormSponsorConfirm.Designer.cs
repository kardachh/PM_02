namespace marathon_skills_2021.forms
{
    partial class FormSponsorConfirm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSponsorConfirm));
            this.pictureBoxBackGround = new System.Windows.Forms.PictureBox();
            this.labelMarathon = new System.Windows.Forms.Label();
            this.pictureBoxTimer = new System.Windows.Forms.PictureBox();
            this.labelBefore = new System.Windows.Forms.Label();
            this.labelTimer = new System.Windows.Forms.Label();
            this.buttonBack = new System.Windows.Forms.Button();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.labelRunnerRegistration = new System.Windows.Forms.Label();
            this.labelPlease = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
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
            this.labelRunnerRegistration.Location = new System.Drawing.Point(191, 105);
            this.labelRunnerRegistration.Name = "labelRunnerRegistration";
            this.labelRunnerRegistration.Size = new System.Drawing.Size(368, 31);
            this.labelRunnerRegistration.TabIndex = 78;
            this.labelRunnerRegistration.Text = "Thanks for your sponsorship!";
            this.labelRunnerRegistration.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelPlease
            // 
            this.labelPlease.AutoSize = true;
            this.labelPlease.Font = new System.Drawing.Font("Rockwell", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPlease.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.labelPlease.Location = new System.Drawing.Point(101, 145);
            this.labelPlease.Name = "labelPlease";
            this.labelPlease.Size = new System.Drawing.Size(589, 23);
            this.labelPlease.TabIndex = 79;
            this.labelPlease.Text = "Thank you for supporting the runner in Marathon Skills 2021!";
            this.labelPlease.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Rockwell", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(252, 181);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 23);
            this.label1.TabIndex = 80;
            this.label1.Text = "Runner";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Rockwell", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label2.Location = new System.Drawing.Point(252, 220);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 23);
            this.label2.TabIndex = 81;
            this.label2.Text = "Charity";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Rockwell", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label3.Location = new System.Drawing.Point(405, 263);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 32);
            this.label3.TabIndex = 82;
            this.label3.Text = "$";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FormSponsorConfirm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(774, 501);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelPlease);
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
            this.Name = "FormSponsorConfirm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Marathon 2021 - Sponsor Confirm";
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
        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Label labelRunnerRegistration;
        private System.Windows.Forms.Label labelPlease;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

