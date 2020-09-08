namespace WindowsFormsApp1
{
    partial class main_window
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.имяDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.величинаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.уголDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.направлениеDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ds_Table = new System.Data.DataSet();
            this.dataTable1 = new System.Data.DataTable();
            this.data_table1_name = new System.Data.DataColumn();
            this.data_table1_scale = new System.Data.DataColumn();
            this.data_table1_angle = new System.Data.DataColumn();
            this.data_table1_way = new System.Data.DataColumn();
            this.Add_Row_Button = new System.Windows.Forms.Button();
            this.Draw = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ds_Table)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Location = new System.Drawing.Point(467, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(411, 411);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.имяDataGridViewTextBoxColumn,
            this.величинаDataGridViewTextBoxColumn,
            this.уголDataGridViewTextBoxColumn,
            this.направлениеDataGridViewTextBoxColumn});
            this.dataGridView1.DataMember = "Table1";
            this.dataGridView1.DataSource = this.ds_Table;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(449, 150);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView1_CellContentClick);
            // 
            // имяDataGridViewTextBoxColumn
            // 
            this.имяDataGridViewTextBoxColumn.DataPropertyName = "Имя";
            this.имяDataGridViewTextBoxColumn.HeaderText = "Имя";
            this.имяDataGridViewTextBoxColumn.Name = "имяDataGridViewTextBoxColumn";
            // 
            // величинаDataGridViewTextBoxColumn
            // 
            this.величинаDataGridViewTextBoxColumn.DataPropertyName = "Величина";
            this.величинаDataGridViewTextBoxColumn.HeaderText = "Величина";
            this.величинаDataGridViewTextBoxColumn.Name = "величинаDataGridViewTextBoxColumn";
            // 
            // уголDataGridViewTextBoxColumn
            // 
            this.уголDataGridViewTextBoxColumn.DataPropertyName = "Угол";
            this.уголDataGridViewTextBoxColumn.HeaderText = "Угол";
            this.уголDataGridViewTextBoxColumn.Name = "уголDataGridViewTextBoxColumn";
            // 
            // направлениеDataGridViewTextBoxColumn
            // 
            this.направлениеDataGridViewTextBoxColumn.DataPropertyName = "Направление";
            this.направлениеDataGridViewTextBoxColumn.HeaderText = "Направление";
            this.направлениеDataGridViewTextBoxColumn.Name = "направлениеDataGridViewTextBoxColumn";
            // 
            // ds_Table
            // 
            this.ds_Table.DataSetName = "Table";
            this.ds_Table.Tables.AddRange(new System.Data.DataTable[] {
            this.dataTable1});
            // 
            // dataTable1
            // 
            this.dataTable1.Columns.AddRange(new System.Data.DataColumn[] {
            this.data_table1_name,
            this.data_table1_scale,
            this.data_table1_angle,
            this.data_table1_way});
            this.dataTable1.TableName = "Table1";
            // 
            // data_table1_name
            // 
            this.data_table1_name.ColumnName = "Имя";
            // 
            // data_table1_scale
            // 
            this.data_table1_scale.ColumnName = "Величина";
            this.data_table1_scale.DataType = typeof(double);
            // 
            // data_table1_angle
            // 
            this.data_table1_angle.ColumnName = "Угол";
            this.data_table1_angle.DataType = typeof(double);
            // 
            // data_table1_way
            // 
            this.data_table1_way.ColumnName = "Направление";
            this.data_table1_way.MaxLength = 1;
            // 
            // Add_Row_Button
            // 
            this.Add_Row_Button.Location = new System.Drawing.Point(331, 400);
            this.Add_Row_Button.Name = "Add_Row_Button";
            this.Add_Row_Button.Size = new System.Drawing.Size(130, 23);
            this.Add_Row_Button.TabIndex = 2;
            this.Add_Row_Button.Text = "Добавить строку";
            this.Add_Row_Button.UseVisualStyleBackColor = true;
            this.Add_Row_Button.Click += new System.EventHandler(this.Add_Row_Button_Click);
            // 
            // Draw
            // 
            this.Draw.Location = new System.Drawing.Point(232, 400);
            this.Draw.Name = "Draw";
            this.Draw.Size = new System.Drawing.Size(82, 23);
            this.Draw.TabIndex = 3;
            this.Draw.Text = "Нарисовать";
            this.Draw.UseVisualStyleBackColor = true;
            this.Draw.Click += new System.EventHandler(this.Draw_Click);
            // 
            // main_window
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(890, 450);
            this.Controls.Add(this.Draw);
            this.Controls.Add(this.Add_Row_Button);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "main_window";
            this.Text = "main_window";
            this.Load += new System.EventHandler(this.main_window_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ds_Table)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button Add_Row_Button;
        
        private System.Data.DataTable dataTable1;
        private System.Data.DataSet ds_Table;
        private System.Data.DataTable table;
        private System.Data.DataColumn data_table1_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn имяDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn величинаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn уголDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn направлениеDataGridViewTextBoxColumn;
        private System.Data.DataColumn data_table1_scale;
        private System.Data.DataColumn data_table1_angle;
        private System.Data.DataColumn data_table1_way;
        private System.Windows.Forms.Button Draw;
    }
}