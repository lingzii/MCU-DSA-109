
namespace Homework_3
{
	partial class Form1
	{
		/// <summary>
		///  Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		///  Clean up any resources being used.
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
		///  Required method for Designer support - do not modify
		///  the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Insert_btn = new System.Windows.Forms.Button();
            this.delete_btn = new System.Windows.Forms.Button();
            this.number = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.generate = new System.Windows.Forms.Button();
            this.size = new System.Windows.Forms.TextBox();
            this.range = new System.Windows.Forms.TextBox();
            this.broad = new System.Windows.Forms.TextBox();
            this.sort_btn = new System.Windows.Forms.Button();
            this.clear_btn = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Insert_btn
            // 
            this.Insert_btn.Location = new System.Drawing.Point(6, 51);
            this.Insert_btn.Name = "Insert_btn";
            this.Insert_btn.Size = new System.Drawing.Size(100, 23);
            this.Insert_btn.TabIndex = 0;
            this.Insert_btn.Text = "Insert";
            this.Insert_btn.UseVisualStyleBackColor = true;
            this.Insert_btn.Click += new System.EventHandler(this.Insert_btn_Click);
            // 
            // delete_btn
            // 
            this.delete_btn.Location = new System.Drawing.Point(6, 80);
            this.delete_btn.Name = "delete_btn";
            this.delete_btn.Size = new System.Drawing.Size(100, 23);
            this.delete_btn.TabIndex = 3;
            this.delete_btn.Text = "Delete";
            this.delete_btn.UseVisualStyleBackColor = true;
            this.delete_btn.Click += new System.EventHandler(this.delete_btn_Click);
            // 
            // number
            // 
            this.number.Location = new System.Drawing.Point(6, 22);
            this.number.Name = "number";
            this.number.Size = new System.Drawing.Size(100, 27);
            this.number.TabIndex = 4;
            this.number.Text = "87";
            this.number.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.number);
            this.groupBox1.Controls.Add(this.Insert_btn);
            this.groupBox1.Controls.Add(this.delete_btn);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(114, 112);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Modify";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.generate);
            this.groupBox2.Controls.Add(this.size);
            this.groupBox2.Controls.Add(this.range);
            this.groupBox2.Location = new System.Drawing.Point(12, 130);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(114, 113);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Random";
            // 
            // generate
            // 
            this.generate.Location = new System.Drawing.Point(6, 80);
            this.generate.Name = "generate";
            this.generate.Size = new System.Drawing.Size(100, 23);
            this.generate.TabIndex = 7;
            this.generate.Text = "Generate";
            this.generate.UseVisualStyleBackColor = true;
            this.generate.Click += new System.EventHandler(this.generate_Click);
            // 
            // size
            // 
            this.size.Location = new System.Drawing.Point(6, 51);
            this.size.Name = "size";
            this.size.Size = new System.Drawing.Size(100, 27);
            this.size.TabIndex = 9;
            this.size.Text = "100";
            this.size.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // range
            // 
            this.range.Location = new System.Drawing.Point(6, 22);
            this.range.Name = "range";
            this.range.Size = new System.Drawing.Size(100, 27);
            this.range.TabIndex = 8;
            this.range.Text = "10";
            this.range.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // broad
            // 
            this.broad.Location = new System.Drawing.Point(0, 3);
            this.broad.Multiline = true;
            this.broad.Name = "broad";
            this.broad.ReadOnly = true;
            this.broad.Size = new System.Drawing.Size(576, 391);
            this.broad.TabIndex = 7;
            // 
            // sort_btn
            // 
            this.sort_btn.Location = new System.Drawing.Point(18, 330);
            this.sort_btn.Name = "sort_btn";
            this.sort_btn.Size = new System.Drawing.Size(100, 75);
            this.sort_btn.TabIndex = 8;
            this.sort_btn.Text = "Sort";
            this.sort_btn.UseVisualStyleBackColor = true;
            this.sort_btn.Click += new System.EventHandler(this.sort_btn_Click);
            // 
            // clear_btn
            // 
            this.clear_btn.Location = new System.Drawing.Point(18, 249);
            this.clear_btn.Name = "clear_btn";
            this.clear_btn.Size = new System.Drawing.Size(100, 75);
            this.clear_btn.TabIndex = 9;
            this.clear_btn.Text = "Clear";
            this.clear_btn.UseVisualStyleBackColor = true;
            this.clear_btn.Click += new System.EventHandler(this.clear_btn_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(132, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(587, 426);
            this.tabControl1.TabIndex = 10;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.broad);
            this.tabPage1.Location = new System.Drawing.Point(4, 28);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(579, 394);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "console";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.pictureBox1);
            this.tabPage2.Location = new System.Drawing.Point(4, 28);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(579, 394);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Analysis chart";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-4, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(586, 398);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(726, 450);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.clear_btn);
            this.Controls.Add(this.sort_btn);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Homework 03 - Heap & Sort by Lingzi";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button Insert_btn;
		private System.Windows.Forms.Button delete_btn;
		private System.Windows.Forms.TextBox number;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.Button generate;
		private System.Windows.Forms.TextBox size;
		private System.Windows.Forms.TextBox range;
		private System.Windows.Forms.TextBox broad;
        private System.Windows.Forms.Button sort_btn;
        private System.Windows.Forms.Button clear_btn;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

