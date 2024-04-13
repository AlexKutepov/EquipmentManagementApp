
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
            this.btnSaveToFile = new System.Windows.Forms.Button();
            this.txtLocationName = new System.Windows.Forms.TextBox();
            this.txtlocationNumber = new System.Windows.Forms.TextBox();
            this.txtLocationSegment = new System.Windows.Forms.TextBox();
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
            this.txtSerialNumber.TextChanged += new System.EventHandler(this.txtSerialNumber_TextChanged);
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
            this.btnAddEquipment.Location = new System.Drawing.Point(10, 197);
            this.btnAddEquipment.Name = "btnAddEquipment";
            this.btnAddEquipment.Size = new System.Drawing.Size(220, 23);
            this.btnAddEquipment.TabIndex = 4;
            this.btnAddEquipment.Text = "Добавить новую позицию";
            this.btnAddEquipment.UseVisualStyleBackColor = true;
            this.btnAddEquipment.Click += new System.EventHandler(this.btnAddEquipment_Click_1);
            // 
            // btnRemoveEquipment
            // 
            this.btnRemoveEquipment.Location = new System.Drawing.Point(10, 226);
            this.btnRemoveEquipment.Name = "btnRemoveEquipment";
            this.btnRemoveEquipment.Size = new System.Drawing.Size(220, 23);
            this.btnRemoveEquipment.TabIndex = 5;
            this.btnRemoveEquipment.Text = "Удалить выбранную позициюУдалить выбранную позицию";
            this.btnRemoveEquipment.UseVisualStyleBackColor = true;
            this.btnRemoveEquipment.Click += new System.EventHandler(this.btnRemoveEquipment_Click_1);
            // 
            // btnEditEquipment
            // 
            this.btnEditEquipment.Location = new System.Drawing.Point(10, 255);
            this.btnEditEquipment.Name = "btnEditEquipment";
            this.btnEditEquipment.Size = new System.Drawing.Size(220, 23);
            this.btnEditEquipment.TabIndex = 6;
            this.btnEditEquipment.Text = "Редактировать выбранную позициюУдалить выбранную позицию";
            this.btnEditEquipment.UseVisualStyleBackColor = true;
            this.btnEditEquipment.Click += new System.EventHandler(this.btnEditEquipment_Click_1);
            // 
            // btnMoveEquipment
            // 
            this.btnMoveEquipment.Location = new System.Drawing.Point(10, 284);
            this.btnMoveEquipment.Name = "btnMoveEquipment";
            this.btnMoveEquipment.Size = new System.Drawing.Size(220, 23);
            this.btnMoveEquipment.TabIndex = 7;
            this.btnMoveEquipment.Text = "Переместить выбранную позициюУдалить выбранную позицию";
            this.btnMoveEquipment.UseVisualStyleBackColor = true;
            this.btnMoveEquipment.Click += new System.EventHandler(this.btnMoveEquipment_Click_1);
            // 
            // btnSearchByLocation
            // 
            this.btnSearchByLocation.Location = new System.Drawing.Point(233, 315);
            this.btnSearchByLocation.Name = "btnSearchByLocation";
            this.btnSearchByLocation.Size = new System.Drawing.Size(220, 23);
            this.btnSearchByLocation.TabIndex = 8;
            this.btnSearchByLocation.Text = "Искать по местоложению";
            this.btnSearchByLocation.UseVisualStyleBackColor = true;
            this.btnSearchByLocation.Click += new System.EventHandler(this.btnSearchByLocation_Click);
            // 
            // txtLocation
            // 
            this.txtLocation.Location = new System.Drawing.Point(10, 315);
            this.txtLocation.Name = "txtLocation";
            this.txtLocation.Size = new System.Drawing.Size(217, 20);
            this.txtLocation.TabIndex = 9;
            this.txtLocation.Text = "ввод местоположения позиции";
            // 
            // btnSearchByCategory
            // 
            this.btnSearchByCategory.Location = new System.Drawing.Point(233, 344);
            this.btnSearchByCategory.Name = "btnSearchByCategory";
            this.btnSearchByCategory.Size = new System.Drawing.Size(219, 23);
            this.btnSearchByCategory.TabIndex = 10;
            this.btnSearchByCategory.Text = "поиск по категории";
            this.btnSearchByCategory.UseVisualStyleBackColor = true;
            this.btnSearchByCategory.Click += new System.EventHandler(this.btnSearchByCategory_Click);
            // 
            // txtSearchCategory
            // 
            this.txtSearchCategory.Location = new System.Drawing.Point(10, 344);
            this.txtSearchCategory.Name = "txtSearchCategory";
            this.txtSearchCategory.Size = new System.Drawing.Size(217, 20);
            this.txtSearchCategory.TabIndex = 11;
            this.txtSearchCategory.Text = "ввод категории для поиска";
            // 
            // btnExportToExcel
            // 
            this.btnExportToExcel.Location = new System.Drawing.Point(10, 403);
            this.btnExportToExcel.Name = "btnExportToExcel";
            this.btnExportToExcel.Size = new System.Drawing.Size(217, 23);
            this.btnExportToExcel.TabIndex = 12;
            this.btnExportToExcel.Text = "экспорт данных в Excel";
            this.btnExportToExcel.UseVisualStyleBackColor = true;
            this.btnExportToExcel.Click += new System.EventHandler(this.btnExportToExcel_Click_1);
            // 
            // dataListViewEquipment
            // 
            this.dataListViewEquipment.CellEditUseWholeCell = false;
            this.dataListViewEquipment.DataSource = null;
            this.dataListViewEquipment.HideSelection = false;
            this.dataListViewEquipment.Location = new System.Drawing.Point(288, 12);
            this.dataListViewEquipment.Name = "dataListViewEquipment";
            this.dataListViewEquipment.Size = new System.Drawing.Size(715, 203);
            this.dataListViewEquipment.TabIndex = 13;
            this.dataListViewEquipment.UseCompatibleStateImageBehavior = false;
            this.dataListViewEquipment.View = System.Windows.Forms.View.Details;
            this.dataListViewEquipment.SelectedIndexChanged += new System.EventHandler(this.dataListViewEquipment_SelectedIndexChanged);
            // 
            // btnSaveToFile
            // 
            this.btnSaveToFile.Location = new System.Drawing.Point(288, 226);
            this.btnSaveToFile.Name = "btnSaveToFile";
            this.btnSaveToFile.Size = new System.Drawing.Size(217, 52);
            this.btnSaveToFile.TabIndex = 14;
            this.btnSaveToFile.Text = "сохранить изменения";
            this.btnSaveToFile.UseVisualStyleBackColor = true;
            this.btnSaveToFile.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtLocationName
            // 
            this.txtLocationName.Location = new System.Drawing.Point(13, 115);
            this.txtLocationName.Name = "txtLocationName";
            this.txtLocationName.Size = new System.Drawing.Size(219, 20);
            this.txtLocationName.TabIndex = 15;
            this.txtLocationName.Text = "Название склада/Фио отвественного";
            // 
            // txtlocationNumber
            // 
            this.txtlocationNumber.Location = new System.Drawing.Point(13, 141);
            this.txtlocationNumber.Name = "txtlocationNumber";
            this.txtlocationNumber.Size = new System.Drawing.Size(219, 20);
            this.txtlocationNumber.TabIndex = 16;
            this.txtlocationNumber.Text = "Номер склада/отвественного (число)";
            // 
            // txtLocationSegment
            // 
            this.txtLocationSegment.Location = new System.Drawing.Point(12, 167);
            this.txtLocationSegment.Name = "txtLocationSegment";
            this.txtLocationSegment.Size = new System.Drawing.Size(219, 20);
            this.txtLocationSegment.TabIndex = 17;
            this.txtLocationSegment.Text = "Имя физ.лица/наименование юр.лица ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1028, 450);
            this.Controls.Add(this.txtLocationSegment);
            this.Controls.Add(this.txtlocationNumber);
            this.Controls.Add(this.txtLocationName);
            this.Controls.Add(this.btnSaveToFile);
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
        private System.Windows.Forms.Button btnSaveToFile;
        private System.Windows.Forms.TextBox txtLocationName;
        private System.Windows.Forms.TextBox txtlocationNumber;
        private System.Windows.Forms.TextBox txtLocationSegment;
    }
}

