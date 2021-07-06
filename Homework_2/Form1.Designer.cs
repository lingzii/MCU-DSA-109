
namespace Homework_2
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Range = new System.Windows.Forms.TextBox();
            this.Quantity = new System.Windows.Forms.TextBox();
            this.Generate_btn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Clear_btn = new System.Windows.Forms.Button();
            this.Delete_btn = new System.Windows.Forms.Button();
            this.Search_btn = new System.Windows.Forms.Button();
            this.Insert_btn = new System.Windows.Forms.Button();
            this.Number = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.Infix = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Prefix = new System.Windows.Forms.TextBox();
            this.Postfix = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.Level = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.LevelTraversal_btn = new System.Windows.Forms.Button();
            this.PostTraversal_btn = new System.Windows.Forms.Button();
            this.PreTraversal_btn = new System.Windows.Forms.Button();
            this.InTraversal_btn = new System.Windows.Forms.Button();
            this.FindByPre = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.Board = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.FindByLevel = new System.Windows.Forms.Button();
            this.FindByPost = new System.Windows.Forms.Button();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox5.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Range);
            this.groupBox1.Controls.Add(this.Quantity);
            this.groupBox1.Controls.Add(this.Generate_btn);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(8, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(205, 129);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Random generation";
            // 
            // Range
            // 
            this.Range.Location = new System.Drawing.Point(93, 58);
            this.Range.Name = "Range";
            this.Range.Size = new System.Drawing.Size(100, 25);
            this.Range.TabIndex = 6;
            this.Range.Text = "10";
            this.Range.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Quantity
            // 
            this.Quantity.Location = new System.Drawing.Point(93, 27);
            this.Quantity.Name = "Quantity";
            this.Quantity.Size = new System.Drawing.Size(100, 25);
            this.Quantity.TabIndex = 5;
            this.Quantity.Text = "10";
            this.Quantity.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Generate_btn
            // 
            this.Generate_btn.Location = new System.Drawing.Point(6, 89);
            this.Generate_btn.Name = "Generate_btn";
            this.Generate_btn.Size = new System.Drawing.Size(187, 25);
            this.Generate_btn.TabIndex = 3;
            this.Generate_btn.Text = "Generate";
            this.Generate_btn.UseVisualStyleBackColor = true;
            this.Generate_btn.Click += new System.EventHandler(this.Generate_btn_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 18);
            this.label1.TabIndex = 2;
            this.label1.Text = "Quantity";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 18);
            this.label2.TabIndex = 4;
            this.label2.Text = "Range";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.Clear_btn);
            this.groupBox2.Controls.Add(this.Delete_btn);
            this.groupBox2.Controls.Add(this.Search_btn);
            this.groupBox2.Controls.Add(this.Insert_btn);
            this.groupBox2.Controls.Add(this.Number);
            this.groupBox2.Location = new System.Drawing.Point(8, 138);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(205, 126);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Modify BST";
            // 
            // Clear_btn
            // 
            this.Clear_btn.Location = new System.Drawing.Point(103, 86);
            this.Clear_btn.Name = "Clear_btn";
            this.Clear_btn.Size = new System.Drawing.Size(90, 25);
            this.Clear_btn.TabIndex = 10;
            this.Clear_btn.Text = "Clear";
            this.Clear_btn.UseVisualStyleBackColor = true;
            this.Clear_btn.Click += new System.EventHandler(this.Clear_btn_Click);
            // 
            // Delete_btn
            // 
            this.Delete_btn.Location = new System.Drawing.Point(6, 86);
            this.Delete_btn.Name = "Delete_btn";
            this.Delete_btn.Size = new System.Drawing.Size(90, 25);
            this.Delete_btn.TabIndex = 9;
            this.Delete_btn.Text = "Delete";
            this.Delete_btn.UseVisualStyleBackColor = true;
            this.Delete_btn.Click += new System.EventHandler(this.Delete_btn_Click);
            // 
            // Search_btn
            // 
            this.Search_btn.Location = new System.Drawing.Point(103, 55);
            this.Search_btn.Name = "Search_btn";
            this.Search_btn.Size = new System.Drawing.Size(90, 25);
            this.Search_btn.TabIndex = 8;
            this.Search_btn.Text = "Search";
            this.Search_btn.UseVisualStyleBackColor = true;
            this.Search_btn.Click += new System.EventHandler(this.Search_btn_Click);
            // 
            // Insert_btn
            // 
            this.Insert_btn.Location = new System.Drawing.Point(6, 55);
            this.Insert_btn.Name = "Insert_btn";
            this.Insert_btn.Size = new System.Drawing.Size(90, 25);
            this.Insert_btn.TabIndex = 7;
            this.Insert_btn.Text = "Insert";
            this.Insert_btn.UseVisualStyleBackColor = true;
            this.Insert_btn.Click += new System.EventHandler(this.Insert_btn_Click);
            // 
            // Number
            // 
            this.Number.Location = new System.Drawing.Point(6, 24);
            this.Number.Name = "Number";
            this.Number.Size = new System.Drawing.Size(187, 25);
            this.Number.TabIndex = 7;
            this.Number.Text = "10";
            this.Number.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.Infix);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.Prefix);
            this.groupBox3.Controls.Add(this.Postfix);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.Level);
            this.groupBox3.Location = new System.Drawing.Point(3, 3);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(210, 162);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Input";
            // 
            // Infix
            // 
            this.Infix.Location = new System.Drawing.Point(83, 24);
            this.Infix.Name = "Infix";
            this.Infix.Size = new System.Drawing.Size(109, 25);
            this.Infix.TabIndex = 11;
            this.Infix.Text = "HBJAFDGCE";
            this.Infix.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 58);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 18);
            this.label4.TabIndex = 5;
            this.label4.Text = "Prefix";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 89);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 18);
            this.label5.TabIndex = 6;
            this.label5.Text = "Postfix";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 18);
            this.label3.TabIndex = 3;
            this.label3.Text = "Infix";
            // 
            // Prefix
            // 
            this.Prefix.Location = new System.Drawing.Point(83, 55);
            this.Prefix.Name = "Prefix";
            this.Prefix.Size = new System.Drawing.Size(109, 25);
            this.Prefix.TabIndex = 9;
            this.Prefix.Text = "ABHJCDFGE";
            this.Prefix.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Postfix
            // 
            this.Postfix.Location = new System.Drawing.Point(83, 86);
            this.Postfix.Name = "Postfix";
            this.Postfix.Size = new System.Drawing.Size(109, 25);
            this.Postfix.TabIndex = 4;
            this.Postfix.Text = "HJBFGDECA";
            this.Postfix.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(18, 120);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 18);
            this.label6.TabIndex = 7;
            this.label6.Text = "Level";
            // 
            // Level
            // 
            this.Level.Location = new System.Drawing.Point(83, 117);
            this.Level.Name = "Level";
            this.Level.Size = new System.Drawing.Size(109, 25);
            this.Level.TabIndex = 10;
            this.Level.Text = "ABCHJDEFG";
            this.Level.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.LevelTraversal_btn);
            this.groupBox4.Controls.Add(this.PostTraversal_btn);
            this.groupBox4.Controls.Add(this.PreTraversal_btn);
            this.groupBox4.Controls.Add(this.InTraversal_btn);
            this.groupBox4.Location = new System.Drawing.Point(8, 270);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(205, 157);
            this.groupBox4.TabIndex = 1;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Traversal BST";
            // 
            // LevelTraversal_btn
            // 
            this.LevelTraversal_btn.Location = new System.Drawing.Point(6, 117);
            this.LevelTraversal_btn.Name = "LevelTraversal_btn";
            this.LevelTraversal_btn.Size = new System.Drawing.Size(187, 25);
            this.LevelTraversal_btn.TabIndex = 7;
            this.LevelTraversal_btn.Text = "Level-order";
            this.LevelTraversal_btn.UseVisualStyleBackColor = true;
            this.LevelTraversal_btn.Click += new System.EventHandler(this.LevelTraversal_btn_Click);
            // 
            // PostTraversal_btn
            // 
            this.PostTraversal_btn.Location = new System.Drawing.Point(6, 86);
            this.PostTraversal_btn.Name = "PostTraversal_btn";
            this.PostTraversal_btn.Size = new System.Drawing.Size(187, 25);
            this.PostTraversal_btn.TabIndex = 6;
            this.PostTraversal_btn.Text = "Postorder";
            this.PostTraversal_btn.UseVisualStyleBackColor = true;
            this.PostTraversal_btn.Click += new System.EventHandler(this.PostTraversal_btn_Click);
            // 
            // PreTraversal_btn
            // 
            this.PreTraversal_btn.Location = new System.Drawing.Point(6, 55);
            this.PreTraversal_btn.Name = "PreTraversal_btn";
            this.PreTraversal_btn.Size = new System.Drawing.Size(187, 25);
            this.PreTraversal_btn.TabIndex = 5;
            this.PreTraversal_btn.Text = "Preorder";
            this.PreTraversal_btn.UseVisualStyleBackColor = true;
            this.PreTraversal_btn.Click += new System.EventHandler(this.PreTraversal_btn_Click);
            // 
            // InTraversal_btn
            // 
            this.InTraversal_btn.Location = new System.Drawing.Point(6, 24);
            this.InTraversal_btn.Name = "InTraversal_btn";
            this.InTraversal_btn.Size = new System.Drawing.Size(187, 25);
            this.InTraversal_btn.TabIndex = 4;
            this.InTraversal_btn.Text = "Inorder";
            this.InTraversal_btn.UseVisualStyleBackColor = true;
            this.InTraversal_btn.Click += new System.EventHandler(this.InTraversal_btn_Click);
            // 
            // FindByPre
            // 
            this.FindByPre.Location = new System.Drawing.Point(9, 24);
            this.FindByPre.Name = "FindByPre";
            this.FindByPre.Size = new System.Drawing.Size(187, 25);
            this.FindByPre.TabIndex = 9;
            this.FindByPre.Text = "Infix + Prefix";
            this.FindByPre.UseVisualStyleBackColor = true;
            this.FindByPre.Click += new System.EventHandler(this.FindByPre_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(1, 1);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(877, 611);
            this.tabControl1.TabIndex = 2;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.Board);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Controls.Add(this.groupBox4);
            this.tabPage1.Location = new System.Drawing.Point(4, 27);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(869, 580);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Binary Tree";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // Board
            // 
            this.Board.BackColor = System.Drawing.SystemColors.Window;
            this.Board.Location = new System.Drawing.Point(219, 3);
            this.Board.Multiline = true;
            this.Board.Name = "Board";
            this.Board.ReadOnly = true;
            this.Board.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.Board.Size = new System.Drawing.Size(647, 572);
            this.Board.TabIndex = 3;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.pictureBox1);
            this.tabPage2.Controls.Add(this.groupBox5);
            this.tabPage2.Controls.Add(this.groupBox3);
            this.tabPage2.Location = new System.Drawing.Point(4, 27);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(869, 580);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Find BST";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(219, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(644, 572);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.FindByLevel);
            this.groupBox5.Controls.Add(this.FindByPost);
            this.groupBox5.Controls.Add(this.FindByPre);
            this.groupBox5.Location = new System.Drawing.Point(3, 171);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(210, 129);
            this.groupBox5.TabIndex = 9;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Output";
            // 
            // FindByLevel
            // 
            this.FindByLevel.Location = new System.Drawing.Point(9, 86);
            this.FindByLevel.Name = "FindByLevel";
            this.FindByLevel.Size = new System.Drawing.Size(187, 25);
            this.FindByLevel.TabIndex = 11;
            this.FindByLevel.Text = "Infix + Level";
            this.FindByLevel.UseVisualStyleBackColor = true;
            this.FindByLevel.Click += new System.EventHandler(this.FindByLevel_Click);
            // 
            // FindByPost
            // 
            this.FindByPost.Location = new System.Drawing.Point(9, 55);
            this.FindByPost.Name = "FindByPost";
            this.FindByPost.Size = new System.Drawing.Size(187, 25);
            this.FindByPost.TabIndex = 10;
            this.FindByPost.Text = "Infix + Postfix";
            this.FindByPost.UseVisualStyleBackColor = true;
            this.FindByPost.Click += new System.EventHandler(this.FindByPost_Click);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.label7);
            this.tabPage3.Location = new System.Drawing.Point(4, 27);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(869, 580);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Function list";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(20, 21);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(560, 144);
            this.label7.TabIndex = 0;
            this.label7.Text = resources.GetString("label7.Text");
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(880, 615);
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Homework 02 - Traversal & Determining a Binary Tree by Lingzi";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox5.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Range;
        private System.Windows.Forms.TextBox Quantity;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button Delete_btn;
        private System.Windows.Forms.Button Search_btn;
        private System.Windows.Forms.Button Insert_btn;
        private System.Windows.Forms.TextBox Number;
        private System.Windows.Forms.Button Clear_btn;
        private System.Windows.Forms.Button LevelTraversal_btn;
        private System.Windows.Forms.Button PostTraversal_btn;
        private System.Windows.Forms.Button PreTraversal_btn;
        private System.Windows.Forms.Button InTraversal_btn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox Level;
        private System.Windows.Forms.TextBox Postfix;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox Prefix;
        private System.Windows.Forms.TextBox Infix;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button FindByPre;
        private System.Windows.Forms.Button FindByLevel;
        private System.Windows.Forms.Button FindByPost;
        private System.Windows.Forms.TextBox Board;
        private System.Windows.Forms.Button Generate_btn;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Label label7;
    }
}

