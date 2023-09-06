namespace Recipe_World
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Recipes = new System.Windows.Forms.Button();
            this.Close1 = new System.Windows.Forms.Button();
            this.About = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.logIn = new System.Windows.Forms.ToolStripMenuItem();
            this.administator = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Recipes
            // 
            this.Recipes.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.Recipes.Font = new System.Drawing.Font("Prime", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Recipes.Location = new System.Drawing.Point(453, 258);
            this.Recipes.Name = "Recipes";
            this.Recipes.Size = new System.Drawing.Size(132, 48);
            this.Recipes.TabIndex = 0;
            this.Recipes.Text = "Recipes";
            this.Recipes.UseVisualStyleBackColor = true;
            this.Recipes.Click += new System.EventHandler(this.Menu_Click);
            // 
            // Close1
            // 
            this.Close1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.Close1.Font = new System.Drawing.Font("Prime", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Close1.Location = new System.Drawing.Point(656, 400);
            this.Close1.Name = "Close1";
            this.Close1.Size = new System.Drawing.Size(132, 38);
            this.Close1.TabIndex = 2;
            this.Close1.Text = "Close";
            this.Close1.UseVisualStyleBackColor = true;
            this.Close1.Click += new System.EventHandler(this.button3_Click);
            // 
            // About
            // 
            this.About.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.About.Font = new System.Drawing.Font("Prime", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.About.Location = new System.Drawing.Point(453, 334);
            this.About.Name = "About";
            this.About.Size = new System.Drawing.Size(132, 38);
            this.About.TabIndex = 0;
            this.About.Text = "About";
            this.About.UseVisualStyleBackColor = true;
            this.About.Click += new System.EventHandler(this.About_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Transparent;
            this.menuStrip1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.logIn});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 36);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // logIn
            // 
            this.logIn.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.administator});
            this.logIn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logIn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.logIn.Name = "logIn";
            this.logIn.Size = new System.Drawing.Size(84, 32);
            this.logIn.Text = "Log In";
            // 
            // administator
            // 
            this.administator.BackColor = System.Drawing.Color.WhiteSmoke;
            this.administator.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.administator.Name = "administator";
            this.administator.Size = new System.Drawing.Size(230, 32);
            this.administator.Text = "Administrator";
            this.administator.Click += new System.EventHandler(this.administatorToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Close1);
            this.Controls.Add(this.About);
            this.Controls.Add(this.Recipes);
            this.Controls.Add(this.menuStrip1);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Recipe World";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Recipes;
        private System.Windows.Forms.Button Close1;
        private System.Windows.Forms.Button About;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem logIn;
        private System.Windows.Forms.ToolStripMenuItem administator;
    }
}

