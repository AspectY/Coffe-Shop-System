
namespace BeetleCaf
{
    partial class Menu
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnOrder = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.btnMain = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.BackColor = System.Drawing.Color.Snow;
            this.listBox1.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 15;
            this.listBox1.Location = new System.Drawing.Point(12, 47);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(535, 364);
            this.listBox1.TabIndex = 0;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // listBox2
            // 
            this.listBox2.BackColor = System.Drawing.Color.Snow;
            this.listBox2.FormattingEnabled = true;
            this.listBox2.Location = new System.Drawing.Point(569, 47);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(219, 186);
            this.listBox2.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 17F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Peru;
            this.label1.Location = new System.Drawing.Point(221, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(200, 26);
            this.label1.TabIndex = 2;
            this.label1.Text = "Menu for BeetleCaf:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Peru;
            this.label2.Location = new System.Drawing.Point(622, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Your Current Order:";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(566, 236);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(222, 40);
            this.label3.TabIndex = 4;
            this.label3.Text = "Select item from current order you would like to remove:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnRemove
            // 
            this.btnRemove.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemove.ForeColor = System.Drawing.Color.Peru;
            this.btnRemove.Location = new System.Drawing.Point(569, 270);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(219, 35);
            this.btnRemove.TabIndex = 5;
            this.btnRemove.Text = "Remove Item";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnOrder
            // 
            this.btnOrder.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOrder.ForeColor = System.Drawing.Color.Peru;
            this.btnOrder.Location = new System.Drawing.Point(569, 327);
            this.btnOrder.Name = "btnOrder";
            this.btnOrder.Size = new System.Drawing.Size(219, 33);
            this.btnOrder.TabIndex = 6;
            this.btnOrder.Text = "Place Order";
            this.btnOrder.UseVisualStyleBackColor = true;
            this.btnOrder.Click += new System.EventHandler(this.btnOrder_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(633, 308);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = "Place your order:";
            // 
            // btnMain
            // 
            this.btnMain.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMain.ForeColor = System.Drawing.Color.Peru;
            this.btnMain.Location = new System.Drawing.Point(569, 366);
            this.btnMain.Name = "btnMain";
            this.btnMain.Size = new System.Drawing.Size(219, 35);
            this.btnMain.TabIndex = 9;
            this.btnMain.Text = "Back to main menu";
            this.btnMain.UseVisualStyleBackColor = true;
            this.btnMain.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 416);
            this.Controls.Add(this.btnMain);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnOrder);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.listBox1);
            this.Name = "Menu";
            this.Text = " ";
            this.Load += new System.EventHandler(this.Menu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnOrder;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnMain;
    }
}