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
            this.calculateButton = new System.Windows.Forms.Button();
            this.leftPoint = new System.Windows.Forms.TextBox();
            this.upPoint = new System.Windows.Forms.TextBox();
            this.rightPoint = new System.Windows.Forms.TextBox();
            this.downPoint = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBoxOOP = new System.Windows.Forms.GroupBox();
            this.forOOP = new System.Windows.Forms.RichTextBox();
            this.groupBoxNonOOP = new System.Windows.Forms.GroupBox();
            this.forNonOOP = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.figurePicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.groupBoxOOP.SuspendLayout();
            this.groupBoxNonOOP.SuspendLayout();
            this.SuspendLayout();
            // 
            // figurePicture
            // 
            this.figurePicture.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.figurePicture.Dock = System.Windows.Forms.DockStyle.Right;
            this.figurePicture.Location = new System.Drawing.Point(574, 0);
            this.figurePicture.Name = "figurePicture";
            this.figurePicture.Size = new System.Drawing.Size(569, 215);
            this.figurePicture.TabIndex = 0;
            this.figurePicture.TabStop = false;
            // 
            // calculateButton
            // 
            this.calculateButton.Location = new System.Drawing.Point(311, 87);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(75, 23);
            this.calculateButton.TabIndex = 1;
            this.calculateButton.Text = "Вычислить";
            this.calculateButton.UseVisualStyleBackColor = true;
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // leftPoint
            // 
            this.leftPoint.Location = new System.Drawing.Point(182, 22);
            this.leftPoint.Name = "leftPoint";
            this.leftPoint.Size = new System.Drawing.Size(100, 20);
            this.leftPoint.TabIndex = 2;
            // 
            // upPoint
            // 
            this.upPoint.Location = new System.Drawing.Point(182, 68);
            this.upPoint.Name = "upPoint";
            this.upPoint.Size = new System.Drawing.Size(100, 20);
            this.upPoint.TabIndex = 3;
            // 
            // rightPoint
            // 
            this.rightPoint.Location = new System.Drawing.Point(182, 114);
            this.rightPoint.Name = "rightPoint";
            this.rightPoint.Size = new System.Drawing.Size(100, 20);
            this.rightPoint.TabIndex = 4;
            // 
            // downPoint
            // 
            this.downPoint.Location = new System.Drawing.Point(182, 161);
            this.downPoint.Name = "downPoint";
            this.downPoint.Size = new System.Drawing.Size(100, 20);
            this.downPoint.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Левая точка";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Верхняя точка";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(39, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Правая точка";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(39, 164);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Нижняя точка";
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
            this.splitContainer1.Panel1.Controls.Add(this.figurePicture);
            this.splitContainer1.Panel1.Controls.Add(this.label4);
            this.splitContainer1.Panel1.Controls.Add(this.calculateButton);
            this.splitContainer1.Panel1.Controls.Add(this.label3);
            this.splitContainer1.Panel1.Controls.Add(this.leftPoint);
            this.splitContainer1.Panel1.Controls.Add(this.label2);
            this.splitContainer1.Panel1.Controls.Add(this.upPoint);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            this.splitContainer1.Panel1.Controls.Add(this.rightPoint);
            this.splitContainer1.Panel1.Controls.Add(this.downPoint);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.tableLayoutPanel1);
            this.splitContainer1.Size = new System.Drawing.Size(1143, 612);
            this.splitContainer1.SplitterDistance = 215;
            this.splitContainer1.TabIndex = 10;
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
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1143, 393);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // groupBoxOOP
            // 
            this.groupBoxOOP.Controls.Add(this.forOOP);
            this.groupBoxOOP.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxOOP.Location = new System.Drawing.Point(3, 3);
            this.groupBoxOOP.Name = "groupBoxOOP";
            this.groupBoxOOP.Size = new System.Drawing.Size(565, 387);
            this.groupBoxOOP.TabIndex = 0;
            this.groupBoxOOP.TabStop = false;
            this.groupBoxOOP.Text = "ООП";
            // 
            // forOOP
            // 
            this.forOOP.Dock = System.Windows.Forms.DockStyle.Fill;
            this.forOOP.Location = new System.Drawing.Point(3, 16);
            this.forOOP.Name = "forOOP";
            this.forOOP.Size = new System.Drawing.Size(559, 368);
            this.forOOP.TabIndex = 0;
            this.forOOP.Text = "";
            // 
            // groupBoxNonOOP
            // 
            this.groupBoxNonOOP.Controls.Add(this.forNonOOP);
            this.groupBoxNonOOP.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxNonOOP.Location = new System.Drawing.Point(574, 3);
            this.groupBoxNonOOP.Name = "groupBoxNonOOP";
            this.groupBoxNonOOP.Size = new System.Drawing.Size(566, 387);
            this.groupBoxNonOOP.TabIndex = 1;
            this.groupBoxNonOOP.TabStop = false;
            this.groupBoxNonOOP.Text = "Процедурно";
            // 
            // forNonOOP
            // 
            this.forNonOOP.Dock = System.Windows.Forms.DockStyle.Fill;
            this.forNonOOP.Location = new System.Drawing.Point(3, 16);
            this.forNonOOP.Name = "forNonOOP";
            this.forNonOOP.Size = new System.Drawing.Size(560, 368);
            this.forNonOOP.TabIndex = 0;
            this.forNonOOP.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1143, 612);
            this.Controls.Add(this.splitContainer1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.figurePicture)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.groupBoxOOP.ResumeLayout(false);
            this.groupBoxNonOOP.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox figurePicture;
        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.TextBox leftPoint;
        private System.Windows.Forms.TextBox upPoint;
        private System.Windows.Forms.TextBox rightPoint;
        private System.Windows.Forms.TextBox downPoint;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.GroupBox groupBoxOOP;
        private System.Windows.Forms.RichTextBox forOOP;
        private System.Windows.Forms.GroupBox groupBoxNonOOP;
        private System.Windows.Forms.RichTextBox forNonOOP;
    }
}

