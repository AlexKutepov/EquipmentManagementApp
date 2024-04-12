
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
            this.SuspendLayout();
            // 
            // txtSerialNumber
            // 
            this.txtSerialNumber.Location = new System.Drawing.Point(12, 12);
            this.txtSerialNumber.Name = "txtSerialNumber";
            this.txtSerialNumber.Size = new System.Drawing.Size(220, 20);
            this.txtSerialNumber.TabIndex = 0;
            this.txtSerialNumber.Text = "ввод серийного номера оборудования";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(12, 38);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(220, 20);
            this.txtName.TabIndex = 1;
            this.txtName.Text = "ввод названия оборудования";
            // 
            // txtCategory
            // 
            this.txtCategory.Location = new System.Drawing.Point(13, 65);
            this.txtCategory.Name = "txtCategory";
            this.txtCategory.Size = new System.Drawing.Size(219, 20);
            this.txtCategory.TabIndex = 2;
            this.txtCategory.Text = " ввод категории оборудования";
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnEditEquipment);
            this.Controls.Add(this.btnRemoveEquipment);
            this.Controls.Add(this.btnAddEquipment);
            this.Controls.Add(this.chkIsFunctional);
            this.Controls.Add(this.txtCategory);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtSerialNumber);
            this.Name = "Form1";
            this.Text = "Form1";
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
    }
}

