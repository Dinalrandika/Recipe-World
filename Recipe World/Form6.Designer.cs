namespace Recipe_World
{
    partial class Form6
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form6));
            this.Name = new System.Windows.Forms.TextBox();
            this.ingredients = new System.Windows.Forms.TextBox();
            this.Process = new System.Windows.Forms.TextBox();
            this.No = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Close2 = new System.Windows.Forms.Button();
            this.Back2 = new System.Windows.Forms.Button();
            this.Delete = new System.Windows.Forms.Button();
            this.Edit = new System.Windows.Forms.Button();
            this.Add1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Name
            // 
            this.Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name.Location = new System.Drawing.Point(184, 73);
            this.Name.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name.Multiline = true;
            this.Name.Name = "Name";
            this.Name.Size = new System.Drawing.Size(261, 37);
            this.Name.TabIndex = 7;
            // 
            // ingredients
            // 
            this.ingredients.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ingredients.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.ingredients.Location = new System.Drawing.Point(184, 130);
            this.ingredients.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ingredients.Multiline = true;
            this.ingredients.Name = "ingredients";
            this.ingredients.Size = new System.Drawing.Size(567, 118);
            this.ingredients.TabIndex = 7;
            this.ingredients.TextChanged += new System.EventHandler(this.ingredients_TextChanged);
            // 
            // Process
            // 
            this.Process.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Process.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.Process.Location = new System.Drawing.Point(184, 255);
            this.Process.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Process.Multiline = true;
            this.Process.Name = "Process";
            this.Process.Size = new System.Drawing.Size(567, 118);
            this.Process.TabIndex = 7;
            // 
            // No
            // 
            this.No.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.No.Location = new System.Drawing.Point(615, 73);
            this.No.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.No.Multiline = true;
            this.No.Name = "No";
            this.No.Size = new System.Drawing.Size(136, 37);
            this.No.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Prime", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.label1.Location = new System.Drawing.Point(84, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 28);
            this.label1.TabIndex = 8;
            this.label1.Text = "Name :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Prime", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label2.Location = new System.Drawing.Point(525, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 28);
            this.label2.TabIndex = 8;
            this.label2.Text = "No :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Prime", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.label3.Location = new System.Drawing.Point(23, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(146, 28);
            this.label3.TabIndex = 8;
            this.label3.Text = "Ingredients :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Prime", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.label4.Location = new System.Drawing.Point(52, 255);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(113, 28);
            this.label4.TabIndex = 8;
            this.label4.Text = "Process :";
            // 
            // Close2
            // 
            this.Close2.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.Close2.Font = new System.Drawing.Font("Prime", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Close2.Location = new System.Drawing.Point(655, 399);
            this.Close2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Close2.Name = "Close2";
            this.Close2.Size = new System.Drawing.Size(132, 38);
            this.Close2.TabIndex = 9;
            this.Close2.Text = "Close";
            this.Close2.UseVisualStyleBackColor = true;
            this.Close2.Click += new System.EventHandler(this.Close2_Click);
            // 
            // Back2
            // 
            this.Back2.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.Back2.Font = new System.Drawing.Font("Prime", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Back2.Location = new System.Drawing.Point(499, 399);
            this.Back2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Back2.Name = "Back2";
            this.Back2.Size = new System.Drawing.Size(132, 38);
            this.Back2.TabIndex = 9;
            this.Back2.Text = "Back";
            this.Back2.UseVisualStyleBackColor = true;
            this.Back2.Click += new System.EventHandler(this.Back2_Click);
            // 
            // Delete
            // 
            this.Delete.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.Delete.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.Delete.Font = new System.Drawing.Font("Prime", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Delete.Location = new System.Drawing.Point(313, 399);
            this.Delete.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(132, 38);
            this.Delete.TabIndex = 9;
            this.Delete.Text = "Delete";
            this.Delete.UseVisualStyleBackColor = false;
            this.Delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // Edit
            // 
            this.Edit.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.Edit.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.Edit.Font = new System.Drawing.Font("Prime", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Edit.Location = new System.Drawing.Point(164, 399);
            this.Edit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Edit.Name = "Edit";
            this.Edit.Size = new System.Drawing.Size(132, 38);
            this.Edit.TabIndex = 9;
            this.Edit.Text = "Edit";
            this.Edit.UseVisualStyleBackColor = false;
            this.Edit.Click += new System.EventHandler(this.Edit_Click);
            // 
            // Add1
            // 
            this.Add1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.Add1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.Add1.Font = new System.Drawing.Font("Prime", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Add1.Location = new System.Drawing.Point(15, 399);
            this.Add1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Add1.Name = "Add1";
            this.Add1.Size = new System.Drawing.Size(132, 38);
            this.Add1.TabIndex = 9;
            this.Add1.Text = "Add";
            this.Add1.UseVisualStyleBackColor = false;
            this.Add1.Click += new System.EventHandler(this.Add1_Click);
            // 
            // Form6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(801, 450);
            this.Controls.Add(this.Add1);
            this.Controls.Add(this.Edit);
            this.Controls.Add(this.Delete);
            this.Controls.Add(this.Back2);
            this.Controls.Add(this.Close2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Process);
            this.Controls.Add(this.ingredients);
            this.Controls.Add(this.No);
            this.Controls.Add(this.Name);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            //this.Name = "Form6";
            this.Text = "Add";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Name;
        private System.Windows.Forms.TextBox ingredients;
        private System.Windows.Forms.TextBox Process;
        private System.Windows.Forms.TextBox No;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button Close2;
        private System.Windows.Forms.Button Back2;
        private System.Windows.Forms.Button Delete;
        private System.Windows.Forms.Button Edit;
        private System.Windows.Forms.Button Add1;
    }
}