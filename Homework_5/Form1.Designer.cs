
namespace Homework_5
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.generate_btn = new System.Windows.Forms.Button();
            this.maxWeight = new System.Windows.Forms.TextBox();
            this.import_btn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.weightRange = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.vertexNumber = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.broad = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.sourceGridView = new System.Windows.Forms.DataGridView();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.MSTGridView = new System.Windows.Forms.DataGridView();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.sort_ckb = new System.Windows.Forms.RadioButton();
            this.kruskal_btn = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.detect_subset_ckb = new System.Windows.Forms.RadioButton();
            this.detect_loop_ckb = new System.Windows.Forms.RadioButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.prim_btn = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tabControl.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sourceGridView)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MSTGridView)).BeginInit();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tableLayoutPanel1);
            this.groupBox1.Location = new System.Drawing.Point(12, 13);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Size = new System.Drawing.Size(270, 203);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Random generate";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.generate_btn, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.maxWeight, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.import_btn, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.weightRange, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.vertexNumber, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 22);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(10);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(264, 177);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // generate_btn
            // 
            this.generate_btn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.generate_btn.Location = new System.Drawing.Point(138, 138);
            this.generate_btn.Margin = new System.Windows.Forms.Padding(6);
            this.generate_btn.Name = "generate_btn";
            this.generate_btn.Size = new System.Drawing.Size(120, 33);
            this.generate_btn.TabIndex = 3;
            this.generate_btn.Text = "Generate";
            this.generate_btn.UseVisualStyleBackColor = true;
            this.generate_btn.Click += new System.EventHandler(this.generate_btn_Click);
            // 
            // maxWeight
            // 
            this.maxWeight.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.maxWeight.Location = new System.Drawing.Point(138, 98);
            this.maxWeight.Margin = new System.Windows.Forms.Padding(6, 10, 6, 3);
            this.maxWeight.Name = "maxWeight";
            this.maxWeight.Size = new System.Drawing.Size(120, 25);
            this.maxWeight.TabIndex = 4;
            this.maxWeight.Text = "250";
            this.maxWeight.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // import_btn
            // 
            this.import_btn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.import_btn.Location = new System.Drawing.Point(6, 138);
            this.import_btn.Margin = new System.Windows.Forms.Padding(6);
            this.import_btn.Name = "import_btn";
            this.import_btn.Size = new System.Drawing.Size(120, 33);
            this.import_btn.TabIndex = 2;
            this.import_btn.Text = "Import";
            this.import_btn.UseVisualStyleBackColor = true;
            this.import_btn.Click += new System.EventHandler(this.import_btn_Click);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(126, 44);
            this.label3.TabIndex = 7;
            this.label3.Text = "max weight";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // weightRange
            // 
            this.weightRange.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.weightRange.Location = new System.Drawing.Point(138, 54);
            this.weightRange.Margin = new System.Windows.Forms.Padding(6, 10, 6, 3);
            this.weightRange.Name = "weightRange";
            this.weightRange.Size = new System.Drawing.Size(120, 25);
            this.weightRange.TabIndex = 3;
            this.weightRange.Text = "1000";
            this.weightRange.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 44);
            this.label1.TabIndex = 5;
            this.label1.Text = "vertex number";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // vertexNumber
            // 
            this.vertexNumber.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.vertexNumber.Location = new System.Drawing.Point(138, 10);
            this.vertexNumber.Margin = new System.Windows.Forms.Padding(6, 10, 6, 3);
            this.vertexNumber.Name = "vertexNumber";
            this.vertexNumber.Size = new System.Drawing.Size(120, 25);
            this.vertexNumber.TabIndex = 2;
            this.vertexNumber.Text = "10";
            this.vertexNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 44);
            this.label2.TabIndex = 6;
            this.label2.Text = "weight range";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tabControl
            // 
            this.tabControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl.Controls.Add(this.tabPage1);
            this.tabControl.Controls.Add(this.tabPage2);
            this.tabControl.Controls.Add(this.tabPage3);
            this.tabControl.Controls.Add(this.tabPage4);
            this.tabControl.Location = new System.Drawing.Point(292, 12);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(926, 590);
            this.tabControl.TabIndex = 2;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.broad);
            this.tabPage1.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.tabPage1.Location = new System.Drawing.Point(4, 27);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(918, 559);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "console";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // broad
            // 
            this.broad.BackColor = System.Drawing.SystemColors.Window;
            this.broad.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.broad.Dock = System.Windows.Forms.DockStyle.Fill;
            this.broad.Location = new System.Drawing.Point(3, 3);
            this.broad.Multiline = true;
            this.broad.Name = "broad";
            this.broad.ReadOnly = true;
            this.broad.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.broad.Size = new System.Drawing.Size(912, 553);
            this.broad.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.sourceGridView);
            this.tabPage2.Location = new System.Drawing.Point(4, 27);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(918, 559);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "source matrix";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // sourceGridView
            // 
            this.sourceGridView.AllowUserToAddRows = false;
            this.sourceGridView.AllowUserToDeleteRows = false;
            this.sourceGridView.AllowUserToResizeColumns = false;
            this.sourceGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.sourceGridView.BackgroundColor = System.Drawing.SystemColors.Window;
            this.sourceGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.sourceGridView.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            this.sourceGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.sourceGridView.ColumnHeadersVisible = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Code New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.sourceGridView.DefaultCellStyle = dataGridViewCellStyle1;
            this.sourceGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sourceGridView.Location = new System.Drawing.Point(3, 3);
            this.sourceGridView.MultiSelect = false;
            this.sourceGridView.Name = "sourceGridView";
            this.sourceGridView.ReadOnly = true;
            this.sourceGridView.RowHeadersVisible = false;
            this.sourceGridView.RowHeadersWidth = 51;
            this.sourceGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.sourceGridView.RowTemplate.Height = 45;
            this.sourceGridView.RowTemplate.ReadOnly = true;
            this.sourceGridView.ShowCellErrors = false;
            this.sourceGridView.ShowCellToolTips = false;
            this.sourceGridView.ShowEditingIcon = false;
            this.sourceGridView.ShowRowErrors = false;
            this.sourceGridView.Size = new System.Drawing.Size(912, 553);
            this.sourceGridView.TabIndex = 0;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.MSTGridView);
            this.tabPage3.Location = new System.Drawing.Point(4, 27);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(918, 559);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "MST edge matrix";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // MSTGridView
            // 
            this.MSTGridView.AllowUserToAddRows = false;
            this.MSTGridView.AllowUserToDeleteRows = false;
            this.MSTGridView.AllowUserToResizeColumns = false;
            this.MSTGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.MSTGridView.BackgroundColor = System.Drawing.SystemColors.Window;
            this.MSTGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.MSTGridView.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            this.MSTGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.MSTGridView.ColumnHeadersVisible = false;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Code New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.MSTGridView.DefaultCellStyle = dataGridViewCellStyle2;
            this.MSTGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MSTGridView.Location = new System.Drawing.Point(3, 3);
            this.MSTGridView.MultiSelect = false;
            this.MSTGridView.Name = "MSTGridView";
            this.MSTGridView.ReadOnly = true;
            this.MSTGridView.RowHeadersVisible = false;
            this.MSTGridView.RowHeadersWidth = 51;
            this.MSTGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.MSTGridView.RowTemplate.Height = 45;
            this.MSTGridView.RowTemplate.ReadOnly = true;
            this.MSTGridView.ShowCellErrors = false;
            this.MSTGridView.ShowCellToolTips = false;
            this.MSTGridView.ShowEditingIcon = false;
            this.MSTGridView.ShowRowErrors = false;
            this.MSTGridView.Size = new System.Drawing.Size(912, 553);
            this.MSTGridView.TabIndex = 1;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.pictureBox);
            this.tabPage4.Location = new System.Drawing.Point(4, 27);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(918, 559);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "MST visualization";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // pictureBox
            // 
            this.pictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox.Location = new System.Drawing.Point(3, 3);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(912, 553);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox.TabIndex = 0;
            this.pictureBox.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tableLayoutPanel2);
            this.groupBox2.Location = new System.Drawing.Point(12, 225);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(270, 236);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Find MST by kruskal";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel4, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.kruskal_btn, 0, 4);
            this.tableLayoutPanel2.Controls.Add(this.label4, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.label5, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel3, 0, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 21);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 5;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 67F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(264, 212);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 2;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Controls.Add(this.radioButton4, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.sort_ckb, 0, 0);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(3, 111);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(258, 30);
            this.tableLayoutPanel4.TabIndex = 4;
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radioButton4.Location = new System.Drawing.Point(132, 3);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(123, 24);
            this.radioButton4.TabIndex = 3;
            this.radioButton4.Text = "heap";
            this.radioButton4.UseVisualStyleBackColor = true;
            // 
            // sort_ckb
            // 
            this.sort_ckb.AutoSize = true;
            this.sort_ckb.Checked = true;
            this.sort_ckb.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sort_ckb.Location = new System.Drawing.Point(3, 3);
            this.sort_ckb.Name = "sort_ckb";
            this.sort_ckb.Size = new System.Drawing.Size(123, 24);
            this.sort_ckb.TabIndex = 2;
            this.sort_ckb.TabStop = true;
            this.sort_ckb.Text = "sort";
            this.sort_ckb.UseVisualStyleBackColor = true;
            // 
            // kruskal_btn
            // 
            this.kruskal_btn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kruskal_btn.Location = new System.Drawing.Point(6, 154);
            this.kruskal_btn.Margin = new System.Windows.Forms.Padding(6, 10, 6, 10);
            this.kruskal_btn.Name = "kruskal_btn";
            this.kruskal_btn.Size = new System.Drawing.Size(252, 48);
            this.kruskal_btn.TabIndex = 0;
            this.kruskal_btn.Text = "Kruskal\'s algorithm";
            this.kruskal_btn.UseVisualStyleBackColor = true;
            this.kruskal_btn.Click += new System.EventHandler(this.kruskal_btn_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Location = new System.Drawing.Point(3, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(258, 36);
            this.label4.TabIndex = 1;
            this.label4.Text = "Cycle detection by";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label5.Location = new System.Drawing.Point(3, 72);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(258, 36);
            this.label5.TabIndex = 2;
            this.label5.Text = "Per edge order by";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 49.6124F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.3876F));
            this.tableLayoutPanel3.Controls.Add(this.detect_subset_ckb, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.detect_loop_ckb, 0, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 39);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(258, 30);
            this.tableLayoutPanel3.TabIndex = 3;
            // 
            // detect_subset_ckb
            // 
            this.detect_subset_ckb.AutoSize = true;
            this.detect_subset_ckb.Dock = System.Windows.Forms.DockStyle.Fill;
            this.detect_subset_ckb.Location = new System.Drawing.Point(130, 3);
            this.detect_subset_ckb.Name = "detect_subset_ckb";
            this.detect_subset_ckb.Size = new System.Drawing.Size(125, 24);
            this.detect_subset_ckb.TabIndex = 1;
            this.detect_subset_ckb.Text = "unionFind";
            this.detect_subset_ckb.UseVisualStyleBackColor = true;
            // 
            // detect_loop_ckb
            // 
            this.detect_loop_ckb.AutoSize = true;
            this.detect_loop_ckb.Checked = true;
            this.detect_loop_ckb.Dock = System.Windows.Forms.DockStyle.Fill;
            this.detect_loop_ckb.Location = new System.Drawing.Point(3, 3);
            this.detect_loop_ckb.Name = "detect_loop_ckb";
            this.detect_loop_ckb.Size = new System.Drawing.Size(121, 24);
            this.detect_loop_ckb.TabIndex = 0;
            this.detect_loop_ckb.TabStop = true;
            this.detect_loop_ckb.Text = "loop";
            this.detect_loop_ckb.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.prim_btn);
            this.groupBox3.Location = new System.Drawing.Point(12, 467);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(270, 94);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Find MST by Prim";
            // 
            // prim_btn
            // 
            this.prim_btn.Location = new System.Drawing.Point(9, 31);
            this.prim_btn.Name = "prim_btn";
            this.prim_btn.Size = new System.Drawing.Size(252, 47);
            this.prim_btn.TabIndex = 0;
            this.prim_btn.Text = "Prim\'s algorithm";
            this.prim_btn.UseVisualStyleBackColor = true;
            this.prim_btn.Click += new System.EventHandler(this.prim_btn_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Checked = true;
            this.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.checkBox1.Location = new System.Drawing.Point(0, 0);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.checkBox1.Size = new System.Drawing.Size(270, 39);
            this.checkBox1.TabIndex = 0;
            this.checkBox1.Text = "Print edges in MST";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.checkBox1);
            this.panel1.Location = new System.Drawing.Point(12, 567);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(270, 39);
            this.panel1.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1230, 614);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Code New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.Text = "Home 5 - MST_Kruskal\'s and Prim\'s algorithms by Lingzi";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tabControl.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.sourceGridView)).EndInit();
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.MSTGridView)).EndInit();
            this.tabPage4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button generate_btn;
        private System.Windows.Forms.TextBox maxWeight;
        private System.Windows.Forms.Button import_btn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox weightRange;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox vertexNumber;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button kruskal_btn;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button prim_btn;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.RadioButton sort_ckb;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.RadioButton detect_subset_ckb;
        private System.Windows.Forms.RadioButton detect_loop_ckb;
        private System.Windows.Forms.TextBox broad;
        private System.Windows.Forms.DataGridView sourceGridView;
        private System.Windows.Forms.DataGridView MSTGridView;
        private System.Windows.Forms.PictureBox pictureBox;
    }
}

