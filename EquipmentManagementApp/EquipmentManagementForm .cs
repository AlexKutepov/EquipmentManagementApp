using BrightIdeasSoftware;
using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;


namespace EquipmentManagementApp
{
    public partial class Form1 : Form
    {
        private EquipmentManager equipmentManager; 

        public Form1()
        {
            InitializeComponent();
            equipmentManager = new EquipmentManager();
            dataListViewEquipment.DataSource = equipmentManager.GetEquipmentList();
            ImportDataFromExcel();
            InitializeDataListView();
        }
        private void InitializeDataListView()
        {

            dataListViewEquipment.SetObjects(equipmentManager.GetEquipmentList());
            dataListViewEquipment.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
        }

        private void ImportDataFromExcel()
        {
            string filePath = "Equipment.xlsx"; // Путь к файлу Excel
            try
            {
                if (File.Exists(filePath))
                {
                    equipmentManager.ImportFromExcel(filePath);
                    MessageBox.Show("Импорт данных из Excel завершен", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Файл в каталоге не найден: Equipment.xlsx", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    LogError("Файл не найден: Equipment.xlsx");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка импорта из Exel: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                LogError($"Ошибка импорта из Exel: {ex.Message}");
            }
        }

        private void ClearFields()
        {
            txtSerialNumber.Text = "";
            txtName.Text = "";
            txtCategory.Text = "";
            chkIsFunctional.Checked = false;
        }

        private void btnAddEquipment_Click_1(object sender, EventArgs e)
        {
            try
            {
                string serialNumber = txtSerialNumber.Text;
                string name = txtName.Text;
                string category = txtCategory.Text;
                bool isFunctional = chkIsFunctional.Checked;

                Equipment newEquipment = new Equipment
                {
                    SerialNumber = serialNumber,
                    Name = name,
                    Category = category,
                    IsFunctional = isFunctional
                };

                equipmentManager.AddEquipment(newEquipment);

                ClearFields();
                InitializeDataListView();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка добавления позиции: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                LogError($"Ошибка добавления позиции: {ex.Message}");
            }
        }
        private void btnRemoveEquipment_Click_1(object sender, EventArgs e)
        {
            Equipment selectedEquipment = (Equipment)dataListViewEquipment.SelectedObject;
            if (selectedEquipment != null)
            {
                equipmentManager.RemoveEquipment(selectedEquipment.SerialNumber);
                InitializeDataListView();
            }
        }

        private void btnEditEquipment_Click_1(object sender, EventArgs e)
        {
            Equipment selectedEquipment = (Equipment)dataListViewEquipment.SelectedObject;
            if (selectedEquipment != null)
            {
                selectedEquipment.Name = txtName.Text;
                selectedEquipment.Category = txtCategory.Text;
                selectedEquipment.IsFunctional = chkIsFunctional.Checked;
                equipmentManager.UpdateEquipment(selectedEquipment);
                ClearFields();
                InitializeDataListView();
            }
        }

        private void btnMoveEquipment_Click_1(object sender, EventArgs e)
        {
            Equipment selectedEquipment = (Equipment)dataListViewEquipment.SelectedObject;
            if (selectedEquipment != null)
            {
                // Логика перемещения оборудования
                // Например, можно вызвать метод ReallocateEquipment, если он уже реализован в классе EquipmentManager
                // equipmentManager.ReallocateEquipment(selectedEquipment.SerialNumber, newLocation);
            }
        }
        private void dataListViewEquipment_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Логика, которая будет выполняться при изменении выделенного элемента в списке оборудования
            // Например, можно отобразить информацию о выбранном оборудовании в соответствующих текстовых полях
            Equipment selectedEquipment = (Equipment)dataListViewEquipment.SelectedObject;
            if (selectedEquipment != null)
            {
                txtSerialNumber.Text = selectedEquipment.SerialNumber;
                txtName.Text = selectedEquipment.Name;
                txtCategory.Text = selectedEquipment.Category;
                chkIsFunctional.Checked = selectedEquipment.IsFunctional;
            }
            else
            {
                // Очистить текстовые поля, если ничего не выбрано
                ClearFields();
            }
        }

        private void btnSearchByLocation_Click(object sender, EventArgs e)
        {
            string location = txtLocation.Text;
            List<Equipment> equipmentList = equipmentManager.SearchByLocation(location);
            dataListViewEquipment.SetObjects(equipmentList);
        }

        private void btnSearchByCategory_Click(object sender, EventArgs e)
        {
            string category = txtSearchCategory.Text;
            List<Equipment> equipmentList = equipmentManager.SearchByCategory(category);
            dataListViewEquipment.SetObjects(equipmentList);
        }

        private void btnExportToExcel_Click_1(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Excel files (*.xlsx)|*.xlsx|All files (*.*)|*.*";
            saveFileDialog.FilterIndex = 1;
            saveFileDialog.RestoreDirectory = true;

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    equipmentManager.ExportToExcel(saveFileDialog.FileName);
                    MessageBox.Show("Успешная выгрузка данных в Excel!", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ошибка выгрузки данных в Excel: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    LogError($"Ошибка выгрузки данных в Excel: {ex.Message}");
                }
            }
        }

        private void btnSaveToFile_Click(object sender, EventArgs e)
        {
            // Путь к файлу, который вы хотите сохранить вместе с программой
            string targetFilePath = "EquipmentData.xlsx";

            try
            {
                equipmentManager.ExportToExcel(targetFilePath);
                MessageBox.Show("Данные успешно сохранены в файл с программой!", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка сохранения данных в файл с программой: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                LogError($"Ошибка сохранения данных в файл с программой: {ex.Message}");
            }
        }

        private void txtSerialNumber_TextChanged(object sender, EventArgs e)
        {

        }

        private string logFilePath = "error_log.txt";

        private void LogError(string errorMessage)
        {
            try
            {
                using (StreamWriter writer = new StreamWriter(logFilePath, true))
                {
                    writer.WriteLine($"[{DateTime.Now}] {errorMessage}");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка в логгирование ошибок : {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
