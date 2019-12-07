namespace MyTransport
{
    partial class FormParking
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
            this.pictureBoxParking = new System.Windows.Forms.PictureBox();
            this.buttonSet_Aircraft = new System.Windows.Forms.Button();
            this.buttonSet_AttackAircraft = new System.Windows.Forms.Button();
            this.groupBox = new System.Windows.Forms.GroupBox();
            this.pictureBoxGet = new System.Windows.Forms.PictureBox();
            this.buttonGet = new System.Windows.Forms.Button();
            this.label = new System.Windows.Forms.Label();
            this.maskedTextBox = new System.Windows.Forms.MaskedTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxParking)).BeginInit();
            this.groupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxGet)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxParking
            // 
            this.pictureBoxParking.Location = new System.Drawing.Point(12, 12);
            this.pictureBoxParking.Name = "pictureBoxParking";
            this.pictureBoxParking.Size = new System.Drawing.Size(613, 426);
            this.pictureBoxParking.TabIndex = 0;
            this.pictureBoxParking.TabStop = false;
            // 
            // buttonSet_Aircraft
            // 
            this.buttonSet_Aircraft.Location = new System.Drawing.Point(702, 12);
            this.buttonSet_Aircraft.Name = "buttonSet_Aircraft";
            this.buttonSet_Aircraft.Size = new System.Drawing.Size(85, 66);
            this.buttonSet_Aircraft.TabIndex = 1;
            this.buttonSet_Aircraft.Text = "Посадить самолет";
            this.buttonSet_Aircraft.UseVisualStyleBackColor = true;
            this.buttonSet_Aircraft.Click += new System.EventHandler(this.buttonSet_Aircraft_Click);
            // 
            // buttonSet_AttackAircraft
            // 
            this.buttonSet_AttackAircraft.Location = new System.Drawing.Point(702, 84);
            this.buttonSet_AttackAircraft.Name = "buttonSet_AttackAircraft";
            this.buttonSet_AttackAircraft.Size = new System.Drawing.Size(85, 67);
            this.buttonSet_AttackAircraft.TabIndex = 2;
            this.buttonSet_AttackAircraft.Text = "Посадить штурмовик";
            this.buttonSet_AttackAircraft.UseVisualStyleBackColor = true;
            this.buttonSet_AttackAircraft.Click += new System.EventHandler(this.buttonSet_AttackAircraft_Click);
            // 
            // groupBox
            // 
            this.groupBox.Controls.Add(this.pictureBoxGet);
            this.groupBox.Controls.Add(this.buttonGet);
            this.groupBox.Controls.Add(this.label);
            this.groupBox.Controls.Add(this.maskedTextBox);
            this.groupBox.Location = new System.Drawing.Point(631, 169);
            this.groupBox.Name = "groupBox";
            this.groupBox.Size = new System.Drawing.Size(224, 257);
            this.groupBox.TabIndex = 3;
            this.groupBox.TabStop = false;
            this.groupBox.Text = "Забрать самолет";
            // 
            // pictureBoxGet
            // 
            this.pictureBoxGet.Location = new System.Drawing.Point(33, 80);
            this.pictureBoxGet.Name = "pictureBoxGet";
            this.pictureBoxGet.Size = new System.Drawing.Size(166, 121);
            this.pictureBoxGet.TabIndex = 3;
            this.pictureBoxGet.TabStop = false;
            // 
            // buttonGet
            // 
            this.buttonGet.Location = new System.Drawing.Point(23, 51);
            this.buttonGet.Name = "buttonGet";
            this.buttonGet.Size = new System.Drawing.Size(75, 23);
            this.buttonGet.TabIndex = 2;
            this.buttonGet.Text = "Забрать";
            this.buttonGet.UseVisualStyleBackColor = true;
            this.buttonGet.Click += new System.EventHandler(this.buttonGet_Click);
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Location = new System.Drawing.Point(20, 25);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(42, 13);
            this.label.TabIndex = 1;
            this.label.Text = "Место:";
            // 
            // maskedTextBox
            // 
            this.maskedTextBox.Location = new System.Drawing.Point(71, 25);
            this.maskedTextBox.Name = "maskedTextBox";
            this.maskedTextBox.Size = new System.Drawing.Size(100, 20);
            this.maskedTextBox.TabIndex = 0;
            // 
            // FormParking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(887, 450);
            this.Controls.Add(this.pictureBoxParking);
            this.Controls.Add(this.groupBox);
            this.Controls.Add(this.buttonSet_AttackAircraft);
            this.Controls.Add(this.buttonSet_Aircraft);
            this.Name = "FormParking";
            this.Text = "FormParking";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxParking)).EndInit();
            this.groupBox.ResumeLayout(false);
            this.groupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxGet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxParking;
        private System.Windows.Forms.Button buttonSet_Aircraft;
        private System.Windows.Forms.Button buttonSet_AttackAircraft;
        private System.Windows.Forms.GroupBox groupBox;
        private System.Windows.Forms.PictureBox pictureBoxGet;
        private System.Windows.Forms.Button buttonGet;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.MaskedTextBox maskedTextBox;
    }
}