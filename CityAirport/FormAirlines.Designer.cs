namespace CityAirport
{
    partial class FormAirlines
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAirlines));
            this.cityAirportDataSet = new CityAirport.CityAirportDataSet();
            this.airlinesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.airlinesTableAdapter = new CityAirport.CityAirportDataSetTableAdapters.AirlinesTableAdapter();
            this.tableAdapterManager = new CityAirport.CityAirportDataSetTableAdapters.TableAdapterManager();
            this.airlinesBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.airlinesBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.airlinesDataGridView = new System.Windows.Forms.DataGridView();
            this.textBox_name = new System.Windows.Forms.TextBox();
            this.textBox_address = new System.Windows.Forms.TextBox();
            this.textBox_phone = new System.Windows.Forms.TextBox();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.airlineidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.airlinenameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.airlineaddressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.airlinephoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.cityAirportDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.airlinesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.airlinesBindingNavigator)).BeginInit();
            this.airlinesBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.airlinesDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // cityAirportDataSet
            // 
            this.cityAirportDataSet.DataSetName = "CityAirportDataSet";
            this.cityAirportDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // airlinesBindingSource
            // 
            this.airlinesBindingSource.DataMember = "Airlines";
            this.airlinesBindingSource.DataSource = this.cityAirportDataSet;
            // 
            // airlinesTableAdapter
            // 
            this.airlinesTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AirlinesTableAdapter = this.airlinesTableAdapter;
            this.tableAdapterManager.AirplanesTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.FlightsTableAdapter = null;
            this.tableAdapterManager.PassengersTableAdapter = null;
            this.tableAdapterManager.ReservationsTableAdapter = null;
            this.tableAdapterManager.SeatsTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = CityAirport.CityAirportDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // airlinesBindingNavigator
            // 
            this.airlinesBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.airlinesBindingNavigator.BindingSource = this.airlinesBindingSource;
            this.airlinesBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.airlinesBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.airlinesBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.airlinesBindingNavigatorSaveItem});
            this.airlinesBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.airlinesBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.airlinesBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.airlinesBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.airlinesBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.airlinesBindingNavigator.Name = "airlinesBindingNavigator";
            this.airlinesBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.airlinesBindingNavigator.Size = new System.Drawing.Size(708, 25);
            this.airlinesBindingNavigator.TabIndex = 0;
            this.airlinesBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(43, 22);
            this.bindingNavigatorCountItem.Text = "для {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
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
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // airlinesBindingNavigatorSaveItem
            // 
            this.airlinesBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.airlinesBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("airlinesBindingNavigatorSaveItem.Image")));
            this.airlinesBindingNavigatorSaveItem.Name = "airlinesBindingNavigatorSaveItem";
            this.airlinesBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.airlinesBindingNavigatorSaveItem.Text = "Save Data";
            this.airlinesBindingNavigatorSaveItem.Click += new System.EventHandler(this.airlinesBindingNavigatorSaveItem_Click);
            // 
            // airlinesDataGridView
            // 
            this.airlinesDataGridView.AllowUserToAddRows = false;
            this.airlinesDataGridView.AllowUserToDeleteRows = false;
            this.airlinesDataGridView.AutoGenerateColumns = false;
            this.airlinesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.airlinesDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.airlineidDataGridViewTextBoxColumn,
            this.airlinenameDataGridViewTextBoxColumn,
            this.airlineaddressDataGridViewTextBoxColumn,
            this.airlinephoneDataGridViewTextBoxColumn});
            this.airlinesDataGridView.DataSource = this.airlinesBindingSource;
            this.airlinesDataGridView.Location = new System.Drawing.Point(12, 28);
            this.airlinesDataGridView.Name = "airlinesDataGridView";
            this.airlinesDataGridView.ReadOnly = true;
            this.airlinesDataGridView.Size = new System.Drawing.Size(448, 220);
            this.airlinesDataGridView.TabIndex = 1;
            this.airlinesDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.airlinesDataGridView_CellClick);
            // 
            // textBox_name
            // 
            this.textBox_name.Location = new System.Drawing.Point(194, 299);
            this.textBox_name.Name = "textBox_name";
            this.textBox_name.Size = new System.Drawing.Size(100, 20);
            this.textBox_name.TabIndex = 2;
            // 
            // textBox_address
            // 
            this.textBox_address.Location = new System.Drawing.Point(194, 336);
            this.textBox_address.Name = "textBox_address";
            this.textBox_address.Size = new System.Drawing.Size(100, 20);
            this.textBox_address.TabIndex = 3;
            // 
            // textBox_phone
            // 
            this.textBox_phone.Location = new System.Drawing.Point(194, 376);
            this.textBox_phone.Name = "textBox_phone";
            this.textBox_phone.Size = new System.Drawing.Size(100, 20);
            this.textBox_phone.TabIndex = 4;
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(386, 297);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(75, 23);
            this.buttonAdd.TabIndex = 5;
            this.buttonAdd.Text = "Добавить";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(386, 326);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(75, 23);
            this.buttonDelete.TabIndex = 6;
            this.buttonDelete.Text = "Удалить";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // buttonEdit
            // 
            this.buttonEdit.Location = new System.Drawing.Point(386, 355);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(75, 23);
            this.buttonEdit.TabIndex = 7;
            this.buttonEdit.Text = "Изменить";
            this.buttonEdit.UseVisualStyleBackColor = true;
            this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Location = new System.Drawing.Point(386, 384);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(75, 23);
            this.buttonUpdate.TabIndex = 8;
            this.buttonUpdate.Text = "Обновить";
            this.buttonUpdate.UseVisualStyleBackColor = true;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // airlineidDataGridViewTextBoxColumn
            // 
            this.airlineidDataGridViewTextBoxColumn.DataPropertyName = "airline_id";
            this.airlineidDataGridViewTextBoxColumn.HeaderText = "Номер";
            this.airlineidDataGridViewTextBoxColumn.Name = "airlineidDataGridViewTextBoxColumn";
            this.airlineidDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // airlinenameDataGridViewTextBoxColumn
            // 
            this.airlinenameDataGridViewTextBoxColumn.DataPropertyName = "airline_name";
            this.airlinenameDataGridViewTextBoxColumn.HeaderText = "Авиакомпания";
            this.airlinenameDataGridViewTextBoxColumn.Name = "airlinenameDataGridViewTextBoxColumn";
            this.airlinenameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // airlineaddressDataGridViewTextBoxColumn
            // 
            this.airlineaddressDataGridViewTextBoxColumn.DataPropertyName = "airline_address";
            this.airlineaddressDataGridViewTextBoxColumn.HeaderText = "Адрес";
            this.airlineaddressDataGridViewTextBoxColumn.Name = "airlineaddressDataGridViewTextBoxColumn";
            this.airlineaddressDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // airlinephoneDataGridViewTextBoxColumn
            // 
            this.airlinephoneDataGridViewTextBoxColumn.DataPropertyName = "airline_phone";
            this.airlinephoneDataGridViewTextBoxColumn.HeaderText = "Телефон";
            this.airlinephoneDataGridViewTextBoxColumn.Name = "airlinephoneDataGridViewTextBoxColumn";
            this.airlinephoneDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(106, 302);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Авиакомпания";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(106, 339);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Адрес";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(106, 379);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Телефон";
            // 
            // FormAirlines
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(708, 506);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonUpdate);
            this.Controls.Add(this.buttonEdit);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.textBox_phone);
            this.Controls.Add(this.textBox_address);
            this.Controls.Add(this.textBox_name);
            this.Controls.Add(this.airlinesDataGridView);
            this.Controls.Add(this.airlinesBindingNavigator);
            this.Name = "FormAirlines";
            this.Text = "FormAirlines";
            this.Load += new System.EventHandler(this.FormAirlines_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cityAirportDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.airlinesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.airlinesBindingNavigator)).EndInit();
            this.airlinesBindingNavigator.ResumeLayout(false);
            this.airlinesBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.airlinesDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CityAirportDataSet cityAirportDataSet;
        private System.Windows.Forms.BindingSource airlinesBindingSource;
        private CityAirportDataSetTableAdapters.AirlinesTableAdapter airlinesTableAdapter;
        private CityAirportDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator airlinesBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton airlinesBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView airlinesDataGridView;
        private System.Windows.Forms.TextBox textBox_name;
        private System.Windows.Forms.TextBox textBox_address;
        private System.Windows.Forms.TextBox textBox_phone;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.DataGridViewTextBoxColumn airlineidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn airlinenameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn airlineaddressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn airlinephoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}