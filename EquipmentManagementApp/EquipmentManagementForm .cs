using BrightIdeasSoftware;
using System;
using System.Collections.Generic;
using System.Drawing;
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
            InitializeColumns();
            UpdateListViewData();
        }
        private void InitializeColumns()
        {
            dataListViewEquipment.Columns.Clear();

            OLVColumn serialNumberColumn = new OLVColumn("Серийный номер", "SerialNumber");
            OLVColumn nameColumn = new OLVColumn("Наименование", "Name");
            OLVColumn categoryColumn = new OLVColumn("Категория", "Category");
            OLVColumn isFunctionalColumn = new OLVColumn("Рабочий/не рабочий", "IsFunctional");
            OLVColumn locationNumberColumn = new OLVColumn("Номер склада/ответственного", "Location.Number");
            OLVColumn locationNameColumn = new OLVColumn("Название склада/ФИО ответственного", "Location.Name");
            OLVColumn locationSegmentColumn = new OLVColumn("Имя физ. лица/наименование юр. лица", "Location.Segment");

            serialNumberColumn.AspectGetter = delegate (object x) { return ((Equipment)x).SerialNumber; };
            nameColumn.AspectGetter = delegate (object x) { return ((Equipment)x).Name; };
            categoryColumn.AspectGetter = delegate (object x) { return ((Equipment)x).Category; };
            isFunctionalColumn.AspectGetter = delegate (object x) { return ((Equipment)x).IsFunctional ? "Да" : "Нет"; };
            locationNumberColumn.AspectGetter = delegate (object x) { return ((Equipment)x).Location?.Number.ToString(); };
            locationNameColumn.AspectGetter = delegate (object x) { return ((Equipment)x).Location?.Name; };
            locationSegmentColumn.AspectGetter = delegate (object x) { return ((Equipment)x).Location?.Segment; };

            dataListViewEquipment.Columns.AddRange(new OLVColumn[] {
        serialNumberColumn, nameColumn, categoryColumn, isFunctionalColumn,
        locationNumberColumn, locationNameColumn, locationSegmentColumn
    });

            dataListViewEquipment.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
            SetColumnHeaderFont();
        }


        private void UpdateListViewData()
        {
            dataListViewEquipment.SetObjects(equipmentManager.GetEquipmentList());
        }

        private void SetColumnHeaderFont()
        {
            foreach (OLVColumn column in dataListViewEquipment.Columns)
            {
                column.HeaderFont = new Font("Arial", 10, FontStyle.Bold);
            }
        }

        private void ImportDataFromExcel()
        {
            string filePath = "Equipment.xlsx"; 
            try
            {
                if (File.Exists(filePath))
                {
                    equipmentManager.ImportFromExcel(filePath);
                    MessageBox.Show("Импорт данных из Excel завершен", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    UpdateListViewData();
                    dataListViewEquipment.SetObjects(equipmentManager.GetEquipmentList()); 
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
            txtLocationName.Text = "";
            txtlocationNumber.Text = "";
            txtLocationSegment.Text = "";
        }

        private void btnAddEquipment_Click_1(object sender, EventArgs e)
        {
            try
            {
                string serialNumber = txtSerialNumber.Text;
                string name = txtName.Text;
                string category = txtCategory.Text;
                bool isFunctional = chkIsFunctional.Checked;
                string locationName = txtLocationName.Text; 
                int locationNumber = 0;
                string locationSegment = txtLocationSegment.Text;
                int.TryParse(txtlocationNumber.Text, out locationNumber);
                if (string.IsNullOrWhiteSpace(serialNumber) || string.IsNullOrWhiteSpace(name) || string.IsNullOrWhiteSpace(category) ||
                    string.IsNullOrWhiteSpace(locationName) || string.IsNullOrWhiteSpace(locationSegment) )
                {
                    MessageBox.Show("Пожалуйста, заполните все поля корректно.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                
                Location newLocation = new Location
                {
                    Number = locationNumber,
                    Name = locationName,
                    Segment = locationSegment
                }; 

                Equipment newEquipment = new Equipment
                {
                    SerialNumber = serialNumber,
                    Name = name,
                    Category = category,
                    IsFunctional = isFunctional,
                    Location = newLocation
                };

                equipmentManager.AddEquipment(newEquipment);

                ClearFields();
                UpdateListViewData();
                dataListViewEquipment.SetObjects(equipmentManager.GetEquipmentList());
                MessageBox.Show("Позиция добавлена", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                UpdateListViewData();
                dataListViewEquipment.SetObjects(equipmentManager.GetEquipmentList());
                MessageBox.Show("Позиция удалена", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnEditEquipment_Click_1(object sender, EventArgs e)
        {
            Equipment selectedEquipment = (Equipment)dataListViewEquipment.SelectedObject;
            if (selectedEquipment != null)
            {
                string currentSerialNumber = selectedEquipment.SerialNumber;

 
                selectedEquipment.SerialNumber = txtSerialNumber.Text;
                selectedEquipment.Name = txtName.Text;
                selectedEquipment.Category = txtCategory.Text;
                selectedEquipment.IsFunctional = chkIsFunctional.Checked;

                selectedEquipment.Location.Name = txtLocationName.Text;
                int locationNumber;
                if (int.TryParse(txtlocationNumber.Text, out locationNumber))
                {
                    selectedEquipment.Location.Number = locationNumber;
                }
                selectedEquipment.Location.Segment = txtLocationSegment.Text;

                equipmentManager.UpdateEquipment(currentSerialNumber, selectedEquipment);

                ClearFields();
                UpdateListViewData();
                MessageBox.Show("Позиция отредактирована", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnMoveEquipment_Click_1(object sender, EventArgs e)
        {
            Equipment selectedEquipment = (Equipment)dataListViewEquipment.SelectedObject;
            if (selectedEquipment != null)
            {
                MessageBox.Show("Позиция перемещена", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }
        private void dataListViewEquipment_SelectedIndexChanged(object sender, EventArgs e)
        {
            Equipment selectedEquipment = (Equipment)dataListViewEquipment.SelectedObject;
            if (selectedEquipment != null)
            {
                txtSerialNumber.Text = selectedEquipment.SerialNumber;
                txtName.Text = selectedEquipment.Name;
                txtCategory.Text = selectedEquipment.Category;
                chkIsFunctional.Checked = selectedEquipment.IsFunctional;
                if (selectedEquipment.Location != null)
                {
                    txtLocationName.Text = selectedEquipment.Location.Name;
                    txtlocationNumber.Text = selectedEquipment.Location.Number.ToString();
                    txtLocationSegment.Text = selectedEquipment.Location.Segment;
                }
                else
                {
                    txtLocationName.Text = string.Empty;
                    txtlocationNumber.Text = string.Empty;
                    txtLocationSegment.Text = string.Empty;
                }
            }
            else
            {
                ClearFields();
            }
        }


        private void btnSearchByLocation_Click(object sender, EventArgs e)
        {
            string location = txtLocation.Text;
            List<Equipment> equipmentList = equipmentManager.SearchByLocation(location);
            if (equipmentList.Count == 0)
            {
                MessageBox.Show("Данные не найдены", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                dataListViewEquipment.SetObjects(equipmentList);
                dataListViewEquipment.SelectedIndex = 0;
            }
        }


        private void btnSearchByCategory_Click(object sender, EventArgs e)
        {
            string category = txtSearchCategory.Text;
            List<Equipment> equipmentList = equipmentManager.SearchByCategory(category);
            if (equipmentList.Count == 0)
            {
                MessageBox.Show("Данные не найдены", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                dataListViewEquipment.SetObjects(equipmentList);
                dataListViewEquipment.SelectedIndex = 0;
            }
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
        private void button1_Click(object sender, EventArgs e)
        {
            string targetFilePath = "Equipment.xlsx";

            try
            {
                equipmentManager.ExportToExcel(targetFilePath);
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
