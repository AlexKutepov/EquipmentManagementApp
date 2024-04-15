
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
            this.dataListViewEquipment = new BrightIdeasSoftware.DataListView();
            this.panel1 = new System.Windows.Forms.Panel();
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
            this.btnSaveToFile = new System.Windows.Forms.Button();
            this.txtLocationName = new System.Windows.Forms.TextBox();
            this.txtlocationNumber = new System.Windows.Forms.TextBox();
            this.txtLocationSegment = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.showAllData = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataListViewEquipment)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataListViewEquipment
            // 
            this.dataListViewEquipment.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataListViewEquipment.CellEditUseWholeCell = false;
            this.dataListViewEquipment.DataSource = null;
            this.dataListViewEquipment.HideSelection = false;
            this.dataListViewEquipment.Location = new System.Drawing.Point(5, 12);
            this.dataListViewEquipment.Name = "dataListViewEquipment";
            this.dataListViewEquipment.Size = new System.Drawing.Size(695, 259);
            this.dataListViewEquipment.TabIndex = 13;
            this.dataListViewEquipment.UseCompatibleStateImageBehavior = false;
            this.dataListViewEquipment.View = System.Windows.Forms.View.Details;
            this.dataListViewEquipment.SelectedIndexChanged += new System.EventHandler(this.dataListViewEquipment_SelectedIndexChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnExportToExcel);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.showAllData);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.btnSaveToFile);
            this.panel1.Controls.Add(this.txtLocationSegment);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txtlocationNumber);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.txtLocationName);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.chkIsFunctional);
            this.panel1.Controls.Add(this.btnMoveEquipment);
            this.panel1.Controls.Add(this.btnEditEquipment);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnRemoveEquipment);
            this.panel1.Controls.Add(this.btnSearchByLocation);
            this.panel1.Controls.Add(this.btnAddEquipment);
            this.panel1.Controls.Add(this.txtLocation);
            this.panel1.Controls.Add(this.btnSearchByCategory);
            this.panel1.Controls.Add(this.txtSearchCategory);
            this.panel1.Controls.Add(this.txtSerialNumber);
            this.panel1.Controls.Add(this.txtName);
            this.panel1.Controls.Add(this.txtCategory);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 277);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(700, 421);
            this.panel1.TabIndex = 27;
            // 
            // txtSerialNumber
            // 
            this.txtSerialNumber.Location = new System.Drawing.Point(6, 18);
            this.txtSerialNumber.Name = "txtSerialNumber";
            this.txtSerialNumber.Size = new System.Drawing.Size(220, 20);
            this.txtSerialNumber.TabIndex = 0;
            this.txtSerialNumber.TextChanged += new System.EventHandler(this.txtSerialNumber_TextChanged);
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(6, 61);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(220, 20);
            this.txtName.TabIndex = 1;
            // 
            // txtCategory
            // 
            this.txtCategory.Location = new System.Drawing.Point(7, 107);
            this.txtCategory.Name = "txtCategory";
            this.txtCategory.Size = new System.Drawing.Size(219, 20);
            this.txtCategory.TabIndex = 2;
            // 
            // chkIsFunctional
            // 
            this.chkIsFunctional.AutoSize = true;
            this.chkIsFunctional.Location = new System.Drawing.Point(6, 134);
            this.chkIsFunctional.Name = "chkIsFunctional";
            this.chkIsFunctional.Size = new System.Drawing.Size(197, 17);
            this.chkIsFunctional.TabIndex = 3;
            this.chkIsFunctional.Text = "исправно (нажать) / не исправно ";
            this.chkIsFunctional.UseVisualStyleBackColor = true;
            // 
            // btnAddEquipment
            // 
            this.btnAddEquipment.Location = new System.Drawing.Point(6, 280);
            this.btnAddEquipment.Name = "btnAddEquipment";
            this.btnAddEquipment.Size = new System.Drawing.Size(220, 30);
            this.btnAddEquipment.TabIndex = 4;
            this.btnAddEquipment.Text = "Добавить новую позицию";
            this.btnAddEquipment.UseVisualStyleBackColor = true;
            this.btnAddEquipment.Click += new System.EventHandler(this.btnAddEquipment_Click_1);
            // 
            // btnRemoveEquipment
            // 
            this.btnRemoveEquipment.Location = new System.Drawing.Point(5, 316);
            this.btnRemoveEquipment.Name = "btnRemoveEquipment";
            this.btnRemoveEquipment.Size = new System.Drawing.Size(220, 30);
            this.btnRemoveEquipment.TabIndex = 5;
            this.btnRemoveEquipment.Text = "Удалить выбранную позицию";
            this.btnRemoveEquipment.UseVisualStyleBackColor = true;
            this.btnRemoveEquipment.Click += new System.EventHandler(this.btnRemoveEquipment_Click_1);
            // 
            // btnEditEquipment
            // 
            this.btnEditEquipment.Location = new System.Drawing.Point(6, 352);
            this.btnEditEquipment.Name = "btnEditEquipment";
            this.btnEditEquipment.Size = new System.Drawing.Size(220, 30);
            this.btnEditEquipment.TabIndex = 6;
            this.btnEditEquipment.Text = "Редактировать выбранную позицию";
            this.btnEditEquipment.UseVisualStyleBackColor = true;
            this.btnEditEquipment.Click += new System.EventHandler(this.btnEditEquipment_Click_1);
            // 
            // btnMoveEquipment
            // 
            this.btnMoveEquipment.Location = new System.Drawing.Point(6, 388);
            this.btnMoveEquipment.Name = "btnMoveEquipment";
            this.btnMoveEquipment.Size = new System.Drawing.Size(220, 30);
            this.btnMoveEquipment.TabIndex = 7;
            this.btnMoveEquipment.Text = "Переместить выбранную позицию";
            this.btnMoveEquipment.UseVisualStyleBackColor = true;
            this.btnMoveEquipment.Click += new System.EventHandler(this.btnMoveEquipment_Click_1);
            // 
            // btnSearchByLocation
            // 
            this.btnSearchByLocation.Location = new System.Drawing.Point(245, 45);
            this.btnSearchByLocation.Name = "btnSearchByLocation";
            this.btnSearchByLocation.Size = new System.Drawing.Size(220, 60);
            this.btnSearchByLocation.TabIndex = 8;
            this.btnSearchByLocation.Text = "Искать по местоложению";
            this.btnSearchByLocation.UseVisualStyleBackColor = true;
            this.btnSearchByLocation.Click += new System.EventHandler(this.btnSearchByLocation_Click);
            // 
            // txtLocation
            // 
            this.txtLocation.Location = new System.Drawing.Point(248, 18);
            this.txtLocation.Name = "txtLocation";
            this.txtLocation.Size = new System.Drawing.Size(217, 20);
            this.txtLocation.TabIndex = 9;
            // 
            // btnSearchByCategory
            // 
            this.btnSearchByCategory.Location = new System.Drawing.Point(471, 45);
            this.btnSearchByCategory.Name = "btnSearchByCategory";
            this.btnSearchByCategory.Size = new System.Drawing.Size(220, 60);
            this.btnSearchByCategory.TabIndex = 10;
            this.btnSearchByCategory.Text = "Поиск по категории";
            this.btnSearchByCategory.UseVisualStyleBackColor = true;
            this.btnSearchByCategory.Click += new System.EventHandler(this.btnSearchByCategory_Click);
            // 
            // txtSearchCategory
            // 
            this.txtSearchCategory.Location = new System.Drawing.Point(471, 18);
            this.txtSearchCategory.Name = "txtSearchCategory";
            this.txtSearchCategory.Size = new System.Drawing.Size(217, 20);
            this.txtSearchCategory.TabIndex = 11;
            // 
            // btnExportToExcel
            // 
            this.btnExportToExcel.Location = new System.Drawing.Point(245, 352);
            this.btnExportToExcel.Name = "btnExportToExcel";
            this.btnExportToExcel.Size = new System.Drawing.Size(220, 60);
            this.btnExportToExcel.TabIndex = 12;
            this.btnExportToExcel.Text = "Экспорт данных в Excel";
            this.btnExportToExcel.UseVisualStyleBackColor = true;
            this.btnExportToExcel.Click += new System.EventHandler(this.btnExportToExcel_Click_1);
            // 
            // btnSaveToFile
            // 
            this.btnSaveToFile.Location = new System.Drawing.Point(245, 280);
            this.btnSaveToFile.Name = "btnSaveToFile";
            this.btnSaveToFile.Size = new System.Drawing.Size(220, 60);
            this.btnSaveToFile.TabIndex = 14;
            this.btnSaveToFile.Text = "Сохранить изменения";
            this.btnSaveToFile.UseVisualStyleBackColor = true;
            this.btnSaveToFile.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtLocationName
            // 
            this.txtLocationName.Location = new System.Drawing.Point(6, 173);
            this.txtLocationName.Name = "txtLocationName";
            this.txtLocationName.Size = new System.Drawing.Size(219, 20);
            this.txtLocationName.TabIndex = 15;
            // 
            // txtlocationNumber
            // 
            this.txtlocationNumber.Location = new System.Drawing.Point(6, 215);
            this.txtlocationNumber.Name = "txtlocationNumber";
            this.txtlocationNumber.Size = new System.Drawing.Size(219, 20);
            this.txtlocationNumber.TabIndex = 16;
            // 
            // txtLocationSegment
            // 
            this.txtLocationSegment.Location = new System.Drawing.Point(6, 254);
            this.txtLocationSegment.Name = "txtLocationSegment";
            this.txtLocationSegment.Size = new System.Drawing.Size(219, 20);
            this.txtLocationSegment.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 13);
            this.label1.TabIndex = 18;
            this.label1.Text = "Ввод серийного номера";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 13);
            this.label2.TabIndex = 19;
            this.label2.Text = "Ввод названия";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 13);
            this.label3.TabIndex = 20;
            this.label3.Text = "Ввод категории";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 154);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(202, 13);
            this.label4.TabIndex = 21;
            this.label4.Text = "Название склада/Фио отвественного";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 196);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(198, 13);
            this.label5.TabIndex = 22;
            this.label5.Text = "Номер склада/отвественного (число)";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 238);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(205, 13);
            this.label6.TabIndex = 23;
            this.label6.Text = "Имя физ.лица/наименование юр.лица ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(245, 2);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(227, 13);
            this.label7.TabIndex = 24;
            this.label7.Text = "Ввод местоположения позиции для поиска";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(511, 2);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(147, 13);
            this.label8.TabIndex = 25;
            this.label8.Text = "Ввод категории для поиска";
            // 
            // showAllData
            // 
            this.showAllData.Location = new System.Drawing.Point(245, 111);
            this.showAllData.Name = "showAllData";
            this.showAllData.Size = new System.Drawing.Size(220, 60);
            this.showAllData.TabIndex = 26;
            this.showAllData.Text = "Отобразить все элементы";
            this.showAllData.UseVisualStyleBackColor = true;
            this.showAllData.Click += new System.EventHandler(this.showAllData_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 698);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataListViewEquipment);
            this.Name = "Form1";
            this.Text = "Учет оборудования";
            ((System.ComponentModel.ISupportInitialize)(this.dataListViewEquipment)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private BrightIdeasSoftware.DataListView dataListViewEquipment;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnExportToExcel;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button showAllData;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnSaveToFile;
        private System.Windows.Forms.TextBox txtLocationSegment;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtlocationNumber;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtLocationName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox chkIsFunctional;
        private System.Windows.Forms.Button btnMoveEquipment;
        private System.Windows.Forms.Button btnEditEquipment;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnRemoveEquipment;
        private System.Windows.Forms.Button btnSearchByLocation;
        private System.Windows.Forms.Button btnAddEquipment;
        private System.Windows.Forms.TextBox txtLocation;
        private System.Windows.Forms.Button btnSearchByCategory;
        private System.Windows.Forms.TextBox txtSearchCategory;
        private System.Windows.Forms.TextBox txtSerialNumber;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtCategory;
    }
}

