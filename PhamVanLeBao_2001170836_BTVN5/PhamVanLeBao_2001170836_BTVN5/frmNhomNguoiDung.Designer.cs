﻿namespace PhamVanLeBao_2001170836_BTVN5
{
    partial class frmNhomNguoiDung
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmNhomNguoiDung));
            System.Windows.Forms.Label maNhomLabel;
            System.Windows.Forms.Label tenNhomLabel;
            System.Windows.Forms.Label ghiChuLabel;
            this.dataSet1 = new PhamVanLeBao_2001170836_BTVN5.DataSet1();
            this.ql_NhomNguoiDungBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ql_NhomNguoiDungTableAdapter = new PhamVanLeBao_2001170836_BTVN5.DataSet1TableAdapters.ql_NhomNguoiDungTableAdapter();
            this.tableAdapterManager = new PhamVanLeBao_2001170836_BTVN5.DataSet1TableAdapters.TableAdapterManager();
            this.ql_NhomNguoiDungBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.ql_NhomNguoiDungBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.ql_NhomNguoiDungDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maNhomTextBox = new System.Windows.Forms.TextBox();
            this.tenNhomTextBox = new System.Windows.Forms.TextBox();
            this.ghiChuTextBox = new System.Windows.Forms.TextBox();
            maNhomLabel = new System.Windows.Forms.Label();
            tenNhomLabel = new System.Windows.Forms.Label();
            ghiChuLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ql_NhomNguoiDungBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ql_NhomNguoiDungBindingNavigator)).BeginInit();
            this.ql_NhomNguoiDungBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ql_NhomNguoiDungDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ql_NhomNguoiDungBindingSource
            // 
            this.ql_NhomNguoiDungBindingSource.DataMember = "ql_NhomNguoiDung";
            this.ql_NhomNguoiDungBindingSource.DataSource = this.dataSet1;
            // 
            // ql_NhomNguoiDungTableAdapter
            // 
            this.ql_NhomNguoiDungTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.DM_ManHinhTableAdapter = null;
            this.tableAdapterManager.ql_NguoiDungNhomNguoiDungTableAdapter = null;
            this.tableAdapterManager.ql_NguoiDungTableAdapter = null;
            this.tableAdapterManager.ql_NhomNguoiDungTableAdapter = this.ql_NhomNguoiDungTableAdapter;
            this.tableAdapterManager.ql_PhanQuyenTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = PhamVanLeBao_2001170836_BTVN5.DataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // ql_NhomNguoiDungBindingNavigator
            // 
            this.ql_NhomNguoiDungBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.ql_NhomNguoiDungBindingNavigator.BindingSource = this.ql_NhomNguoiDungBindingSource;
            this.ql_NhomNguoiDungBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.ql_NhomNguoiDungBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.ql_NhomNguoiDungBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.ql_NhomNguoiDungBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.ql_NhomNguoiDungBindingNavigatorSaveItem});
            this.ql_NhomNguoiDungBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.ql_NhomNguoiDungBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.ql_NhomNguoiDungBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.ql_NhomNguoiDungBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.ql_NhomNguoiDungBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.ql_NhomNguoiDungBindingNavigator.Name = "ql_NhomNguoiDungBindingNavigator";
            this.ql_NhomNguoiDungBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.ql_NhomNguoiDungBindingNavigator.Size = new System.Drawing.Size(800, 27);
            this.ql_NhomNguoiDungBindingNavigator.TabIndex = 0;
            this.ql_NhomNguoiDungBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(29, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(29, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 27);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(45, 20);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 6);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 6);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // ql_NhomNguoiDungBindingNavigatorSaveItem
            // 
            this.ql_NhomNguoiDungBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ql_NhomNguoiDungBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("ql_NhomNguoiDungBindingNavigatorSaveItem.Image")));
            this.ql_NhomNguoiDungBindingNavigatorSaveItem.Name = "ql_NhomNguoiDungBindingNavigatorSaveItem";
            this.ql_NhomNguoiDungBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 23);
            this.ql_NhomNguoiDungBindingNavigatorSaveItem.Text = "Save Data";
            this.ql_NhomNguoiDungBindingNavigatorSaveItem.Click += new System.EventHandler(this.ql_NhomNguoiDungBindingNavigatorSaveItem_Click);
            // 
            // ql_NhomNguoiDungDataGridView
            // 
            this.ql_NhomNguoiDungDataGridView.AutoGenerateColumns = false;
            this.ql_NhomNguoiDungDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ql_NhomNguoiDungDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.ql_NhomNguoiDungDataGridView.DataSource = this.ql_NhomNguoiDungBindingSource;
            this.ql_NhomNguoiDungDataGridView.Location = new System.Drawing.Point(12, 259);
            this.ql_NhomNguoiDungDataGridView.Name = "ql_NhomNguoiDungDataGridView";
            this.ql_NhomNguoiDungDataGridView.RowHeadersWidth = 51;
            this.ql_NhomNguoiDungDataGridView.RowTemplate.Height = 24;
            this.ql_NhomNguoiDungDataGridView.Size = new System.Drawing.Size(437, 220);
            this.ql_NhomNguoiDungDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "MaNhom";
            this.dataGridViewTextBoxColumn1.HeaderText = "MaNhom";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 125;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "TenNhom";
            this.dataGridViewTextBoxColumn2.HeaderText = "TenNhom";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 125;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "GhiChu";
            this.dataGridViewTextBoxColumn3.HeaderText = "GhiChu";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 125;
            // 
            // maNhomLabel
            // 
            maNhomLabel.AutoSize = true;
            maNhomLabel.Location = new System.Drawing.Point(51, 63);
            maNhomLabel.Name = "maNhomLabel";
            maNhomLabel.Size = new System.Drawing.Size(72, 17);
            maNhomLabel.TabIndex = 2;
            maNhomLabel.Text = "Ma Nhom:";
            // 
            // maNhomTextBox
            // 
            this.maNhomTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ql_NhomNguoiDungBindingSource, "MaNhom", true));
            this.maNhomTextBox.Location = new System.Drawing.Point(135, 60);
            this.maNhomTextBox.Name = "maNhomTextBox";
            this.maNhomTextBox.Size = new System.Drawing.Size(100, 22);
            this.maNhomTextBox.TabIndex = 3;
            // 
            // tenNhomLabel
            // 
            tenNhomLabel.AutoSize = true;
            tenNhomLabel.Location = new System.Drawing.Point(51, 91);
            tenNhomLabel.Name = "tenNhomLabel";
            tenNhomLabel.Size = new System.Drawing.Size(78, 17);
            tenNhomLabel.TabIndex = 4;
            tenNhomLabel.Text = "Ten Nhom:";
            // 
            // tenNhomTextBox
            // 
            this.tenNhomTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ql_NhomNguoiDungBindingSource, "TenNhom", true));
            this.tenNhomTextBox.Location = new System.Drawing.Point(135, 88);
            this.tenNhomTextBox.Name = "tenNhomTextBox";
            this.tenNhomTextBox.Size = new System.Drawing.Size(100, 22);
            this.tenNhomTextBox.TabIndex = 5;
            // 
            // ghiChuLabel
            // 
            ghiChuLabel.AutoSize = true;
            ghiChuLabel.Location = new System.Drawing.Point(51, 119);
            ghiChuLabel.Name = "ghiChuLabel";
            ghiChuLabel.Size = new System.Drawing.Size(63, 17);
            ghiChuLabel.TabIndex = 6;
            ghiChuLabel.Text = "Ghi Chu:";
            // 
            // ghiChuTextBox
            // 
            this.ghiChuTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ql_NhomNguoiDungBindingSource, "GhiChu", true));
            this.ghiChuTextBox.Location = new System.Drawing.Point(135, 116);
            this.ghiChuTextBox.Name = "ghiChuTextBox";
            this.ghiChuTextBox.Size = new System.Drawing.Size(100, 22);
            this.ghiChuTextBox.TabIndex = 7;
            // 
            // frmNhomNguoiDung
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 529);
            this.Controls.Add(maNhomLabel);
            this.Controls.Add(this.maNhomTextBox);
            this.Controls.Add(tenNhomLabel);
            this.Controls.Add(this.tenNhomTextBox);
            this.Controls.Add(ghiChuLabel);
            this.Controls.Add(this.ghiChuTextBox);
            this.Controls.Add(this.ql_NhomNguoiDungDataGridView);
            this.Controls.Add(this.ql_NhomNguoiDungBindingNavigator);
            this.Name = "frmNhomNguoiDung";
            this.Text = "frmNhomNguoiDung";
            this.Load += new System.EventHandler(this.frmNhomNguoiDung_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ql_NhomNguoiDungBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ql_NhomNguoiDungBindingNavigator)).EndInit();
            this.ql_NhomNguoiDungBindingNavigator.ResumeLayout(false);
            this.ql_NhomNguoiDungBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ql_NhomNguoiDungDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource ql_NhomNguoiDungBindingSource;
        private DataSet1TableAdapters.ql_NhomNguoiDungTableAdapter ql_NhomNguoiDungTableAdapter;
        private DataSet1TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator ql_NhomNguoiDungBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton ql_NhomNguoiDungBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView ql_NhomNguoiDungDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.TextBox maNhomTextBox;
        private System.Windows.Forms.TextBox tenNhomTextBox;
        private System.Windows.Forms.TextBox ghiChuTextBox;
    }
}