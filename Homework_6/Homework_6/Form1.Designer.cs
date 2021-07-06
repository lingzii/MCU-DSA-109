
namespace Homework_6
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
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.all_sort_btn = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.number = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.density = new System.Windows.Forms.Label();
            this.trackBar = new System.Windows.Forms.TrackBar();
            this.generate_btn = new System.Windows.Forms.Button();
            this.sort_btn = new System.Windows.Forms.Button();
            this.detail_ckb = new System.Windows.Forms.CheckBox();
            this.board = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tableLayoutPanel2);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(230, 461);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Random generate";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.all_sort_btn, 0, 5);
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel1, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.trackBar, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.generate_btn, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.sort_btn, 0, 4);
            this.tableLayoutPanel2.Controls.Add(this.detail_ckb, 0, 2);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 21);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 6;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(224, 437);
            this.tableLayoutPanel2.TabIndex = 2;
            // 
            // all_sort_btn
            // 
            this.all_sort_btn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.all_sort_btn.Location = new System.Drawing.Point(10, 360);
            this.all_sort_btn.Margin = new System.Windows.Forms.Padding(10);
            this.all_sort_btn.Name = "all_sort_btn";
            this.all_sort_btn.Size = new System.Drawing.Size(204, 67);
            this.all_sort_btn.TabIndex = 5;
            this.all_sort_btn.Text = "All sequence\r\nof Topology sort ";
            this.all_sort_btn.UseVisualStyleBackColor = true;
            this.all_sort_btn.Click += new System.EventHandler(this.all_sort_btn_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 57.98319F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 42.01681F));
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.number, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.density, 1, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(218, 94);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 47);
            this.label1.TabIndex = 0;
            this.label1.Text = "vertex number";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // number
            // 
            this.number.Dock = System.Windows.Forms.DockStyle.Fill;
            this.number.Location = new System.Drawing.Point(136, 10);
            this.number.Margin = new System.Windows.Forms.Padding(10, 10, 10, 3);
            this.number.Name = "number";
            this.number.Size = new System.Drawing.Size(72, 25);
            this.number.TabIndex = 3;
            this.number.TabStop = false;
            this.number.Text = "10";
            this.number.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Location = new System.Drawing.Point(3, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 47);
            this.label2.TabIndex = 4;
            this.label2.Text = "edge density";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // density
            // 
            this.density.AutoSize = true;
            this.density.Dock = System.Windows.Forms.DockStyle.Fill;
            this.density.Location = new System.Drawing.Point(129, 47);
            this.density.Name = "density";
            this.density.Size = new System.Drawing.Size(86, 47);
            this.density.TabIndex = 5;
            this.density.Text = "0.2";
            this.density.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // trackBar
            // 
            this.trackBar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.trackBar.Location = new System.Drawing.Point(10, 103);
            this.trackBar.Margin = new System.Windows.Forms.Padding(10, 3, 10, 3);
            this.trackBar.Maximum = 50;
            this.trackBar.Minimum = 2;
            this.trackBar.Name = "trackBar";
            this.trackBar.Size = new System.Drawing.Size(204, 34);
            this.trackBar.TabIndex = 2;
            this.trackBar.Value = 20;
            this.trackBar.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // generate_btn
            // 
            this.generate_btn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.generate_btn.Location = new System.Drawing.Point(10, 186);
            this.generate_btn.Margin = new System.Windows.Forms.Padding(10);
            this.generate_btn.Name = "generate_btn";
            this.generate_btn.Size = new System.Drawing.Size(204, 67);
            this.generate_btn.TabIndex = 1;
            this.generate_btn.Text = "Generate";
            this.generate_btn.UseVisualStyleBackColor = true;
            this.generate_btn.Click += new System.EventHandler(this.generate_btn_Click);
            // 
            // sort_btn
            // 
            this.sort_btn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sort_btn.Location = new System.Drawing.Point(10, 273);
            this.sort_btn.Margin = new System.Windows.Forms.Padding(10);
            this.sort_btn.Name = "sort_btn";
            this.sort_btn.Size = new System.Drawing.Size(204, 67);
            this.sort_btn.TabIndex = 3;
            this.sort_btn.Text = "Topology sort";
            this.sort_btn.UseVisualStyleBackColor = true;
            this.sort_btn.Click += new System.EventHandler(this.sort_btn_Click);
            // 
            // detail_ckb
            // 
            this.detail_ckb.AutoSize = true;
            this.detail_ckb.Checked = true;
            this.detail_ckb.CheckState = System.Windows.Forms.CheckState.Checked;
            this.detail_ckb.Dock = System.Windows.Forms.DockStyle.Fill;
            this.detail_ckb.Location = new System.Drawing.Point(16, 143);
            this.detail_ckb.Margin = new System.Windows.Forms.Padding(16, 3, 3, 3);
            this.detail_ckb.Name = "detail_ckb";
            this.detail_ckb.Size = new System.Drawing.Size(205, 30);
            this.detail_ckb.TabIndex = 4;
            this.detail_ckb.Text = "Print detailed result";
            this.detail_ckb.UseVisualStyleBackColor = true;
            // 
            // board
            // 
            this.board.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.board.BackColor = System.Drawing.SystemColors.Window;
            this.board.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.board.Location = new System.Drawing.Point(248, 12);
            this.board.Multiline = true;
            this.board.Name = "board";
            this.board.ReadOnly = true;
            this.board.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.board.Size = new System.Drawing.Size(800, 600);
            this.board.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1053, 625);
            this.Controls.Add(this.board);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.Text = "Homework 6 - Topological Sequences by Lingzi";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox number;
        private System.Windows.Forms.Button generate_btn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label density;
        private System.Windows.Forms.TrackBar trackBar;
        private System.Windows.Forms.TextBox board;
        private System.Windows.Forms.Button sort_btn;
        private System.Windows.Forms.Button all_sort_btn;
        private System.Windows.Forms.CheckBox detail_ckb;
    }
}

