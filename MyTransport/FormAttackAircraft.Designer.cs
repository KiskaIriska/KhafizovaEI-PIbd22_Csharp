namespace MyTransport
{
    partial class FormAttackAircraft
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAttackAircraft));
            this.buttonCreateAircraft = new System.Windows.Forms.Button();
            this.buttonUp = new System.Windows.Forms.Button();
            this.buttonLeft = new System.Windows.Forms.Button();
            this.buttonDown = new System.Windows.Forms.Button();
            this.buttonRight = new System.Windows.Forms.Button();
            this.pictureBoxAttackAircraft = new System.Windows.Forms.PictureBox();
            this.buttonCreateAttackAircraft = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAttackAircraft)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonCreateAircraft
            // 
            this.buttonCreateAircraft.Location = new System.Drawing.Point(12, 12);
            this.buttonCreateAircraft.Name = "buttonCreateAircraft";
            this.buttonCreateAircraft.Size = new System.Drawing.Size(75, 47);
            this.buttonCreateAircraft.TabIndex = 0;
            this.buttonCreateAircraft.Text = "Создать самолет";
            this.buttonCreateAircraft.UseVisualStyleBackColor = true;
            this.buttonCreateAircraft.Click += new System.EventHandler(this.buttonCreateAircraft_Click);
            // 
            // buttonUp
            // 
            this.buttonUp.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonUp.BackgroundImage")));
            this.buttonUp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonUp.Location = new System.Drawing.Point(722, 359);
            this.buttonUp.Name = "buttonUp";
            this.buttonUp.Size = new System.Drawing.Size(28, 27);
            this.buttonUp.TabIndex = 1;
            this.buttonUp.UseVisualStyleBackColor = true;
            this.buttonUp.Click += new System.EventHandler(this.buttonMove_Click);
            // 
            // buttonLeft
            // 
            this.buttonLeft.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonLeft.BackgroundImage")));
            this.buttonLeft.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonLeft.Location = new System.Drawing.Point(680, 392);
            this.buttonLeft.Name = "buttonLeft";
            this.buttonLeft.Size = new System.Drawing.Size(31, 23);
            this.buttonLeft.TabIndex = 2;
            this.buttonLeft.UseVisualStyleBackColor = true;
            this.buttonLeft.Click += new System.EventHandler(this.buttonMove_Click);
            // 
            // buttonDown
            // 
            this.buttonDown.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonDown.BackgroundImage")));
            this.buttonDown.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonDown.Location = new System.Drawing.Point(722, 415);
            this.buttonDown.Name = "buttonDown";
            this.buttonDown.Size = new System.Drawing.Size(28, 23);
            this.buttonDown.TabIndex = 3;
            this.buttonDown.UseVisualStyleBackColor = true;
            this.buttonDown.Click += new System.EventHandler(this.buttonMove_Click);
            // 
            // buttonRight
            // 
            this.buttonRight.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonRight.BackgroundImage")));
            this.buttonRight.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonRight.Location = new System.Drawing.Point(757, 392);
            this.buttonRight.Name = "buttonRight";
            this.buttonRight.Size = new System.Drawing.Size(31, 23);
            this.buttonRight.TabIndex = 4;
            this.buttonRight.UseVisualStyleBackColor = true;
            this.buttonRight.Click += new System.EventHandler(this.buttonMove_Click);
            // 
            // pictureBoxAttackAircraft
            // 
            this.pictureBoxAttackAircraft.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBoxAttackAircraft.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxAttackAircraft.Name = "pictureBoxAttackAircraft";
            this.pictureBoxAttackAircraft.Size = new System.Drawing.Size(800, 450);
            this.pictureBoxAttackAircraft.TabIndex = 5;
            this.pictureBoxAttackAircraft.TabStop = false;
            this.pictureBoxAttackAircraft.Click += new System.EventHandler(this.buttonMove_Click);
            // 
            // buttonCreateAttackAircraft
            // 
            this.buttonCreateAttackAircraft.Location = new System.Drawing.Point(93, 12);
            this.buttonCreateAttackAircraft.Name = "buttonCreateAttackAircraft";
            this.buttonCreateAttackAircraft.Size = new System.Drawing.Size(75, 47);
            this.buttonCreateAttackAircraft.TabIndex = 6;
            this.buttonCreateAttackAircraft.Text = "Создать штурмовик";
            this.buttonCreateAttackAircraft.UseVisualStyleBackColor = true;
            this.buttonCreateAttackAircraft.Click += new System.EventHandler(this.buttonCreateAttackAircraft_Click);
            // 
            // FormAttackAircraft
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonCreateAttackAircraft);
            this.Controls.Add(this.buttonCreateAircraft);
            this.Controls.Add(this.buttonLeft);
            this.Controls.Add(this.buttonDown);
            this.Controls.Add(this.buttonRight);
            this.Controls.Add(this.buttonUp);
            this.Controls.Add(this.pictureBoxAttackAircraft);
            this.Name = "FormAttackAircraft";
            this.Text = "FormAttackAircraft";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAttackAircraft)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonCreateAircraft;
        private System.Windows.Forms.Button buttonUp;
        private System.Windows.Forms.Button buttonLeft;
        private System.Windows.Forms.Button buttonDown;
        private System.Windows.Forms.Button buttonRight;
        private System.Windows.Forms.PictureBox pictureBoxAttackAircraft;
        private System.Windows.Forms.Button buttonCreateAttackAircraft;
    }
}

