﻿
namespace ULTRAMAVERICK.Forms.Research_And_Development
{
    partial class frmItemType
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvItemType = new Guna.UI2.WinForms.Guna2DataGridView();
            this.item_type_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.item_type_desc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.it_added_at = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.it_added_by = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.it_updated_at = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.it_updated_by = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lbltotalrecords = new System.Windows.Forms.Label();
            this.materialCard1 = new MaterialSkin.Controls.MaterialCard();
            this.txtmatItemType = new MaterialSkin.Controls.MaterialTextBox();
            this.txtCreatedAt = new MaterialSkin.Controls.MaterialTextBox();
            this.txtModifiedAt = new MaterialSkin.Controls.MaterialTextBox();
            this.matBtnEdit = new MaterialSkin.Controls.MaterialButton();
            this.lblrecordDesc = new System.Windows.Forms.Label();
            this.metroSave = new MetroFramework.Controls.MetroButton();
            this.matBtnSave = new MaterialSkin.Controls.MaterialButton();
            this.matBtnDelete = new MaterialSkin.Controls.MaterialButton();
            this.matBtnCancel = new MaterialSkin.Controls.MaterialButton();
            this.materialCard2 = new MaterialSkin.Controls.MaterialCard();
            this.metroFinalSaving = new MetroFramework.Controls.MetroButton();
            this.txtCreatedBy = new MaterialSkin.Controls.MaterialTextBox();
            this.txtModifiedBy = new MaterialSkin.Controls.MaterialTextBox();
            this.matBtnNew = new MaterialSkin.Controls.MaterialButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItemType)).BeginInit();
            this.materialCard1.SuspendLayout();
            this.materialCard2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvItemType
            // 
            this.dgvItemType.AllowUserToAddRows = false;
            this.dgvItemType.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgvItemType.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvItemType.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvItemType.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            this.dgvItemType.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvItemType.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvItemType.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 8F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvItemType.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvItemType.ColumnHeadersHeight = 35;
            this.dgvItemType.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvItemType.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.item_type_id,
            this.item_type_desc,
            this.it_added_at,
            this.it_added_by,
            this.it_updated_at,
            this.it_updated_by});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvItemType.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvItemType.EnableHeadersVisualStyles = false;
            this.dgvItemType.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            this.dgvItemType.Location = new System.Drawing.Point(36, 48);
            this.dgvItemType.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.dgvItemType.Name = "dgvItemType";
            this.dgvItemType.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvItemType.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvItemType.RowHeadersVisible = false;
            this.dgvItemType.RowHeadersWidth = 102;
            this.dgvItemType.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvItemType.RowTemplate.DividerHeight = 5;
            this.dgvItemType.RowTemplate.Height = 40;
            this.dgvItemType.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvItemType.Size = new System.Drawing.Size(1706, 539);
            this.dgvItemType.TabIndex = 593;
            this.dgvItemType.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Default;
            this.dgvItemType.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvItemType.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvItemType.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvItemType.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvItemType.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvItemType.ThemeStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            this.dgvItemType.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            this.dgvItemType.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            this.dgvItemType.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvItemType.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.dgvItemType.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.DimGray;
            this.dgvItemType.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvItemType.ThemeStyle.HeaderStyle.Height = 35;
            this.dgvItemType.ThemeStyle.ReadOnly = true;
            this.dgvItemType.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvItemType.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvItemType.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dgvItemType.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.dgvItemType.ThemeStyle.RowsStyle.Height = 40;
            this.dgvItemType.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.dgvItemType.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.White;
            this.dgvItemType.CurrentCellChanged += new System.EventHandler(this.dgvItemType_CurrentCellChanged);
            // 
            // item_type_id
            // 
            this.item_type_id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.item_type_id.DataPropertyName = "item_type_id";
            this.item_type_id.FillWeight = 40.60914F;
            this.item_type_id.HeaderText = "ID";
            this.item_type_id.MinimumWidth = 12;
            this.item_type_id.Name = "item_type_id";
            this.item_type_id.ReadOnly = true;
            this.item_type_id.Width = 12;
            // 
            // item_type_desc
            // 
            this.item_type_desc.DataPropertyName = "item_type_desc";
            this.item_type_desc.FillWeight = 99.49239F;
            this.item_type_desc.HeaderText = "Item Class";
            this.item_type_desc.MinimumWidth = 12;
            this.item_type_desc.Name = "item_type_desc";
            this.item_type_desc.ReadOnly = true;
            this.item_type_desc.Width = 189;
            // 
            // it_added_at
            // 
            this.it_added_at.DataPropertyName = "it_added_at";
            this.it_added_at.FillWeight = 99.49239F;
            this.it_added_at.HeaderText = "Created Date";
            this.it_added_at.MinimumWidth = 12;
            this.it_added_at.Name = "it_added_at";
            this.it_added_at.ReadOnly = true;
            this.it_added_at.Width = 225;
            // 
            // it_added_by
            // 
            this.it_added_by.DataPropertyName = "it_added_by";
            this.it_added_by.FillWeight = 99.49239F;
            this.it_added_by.HeaderText = "Created By";
            this.it_added_by.MinimumWidth = 12;
            this.it_added_by.Name = "it_added_by";
            this.it_added_by.ReadOnly = true;
            this.it_added_by.Width = 197;
            // 
            // it_updated_at
            // 
            this.it_updated_at.DataPropertyName = "it_updated_at";
            this.it_updated_at.FillWeight = 99.49239F;
            this.it_updated_at.HeaderText = "Updated Date";
            this.it_updated_at.MinimumWidth = 12;
            this.it_updated_at.Name = "it_updated_at";
            this.it_updated_at.ReadOnly = true;
            this.it_updated_at.Width = 236;
            // 
            // it_updated_by
            // 
            this.it_updated_by.DataPropertyName = "it_updated_by";
            this.it_updated_by.HeaderText = "Updated By";
            this.it_updated_by.MinimumWidth = 12;
            this.it_updated_by.Name = "it_updated_by";
            this.it_updated_by.ReadOnly = true;
            this.it_updated_by.Width = 208;
            // 
            // lbltotalrecords
            // 
            this.lbltotalrecords.AutoSize = true;
            this.lbltotalrecords.BackColor = System.Drawing.Color.Transparent;
            this.lbltotalrecords.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.900001F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltotalrecords.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbltotalrecords.Location = new System.Drawing.Point(316, 613);
            this.lbltotalrecords.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.lbltotalrecords.Name = "lbltotalrecords";
            this.lbltotalrecords.Size = new System.Drawing.Size(92, 39);
            this.lbltotalrecords.TabIndex = 550;
            this.lbltotalrecords.Text = "CCC";
            // 
            // materialCard1
            // 
            this.materialCard1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.materialCard1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard1.Controls.Add(this.txtmatItemType);
            this.materialCard1.Depth = 0;
            this.materialCard1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard1.Location = new System.Drawing.Point(40, 130);
            this.materialCard1.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard1.Name = "materialCard1";
            this.materialCard1.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard1.Size = new System.Drawing.Size(1769, 143);
            this.materialCard1.TabIndex = 634;
            // 
            // txtmatItemType
            // 
            this.txtmatItemType.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtmatItemType.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtmatItemType.Depth = 0;
            this.txtmatItemType.Enabled = false;
            this.txtmatItemType.Font = new System.Drawing.Font("Roboto", 12F);
            this.txtmatItemType.Hint = "Item Type";
            this.txtmatItemType.Location = new System.Drawing.Point(36, 32);
            this.txtmatItemType.MaxLength = 50;
            this.txtmatItemType.MouseState = MaterialSkin.MouseState.OUT;
            this.txtmatItemType.Multiline = false;
            this.txtmatItemType.Name = "txtmatItemType";
            this.txtmatItemType.Size = new System.Drawing.Size(1706, 50);
            this.txtmatItemType.TabIndex = 0;
            this.txtmatItemType.Text = "";
            // 
            // txtCreatedAt
            // 
            this.txtCreatedAt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCreatedAt.Depth = 0;
            this.txtCreatedAt.Enabled = false;
            this.txtCreatedAt.Font = new System.Drawing.Font("Roboto", 12F);
            this.txtCreatedAt.Hint = "Created At";
            this.txtCreatedAt.Location = new System.Drawing.Point(736, 325);
            this.txtCreatedAt.MaxLength = 50;
            this.txtCreatedAt.MouseState = MaterialSkin.MouseState.OUT;
            this.txtCreatedAt.Multiline = false;
            this.txtCreatedAt.Name = "txtCreatedAt";
            this.txtCreatedAt.Size = new System.Drawing.Size(275, 50);
            this.txtCreatedAt.TabIndex = 638;
            this.txtCreatedAt.Text = "";
            this.txtCreatedAt.Visible = false;
            // 
            // txtModifiedAt
            // 
            this.txtModifiedAt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtModifiedAt.Depth = 0;
            this.txtModifiedAt.Enabled = false;
            this.txtModifiedAt.Font = new System.Drawing.Font("Roboto", 12F);
            this.txtModifiedAt.Hint = "Modified At";
            this.txtModifiedAt.Location = new System.Drawing.Point(1387, 325);
            this.txtModifiedAt.MaxLength = 50;
            this.txtModifiedAt.MouseState = MaterialSkin.MouseState.OUT;
            this.txtModifiedAt.Multiline = false;
            this.txtModifiedAt.Name = "txtModifiedAt";
            this.txtModifiedAt.Size = new System.Drawing.Size(275, 50);
            this.txtModifiedAt.TabIndex = 632;
            this.txtModifiedAt.Text = "";
            this.txtModifiedAt.Visible = false;
            // 
            // matBtnEdit
            // 
            this.matBtnEdit.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.matBtnEdit.Depth = 0;
            this.matBtnEdit.DrawShadows = true;
            this.matBtnEdit.HighEmphasis = true;
            this.matBtnEdit.Icon = null;
            this.matBtnEdit.Location = new System.Drawing.Point(277, 334);
            this.matBtnEdit.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.matBtnEdit.MouseState = MaterialSkin.MouseState.HOVER;
            this.matBtnEdit.Name = "matBtnEdit";
            this.matBtnEdit.Size = new System.Drawing.Size(53, 36);
            this.matBtnEdit.TabIndex = 636;
            this.matBtnEdit.Text = "EDIT";
            this.matBtnEdit.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.matBtnEdit.UseAccentColor = false;
            this.matBtnEdit.UseVisualStyleBackColor = true;
            this.matBtnEdit.Click += new System.EventHandler(this.matBtnEdit_Click);
            // 
            // lblrecordDesc
            // 
            this.lblrecordDesc.AutoSize = true;
            this.lblrecordDesc.BackColor = System.Drawing.Color.Transparent;
            this.lblrecordDesc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.900001F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblrecordDesc.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblrecordDesc.Location = new System.Drawing.Point(43, 613);
            this.lblrecordDesc.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.lblrecordDesc.Name = "lblrecordDesc";
            this.lblrecordDesc.Size = new System.Drawing.Size(247, 39);
            this.lblrecordDesc.TabIndex = 550;
            this.lblrecordDesc.Text = "Total Records :";
            // 
            // metroSave
            // 
            this.metroSave.Location = new System.Drawing.Point(1014, 291);
            this.metroSave.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.metroSave.Name = "metroSave";
            this.metroSave.Size = new System.Drawing.Size(181, 48);
            this.metroSave.TabIndex = 643;
            this.metroSave.Text = "Add";
            this.metroSave.UseSelectable = true;
            this.metroSave.Visible = false;
            this.metroSave.Click += new System.EventHandler(this.metroSave_Click);
            // 
            // matBtnSave
            // 
            this.matBtnSave.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.matBtnSave.Depth = 0;
            this.matBtnSave.DrawShadows = true;
            this.matBtnSave.HighEmphasis = true;
            this.matBtnSave.Icon = null;
            this.matBtnSave.Location = new System.Drawing.Point(252, 293);
            this.matBtnSave.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.matBtnSave.MouseState = MaterialSkin.MouseState.HOVER;
            this.matBtnSave.Name = "matBtnSave";
            this.matBtnSave.Size = new System.Drawing.Size(58, 36);
            this.matBtnSave.TabIndex = 642;
            this.matBtnSave.Text = "SAVE";
            this.matBtnSave.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.matBtnSave.UseAccentColor = false;
            this.matBtnSave.UseVisualStyleBackColor = true;
            this.matBtnSave.Visible = false;
            this.matBtnSave.Click += new System.EventHandler(this.matBtnSave_Click);
            // 
            // matBtnDelete
            // 
            this.matBtnDelete.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.matBtnDelete.Depth = 0;
            this.matBtnDelete.DrawShadows = true;
            this.matBtnDelete.HighEmphasis = true;
            this.matBtnDelete.Icon = null;
            this.matBtnDelete.Location = new System.Drawing.Point(406, 293);
            this.matBtnDelete.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.matBtnDelete.MouseState = MaterialSkin.MouseState.HOVER;
            this.matBtnDelete.Name = "matBtnDelete";
            this.matBtnDelete.Size = new System.Drawing.Size(80, 36);
            this.matBtnDelete.TabIndex = 641;
            this.matBtnDelete.Text = "REMOVE";
            this.matBtnDelete.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.matBtnDelete.UseAccentColor = false;
            this.matBtnDelete.UseVisualStyleBackColor = true;
            this.matBtnDelete.Click += new System.EventHandler(this.matBtnDelete_Click);
            // 
            // matBtnCancel
            // 
            this.matBtnCancel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.matBtnCancel.Depth = 0;
            this.matBtnCancel.DrawShadows = true;
            this.matBtnCancel.HighEmphasis = true;
            this.matBtnCancel.Icon = null;
            this.matBtnCancel.Location = new System.Drawing.Point(574, 293);
            this.matBtnCancel.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.matBtnCancel.MouseState = MaterialSkin.MouseState.HOVER;
            this.matBtnCancel.Name = "matBtnCancel";
            this.matBtnCancel.Size = new System.Drawing.Size(77, 36);
            this.matBtnCancel.TabIndex = 640;
            this.matBtnCancel.Text = "CANCEL";
            this.matBtnCancel.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.matBtnCancel.UseAccentColor = false;
            this.matBtnCancel.UseVisualStyleBackColor = true;
            this.matBtnCancel.Visible = false;
            this.matBtnCancel.Click += new System.EventHandler(this.matBtnCancel_Click);
            // 
            // materialCard2
            // 
            this.materialCard2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.materialCard2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard2.Controls.Add(this.dgvItemType);
            this.materialCard2.Controls.Add(this.lbltotalrecords);
            this.materialCard2.Controls.Add(this.lblrecordDesc);
            this.materialCard2.Depth = 0;
            this.materialCard2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard2.Location = new System.Drawing.Point(40, 389);
            this.materialCard2.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard2.Name = "materialCard2";
            this.materialCard2.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard2.Size = new System.Drawing.Size(1769, 669);
            this.materialCard2.TabIndex = 633;
            // 
            // metroFinalSaving
            // 
            this.metroFinalSaving.Location = new System.Drawing.Point(1338, 291);
            this.metroFinalSaving.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.metroFinalSaving.Name = "metroFinalSaving";
            this.metroFinalSaving.Size = new System.Drawing.Size(181, 48);
            this.metroFinalSaving.TabIndex = 644;
            this.metroFinalSaving.Text = "Saving";
            this.metroFinalSaving.UseSelectable = true;
            this.metroFinalSaving.Visible = false;
            this.metroFinalSaving.Click += new System.EventHandler(this.metroFinalSaving_Click);
            // 
            // txtCreatedBy
            // 
            this.txtCreatedBy.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCreatedBy.Depth = 0;
            this.txtCreatedBy.Enabled = false;
            this.txtCreatedBy.Font = new System.Drawing.Font("Roboto", 12F);
            this.txtCreatedBy.Hint = "Created By";
            this.txtCreatedBy.Location = new System.Drawing.Point(1068, 325);
            this.txtCreatedBy.MaxLength = 50;
            this.txtCreatedBy.MouseState = MaterialSkin.MouseState.OUT;
            this.txtCreatedBy.Multiline = false;
            this.txtCreatedBy.Name = "txtCreatedBy";
            this.txtCreatedBy.Size = new System.Drawing.Size(275, 50);
            this.txtCreatedBy.TabIndex = 639;
            this.txtCreatedBy.Text = "";
            this.txtCreatedBy.Visible = false;
            // 
            // txtModifiedBy
            // 
            this.txtModifiedBy.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtModifiedBy.Depth = 0;
            this.txtModifiedBy.Enabled = false;
            this.txtModifiedBy.Font = new System.Drawing.Font("Roboto", 12F);
            this.txtModifiedBy.Hint = "Modified By";
            this.txtModifiedBy.Location = new System.Drawing.Point(1699, 325);
            this.txtModifiedBy.MaxLength = 50;
            this.txtModifiedBy.MouseState = MaterialSkin.MouseState.OUT;
            this.txtModifiedBy.Multiline = false;
            this.txtModifiedBy.Name = "txtModifiedBy";
            this.txtModifiedBy.Size = new System.Drawing.Size(275, 50);
            this.txtModifiedBy.TabIndex = 637;
            this.txtModifiedBy.Text = "";
            this.txtModifiedBy.Visible = false;
            // 
            // matBtnNew
            // 
            this.matBtnNew.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.matBtnNew.Depth = 0;
            this.matBtnNew.DrawShadows = true;
            this.matBtnNew.HighEmphasis = true;
            this.matBtnNew.Icon = null;
            this.matBtnNew.Location = new System.Drawing.Point(76, 293);
            this.matBtnNew.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.matBtnNew.MouseState = MaterialSkin.MouseState.HOVER;
            this.matBtnNew.Name = "matBtnNew";
            this.matBtnNew.Size = new System.Drawing.Size(53, 36);
            this.matBtnNew.TabIndex = 635;
            this.matBtnNew.Text = "NEW";
            this.matBtnNew.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.matBtnNew.UseAccentColor = false;
            this.matBtnNew.UseVisualStyleBackColor = true;
            this.matBtnNew.Click += new System.EventHandler(this.matBtnNew_Click);
            // 
            // frmItemType
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1846, 1092);
            this.Controls.Add(this.materialCard1);
            this.Controls.Add(this.txtCreatedAt);
            this.Controls.Add(this.txtModifiedAt);
            this.Controls.Add(this.matBtnEdit);
            this.Controls.Add(this.metroSave);
            this.Controls.Add(this.matBtnSave);
            this.Controls.Add(this.matBtnDelete);
            this.Controls.Add(this.matBtnCancel);
            this.Controls.Add(this.materialCard2);
            this.Controls.Add(this.metroFinalSaving);
            this.Controls.Add(this.txtCreatedBy);
            this.Controls.Add(this.txtModifiedBy);
            this.Controls.Add(this.matBtnNew);
            this.Name = "frmItemType";
            this.Text = "Item Type";
            this.Load += new System.EventHandler(this.frmItemType_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvItemType)).EndInit();
            this.materialCard1.ResumeLayout(false);
            this.materialCard2.ResumeLayout(false);
            this.materialCard2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Guna.UI2.WinForms.Guna2DataGridView dgvItemType;
        private System.Windows.Forms.Label lbltotalrecords;
        private MaterialSkin.Controls.MaterialCard materialCard1;
        private MaterialSkin.Controls.MaterialTextBox txtmatItemType;
        private MaterialSkin.Controls.MaterialTextBox txtCreatedAt;
        private MaterialSkin.Controls.MaterialTextBox txtModifiedAt;
        private MaterialSkin.Controls.MaterialButton matBtnEdit;
        private System.Windows.Forms.Label lblrecordDesc;
        private MetroFramework.Controls.MetroButton metroSave;
        private MaterialSkin.Controls.MaterialButton matBtnSave;
        private MaterialSkin.Controls.MaterialButton matBtnDelete;
        private MaterialSkin.Controls.MaterialButton matBtnCancel;
        private MaterialSkin.Controls.MaterialCard materialCard2;
        private MetroFramework.Controls.MetroButton metroFinalSaving;
        private MaterialSkin.Controls.MaterialTextBox txtCreatedBy;
        private MaterialSkin.Controls.MaterialTextBox txtModifiedBy;
        private MaterialSkin.Controls.MaterialButton matBtnNew;
        private System.Windows.Forms.DataGridViewTextBoxColumn item_type_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn item_type_desc;
        private System.Windows.Forms.DataGridViewTextBoxColumn it_added_at;
        private System.Windows.Forms.DataGridViewTextBoxColumn it_added_by;
        private System.Windows.Forms.DataGridViewTextBoxColumn it_updated_at;
        private System.Windows.Forms.DataGridViewTextBoxColumn it_updated_by;
    }
}