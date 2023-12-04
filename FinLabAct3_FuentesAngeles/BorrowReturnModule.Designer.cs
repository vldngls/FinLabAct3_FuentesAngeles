﻿namespace FLA3_FA
{
    partial class BorrowReturnModule
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
            this.cmbEquipment = new System.Windows.Forms.ComboBox();
            this.equipmentDBBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.laboratoryDBDataSet = new FinLabAct3_FuentesAngeles.LaboratoryDBDataSet();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtBorrowersName = new System.Windows.Forms.TextBox();
            this.txtReason = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnBorrow = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.equipmentNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.equipmentQuantityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.equipmentDescriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.equipmentDBBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.laboratoryDBDataSet2 = new FinLabAct3_FuentesAngeles.LaboratoryDBDataSet2();
            this.equipmentDBBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.laboratoryDBDataSet1 = new FinLabAct3_FuentesAngeles.LaboratoryDBDataSet1();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.btnReturn = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.dateTimePicker3 = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.equipmentDBTableAdapter = new FinLabAct3_FuentesAngeles.LaboratoryDBDataSetTableAdapters.EquipmentDBTableAdapter();
            this.equipmentDBTableAdapter1 = new FinLabAct3_FuentesAngeles.LaboratoryDBDataSet1TableAdapters.EquipmentDBTableAdapter();
            this.equipmentDBTableAdapter2 = new FinLabAct3_FuentesAngeles.LaboratoryDBDataSet2TableAdapters.EquipmentDBTableAdapter();
            this.laboratoryDBDataSet3 = new FinLabAct3_FuentesAngeles.LaboratoryDBDataSet3();
            this.transactionDBBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.transactionDBTableAdapter = new FinLabAct3_FuentesAngeles.LaboratoryDBDataSet3TableAdapters.TransactionDBTableAdapter();
            this.transactionIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userTransactDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.borrowedEquipmentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.borrowQuantityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.transactionDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.equipmentDBBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.laboratoryDBDataSet)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.equipmentDBBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.laboratoryDBDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.equipmentDBBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.laboratoryDBDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.laboratoryDBDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.transactionDBBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbEquipment
            // 
            this.cmbEquipment.DataSource = this.equipmentDBBindingSource;
            this.cmbEquipment.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbEquipment.FormattingEnabled = true;
            this.cmbEquipment.Location = new System.Drawing.Point(125, 38);
            this.cmbEquipment.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cmbEquipment.Name = "cmbEquipment";
            this.cmbEquipment.Size = new System.Drawing.Size(219, 23);
            this.cmbEquipment.TabIndex = 0;
            // 
            // equipmentDBBindingSource
            // 
            this.equipmentDBBindingSource.DataMember = "EquipmentDB";
            this.equipmentDBBindingSource.DataSource = this.laboratoryDBDataSet;
            // 
            // laboratoryDBDataSet
            // 
            this.laboratoryDBDataSet.DataSetName = "LaboratoryDBDataSet";
            this.laboratoryDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Location = new System.Drawing.Point(68, 65);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(233, 23);
            this.dateTimePicker1.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.numericUpDown1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cmbEquipment);
            this.groupBox1.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(23, 129);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox1.Size = new System.Drawing.Size(362, 117);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Borrowing of Equipment";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDown1.Location = new System.Drawing.Point(126, 72);
            this.numericUpDown1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(140, 23);
            this.numericUpDown1.TabIndex = 2;
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(64, 72);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Quantity";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(18, 42);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Equipment name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(32, 31);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 15);
            this.label3.TabIndex = 1;
            this.label3.Text = "Borrower\'s Name";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtBorrowersName);
            this.groupBox2.Controls.Add(this.txtReason);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(23, 23);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox2.Size = new System.Drawing.Size(362, 100);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "User Details";
            // 
            // txtBorrowersName
            // 
            this.txtBorrowersName.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBorrowersName.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.txtBorrowersName.Location = new System.Drawing.Point(141, 28);
            this.txtBorrowersName.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtBorrowersName.Name = "txtBorrowersName";
            this.txtBorrowersName.Size = new System.Drawing.Size(202, 23);
            this.txtBorrowersName.TabIndex = 2;
            this.txtBorrowersName.Text = "     student ID";
            this.txtBorrowersName.TextChanged += new System.EventHandler(this.txtBorrowersName_TextChanged);
            // 
            // txtReason
            // 
            this.txtReason.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtReason.Location = new System.Drawing.Point(141, 60);
            this.txtReason.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtReason.Name = "txtReason";
            this.txtReason.Size = new System.Drawing.Size(202, 23);
            this.txtReason.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(7, 60);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(126, 15);
            this.label4.TabIndex = 1;
            this.label4.Text = "Reason for borrowing";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(110, 36);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(138, 15);
            this.label5.TabIndex = 1;
            this.label5.Text = "Date and time Borrowed";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dateTimePicker1);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.btnBorrow);
            this.groupBox3.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(23, 252);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox3.Size = new System.Drawing.Size(362, 133);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Date Details";
            // 
            // btnBorrow
            // 
            this.btnBorrow.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBorrow.Location = new System.Drawing.Point(267, 95);
            this.btnBorrow.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnBorrow.Name = "btnBorrow";
            this.btnBorrow.Size = new System.Drawing.Size(88, 27);
            this.btnBorrow.TabIndex = 6;
            this.btnBorrow.Text = "Borrow";
            this.btnBorrow.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.equipmentNameDataGridViewTextBoxColumn,
            this.equipmentQuantityDataGridViewTextBoxColumn,
            this.equipmentDescriptionDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.equipmentDBBindingSource2;
            this.dataGridView1.Location = new System.Drawing.Point(393, 21);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(547, 225);
            this.dataGridView1.TabIndex = 17;
            // 
            // equipmentNameDataGridViewTextBoxColumn
            // 
            this.equipmentNameDataGridViewTextBoxColumn.DataPropertyName = "EquipmentName";
            this.equipmentNameDataGridViewTextBoxColumn.HeaderText = "EquipmentName";
            this.equipmentNameDataGridViewTextBoxColumn.Name = "equipmentNameDataGridViewTextBoxColumn";
            // 
            // equipmentQuantityDataGridViewTextBoxColumn
            // 
            this.equipmentQuantityDataGridViewTextBoxColumn.DataPropertyName = "EquipmentQuantity";
            this.equipmentQuantityDataGridViewTextBoxColumn.HeaderText = "EquipmentQuantity";
            this.equipmentQuantityDataGridViewTextBoxColumn.Name = "equipmentQuantityDataGridViewTextBoxColumn";
            // 
            // equipmentDescriptionDataGridViewTextBoxColumn
            // 
            this.equipmentDescriptionDataGridViewTextBoxColumn.DataPropertyName = "EquipmentDescription";
            this.equipmentDescriptionDataGridViewTextBoxColumn.HeaderText = "EquipmentDescription";
            this.equipmentDescriptionDataGridViewTextBoxColumn.Name = "equipmentDescriptionDataGridViewTextBoxColumn";
            // 
            // equipmentDBBindingSource2
            // 
            this.equipmentDBBindingSource2.DataMember = "EquipmentDB";
            this.equipmentDBBindingSource2.DataSource = this.laboratoryDBDataSet2;
            // 
            // laboratoryDBDataSet2
            // 
            this.laboratoryDBDataSet2.DataSetName = "LaboratoryDBDataSet2";
            this.laboratoryDBDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // equipmentDBBindingSource1
            // 
            this.equipmentDBBindingSource1.DataMember = "EquipmentDB";
            this.equipmentDBBindingSource1.DataSource = this.laboratoryDBDataSet1;
            // 
            // laboratoryDBDataSet1
            // 
            this.laboratoryDBDataSet1.DataSetName = "LaboratoryDBDataSet1";
            this.laboratoryDBDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.transactionIDDataGridViewTextBoxColumn,
            this.userTransactDataGridViewTextBoxColumn,
            this.borrowedEquipmentDataGridViewTextBoxColumn,
            this.borrowQuantityDataGridViewTextBoxColumn,
            this.transactionDateDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.transactionDBBindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(393, 252);
            this.dataGridView2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(547, 272);
            this.dataGridView2.TabIndex = 18;
            // 
            // btnReturn
            // 
            this.btnReturn.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReturn.Location = new System.Drawing.Point(267, 99);
            this.btnReturn.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(88, 27);
            this.btnReturn.TabIndex = 19;
            this.btnReturn.Text = "Return";
            this.btnReturn.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.dateTimePicker3);
            this.groupBox4.Controls.Add(this.btnReturn);
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(23, 391);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox4.Size = new System.Drawing.Size(362, 133);
            this.groupBox4.TabIndex = 7;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Date Details";
            // 
            // dateTimePicker3
            // 
            this.dateTimePicker3.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker3.Location = new System.Drawing.Point(68, 65);
            this.dateTimePicker3.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dateTimePicker3.Name = "dateTimePicker3";
            this.dateTimePicker3.Size = new System.Drawing.Size(233, 23);
            this.dateTimePicker3.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(110, 36);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(138, 15);
            this.label7.TabIndex = 1;
            this.label7.Text = "Date and time Borrowed";
            this.label7.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // equipmentDBTableAdapter
            // 
            this.equipmentDBTableAdapter.ClearBeforeFill = true;
            // 
            // equipmentDBTableAdapter1
            // 
            this.equipmentDBTableAdapter1.ClearBeforeFill = true;
            // 
            // equipmentDBTableAdapter2
            // 
            this.equipmentDBTableAdapter2.ClearBeforeFill = true;
            // 
            // laboratoryDBDataSet3
            // 
            this.laboratoryDBDataSet3.DataSetName = "LaboratoryDBDataSet3";
            this.laboratoryDBDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // transactionDBBindingSource
            // 
            this.transactionDBBindingSource.DataMember = "TransactionDB";
            this.transactionDBBindingSource.DataSource = this.laboratoryDBDataSet3;
            // 
            // transactionDBTableAdapter
            // 
            this.transactionDBTableAdapter.ClearBeforeFill = true;
            // 
            // transactionIDDataGridViewTextBoxColumn
            // 
            this.transactionIDDataGridViewTextBoxColumn.DataPropertyName = "TransactionID";
            this.transactionIDDataGridViewTextBoxColumn.HeaderText = "TransactionID";
            this.transactionIDDataGridViewTextBoxColumn.Name = "transactionIDDataGridViewTextBoxColumn";
            // 
            // userTransactDataGridViewTextBoxColumn
            // 
            this.userTransactDataGridViewTextBoxColumn.DataPropertyName = "UserTransact";
            this.userTransactDataGridViewTextBoxColumn.HeaderText = "UserTransact";
            this.userTransactDataGridViewTextBoxColumn.Name = "userTransactDataGridViewTextBoxColumn";
            // 
            // borrowedEquipmentDataGridViewTextBoxColumn
            // 
            this.borrowedEquipmentDataGridViewTextBoxColumn.DataPropertyName = "BorrowedEquipment";
            this.borrowedEquipmentDataGridViewTextBoxColumn.HeaderText = "BorrowedEquipment";
            this.borrowedEquipmentDataGridViewTextBoxColumn.Name = "borrowedEquipmentDataGridViewTextBoxColumn";
            // 
            // borrowQuantityDataGridViewTextBoxColumn
            // 
            this.borrowQuantityDataGridViewTextBoxColumn.DataPropertyName = "BorrowQuantity";
            this.borrowQuantityDataGridViewTextBoxColumn.HeaderText = "BorrowQuantity";
            this.borrowQuantityDataGridViewTextBoxColumn.Name = "borrowQuantityDataGridViewTextBoxColumn";
            // 
            // transactionDateDataGridViewTextBoxColumn
            // 
            this.transactionDateDataGridViewTextBoxColumn.DataPropertyName = "TransactionDate";
            this.transactionDateDataGridViewTextBoxColumn.HeaderText = "TransactionDate";
            this.transactionDateDataGridViewTextBoxColumn.Name = "transactionDateDataGridViewTextBoxColumn";
            // 
            // BorrowReturnModule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::FinLabAct3_FuentesAngeles.Properties.Resources.bg;
            this.ClientSize = new System.Drawing.Size(961, 532);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "BorrowReturnModule";
            this.Padding = new System.Windows.Forms.Padding(19, 18, 19, 18);
            this.Text = "BorrowReturnForm";
            this.Load += new System.EventHandler(this.BorrowReturnModule_Load);
            ((System.ComponentModel.ISupportInitialize)(this.equipmentDBBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.laboratoryDBDataSet)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.equipmentDBBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.laboratoryDBDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.equipmentDBBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.laboratoryDBDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.laboratoryDBDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.transactionDBBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbEquipment;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtBorrowersName;
        private System.Windows.Forms.TextBox txtReason;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnBorrow;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.DateTimePicker dateTimePicker3;
        private System.Windows.Forms.Label label7;
        private FinLabAct3_FuentesAngeles.LaboratoryDBDataSet laboratoryDBDataSet;
        private System.Windows.Forms.BindingSource equipmentDBBindingSource;
        private FinLabAct3_FuentesAngeles.LaboratoryDBDataSetTableAdapters.EquipmentDBTableAdapter equipmentDBTableAdapter;
        private FinLabAct3_FuentesAngeles.LaboratoryDBDataSet1 laboratoryDBDataSet1;
        private System.Windows.Forms.BindingSource equipmentDBBindingSource1;
        private FinLabAct3_FuentesAngeles.LaboratoryDBDataSet1TableAdapters.EquipmentDBTableAdapter equipmentDBTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn equipmentNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn equipmentQuantityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn equipmentDescriptionDataGridViewTextBoxColumn;
        private FinLabAct3_FuentesAngeles.LaboratoryDBDataSet2 laboratoryDBDataSet2;
        private System.Windows.Forms.BindingSource equipmentDBBindingSource2;
        private FinLabAct3_FuentesAngeles.LaboratoryDBDataSet2TableAdapters.EquipmentDBTableAdapter equipmentDBTableAdapter2;
        private FinLabAct3_FuentesAngeles.LaboratoryDBDataSet3 laboratoryDBDataSet3;
        private System.Windows.Forms.BindingSource transactionDBBindingSource;
        private FinLabAct3_FuentesAngeles.LaboratoryDBDataSet3TableAdapters.TransactionDBTableAdapter transactionDBTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn transactionIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn userTransactDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn borrowedEquipmentDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn borrowQuantityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn transactionDateDataGridViewTextBoxColumn;
    }
}