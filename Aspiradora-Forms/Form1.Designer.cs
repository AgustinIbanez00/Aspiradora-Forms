namespace Aspiradora_Forms
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.gbConfig = new System.Windows.Forms.GroupBox();
            this.btnStartStop = new System.Windows.Forms.Button();
            this.btnCleaner = new System.Windows.Forms.Button();
            this.lblPossibility = new System.Windows.Forms.Label();
            this.nudPossibility = new System.Windows.Forms.NumericUpDown();
            this.lblMaxColumns = new System.Windows.Forms.Label();
            this.nudMaxColumns = new System.Windows.Forms.NumericUpDown();
            this.lblMaxRows = new System.Windows.Forms.Label();
            this.nudMaxRows = new System.Windows.Forms.NumericUpDown();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.lblColumns = new System.Windows.Forms.Label();
            this.tbColumns = new System.Windows.Forms.TextBox();
            this.lblRows = new System.Windows.Forms.Label();
            this.tbRows = new System.Windows.Forms.TextBox();
            this.dgvEnvironment = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.timerCleaner = new System.Windows.Forms.Timer(this.components);
            this.bsEnvironment = new System.Windows.Forms.BindingSource(this.components);
            this.btnMoveTo = new System.Windows.Forms.Button();
            this.gbConfig.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudPossibility)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMaxColumns)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMaxRows)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEnvironment)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsEnvironment)).BeginInit();
            this.SuspendLayout();
            // 
            // gbConfig
            // 
            this.gbConfig.Controls.Add(this.btnMoveTo);
            this.gbConfig.Controls.Add(this.btnStartStop);
            this.gbConfig.Controls.Add(this.btnCleaner);
            this.gbConfig.Controls.Add(this.lblPossibility);
            this.gbConfig.Controls.Add(this.nudPossibility);
            this.gbConfig.Controls.Add(this.lblMaxColumns);
            this.gbConfig.Controls.Add(this.nudMaxColumns);
            this.gbConfig.Controls.Add(this.lblMaxRows);
            this.gbConfig.Controls.Add(this.nudMaxRows);
            this.gbConfig.Controls.Add(this.progressBar1);
            this.gbConfig.Controls.Add(this.btnGenerate);
            this.gbConfig.Controls.Add(this.lblColumns);
            this.gbConfig.Controls.Add(this.tbColumns);
            this.gbConfig.Controls.Add(this.lblRows);
            this.gbConfig.Controls.Add(this.tbRows);
            this.gbConfig.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbConfig.Location = new System.Drawing.Point(3, 3);
            this.gbConfig.Name = "gbConfig";
            this.gbConfig.Size = new System.Drawing.Size(803, 84);
            this.gbConfig.TabIndex = 1;
            this.gbConfig.TabStop = false;
            this.gbConfig.Text = "Configuración";
            // 
            // btnStartStop
            // 
            this.btnStartStop.Image = global::Aspiradora_Forms.Resources.play__1_;
            this.btnStartStop.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnStartStop.Location = new System.Drawing.Point(361, 14);
            this.btnStartStop.Name = "btnStartStop";
            this.btnStartStop.Size = new System.Drawing.Size(80, 25);
            this.btnStartStop.TabIndex = 13;
            this.btnStartStop.Text = "Comenzar";
            this.btnStartStop.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnStartStop.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnStartStop.UseVisualStyleBackColor = true;
            this.btnStartStop.Click += new System.EventHandler(this.btnStartStop_Click);
            // 
            // btnCleaner
            // 
            this.btnCleaner.Image = global::Aspiradora_Forms.Resources.refresh__1_;
            this.btnCleaner.Location = new System.Drawing.Point(220, 43);
            this.btnCleaner.Name = "btnCleaner";
            this.btnCleaner.Size = new System.Drawing.Size(135, 25);
            this.btnCleaner.TabIndex = 12;
            this.btnCleaner.Text = "Generar aspiradora";
            this.btnCleaner.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCleaner.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCleaner.UseVisualStyleBackColor = true;
            this.btnCleaner.Click += new System.EventHandler(this.btnCleaner_Click);
            // 
            // lblPossibility
            // 
            this.lblPossibility.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPossibility.AutoSize = true;
            this.lblPossibility.Location = new System.Drawing.Point(447, 11);
            this.lblPossibility.Name = "lblPossibility";
            this.lblPossibility.Size = new System.Drawing.Size(71, 13);
            this.lblPossibility.TabIndex = 11;
            this.lblPossibility.Text = "Posibilidad: %";
            // 
            // nudPossibility
            // 
            this.nudPossibility.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.nudPossibility.Location = new System.Drawing.Point(524, 9);
            this.nudPossibility.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudPossibility.Name = "nudPossibility";
            this.nudPossibility.Size = new System.Drawing.Size(54, 20);
            this.nudPossibility.TabIndex = 10;
            this.nudPossibility.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nudPossibility.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            // 
            // lblMaxColumns
            // 
            this.lblMaxColumns.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblMaxColumns.AutoSize = true;
            this.lblMaxColumns.Location = new System.Drawing.Point(625, 43);
            this.lblMaxColumns.Name = "lblMaxColumns";
            this.lblMaxColumns.Size = new System.Drawing.Size(109, 13);
            this.lblMaxColumns.TabIndex = 9;
            this.lblMaxColumns.Text = "Máximo de columnas:";
            // 
            // nudMaxColumns
            // 
            this.nudMaxColumns.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.nudMaxColumns.Location = new System.Drawing.Point(740, 41);
            this.nudMaxColumns.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nudMaxColumns.Name = "nudMaxColumns";
            this.nudMaxColumns.Size = new System.Drawing.Size(54, 20);
            this.nudMaxColumns.TabIndex = 8;
            this.nudMaxColumns.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nudMaxColumns.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // lblMaxRows
            // 
            this.lblMaxRows.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblMaxRows.AutoSize = true;
            this.lblMaxRows.Location = new System.Drawing.Point(652, 11);
            this.lblMaxRows.Name = "lblMaxRows";
            this.lblMaxRows.Size = new System.Drawing.Size(82, 13);
            this.lblMaxRows.TabIndex = 7;
            this.lblMaxRows.Text = "Máximo de filas:";
            // 
            // nudMaxRows
            // 
            this.nudMaxRows.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.nudMaxRows.Location = new System.Drawing.Point(740, 9);
            this.nudMaxRows.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nudMaxRows.Name = "nudMaxRows";
            this.nudMaxRows.Size = new System.Drawing.Size(54, 20);
            this.nudMaxRows.TabIndex = 6;
            this.nudMaxRows.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nudMaxRows.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(397, 55);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(100, 23);
            this.progressBar1.TabIndex = 5;
            // 
            // btnGenerate
            // 
            this.btnGenerate.Image = global::Aspiradora_Forms.Resources.refresh__1_;
            this.btnGenerate.Location = new System.Drawing.Point(220, 14);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(135, 25);
            this.btnGenerate.TabIndex = 4;
            this.btnGenerate.Text = "Generar basura";
            this.btnGenerate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGenerate.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnGenerate.UseVisualStyleBackColor = true;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // lblColumns
            // 
            this.lblColumns.AutoSize = true;
            this.lblColumns.Location = new System.Drawing.Point(24, 46);
            this.lblColumns.Name = "lblColumns";
            this.lblColumns.Size = new System.Drawing.Size(56, 13);
            this.lblColumns.TabIndex = 3;
            this.lblColumns.Text = "Columnas:";
            // 
            // tbColumns
            // 
            this.tbColumns.Location = new System.Drawing.Point(86, 43);
            this.tbColumns.Name = "tbColumns";
            this.tbColumns.Size = new System.Drawing.Size(100, 20);
            this.tbColumns.TabIndex = 2;
            // 
            // lblRows
            // 
            this.lblRows.AutoSize = true;
            this.lblRows.Location = new System.Drawing.Point(24, 20);
            this.lblRows.Name = "lblRows";
            this.lblRows.Size = new System.Drawing.Size(31, 13);
            this.lblRows.TabIndex = 1;
            this.lblRows.Text = "Filas:";
            // 
            // tbRows
            // 
            this.tbRows.Location = new System.Drawing.Point(86, 17);
            this.tbRows.Name = "tbRows";
            this.tbRows.Size = new System.Drawing.Size(100, 20);
            this.tbRows.TabIndex = 0;
            // 
            // dgvEnvironment
            // 
            this.dgvEnvironment.AllowUserToAddRows = false;
            this.dgvEnvironment.AllowUserToDeleteRows = false;
            this.dgvEnvironment.AllowUserToResizeColumns = false;
            this.dgvEnvironment.AllowUserToResizeRows = false;
            this.dgvEnvironment.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvEnvironment.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvEnvironment.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            this.dgvEnvironment.ColumnHeadersHeight = 15;
            this.dgvEnvironment.ColumnHeadersVisible = false;
            this.dgvEnvironment.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column8,
            this.Column9});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvEnvironment.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvEnvironment.Location = new System.Drawing.Point(3, 93);
            this.dgvEnvironment.Name = "dgvEnvironment";
            this.dgvEnvironment.ReadOnly = true;
            this.dgvEnvironment.RowHeadersVisible = false;
            this.dgvEnvironment.RowHeadersWidth = 15;
            this.dgvEnvironment.RowTemplate.Height = 10;
            this.dgvEnvironment.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvEnvironment.Size = new System.Drawing.Size(803, 354);
            this.dgvEnvironment.TabIndex = 0;
            this.dgvEnvironment.DataSourceChanged += new System.EventHandler(this.dgvEnvironment_DataSourceChanged);
            this.dgvEnvironment.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvEnvironment_CellValueChanged);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Column1";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 88;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Column2";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 88;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Column3";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 88;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Column4";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 88;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Column5";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Width = 87;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Column6";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            this.Column6.Width = 88;
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Column7";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            this.Column7.Width = 88;
            // 
            // Column8
            // 
            this.Column8.HeaderText = "Column8";
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            this.Column8.Width = 88;
            // 
            // Column9
            // 
            this.Column9.HeaderText = "Column9";
            this.Column9.Name = "Column9";
            this.Column9.ReadOnly = true;
            this.Column9.Width = 88;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 139F));
            this.tableLayoutPanel1.Controls.Add(this.dgvEnvironment, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.gbConfig, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(948, 450);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // timerCleaner
            // 
            this.timerCleaner.Interval = 500;
            this.timerCleaner.Tick += new System.EventHandler(this.timerCleaner_Tick);
            // 
            // bsEnvironment
            // 
            this.bsEnvironment.DataSource = typeof(Aspiradora_Forms.PlaceRow);
            this.bsEnvironment.ListChanged += new System.ComponentModel.ListChangedEventHandler(this.bsEnvironment_ListChanged);
            // 
            // btnMoveTo
            // 
            this.btnMoveTo.Location = new System.Drawing.Point(524, 46);
            this.btnMoveTo.Name = "btnMoveTo";
            this.btnMoveTo.Size = new System.Drawing.Size(75, 23);
            this.btnMoveTo.TabIndex = 14;
            this.btnMoveTo.Text = "Mover a:";
            this.btnMoveTo.UseVisualStyleBackColor = true;
            this.btnMoveTo.Click += new System.EventHandler(this.btnMoveTo_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(948, 450);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Form1";
            this.Text = "Aspiradora";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gbConfig.ResumeLayout(false);
            this.gbConfig.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudPossibility)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMaxColumns)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMaxRows)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEnvironment)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bsEnvironment)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource bsEnvironment;
        private System.Windows.Forms.GroupBox gbConfig;
        private System.Windows.Forms.Button btnCleaner;
        private System.Windows.Forms.Label lblPossibility;
        private System.Windows.Forms.NumericUpDown nudPossibility;
        private System.Windows.Forms.Label lblMaxColumns;
        private System.Windows.Forms.NumericUpDown nudMaxColumns;
        private System.Windows.Forms.Label lblMaxRows;
        private System.Windows.Forms.NumericUpDown nudMaxRows;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.Label lblColumns;
        private System.Windows.Forms.TextBox tbColumns;
        private System.Windows.Forms.Label lblRows;
        private System.Windows.Forms.TextBox tbRows;
        private System.Windows.Forms.DataGridView dgvEnvironment;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button btnStartStop;
        private System.Windows.Forms.Timer timerCleaner;
        private System.Windows.Forms.Button btnMoveTo;
    }
}

