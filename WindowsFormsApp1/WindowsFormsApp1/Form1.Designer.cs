namespace WindowsFormsApp1
{
    partial class Calculator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Calculator));
            this.txtdisplay2 = new System.Windows.Forms.TextBox();
            this.txtdisplay1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.Menu = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.Menu)).BeginInit();
            this.SuspendLayout();
            // 
            // txtdisplay2
            // 
            this.txtdisplay2.BackColor = System.Drawing.Color.Gray;
            this.txtdisplay2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtdisplay2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdisplay2.ForeColor = System.Drawing.SystemColors.Window;
            this.txtdisplay2.Location = new System.Drawing.Point(18, 47);
            this.txtdisplay2.Margin = new System.Windows.Forms.Padding(0);
            this.txtdisplay2.Multiline = true;
            this.txtdisplay2.Name = "txtdisplay2";
            this.txtdisplay2.Size = new System.Drawing.Size(342, 21);
            this.txtdisplay2.TabIndex = 2;
            this.txtdisplay2.Text = "2312321312";
            this.txtdisplay2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtdisplay1
            // 
            this.txtdisplay1.BackColor = System.Drawing.Color.Gray;
            this.txtdisplay1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtdisplay1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdisplay1.ForeColor = System.Drawing.SystemColors.Window;
            this.txtdisplay1.Location = new System.Drawing.Point(18, 77);
            this.txtdisplay1.Margin = new System.Windows.Forms.Padding(0);
            this.txtdisplay1.Multiline = true;
            this.txtdisplay1.Name = "txtdisplay1";
            this.txtdisplay1.Size = new System.Drawing.Size(342, 40);
            this.txtdisplay1.TabIndex = 3;
            this.txtdisplay1.Text = "2312321312";
            this.txtdisplay1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Image = global::WindowsFormsApp1.Properties.Resources.icons8_time_machine_24__1_;
            this.button1.Location = new System.Drawing.Point(325, 3);
            this.button1.Margin = new System.Windows.Forms.Padding(0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(35, 28);
            this.button1.TabIndex = 1;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Menu
            // 
            this.Menu.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.menu;
            this.Menu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Menu.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.Menu.Location = new System.Drawing.Point(18, 10);
            this.Menu.Margin = new System.Windows.Forms.Padding(2);
            this.Menu.Name = "Menu";
            this.Menu.Size = new System.Drawing.Size(22, 17);
            this.Menu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Menu.TabIndex = 0;
            this.Menu.TabStop = false;
            // 
            // Calculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(374, 550);
            this.Controls.Add(this.txtdisplay1);
            this.Controls.Add(this.txtdisplay2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Menu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Calculator";
            this.Text = "Calculator";
            this.Load += new System.EventHandler(this.Calculator_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Menu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox Menu;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtdisplay2;
        private System.Windows.Forms.TextBox txtdisplay1;
        private System.Windows.Forms.PictureBox clearhistory;
    }
}

