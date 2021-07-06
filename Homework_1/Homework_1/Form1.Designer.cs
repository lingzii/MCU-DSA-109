
namespace Homework_1
{
    partial class mainForm
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainForm));
            this.modifyBox = new System.Windows.Forms.TextBox();
            this.insertBtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.QuantityBox = new System.Windows.Forms.TextBox();
            this.RangeBox = new System.Windows.Forms.TextBox();
            this.searchBtn = new System.Windows.Forms.Button();
            this.clearBtn = new System.Windows.Forms.Button();
            this.preorderBtn = new System.Windows.Forms.Button();
            this.generateBtn = new System.Windows.Forms.Button();
            this.inorderBtn = new System.Windows.Forms.Button();
            this.postorderBtn = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.board = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // modifyBox
            // 
            this.modifyBox.Location = new System.Drawing.Point(26, 32);
            this.modifyBox.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.modifyBox.Name = "modifyBox";
            this.modifyBox.Size = new System.Drawing.Size(196, 24);
            this.modifyBox.TabIndex = 0;
            this.modifyBox.Text = "16";
            this.modifyBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // insertBtn
            // 
            this.insertBtn.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.insertBtn.Location = new System.Drawing.Point(26, 74);
            this.insertBtn.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.insertBtn.Name = "insertBtn";
            this.insertBtn.Size = new System.Drawing.Size(96, 30);
            this.insertBtn.TabIndex = 2;
            this.insertBtn.Text = "Insert";
            this.insertBtn.UseVisualStyleBackColor = false;
            this.insertBtn.Click += new System.EventHandler(this.insertBtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 35);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 18);
            this.label2.TabIndex = 7;
            this.label2.Text = "Quantity";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(35, 77);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 18);
            this.label3.TabIndex = 8;
            this.label3.Text = "Range";
            // 
            // QuantityBox
            // 
            this.QuantityBox.Location = new System.Drawing.Point(138, 32);
            this.QuantityBox.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.QuantityBox.Name = "QuantityBox";
            this.QuantityBox.Size = new System.Drawing.Size(84, 24);
            this.QuantityBox.TabIndex = 9;
            this.QuantityBox.Text = "10";
            this.QuantityBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // RangeBox
            // 
            this.RangeBox.Location = new System.Drawing.Point(138, 74);
            this.RangeBox.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.RangeBox.Name = "RangeBox";
            this.RangeBox.Size = new System.Drawing.Size(84, 24);
            this.RangeBox.TabIndex = 10;
            this.RangeBox.Text = "100";
            this.RangeBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // searchBtn
            // 
            this.searchBtn.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.searchBtn.Location = new System.Drawing.Point(126, 74);
            this.searchBtn.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.searchBtn.Name = "searchBtn";
            this.searchBtn.Size = new System.Drawing.Size(96, 30);
            this.searchBtn.TabIndex = 11;
            this.searchBtn.Text = "Search";
            this.searchBtn.UseVisualStyleBackColor = false;
            this.searchBtn.Click += new System.EventHandler(this.searchBtn_Click);
            // 
            // clearBtn
            // 
            this.clearBtn.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.clearBtn.Location = new System.Drawing.Point(26, 119);
            this.clearBtn.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.clearBtn.Name = "clearBtn";
            this.clearBtn.Size = new System.Drawing.Size(196, 30);
            this.clearBtn.TabIndex = 14;
            this.clearBtn.Text = "Clear";
            this.clearBtn.UseVisualStyleBackColor = false;
            this.clearBtn.Click += new System.EventHandler(this.clearBtn_Click);
            // 
            // preorderBtn
            // 
            this.preorderBtn.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.preorderBtn.Location = new System.Drawing.Point(26, 73);
            this.preorderBtn.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.preorderBtn.Name = "preorderBtn";
            this.preorderBtn.Size = new System.Drawing.Size(196, 30);
            this.preorderBtn.TabIndex = 18;
            this.preorderBtn.Text = "Preorder";
            this.preorderBtn.UseVisualStyleBackColor = false;
            this.preorderBtn.Click += new System.EventHandler(this.preorderBtn_Click);
            // 
            // generateBtn
            // 
            this.generateBtn.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.generateBtn.Location = new System.Drawing.Point(26, 119);
            this.generateBtn.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.generateBtn.Name = "generateBtn";
            this.generateBtn.Size = new System.Drawing.Size(196, 30);
            this.generateBtn.TabIndex = 19;
            this.generateBtn.Text = "Generate";
            this.generateBtn.UseVisualStyleBackColor = false;
            this.generateBtn.Click += new System.EventHandler(this.generateBtn_Click);
            // 
            // inorderBtn
            // 
            this.inorderBtn.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.inorderBtn.Location = new System.Drawing.Point(26, 28);
            this.inorderBtn.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.inorderBtn.Name = "inorderBtn";
            this.inorderBtn.Size = new System.Drawing.Size(196, 30);
            this.inorderBtn.TabIndex = 20;
            this.inorderBtn.Text = "Inorder";
            this.inorderBtn.UseVisualStyleBackColor = false;
            this.inorderBtn.Click += new System.EventHandler(this.inorderBtn_Click);
            // 
            // postorderBtn
            // 
            this.postorderBtn.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.postorderBtn.Location = new System.Drawing.Point(26, 119);
            this.postorderBtn.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.postorderBtn.Name = "postorderBtn";
            this.postorderBtn.Size = new System.Drawing.Size(196, 30);
            this.postorderBtn.TabIndex = 21;
            this.postorderBtn.Text = "Postorder";
            this.postorderBtn.UseVisualStyleBackColor = false;
            this.postorderBtn.Click += new System.EventHandler(this.postorderBtn_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.QuantityBox);
            this.groupBox1.Controls.Add(this.RangeBox);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.generateBtn);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox1.Location = new System.Drawing.Point(12, 184);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(244, 165);
            this.groupBox1.TabIndex = 22;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Random generation";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.modifyBox);
            this.groupBox2.Controls.Add(this.insertBtn);
            this.groupBox2.Controls.Add(this.searchBtn);
            this.groupBox2.Controls.Add(this.clearBtn);
            this.groupBox2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(244, 166);
            this.groupBox2.TabIndex = 23;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "BST modify";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.inorderBtn);
            this.groupBox3.Controls.Add(this.preorderBtn);
            this.groupBox3.Controls.Add(this.postorderBtn);
            this.groupBox3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox3.Location = new System.Drawing.Point(12, 355);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(244, 167);
            this.groupBox3.TabIndex = 24;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Display BST";
            // 
            // board
            // 
            this.board.BackColor = System.Drawing.SystemColors.GrayText;
            this.board.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.board.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.board.Location = new System.Drawing.Point(272, 12);
            this.board.Margin = new System.Windows.Forms.Padding(10);
            this.board.Multiline = true;
            this.board.Name = "board";
            this.board.ReadOnly = true;
            this.board.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.board.Size = new System.Drawing.Size(597, 510);
            this.board.TabIndex = 25;
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(883, 542);
            this.Controls.Add(this.board);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Consolas", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "mainForm";
            this.Text = "Binary Search Tree by Lingzi";
            this.Load += new System.EventHandler(this.mainForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox modifyBox;
        private System.Windows.Forms.Button insertBtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox QuantityBox;
        private System.Windows.Forms.TextBox RangeBox;
        private System.Windows.Forms.Button searchBtn;
        private System.Windows.Forms.Button clearBtn;
        private System.Windows.Forms.Button preorderBtn;
        private System.Windows.Forms.Button generateBtn;
        private System.Windows.Forms.Button inorderBtn;
        private System.Windows.Forms.Button postorderBtn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox board;
    }
}

