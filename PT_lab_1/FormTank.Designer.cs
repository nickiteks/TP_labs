﻿namespace PT_lab_1
{
    partial class FormTank
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
            this.pictureBoxTank = new System.Windows.Forms.PictureBox();
            this.buttonCreate = new System.Windows.Forms.Button();
            this.buttonUp = new System.Windows.Forms.Button();
            this.buttonLeft = new System.Windows.Forms.Button();
            this.buttonDown = new System.Windows.Forms.Button();
            this.buttonRight = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTank)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxTank
            // 
            this.pictureBoxTank.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBoxTank.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxTank.Name = "pictureBoxTank";
            this.pictureBoxTank.Size = new System.Drawing.Size(884, 461);
            this.pictureBoxTank.TabIndex = 0;
            this.pictureBoxTank.TabStop = false;
            // 
            // buttonCreate
            // 
            this.buttonCreate.Location = new System.Drawing.Point(13, 13);
            this.buttonCreate.Name = "buttonCreate";
            this.buttonCreate.Size = new System.Drawing.Size(75, 23);
            this.buttonCreate.TabIndex = 1;
            this.buttonCreate.Text = "создать";
            this.buttonCreate.UseVisualStyleBackColor = true;
            this.buttonCreate.Click += new System.EventHandler(this.buttonCreate_Click_1);
            // 
            // buttonUp
            // 
            this.buttonUp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonUp.BackgroundImage = global::PT_lab_1.Properties.Resources.up;
            this.buttonUp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonUp.Location = new System.Drawing.Point(815, 392);
            this.buttonUp.Name = "buttonUp";
            this.buttonUp.Size = new System.Drawing.Size(30, 30);
            this.buttonUp.TabIndex = 2;
            this.buttonUp.UseVisualStyleBackColor = true;
            this.buttonUp.Click += new System.EventHandler(this.buttonMove_Click);
            // 
            // buttonLeft
            // 
            this.buttonLeft.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonLeft.BackgroundImage = global::PT_lab_1.Properties.Resources.left;
            this.buttonLeft.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonLeft.Location = new System.Drawing.Point(779, 428);
            this.buttonLeft.Name = "buttonLeft";
            this.buttonLeft.Size = new System.Drawing.Size(30, 30);
            this.buttonLeft.TabIndex = 3;
            this.buttonLeft.UseVisualStyleBackColor = true;
            this.buttonLeft.Click += new System.EventHandler(this.buttonMove_Click);
            // 
            // buttonDown
            // 
            this.buttonDown.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonDown.BackgroundImage = global::PT_lab_1.Properties.Resources.down;
            this.buttonDown.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonDown.Location = new System.Drawing.Point(815, 428);
            this.buttonDown.Name = "buttonDown";
            this.buttonDown.Size = new System.Drawing.Size(30, 30);
            this.buttonDown.TabIndex = 4;
            this.buttonDown.UseVisualStyleBackColor = true;
            this.buttonDown.Click += new System.EventHandler(this.buttonMove_Click);
            // 
            // buttonRight
            // 
            this.buttonRight.BackgroundImage = global::PT_lab_1.Properties.Resources.ight;
            this.buttonRight.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonRight.Location = new System.Drawing.Point(851, 428);
            this.buttonRight.Name = "buttonRight";
            this.buttonRight.Size = new System.Drawing.Size(30, 30);
            this.buttonRight.TabIndex = 5;
            this.buttonRight.UseVisualStyleBackColor = true;
            this.buttonRight.Click += new System.EventHandler(this.buttonMove_Click);
            // 
            // FormTank
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(884, 461);
            this.Controls.Add(this.buttonRight);
            this.Controls.Add(this.buttonDown);
            this.Controls.Add(this.buttonLeft);
            this.Controls.Add(this.buttonUp);
            this.Controls.Add(this.buttonCreate);
            this.Controls.Add(this.pictureBoxTank);
            this.Name = "FormTank";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "танк";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTank)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxTank;
        private System.Windows.Forms.Button buttonCreate;
        private System.Windows.Forms.Button buttonUp;
        private System.Windows.Forms.Button buttonLeft;
        private System.Windows.Forms.Button buttonDown;
        private System.Windows.Forms.Button buttonRight;
    }
}

