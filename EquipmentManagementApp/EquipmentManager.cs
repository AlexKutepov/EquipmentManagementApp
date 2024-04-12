using System;
using System.Collections.Generic;
using System.Linq;
using OfficeOpenXml;
using System.IO;

namespace EquipmentManagementApp
{
    public class EquipmentManager
    {
        private List<Equipment> equipmentList;

        public EquipmentManager()
        {
            equipmentList = new List<Equipment>();
        }

        public List<Equipment> GetEquipmentList()
        {
            return equipmentList;
        }

        public void AddEquipment(Equipment equipment)
        {
            equipmentList.Add(equipment);
        }

        public void RemoveEquipment(string serialNumber)
        {
            equipmentList.RemoveAll(e => e.SerialNumber == serialNumber);
        }

        public void UpdateEquipment(Equipment updatedEquipment)
        {
         
            int index = equipmentList.FindIndex(e => e.SerialNumber == updatedEquipment.SerialNumber);
            if (index != -1)
            {
                equipmentList[index] = updatedEquipment;
            }
        }

        public void MoveEquipmentToLocation(string serialNumber, Location newLocation)
        {
            var equipment = equipmentList.Find(e => e.SerialNumber == serialNumber);
            if (equipment != null)
            {
                equipment.Move(newLocation);
                equipment.Location = newLocation;
            }
        }

        public List<Equipment> SearchByLocation(string location)
        {
            return equipmentList.Where(e => e.Location != null && e.Location.Name == location).ToList();
        }

        public List<Equipment> SearchByCategory(string category)
        {
            return equipmentList.Where(e => e.Category == category).ToList();
        }

        public void SortByName()
        {
            equipmentList = equipmentList.OrderBy(e => e.Name).ToList();
        }

        public void ExportToExcel(string filePath)
        {
            ExcelPackage.LicenseContext = LicenseContext.NonCommercial;
            using (var package = new ExcelPackage())
            {
                var worksheet = package.Workbook.Worksheets.Add("Equipment");

                // Headers
                worksheet.Cells[1, 1].Value = "Серийный номер";
                worksheet.Cells[1, 2].Value = "Имя";
                worksheet.Cells[1, 3].Value = "Категория";
                worksheet.Cells[1, 4].Value = "Рабочий?";

                // Data
                int row = 2;
                foreach (var equipment in equipmentList)
                {
                    worksheet.Cells[row, 1].Value = equipment.SerialNumber;
                    worksheet.Cells[row, 2].Value = equipment.Name;
                    worksheet.Cells[row, 3].Value = equipment.Category;
                    worksheet.Cells[row, 4].Value = equipment.IsFunctional ? "Нет" : "Да";
                    row++;
                }

                // Save Excel file
                package.SaveAs(new FileInfo(filePath));
            }
        }

        public void ImportFromExcel(string filePath)
        {
            ExcelPackage.LicenseContext = LicenseContext.NonCommercial;
            using (var package = new ExcelPackage(new FileInfo(filePath)))
            {
                var worksheet = package.Workbook.Worksheets["Equipment"];
                int rowCount = worksheet.Dimension.Rows;

                for (int row = 2; row <= rowCount; row++)
                {
                    string serialNumber = worksheet.Cells[row, 1].Value?.ToString();
                    string name = worksheet.Cells[row, 2].Value?.ToString();
                    string category = worksheet.Cells[row, 3].Value?.ToString();
                    bool isFunctional = worksheet.Cells[row, 4].Value?.ToString() == "Yes";

                    if (!string.IsNullOrEmpty(serialNumber) && !string.IsNullOrEmpty(name) && !string.IsNullOrEmpty(category))
                    {
                        Equipment equipment = new Equipment
                        {
                            SerialNumber = serialNumber,
                            Name = name,
                            Category = category,
                            IsFunctional = isFunctional
                        };
                        equipmentList.Add(equipment);
                    }
                }
            }
        }
    }
}
