
namespace BeetleCaf
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
            this.btnUserLogin = new System.Windows.Forms.Button();
            this.btnStaffLogin = new System.Windows.Forms.Button();
            this.btnMenu = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnUserLogin
            // 
            this.btnUserLogin.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUserLogin.Location = new System.Drawing.Point(-78, 13);
            this.btnUserLogin.Margin = new System.Windows.Forms.Padding(4);
            this.btnUserLogin.Name = "btnUserLogin";
            this.btnUserLogin.Size = new System.Drawing.Size(100, 28);
            this.btnUserLogin.TabIndex = 0;
            this.btnUserLogin.Text = "User Login";
            this.btnUserLogin.UseVisualStyleBackColor = true;
            this.btnUserLogin.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnStaffLogin
            // 
            this.btnStaffLogin.BackColor = System.Drawing.Color.Transparent;
            this.btnStaffLogin.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStaffLogin.ForeColor = System.Drawing.Color.Peru;
            this.btnStaffLogin.Location = new System.Drawing.Point(16, 416);
            this.btnStaffLogin.Margin = new System.Windows.Forms.Padding(4);
            this.btnStaffLogin.Name = "btnStaffLogin";
            this.btnStaffLogin.Size = new System.Drawing.Size(108, 30);
            this.btnStaffLogin.TabIndex = 1;
            this.btnStaffLogin.Text = "Staff Login";
            this.btnStaffLogin.UseVisualStyleBackColor = false;
            this.btnStaffLogin.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnMenu
            // 
            this.btnMenu.BackColor = System.Drawing.Color.Transparent;
            this.btnMenu.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMenu.ForeColor = System.Drawing.Color.Peru;
            this.btnMenu.Location = new System.Drawing.Point(542, 345);
            this.btnMenu.Margin = new System.Windows.Forms.Padding(4);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(135, 49);
            this.btnMenu.TabIndex = 2;
            this.btnMenu.Text = "Menu";
            this.btnMenu.UseVisualStyleBackColor = false;
            this.btnMenu.Click += new System.EventHandler(this.btnMenu_Click);
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.Peru;
            this.btnExit.Location = new System.Drawing.Point(542, 402);
            this.btnExit.Margin = new System.Windows.Forms.Padding(4);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(135, 42);
            this.btnExit.TabIndex = 3;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(690, 457);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnMenu);
            this.Controls.Add(this.btnStaffLogin);
            this.Controls.Add(this.btnUserLogin);
            this.Font = new System.Drawing.Font("Stencil", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Welcome To BeetleCaf";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnUserLogin;
        private System.Windows.Forms.Button btnStaffLogin;
        private System.Windows.Forms.Button btnMenu;
        private System.Windows.Forms.Button btnExit;
    }
}

