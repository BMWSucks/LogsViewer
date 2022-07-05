namespace LogViewerStep2
{
    partial class LogsViewerForm
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UserId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EntryId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Operation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EntityType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.LogDatailId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LogId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PropertyName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NewValue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OldValue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.UserId,
            this.EntryId,
            this.Operation,
            this.Date,
            this.EntityType});
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.Size = new System.Drawing.Size(1900, 800);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.focusChanged);
            // 
            // Id
            // 
            this.Id.DataPropertyName = "Id";
            this.Id.HeaderText = "Id";
            this.Id.MinimumWidth = 6;
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Width = 315;
            // 
            // UserId
            // 
            this.UserId.DataPropertyName = "UserId";
            this.UserId.HeaderText = "UserId";
            this.UserId.MinimumWidth = 6;
            this.UserId.Name = "UserId";
            this.UserId.ReadOnly = true;
            this.UserId.Width = 315;
            // 
            // EntryId
            // 
            this.EntryId.DataPropertyName = "EntryId";
            this.EntryId.HeaderText = "EntryId";
            this.EntryId.MinimumWidth = 6;
            this.EntryId.Name = "EntryId";
            this.EntryId.ReadOnly = true;
            this.EntryId.Width = 315;
            // 
            // Operation
            // 
            this.Operation.DataPropertyName = "Operation";
            this.Operation.HeaderText = "Operation";
            this.Operation.MinimumWidth = 6;
            this.Operation.Name = "Operation";
            this.Operation.ReadOnly = true;
            this.Operation.Width = 315;
            // 
            // Date
            // 
            this.Date.DataPropertyName = "Date";
            this.Date.HeaderText = "Date";
            this.Date.MinimumWidth = 6;
            this.Date.Name = "Date";
            this.Date.ReadOnly = true;
            this.Date.Width = 315;
            // 
            // EntityType
            // 
            this.EntityType.DataPropertyName = "EntityType";
            this.EntityType.HeaderText = "EntityType";
            this.EntityType.MinimumWidth = 6;
            this.EntityType.Name = "EntityType";
            this.EntityType.ReadOnly = true;
            this.EntityType.Width = 250;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.LogDatailId,
            this.LogId,
            this.PropertyName,
            this.NewValue,
            this.OldValue});
            this.dataGridView2.Location = new System.Drawing.Point(0, 800);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 29;
            this.dataGridView2.Size = new System.Drawing.Size(1900, 300);
            this.dataGridView2.TabIndex = 1;
            // 
            // LogDatailId
            // 
            this.LogDatailId.DataPropertyName = "Id";
            this.LogDatailId.HeaderText = "Id";
            this.LogDatailId.MinimumWidth = 6;
            this.LogDatailId.Name = "LogDatailId";
            this.LogDatailId.ReadOnly = true;
            this.LogDatailId.Width = 370;
            // 
            // LogId
            // 
            this.LogId.DataPropertyName = "LogId";
            this.LogId.HeaderText = "LogId";
            this.LogId.MinimumWidth = 6;
            this.LogId.Name = "LogId";
            this.LogId.ReadOnly = true;
            this.LogId.Width = 370;
            // 
            // PropertyName
            // 
            this.PropertyName.DataPropertyName = "PropertyName";
            this.PropertyName.HeaderText = "PropertyName";
            this.PropertyName.MinimumWidth = 6;
            this.PropertyName.Name = "PropertyName";
            this.PropertyName.ReadOnly = true;
            this.PropertyName.Width = 370;
            // 
            // NewValue
            // 
            this.NewValue.DataPropertyName = "NewValue";
            this.NewValue.HeaderText = "NewValue";
            this.NewValue.MinimumWidth = 6;
            this.NewValue.Name = "NewValue";
            this.NewValue.ReadOnly = true;
            this.NewValue.Width = 370;
            // 
            // OldValue
            // 
            this.OldValue.DataPropertyName = "OldValue";
            this.OldValue.HeaderText = "OldValue";
            this.OldValue.MinimumWidth = 6;
            this.OldValue.Name = "OldValue";
            this.OldValue.ReadOnly = true;
            this.OldValue.Width = 370;
            // 
            // LogsViewerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1924, 1055);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Name = "LogsViewerForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.LogsViewerForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DataGridView dataGridView1;
        private DataGridView dataGridView2;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn UserId;
        private DataGridViewTextBoxColumn EntryId;
        private DataGridViewTextBoxColumn Operation;
        private DataGridViewTextBoxColumn Date;
        private DataGridViewTextBoxColumn EntityType;
        private DataGridViewTextBoxColumn LogDatailId;
        private DataGridViewTextBoxColumn LogId;
        private DataGridViewTextBoxColumn PropertyName;
        private DataGridViewTextBoxColumn NewValue;
        private DataGridViewTextBoxColumn OldValue;
    }
}