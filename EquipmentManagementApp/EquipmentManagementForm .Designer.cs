
namespace EquipmentManagementApp
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtSerialNumber = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtCategory = new System.Windows.Forms.TextBox();
            this.chkIsFunctional = new System.Windows.Forms.CheckBox();
            this.btnAddEquipment = new System.Windows.Forms.Button();
            this.btnRemoveEquipment = new System.Windows.Forms.Button();
            this.btnEditEquipment = new System.Windows.Forms.Button();
            this.btnMoveEquipment = new System.Windows.Forms.Button();
            this.btnSearchByLocation = new System.Windows.Forms.Button();
            this.txtLocation = new System.Windows.Forms.TextBox();
            this.btnSearchByCategory = new System.Windows.Forms.Button();
            this.txtSearchCategory = new System.Windows.Forms.TextBox();
            this.btnExportToExcel = new System.Windows.Forms.Button();
            this.dataListViewEquipment = new BrightIdeasSoftware.DataListView();
            ((System.ComponentModel.ISupportInitialize)(this.dataListViewEquipment)).BeginInit();
            this.SuspendLayout();
            // 
            // txtSerialNumber
            // 
            this.txtSerialNumber.Location = new System.Drawing.Point(12, 12);
            this.txtSerialNumber.Name = "txtSerialNumber";
            this.txtSerialNumber.Size = new System.Drawing.Size(220, 20);
            this.txtSerialNumber.TabIndex = 0;
            this.txtSerialNumber.Text = "ввод серийного номера";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(12, 38);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(220, 20);
            this.txtName.TabIndex = 1;
            this.txtName.Text = "ввод названия";
            // 
            // txtCategory
            // 
            this.txtCategory.Location = new System.Drawing.Point(13, 65);
            this.txtCategory.Name = "txtCategory";
            this.txtCategory.Size = new System.Drawing.Size(219, 20);
            this.txtCategory.TabIndex = 2;
            this.txtCategory.Text = "ввод категории";
            // 
            // chkIsFunctional
            // 
            this.chkIsFunctional.AutoSize = true;
            this.chkIsFunctional.Location = new System.Drawing.Point(13, 92);
            this.chkIsFunctional.Name = "chkIsFunctional";
            this.chkIsFunctional.Size = new System.Drawing.Size(269, 17);
            this.chkIsFunctional.TabIndex = 3;
            this.chkIsFunctional.Text = "исправно (нажать) / не исправно (не нажимать)";
            this.chkIsFunctional.UseVisualStyleBackColor = true;
            // 
            // btnAddEquipment
            // 
            this.btnAddEquipment.Location = new System.Drawing.Point(12, 115);
            this.btnAddEquipment.Name = "btnAddEquipment";
            this.btnAddEquipment.Size = new System.Drawing.Size(220, 23);
            this.btnAddEquipment.TabIndex = 4;
            this.btnAddEquipment.Text = "Добавить новую позицию";
            this.btnAddEquipment.UseVisualStyleBackColor = true;
            // 
            // btnRemoveEquipment
            // 
            this.btnRemoveEquipment.Location = new System.Drawing.Point(12, 144);
            this.btnRemoveEquipment.Name = "btnRemoveEquipment";
            this.btnRemoveEquipment.Size = new System.Drawing.Size(220, 23);
            this.btnRemoveEquipment.TabIndex = 5;
            this.btnRemoveEquipment.Text = "Удалить выбранную позициюУдалить выбранную позицию";
            this.btnRemoveEquipment.UseVisualStyleBackColor = true;
            // 
            // btnEditEquipment
            // 
            this.btnEditEquipment.Location = new System.Drawing.Point(12, 173);
            this.btnEditEquipment.Name = "btnEditEquipment";
            this.btnEditEquipment.Size = new System.Drawing.Size(220, 23);
            this.btnEditEquipment.TabIndex = 6;
            this.btnEditEquipment.Text = "Редактировать выбранную позициюУдалить выбранную позицию";
            this.btnEditEquipment.UseVisualStyleBackColor = true;
            // 
            // btnMoveEquipment
            // 
            this.btnMoveEquipment.Location = new System.Drawing.Point(12, 202);
            this.btnMoveEquipment.Name = "btnMoveEquipment";
            this.btnMoveEquipment.Size = new System.Drawing.Size(220, 23);
            this.btnMoveEquipment.TabIndex = 7;
            this.btnMoveEquipment.Text = "Переместить выбранную позициюУдалить выбранную позицию";
            this.btnMoveEquipment.UseVisualStyleBackColor = true;
            // 
            // btnSearchByLocation
            // 
            this.btnSearchByLocation.Location = new System.Drawing.Point(235, 233);
            this.btnSearchByLocation.Name = "btnSearchByLocation";
            this.btnSearchByLocation.Size = new System.Drawing.Size(220, 23);
            this.btnSearchByLocation.TabIndex = 8;
            this.btnSearchByLocation.Text = "Искать по местоложению";
            this.btnSearchByLocation.UseVisualStyleBackColor = true;
            this.btnSearchByLocation.Click += new System.EventHandler(this.btnSearchByLocation_Click);
            // 
            // txtLocation
            // 
            this.txtLocation.Location = new System.Drawing.Point(12, 233);
            this.txtLocation.Name = "txtLocation";
            this.txtLocation.Size = new System.Drawing.Size(217, 20);
            this.txtLocation.TabIndex = 9;
            this.txtLocation.Text = "ввод местоположения позиции";
            // 
            // btnSearchByCategory
            // 
            this.btnSearchByCategory.Location = new System.Drawing.Point(235, 262);
            this.btnSearchByCategory.Name = "btnSearchByCategory";
            this.btnSearchByCategory.Size = new System.Drawing.Size(219, 23);
            this.btnSearchByCategory.TabIndex = 10;
            this.btnSearchByCategory.Text = "поиск по категории";
            this.btnSearchByCategory.UseVisualStyleBackColor = true;
            this.btnSearchByCategory.Click += new System.EventHandler(this.btnSearchByCategory_Click);
            // 
            // txtSearchCategory
            // 
            this.txtSearchCategory.Location = new System.Drawing.Point(12, 262);
            this.txtSearchCategory.Name = "txtSearchCategory";
            this.txtSearchCategory.Size = new System.Drawing.Size(217, 20);
            this.txtSearchCategory.TabIndex = 11;
            this.txtSearchCategory.Text = "ввод категории для поиска";
            // 
            // btnExportToExcel
            // 
            this.btnExportToExcel.Location = new System.Drawing.Point(12, 298);
            this.btnExportToExcel.Name = "btnExportToExcel";
            this.btnExportToExcel.Size = new System.Drawing.Size(217, 23);
            this.btnExportToExcel.TabIndex = 12;
            this.btnExportToExcel.Text = "экспорт данных в Excel";
            this.btnExportToExcel.UseVisualStyleBackColor = true;
            // 
            // dataListViewEquipment
            // 
            this.dataListViewEquipment.CellEditUseWholeCell = false;
            this.dataListViewEquipment.DataSource = null;
            this.dataListViewEquipment.HideSelection = false;
            this.dataListViewEquipment.Location = new System.Drawing.Point(288, 12);
            this.dataListViewEquipment.Name = "dataListViewEquipment";
            this.dataListViewEquipment.Size = new System.Drawing.Size(500, 203);
            this.dataListViewEquipment.TabIndex = 13;
            this.dataListViewEquipment.UseCompatibleStateImageBehavior = false;
            this.dataListViewEquipment.View = System.Windows.Forms.View.Details;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataListViewEquipment);
            this.Controls.Add(this.btnExportToExcel);
            this.Controls.Add(this.txtSearchCategory);
            this.Controls.Add(this.btnSearchByCategory);
            this.Controls.Add(this.txtLocation);
            this.Controls.Add(this.btnSearchByLocation);
            this.Controls.Add(this.btnMoveEquipment);
            this.Controls.Add(this.btnEditEquipment);
            this.Controls.Add(this.btnRemoveEquipment);
            this.Controls.Add(this.btnAddEquipment);
            this.Controls.Add(this.chkIsFunctional);
            this.Controls.Add(this.txtCategory);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtSerialNumber);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataListViewEquipment)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtSerialNumber;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtCategory;
        private System.Windows.Forms.CheckBox chkIsFunctional;
        private System.Windows.Forms.Button btnAddEquipment;
        private System.Windows.Forms.Button btnRemoveEquipment;
        private System.Windows.Forms.Button btnEditEquipment;
        private System.Windows.Forms.Button btnMoveEquipment;
        private System.Windows.Forms.Button btnSearchByLocation;
        private System.Windows.Forms.TextBox txtLocation;
        private System.Windows.Forms.Button btnSearchByCategory;
        private System.Windows.Forms.TextBox txtSearchCategory;
        private System.Windows.Forms.Button btnExportToExcel;
        private BrightIdeasSoftware.DataListView dataListViewEquipment;
    }
}

