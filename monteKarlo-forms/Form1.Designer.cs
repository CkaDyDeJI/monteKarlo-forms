namespace monteKarlo_forms
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
            this.figurePicture = new System.Windows.Forms.PictureBox();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.downPoint = new System.Windows.Forms.TextBox();
            this.calculateButton = new System.Windows.Forms.Button();
            this.rightPoint = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.upPoint = new System.Windows.Forms.TextBox();
            this.leftPoint = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.figureGroupBox = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBoxOOP = new System.Windows.Forms.GroupBox();
            this.forOOP = new System.Windows.Forms.RichTextBox();
            this.groupBoxNonOOP = new System.Windows.Forms.GroupBox();
            this.forNonOOP = new System.Windows.Forms.RichTextBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.statusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripContainer1 = new System.Windows.Forms.ToolStripContainer();
            ((System.ComponentModel.ISupportInitialize)(this.figurePicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.figureGroupBox.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.groupBoxOOP.SuspendLayout();
            this.groupBoxNonOOP.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.toolStripContainer1.BottomToolStripPanel.SuspendLayout();
            this.toolStripContainer1.ContentPanel.SuspendLayout();
            this.toolStripContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // figurePicture
            // 
            this.figurePicture.BackColor = System.Drawing.SystemColors.Control;
            this.figurePicture.Dock = System.Windows.Forms.DockStyle.Fill;
            this.figurePicture.Location = new System.Drawing.Point(3, 16);
            this.figurePicture.Name = "figurePicture";
            this.figurePicture.Size = new System.Drawing.Size(424, 161);
            this.figurePicture.TabIndex = 0;
            this.figurePicture.TabStop = false;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            this.splitContainer1.Panel1.Controls.Add(this.label4);
            this.splitContainer1.Panel1.Controls.Add(this.downPoint);
            this.splitContainer1.Panel1.Controls.Add(this.calculateButton);
            this.splitContainer1.Panel1.Controls.Add(this.rightPoint);
            this.splitContainer1.Panel1.Controls.Add(this.label3);
            this.splitContainer1.Panel1.Controls.Add(this.upPoint);
            this.splitContainer1.Panel1.Controls.Add(this.leftPoint);
            this.splitContainer1.Panel1.Controls.Add(this.label2);
            this.splitContainer1.Panel1.Controls.Add(this.figureGroupBox);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.tableLayoutPanel1);
            this.splitContainer1.Size = new System.Drawing.Size(1143, 565);
            this.splitContainer1.SplitterDistance = 198;
            this.splitContainer1.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "Левая точка";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 156);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 13);
            this.label4.TabIndex = 19;
            this.label4.Text = "Нижняя точка";
            // 
            // downPoint
            // 
            this.downPoint.Location = new System.Drawing.Point(155, 153);
            this.downPoint.Name = "downPoint";
            this.downPoint.Size = new System.Drawing.Size(100, 20);
            this.downPoint.TabIndex = 15;
            // 
            // calculateButton
            // 
            this.calculateButton.Location = new System.Drawing.Point(284, 79);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(75, 23);
            this.calculateButton.TabIndex = 11;
            this.calculateButton.Text = "Вычислить";
            this.calculateButton.UseVisualStyleBackColor = true;
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // rightPoint
            // 
            this.rightPoint.Location = new System.Drawing.Point(155, 106);
            this.rightPoint.Name = "rightPoint";
            this.rightPoint.Size = new System.Drawing.Size(100, 20);
            this.rightPoint.TabIndex = 14;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 13);
            this.label3.TabIndex = 18;
            this.label3.Text = "Правая точка";
            // 
            // upPoint
            // 
            this.upPoint.Location = new System.Drawing.Point(155, 60);
            this.upPoint.Name = "upPoint";
            this.upPoint.Size = new System.Drawing.Size(100, 20);
            this.upPoint.TabIndex = 13;
            // 
            // leftPoint
            // 
            this.leftPoint.Location = new System.Drawing.Point(155, 14);
            this.leftPoint.Name = "leftPoint";
            this.leftPoint.Size = new System.Drawing.Size(100, 20);
            this.leftPoint.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 13);
            this.label2.TabIndex = 17;
            this.label2.Text = "Верхняя точка";
            // 
            // figureGroupBox
            // 
            this.figureGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.figureGroupBox.Controls.Add(this.figurePicture);
            this.figureGroupBox.Location = new System.Drawing.Point(710, 3);
            this.figureGroupBox.Name = "figureGroupBox";
            this.figureGroupBox.Size = new System.Drawing.Size(430, 180);
            this.figureGroupBox.TabIndex = 10;
            this.figureGroupBox.TabStop = false;
            this.figureGroupBox.Text = "Фигура";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.groupBoxOOP, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.groupBoxNonOOP, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1143, 363);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // groupBoxOOP
            // 
            this.groupBoxOOP.Controls.Add(this.forOOP);
            this.groupBoxOOP.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxOOP.Location = new System.Drawing.Point(3, 3);
            this.groupBoxOOP.Name = "groupBoxOOP";
            this.groupBoxOOP.Size = new System.Drawing.Size(565, 357);
            this.groupBoxOOP.TabIndex = 0;
            this.groupBoxOOP.TabStop = false;
            this.groupBoxOOP.Text = "ООП";
            // 
            // forOOP
            // 
            this.forOOP.Dock = System.Windows.Forms.DockStyle.Fill;
            this.forOOP.Location = new System.Drawing.Point(3, 16);
            this.forOOP.Name = "forOOP";
            this.forOOP.Size = new System.Drawing.Size(559, 338);
            this.forOOP.TabIndex = 0;
            this.forOOP.Text = "";
            // 
            // groupBoxNonOOP
            // 
            this.groupBoxNonOOP.Controls.Add(this.forNonOOP);
            this.groupBoxNonOOP.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxNonOOP.Location = new System.Drawing.Point(574, 3);
            this.groupBoxNonOOP.Name = "groupBoxNonOOP";
            this.groupBoxNonOOP.Size = new System.Drawing.Size(566, 357);
            this.groupBoxNonOOP.TabIndex = 1;
            this.groupBoxNonOOP.TabStop = false;
            this.groupBoxNonOOP.Text = "Процедурно";
            // 
            // forNonOOP
            // 
            this.forNonOOP.Dock = System.Windows.Forms.DockStyle.Fill;
            this.forNonOOP.Location = new System.Drawing.Point(3, 16);
            this.forNonOOP.Name = "forNonOOP";
            this.forNonOOP.Size = new System.Drawing.Size(560, 338);
            this.forNonOOP.TabIndex = 0;
            this.forNonOOP.Text = "";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusLabel});
            this.statusStrip1.Location = new System.Drawing.Point(0, 0);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1143, 22);
            this.statusStrip1.TabIndex = 11;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // statusLabel
            // 
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(39, 17);
            this.statusLabel.Text = "Ready";
            // 
            // toolStripContainer1
            // 
            // 
            // toolStripContainer1.BottomToolStripPanel
            // 
            this.toolStripContainer1.BottomToolStripPanel.Controls.Add(this.statusStrip1);
            // 
            // toolStripContainer1.ContentPanel
            // 
            this.toolStripContainer1.ContentPanel.Controls.Add(this.splitContainer1);
            this.toolStripContainer1.ContentPanel.Size = new System.Drawing.Size(1143, 565);
            this.toolStripContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toolStripContainer1.Location = new System.Drawing.Point(0, 0);
            this.toolStripContainer1.Name = "toolStripContainer1";
            this.toolStripContainer1.Size = new System.Drawing.Size(1143, 612);
            this.toolStripContainer1.TabIndex = 12;
            this.toolStripContainer1.Text = "toolStripContainer1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1143, 612);
            this.Controls.Add(this.toolStripContainer1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.figurePicture)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.figureGroupBox.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.groupBoxOOP.ResumeLayout(false);
            this.groupBoxNonOOP.ResumeLayout(false);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.toolStripContainer1.BottomToolStripPanel.ResumeLayout(false);
            this.toolStripContainer1.BottomToolStripPanel.PerformLayout();
            this.toolStripContainer1.ContentPanel.ResumeLayout(false);
            this.toolStripContainer1.ResumeLayout(false);
            this.toolStripContainer1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox figurePicture;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.GroupBox groupBoxOOP;
        private System.Windows.Forms.RichTextBox forOOP;
        private System.Windows.Forms.GroupBox groupBoxNonOOP;
        private System.Windows.Forms.RichTextBox forNonOOP;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel statusLabel;
        private System.Windows.Forms.ToolStripContainer toolStripContainer1;
        private System.Windows.Forms.GroupBox figureGroupBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox downPoint;
        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.TextBox rightPoint;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox upPoint;
        private System.Windows.Forms.TextBox leftPoint;
        private System.Windows.Forms.Label label2;
    }
}

