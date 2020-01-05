namespace Kyrsach_Hotel_
{
    partial class Rooms
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
            System.Windows.Forms.Label idLabel;
            System.Windows.Forms.Label этажLabel;
            System.Windows.Forms.Label стаутсLabel;
            System.Windows.Forms.Label комнатаLabel;
            System.Windows.Forms.Label состояниеLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Rooms));
            this.mAX13DataSet = new Kyrsach_Hotel_.MAX13DataSet();
            this.номерBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.номерTableAdapter = new Kyrsach_Hotel_.MAX13DataSetTableAdapters.НомерTableAdapter();
            this.tableAdapterManager = new Kyrsach_Hotel_.MAX13DataSetTableAdapters.TableAdapterManager();
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
            this.номерBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.номерBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.этажTextBox = new System.Windows.Forms.TextBox();
            this.стаутсComboBox = new System.Windows.Forms.ComboBox();
            this.комнатаTextBox = new System.Windows.Forms.TextBox();
            this.состояниеCheckBox = new System.Windows.Forms.CheckBox();
            this.номерDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            idLabel = new System.Windows.Forms.Label();
            этажLabel = new System.Windows.Forms.Label();
            стаутсLabel = new System.Windows.Forms.Label();
            комнатаLabel = new System.Windows.Forms.Label();
            состояниеLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.mAX13DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.номерBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.номерBindingNavigator)).BeginInit();
            this.номерBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.номерDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // idLabel
            // 
            idLabel.AutoSize = true;
            idLabel.Location = new System.Drawing.Point(572, 41);
            idLabel.Name = "idLabel";
            idLabel.Size = new System.Drawing.Size(18, 13);
            idLabel.TabIndex = 1;
            idLabel.Text = "id:";
            // 
            // этажLabel
            // 
            этажLabel.AutoSize = true;
            этажLabel.Location = new System.Drawing.Point(572, 67);
            этажLabel.Name = "этажLabel";
            этажLabel.Size = new System.Drawing.Size(36, 13);
            этажLabel.TabIndex = 3;
            этажLabel.Text = "Этаж:";
            // 
            // стаутсLabel
            // 
            стаутсLabel.AutoSize = true;
            стаутсLabel.Location = new System.Drawing.Point(572, 93);
            стаутсLabel.Name = "стаутсLabel";
            стаутсLabel.Size = new System.Drawing.Size(44, 13);
            стаутсLabel.TabIndex = 5;
            стаутсLabel.Text = "Стаутс:";
            // 
            // комнатаLabel
            // 
            комнатаLabel.AutoSize = true;
            комнатаLabel.Location = new System.Drawing.Point(572, 120);
            комнатаLabel.Name = "комнатаLabel";
            комнатаLabel.Size = new System.Drawing.Size(54, 13);
            комнатаLabel.TabIndex = 7;
            комнатаLabel.Text = "Комната:";
            // 
            // состояниеLabel
            // 
            состояниеLabel.AutoSize = true;
            состояниеLabel.Location = new System.Drawing.Point(572, 148);
            состояниеLabel.Name = "состояниеLabel";
            состояниеLabel.Size = new System.Drawing.Size(64, 13);
            состояниеLabel.TabIndex = 9;
            состояниеLabel.Text = "Состояние:";
            // 
            // mAX13DataSet
            // 
            this.mAX13DataSet.DataSetName = "MAX13DataSet";
            this.mAX13DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // номерBindingSource
            // 
            this.номерBindingSource.DataMember = "Номер";
            this.номерBindingSource.DataSource = this.mAX13DataSet;
            // 
            // номерTableAdapter
            // 
            this.номерTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.UpdateOrder = Kyrsach_Hotel_.MAX13DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.ЗаявкаTableAdapter = null;
            this.tableAdapterManager.КлиентTableAdapter = null;
            this.tableAdapterManager.НомерTableAdapter = this.номерTableAdapter;
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Переместить в начало";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Переместить назад";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Положение";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Текущее положение";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(43, 22);
            this.bindingNavigatorCountItem.Text = "для {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Общее число элементов";
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
            this.bindingNavigatorMoveNextItem.Text = "Переместить вперед";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Переместить в конец";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Добавить";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Удалить";
            // 
            // номерBindingNavigatorSaveItem
            // 
            this.номерBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.номерBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("номерBindingNavigatorSaveItem.Image")));
            this.номерBindingNavigatorSaveItem.Name = "номерBindingNavigatorSaveItem";
            this.номерBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.номерBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.номерBindingNavigatorSaveItem.Click += new System.EventHandler(this.номерBindingNavigatorSaveItem_Click);
            // 
            // номерBindingNavigator
            // 
            this.номерBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.номерBindingNavigator.BindingSource = this.номерBindingSource;
            this.номерBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.номерBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.номерBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.номерBindingNavigatorSaveItem});
            this.номерBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.номерBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.номерBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.номерBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.номерBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.номерBindingNavigator.Name = "номерBindingNavigator";
            this.номерBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.номерBindingNavigator.Size = new System.Drawing.Size(776, 25);
            this.номерBindingNavigator.TabIndex = 0;
            this.номерBindingNavigator.Text = "bindingNavigator1";
            // 
            // idTextBox
            // 
            this.idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.номерBindingSource, "id", true));
            this.idTextBox.Location = new System.Drawing.Point(642, 38);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.Size = new System.Drawing.Size(121, 20);
            this.idTextBox.TabIndex = 2;
            // 
            // этажTextBox
            // 
            this.этажTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.номерBindingSource, "Этаж", true));
            this.этажTextBox.Location = new System.Drawing.Point(642, 64);
            this.этажTextBox.Name = "этажTextBox";
            this.этажTextBox.Size = new System.Drawing.Size(121, 20);
            this.этажTextBox.TabIndex = 4;
            // 
            // стаутсComboBox
            // 
            this.стаутсComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.номерBindingSource, "Стаутс", true));
            this.стаутсComboBox.FormattingEnabled = true;
            this.стаутсComboBox.Items.AddRange(new object[] {
            "Эконом",
            "Люкс"});
            this.стаутсComboBox.Location = new System.Drawing.Point(642, 90);
            this.стаутсComboBox.Name = "стаутсComboBox";
            this.стаутсComboBox.Size = new System.Drawing.Size(121, 21);
            this.стаутсComboBox.TabIndex = 6;
            // 
            // комнатаTextBox
            // 
            this.комнатаTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.номерBindingSource, "Комната", true));
            this.комнатаTextBox.Location = new System.Drawing.Point(642, 117);
            this.комнатаTextBox.Name = "комнатаTextBox";
            this.комнатаTextBox.Size = new System.Drawing.Size(121, 20);
            this.комнатаTextBox.TabIndex = 8;
            // 
            // состояниеCheckBox
            // 
            this.состояниеCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.номерBindingSource, "Состояние", true));
            this.состояниеCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.состояниеCheckBox.Location = new System.Drawing.Point(642, 143);
            this.состояниеCheckBox.Name = "состояниеCheckBox";
            this.состояниеCheckBox.Size = new System.Drawing.Size(121, 24);
            this.состояниеCheckBox.TabIndex = 10;
            this.состояниеCheckBox.Text = "занят";
            this.состояниеCheckBox.UseVisualStyleBackColor = true;
            this.состояниеCheckBox.CheckedChanged += new System.EventHandler(this.состояниеCheckBox_CheckedChanged);
            // 
            // номерDataGridView
            // 
            this.номерDataGridView.AutoGenerateColumns = false;
            this.номерDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.номерDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewCheckBoxColumn1});
            this.номерDataGridView.DataSource = this.номерBindingSource;
            this.номерDataGridView.Location = new System.Drawing.Point(12, 38);
            this.номерDataGridView.Name = "номерDataGridView";
            this.номерDataGridView.Size = new System.Drawing.Size(541, 163);
            this.номерDataGridView.TabIndex = 11;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "id";
            this.dataGridViewTextBoxColumn1.HeaderText = "id";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Этаж";
            this.dataGridViewTextBoxColumn2.HeaderText = "Этаж";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Стаутс";
            this.dataGridViewTextBoxColumn3.HeaderText = "Стаутс";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Комната";
            this.dataGridViewTextBoxColumn4.HeaderText = "Комната";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewCheckBoxColumn1
            // 
            this.dataGridViewCheckBoxColumn1.DataPropertyName = "Состояние";
            this.dataGridViewCheckBoxColumn1.HeaderText = "Состояние";
            this.dataGridViewCheckBoxColumn1.Name = "dataGridViewCheckBoxColumn1";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(575, 176);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 12;
            this.button1.Text = "Очистить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Rooms
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(776, 213);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.номерDataGridView);
            this.Controls.Add(idLabel);
            this.Controls.Add(this.idTextBox);
            this.Controls.Add(этажLabel);
            this.Controls.Add(this.этажTextBox);
            this.Controls.Add(стаутсLabel);
            this.Controls.Add(this.стаутсComboBox);
            this.Controls.Add(комнатаLabel);
            this.Controls.Add(this.комнатаTextBox);
            this.Controls.Add(состояниеLabel);
            this.Controls.Add(this.состояниеCheckBox);
            this.Controls.Add(this.номерBindingNavigator);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Rooms";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Номера";
            this.Load += new System.EventHandler(this.Form4_Load);
            ((System.ComponentModel.ISupportInitialize)(this.mAX13DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.номерBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.номерBindingNavigator)).EndInit();
            this.номерBindingNavigator.ResumeLayout(false);
            this.номерBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.номерDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MAX13DataSet mAX13DataSet;
        private System.Windows.Forms.BindingSource номерBindingSource;
        private MAX13DataSetTableAdapters.НомерTableAdapter номерTableAdapter;
        private MAX13DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton номерBindingNavigatorSaveItem;
        private System.Windows.Forms.BindingNavigator номерBindingNavigator;
        private System.Windows.Forms.TextBox idTextBox;
        private System.Windows.Forms.TextBox этажTextBox;
        private System.Windows.Forms.ComboBox стаутсComboBox;
        private System.Windows.Forms.TextBox комнатаTextBox;
        private System.Windows.Forms.CheckBox состояниеCheckBox;
        private System.Windows.Forms.DataGridView номерDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn1;
        private System.Windows.Forms.Button button1;
    }
}