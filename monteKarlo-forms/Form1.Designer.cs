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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.label1 = new System.Windows.Forms.Label();
            this.calculateButton = new System.Windows.Forms.Button();
            this.rightPoint = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.upPoint = new System.Windows.Forms.TextBox();
            this.leftPoint = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.figureGroupBox = new System.Windows.Forms.GroupBox();
            this.figurePicture = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBoxOOP = new System.Windows.Forms.GroupBox();
            this.objectDataGrid = new System.Windows.Forms.DataGridView();
            this.numberOfDots = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numberOfPointsInside = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.actualSquareColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MKSquare = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.accura = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.timeColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBoxNonOOP = new System.Windows.Forms.GroupBox();
            this.procedureDataGrid = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.statusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripContainer1 = new System.Windows.Forms.ToolStripContainer();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.figureGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.figurePicture)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.groupBoxOOP.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.objectDataGrid)).BeginInit();
            this.groupBoxNonOOP.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.procedureDataGrid)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.toolStripContainer1.BottomToolStripPanel.SuspendLayout();
            this.toolStripContainer1.ContentPanel.SuspendLayout();
            this.toolStripContainer1.SuspendLayout();
            this.SuspendLayout();
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
            this.splitContainer1.SplitterDistance = 188;
            this.splitContainer1.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(49, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "Левая точка (b)";
            // 
            // calculateButton
            // 
            this.calculateButton.Location = new System.Drawing.Point(275, 14);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(225, 62);
            this.calculateButton.TabIndex = 11;
            this.calculateButton.Text = "Вычислить";
            this.calculateButton.UseVisualStyleBackColor = true;
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // rightPoint
            // 
            this.rightPoint.Location = new System.Drawing.Point(155, 102);
            this.rightPoint.Name = "rightPoint";
            this.rightPoint.Size = new System.Drawing.Size(100, 20);
            this.rightPoint.TabIndex = 14;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(49, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 13);
            this.label3.TabIndex = 18;
            this.label3.Text = "Правая точка (d)";
            // 
            // upPoint
            // 
            this.upPoint.Location = new System.Drawing.Point(155, 56);
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
            this.label2.Location = new System.Drawing.Point(49, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 13);
            this.label2.TabIndex = 17;
            this.label2.Text = "Верхняя точка (c)";
            // 
            // figureGroupBox
            // 
            this.figureGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.figureGroupBox.Controls.Add(this.figurePicture);
            this.figureGroupBox.Location = new System.Drawing.Point(811, 3);
            this.figureGroupBox.Name = "figureGroupBox";
            this.figureGroupBox.Size = new System.Drawing.Size(326, 184);
            this.figureGroupBox.TabIndex = 10;
            this.figureGroupBox.TabStop = false;
            this.figureGroupBox.Text = "Фигура";
            // 
            // figurePicture
            // 
            this.figurePicture.BackColor = System.Drawing.SystemColors.Control;
            this.figurePicture.Dock = System.Windows.Forms.DockStyle.Fill;
            this.figurePicture.Image = ((System.Drawing.Image)(resources.GetObject("figurePicture.Image")));
            this.figurePicture.Location = new System.Drawing.Point(3, 16);
            this.figurePicture.Name = "figurePicture";
            this.figurePicture.Size = new System.Drawing.Size(320, 165);
            this.figurePicture.TabIndex = 0;
            this.figurePicture.TabStop = false;
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
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1143, 373);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // groupBoxOOP
            // 
            this.groupBoxOOP.Controls.Add(this.objectDataGrid);
            this.groupBoxOOP.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxOOP.Location = new System.Drawing.Point(3, 3);
            this.groupBoxOOP.Name = "groupBoxOOP";
            this.groupBoxOOP.Size = new System.Drawing.Size(565, 367);
            this.groupBoxOOP.TabIndex = 0;
            this.groupBoxOOP.TabStop = false;
            this.groupBoxOOP.Text = "ООП";
            // 
            // objectDataGrid
            // 
            this.objectDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.objectDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.objectDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.numberOfDots,
            this.numberOfPointsInside,
            this.actualSquareColumn,
            this.MKSquare,
            this.accura,
            this.timeColumn});
            this.objectDataGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.objectDataGrid.Location = new System.Drawing.Point(3, 16);
            this.objectDataGrid.Name = "objectDataGrid";
            this.objectDataGrid.RowHeadersVisible = false;
            this.objectDataGrid.Size = new System.Drawing.Size(559, 348);
            this.objectDataGrid.TabIndex = 1;
            // 
            // numberOfDots
            // 
            this.numberOfDots.HeaderText = "Количество точек";
            this.numberOfDots.Name = "numberOfDots";
            // 
            // numberOfPointsInside
            // 
            this.numberOfPointsInside.HeaderText = "Количество точек внутри";
            this.numberOfPointsInside.Name = "numberOfPointsInside";
            // 
            // actualSquareColumn
            // 
            this.actualSquareColumn.HeaderText = "Площадь фигуры";
            this.actualSquareColumn.Name = "actualSquareColumn";
            // 
            // MKSquare
            // 
            this.MKSquare.HeaderText = "Площадь методом МК";
            this.MKSquare.Name = "MKSquare";
            // 
            // accura
            // 
            this.accura.HeaderText = "Погрешность, %";
            this.accura.Name = "accura";
            // 
            // timeColumn
            // 
            this.timeColumn.HeaderText = "Время работы, мс";
            this.timeColumn.Name = "timeColumn";
            // 
            // groupBoxNonOOP
            // 
            this.groupBoxNonOOP.Controls.Add(this.procedureDataGrid);
            this.groupBoxNonOOP.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxNonOOP.Location = new System.Drawing.Point(574, 3);
            this.groupBoxNonOOP.Name = "groupBoxNonOOP";
            this.groupBoxNonOOP.Size = new System.Drawing.Size(566, 367);
            this.groupBoxNonOOP.TabIndex = 1;
            this.groupBoxNonOOP.TabStop = false;
            this.groupBoxNonOOP.Text = "Процедурно";
            // 
            // procedureDataGrid
            // 
            this.procedureDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.procedureDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.procedureDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
            this.procedureDataGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.procedureDataGrid.Location = new System.Drawing.Point(3, 16);
            this.procedureDataGrid.Name = "procedureDataGrid";
            this.procedureDataGrid.RowHeadersVisible = false;
            this.procedureDataGrid.Size = new System.Drawing.Size(560, 348);
            this.procedureDataGrid.TabIndex = 2;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Количество точек";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Количество точек внутри";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "Площадь фигуры";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.HeaderText = "Площадь методом МК";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.HeaderText = "Погрешность, %";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.HeaderText = "Время работы, мс";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
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
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.figureGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.figurePicture)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.groupBoxOOP.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.objectDataGrid)).EndInit();
            this.groupBoxNonOOP.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.procedureDataGrid)).EndInit();
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
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.GroupBox groupBoxOOP;
        private System.Windows.Forms.GroupBox groupBoxNonOOP;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel statusLabel;
        private System.Windows.Forms.ToolStripContainer toolStripContainer1;
        private System.Windows.Forms.DataGridView objectDataGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn numberOfDots;
        private System.Windows.Forms.DataGridViewTextBoxColumn numberOfPointsInside;
        private System.Windows.Forms.DataGridViewTextBoxColumn actualSquareColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn MKSquare;
        private System.Windows.Forms.DataGridViewTextBoxColumn accura;
        private System.Windows.Forms.DataGridViewTextBoxColumn timeColumn;
        private System.Windows.Forms.DataGridView procedureDataGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.TextBox rightPoint;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox upPoint;
        private System.Windows.Forms.TextBox leftPoint;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox figureGroupBox;
        private System.Windows.Forms.PictureBox figurePicture;
    }
}

