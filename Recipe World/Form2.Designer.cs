namespace Recipe_World
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.Add = new System.Windows.Forms.Button();
            this.View = new System.Windows.Forms.Button();
            this.Close2 = new System.Windows.Forms.Button();
            this.Back1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Add
            // 
            this.Add.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.Add.Font = new System.Drawing.Font("Prime", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Add.Location = new System.Drawing.Point(531, 149);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(138, 50);
            this.Add.TabIndex = 1;
            this.Add.Text = "Change";
            this.Add.UseVisualStyleBackColor = true;
            this.Add.Click += new System.EventHandler(this.button2_Click);
            // 
            // View
            // 
            this.View.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.View.Font = new System.Drawing.Font("Prime", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.View.Location = new System.Drawing.Point(531, 220);
            this.View.Name = "View";
            this.View.Size = new System.Drawing.Size(138, 50);
            this.View.TabIndex = 2;
            this.View.Text = "View";
            this.View.UseVisualStyleBackColor = true;
            this.View.Click += new System.EventHandler(this.button1_Click);
            // 
            // Close2
            // 
            this.Close2.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.Close2.Font = new System.Drawing.Font("Prime", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Close2.Location = new System.Drawing.Point(656, 400);
            this.Close2.Name = "Close2";
            this.Close2.Size = new System.Drawing.Size(132, 38);
            this.Close2.TabIndex = 3;
            this.Close2.Text = "Close";
            this.Close2.UseVisualStyleBackColor = true;
            this.Close2.Click += new System.EventHandler(this.button3_Click);
            // 
            // Back1
            // 
            this.Back1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.Back1.Font = new System.Drawing.Font("Prime", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Back1.Location = new System.Drawing.Point(492, 400);
            this.Back1.Name = "Back1";
            this.Back1.Size = new System.Drawing.Size(132, 38);
            this.Back1.TabIndex = 3;
            this.Back1.Text = "Back";
            this.Back1.UseVisualStyleBackColor = true;
            this.Back1.Click += new System.EventHandler(this.button4_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("MV Boli", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(156, 44);
            this.label1.TabIndex = 7;
            this.label1.Text = "Welcome";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Back1);
            this.Controls.Add(this.Close2);
            this.Controls.Add(this.View);
            this.Controls.Add(this.Add);
            this.DoubleBuffered = true;
            this.Name = "Form2";
            this.Text = "Menu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Add;
        private System.Windows.Forms.Button View;
        private System.Windows.Forms.Button Close2;
        private System.Windows.Forms.Button Back1;
        private System.Windows.Forms.Label label1;
    }
}