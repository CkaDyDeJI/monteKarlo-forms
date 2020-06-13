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
            this.aLabel = new System.Windows.Forms.Label();
            this.bottomText = new System.Windows.Forms.TextBox();
            this.clearButton = new System.Windows.Forms.Button();
            this.controlCheck = new System.Windows.Forms.RadioButton();
            this.manualCheck = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.calculateButton = new System.Windows.Forms.Button();
            this.rightPoint = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.upPoint = new System.Windows.Forms.TextBox();
            this.leftPoint = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.figureGroupBox = new System.Windows.Forms.GroupBox();
            this.figurePicture = new System.Windows.Forms.PictureBox();
            this.groupBoxOOP = new System.Windows.Forms.GroupBox();
            this.objectDataGrid = new System.Windows.Forms.DataGridView();
            this.numberOfDots = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numberOfPointsInside = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.actualSquareColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MKSquare = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.accura = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.timeColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolStripContainer1 = new System.Windows.Forms.ToolStripContainer();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.figureGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.figurePicture)).BeginInit();
            this.groupBoxOOP.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.objectDataGrid)).BeginInit();
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
            this.splitContainer1.Panel1.Controls.Add(this.aLabel);
            this.splitContainer1.Panel1.Controls.Add(this.bottomText);
            this.splitContainer1.Panel1.Controls.Add(this.clearButton);
            this.splitContainer1.Panel1.Controls.Add(this.controlCheck);
            this.splitContainer1.Panel1.Controls.Add(this.manualCheck);
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
            this.splitContainer1.Panel2.Controls.Add(this.groupBoxOOP);
            this.splitContainer1.Size = new System.Drawing.Size(1143, 612);
            this.splitContainer1.SplitterDistance = 201;
            this.splitContainer1.TabIndex = 10;
            // 
            // aLabel
            // 
            this.aLabel.AutoSize = true;
            this.aLabel.Location = new System.Drawing.Point(49, 27);
            this.aLabel.Name = "aLabel";
            this.aLabel.Size = new System.Drawing.Size(93, 13);
            this.aLabel.TabIndex = 23;
            this.aLabel.Text = "Нижняя точка (a)";
            // 
            // bottomText
            // 
            this.bottomText.Location = new System.Drawing.Point(155, 24);
            this.bottomText.Name = "bottomText";
            this.bottomText.Size = new System.Drawing.Size(100, 20);
            this.bottomText.TabIndex = 22;
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(275, 99);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(129, 23);
            this.clearButton.TabIndex = 21;
            this.clearButton.Text = "Очистить";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // controlCheck
            // 
            this.controlCheck.AutoSize = true;
            this.controlCheck.Location = new System.Drawing.Point(275, 49);
            this.controlCheck.Name = "controlCheck";
            this.controlCheck.Size = new System.Drawing.Size(129, 17);
            this.controlCheck.TabIndex = 20;
            this.controlCheck.TabStop = true;
            this.controlCheck.Text = "Конрольный пример";
            this.controlCheck.UseVisualStyleBackColor = true;
            this.controlCheck.CheckedChanged += new System.EventHandler(this.controlCheck_CheckedChanged);
            // 
            // manualCheck
            // 
            this.manualCheck.AutoSize = true;
            this.manualCheck.Location = new System.Drawing.Point(275, 25);
            this.manualCheck.Name = "manualCheck";
            this.manualCheck.Size = new System.Drawing.Size(87, 17);
            this.manualCheck.TabIndex = 19;
            this.manualCheck.TabStop = true;
            this.manualCheck.Text = "Ручной ввод";
            this.manualCheck.UseVisualStyleBackColor = true;
            this.manualCheck.CheckedChanged += new System.EventHandler(this.manualCheck_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(49, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "Левая точка (b)";
            // 
            // calculateButton
            // 
            this.calculateButton.Location = new System.Drawing.Point(275, 73);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(129, 23);
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
            this.upPoint.Location = new System.Drawing.Point(155, 76);
            this.upPoint.Name = "upPoint";
            this.upPoint.Size = new System.Drawing.Size(100, 20);
            this.upPoint.TabIndex = 13;
            // 
            // leftPoint
            // 
            this.leftPoint.Location = new System.Drawing.Point(155, 50);
            this.leftPoint.Name = "leftPoint";
            this.leftPoint.Size = new System.Drawing.Size(100, 20);
            this.leftPoint.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(49, 79);
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
            // groupBoxOOP
            // 
            this.groupBoxOOP.Controls.Add(this.objectDataGrid);
            this.groupBoxOOP.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxOOP.Location = new System.Drawing.Point(0, 0);
            this.groupBoxOOP.Name = "groupBoxOOP";
            this.groupBoxOOP.Size = new System.Drawing.Size(1143, 407);
            this.groupBoxOOP.TabIndex = 1;
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
            this.objectDataGrid.Size = new System.Drawing.Size(1137, 388);
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
            // toolStripContainer1
            // 
            // 
            // toolStripContainer1.ContentPanel
            // 
            this.toolStripContainer1.ContentPanel.Controls.Add(this.splitContainer1);
            this.toolStripContainer1.ContentPanel.Size = new System.Drawing.Size(1143, 612);
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
            this.groupBoxOOP.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.objectDataGrid)).EndInit();
            this.toolStripContainer1.ContentPanel.ResumeLayout(false);
            this.toolStripContainer1.ResumeLayout(false);
            this.toolStripContainer1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.ToolStripContainer toolStripContainer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.TextBox rightPoint;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox upPoint;
        private System.Windows.Forms.TextBox leftPoint;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox figureGroupBox;
        private System.Windows.Forms.PictureBox figurePicture;
        private System.Windows.Forms.GroupBox groupBoxOOP;
        private System.Windows.Forms.DataGridView objectDataGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn numberOfDots;
        private System.Windows.Forms.DataGridViewTextBoxColumn numberOfPointsInside;
        private System.Windows.Forms.DataGridViewTextBoxColumn actualSquareColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn MKSquare;
        private System.Windows.Forms.DataGridViewTextBoxColumn accura;
        private System.Windows.Forms.DataGridViewTextBoxColumn timeColumn;
        private System.Windows.Forms.RadioButton controlCheck;
        private System.Windows.Forms.RadioButton manualCheck;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Label aLabel;
        private System.Windows.Forms.TextBox bottomText;
    }
}

