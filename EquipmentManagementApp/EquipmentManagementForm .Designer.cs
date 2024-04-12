
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
            this.components = new System.ComponentModel.Container();
            this.dataListViewEquipment = new BrightIdeasSoftware.DataTreeListView();
            this.btnExportToExcel = new System.Windows.Forms.Button();
            this.txtSearchCategory = new System.Windows.Forms.TextBox();
            this.btnSearchByCategory = new System.Windows.Forms.Button();
            this.txtLocation = new System.Windows.Forms.TextBox();
            this.btnSearchByLocation = new System.Windows.Forms.Button();
            this.btnMoveEquipment = new System.Windows.Forms.Button();
            this.btnEditEquipment = new System.Windows.Forms.Button();
            this.btnRemoveEquipment = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataListViewEquipment)).BeginInit();
            this.SuspendLayout();
            // 
            // dataListViewEquipment
            // 
            this.dataListViewEquipment.CellEditUseWholeCell = false;
            this.dataListViewEquipment.DataSource = null;
            this.dataListViewEquipment.HideSelection = false;
            this.dataListViewEquipment.Location = new System.Drawing.Point(12, 12);
            this.dataListViewEquipment.Name = "dataListViewEquipment";
            this.dataListViewEquipment.RootKeyValueString = "";
            this.dataListViewEquipment.ShowGroups = false;
            this.dataListViewEquipment.Size = new System.Drawing.Size(686, 183);
            this.dataListViewEquipment.TabIndex = 0;
            this.dataListViewEquipment.UseCompatibleStateImageBehavior = false;
            this.dataListViewEquipment.View = System.Windows.Forms.View.Details;
            this.dataListViewEquipment.VirtualMode = true;
            // 
            // btnExportToExcel
            // 
            this.btnExportToExcel.Location = new System.Drawing.Point(473, 374);
            this.btnExportToExcel.Name = "btnExportToExcel";
            this.btnExportToExcel.Size = new System.Drawing.Size(148, 44);
            this.btnExportToExcel.TabIndex = 1;
            this.btnExportToExcel.Text = "экспорта данных в Excel";
            this.btnExportToExcel.UseVisualStyleBackColor = true;
            // 
            // txtSearchCategory
            // 
            this.txtSearchCategory.Location = new System.Drawing.Point(12, 201);
            this.txtSearchCategory.Name = "txtSearchCategory";
            this.txtSearchCategory.Size = new System.Drawing.Size(248, 20);
            this.txtSearchCategory.TabIndex = 2;
            this.txtSearchCategory.Text = "ввода категории оборудования для поиска";
            // 
            // btnSearchByCategory
            // 
            this.btnSearchByCategory.Location = new System.Drawing.Point(299, 201);
            this.btnSearchByCategory.Name = "btnSearchByCategory";
            this.btnSearchByCategory.Size = new System.Drawing.Size(148, 37);
            this.btnSearchByCategory.TabIndex = 3;
            this.btnSearchByCategory.Text = "Поиск по категории";
            this.btnSearchByCategory.UseVisualStyleBackColor = true;
            // 
            // txtLocation
            // 
            this.txtLocation.Location = new System.Drawing.Point(12, 227);
            this.txtLocation.Name = "txtLocation";
            this.txtLocation.Size = new System.Drawing.Size(248, 20);
            this.txtLocation.TabIndex = 4;
            this.txtLocation.Text = "ввод местоположение оборудования";
            // 
            // btnSearchByLocation
            // 
            this.btnSearchByLocation.Location = new System.Drawing.Point(453, 201);
            this.btnSearchByLocation.Name = "btnSearchByLocation";
            this.btnSearchByLocation.Size = new System.Drawing.Size(148, 41);
            this.btnSearchByLocation.TabIndex = 5;
            this.btnSearchByLocation.Text = "Поиска по местоположению";
            this.btnSearchByLocation.UseVisualStyleBackColor = true;
            // 
            // btnMoveEquipment
            // 
            this.btnMoveEquipment.Location = new System.Drawing.Point(447, 318);
            this.btnMoveEquipment.Name = "btnMoveEquipment";
            this.btnMoveEquipment.Size = new System.Drawing.Size(148, 50);
            this.btnMoveEquipment.TabIndex = 6;
            this.btnMoveEquipment.Text = "перемещение выбранного оборудования";
            this.btnMoveEquipment.UseVisualStyleBackColor = true;
            // 
            // btnEditEquipment
            // 
            this.btnEditEquipment.Location = new System.Drawing.Point(447, 265);
            this.btnEditEquipment.Name = "btnEditEquipment";
            this.btnEditEquipment.Size = new System.Drawing.Size(148, 47);
            this.btnEditEquipment.TabIndex = 7;
            this.btnEditEquipment.Text = "редактирование выбраннного оборудования";
            this.btnEditEquipment.UseVisualStyleBackColor = true;
            // 
            // btnRemoveEquipment
            // 
            this.btnRemoveEquipment.Location = new System.Drawing.Point(268, 265);
            this.btnRemoveEquipment.Name = "btnRemoveEquipment";
            this.btnRemoveEquipment.Size = new System.Drawing.Size(136, 62);
            this.btnRemoveEquipment.TabIndex = 8;
            this.btnRemoveEquipment.Text = "удаление выбранного оборудования";
            this.btnRemoveEquipment.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(118, 374);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 9;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnRemoveEquipment);
            this.Controls.Add(this.btnEditEquipment);
            this.Controls.Add(this.btnMoveEquipment);
            this.Controls.Add(this.btnSearchByLocation);
            this.Controls.Add(this.txtLocation);
            this.Controls.Add(this.btnSearchByCategory);
            this.Controls.Add(this.txtSearchCategory);
            this.Controls.Add(this.btnExportToExcel);
            this.Controls.Add(this.dataListViewEquipment);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataListViewEquipment)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private BrightIdeasSoftware.DataTreeListView dataListViewEquipment;
        private System.Windows.Forms.Button btnExportToExcel;
        private System.Windows.Forms.TextBox txtSearchCategory;
        private System.Windows.Forms.Button btnSearchByCategory;
        private System.Windows.Forms.TextBox txtLocation;
        private System.Windows.Forms.Button btnSearchByLocation;
        private System.Windows.Forms.Button btnMoveEquipment;
        private System.Windows.Forms.Button btnEditEquipment;
        private System.Windows.Forms.Button btnRemoveEquipment;
        private System.Windows.Forms.Button button1;
    }
}

