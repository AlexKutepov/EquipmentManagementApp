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

        public void UpdateEquipment(string currentSerialNumber, Equipment updatedEquipment)
        {
            int index = equipmentList.FindIndex(e => e.SerialNumber == currentSerialNumber);
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

                worksheet.Cells[1, 1].Value = "Серийный номер";
                worksheet.Cells[1, 2].Value = "Наименование";
                worksheet.Cells[1, 3].Value = "Категория";
                worksheet.Cells[1, 4].Value = "Рабочий/не рабочий";
                worksheet.Cells[1, 5].Value = "Номер склада/отвественного";
                worksheet.Cells[1, 6].Value = "Название склада/Фио отвественного";
                worksheet.Cells[1, 7].Value = "Имя физ.лица/наименование юр.лица";

                int row = 2;
                foreach (var equipment in equipmentList)
                {
                    worksheet.Cells[row, 1].Value = equipment.SerialNumber;
                    worksheet.Cells[row, 2].Value = equipment.Name;
                    worksheet.Cells[row, 3].Value = equipment.Category;
                    worksheet.Cells[row, 4].Value = equipment.IsFunctional ? "Да" : "Нет";
                    worksheet.Cells[row, 5].Value = equipment.Location?.Number;
                    worksheet.Cells[row, 6].Value = equipment.Location?.Name;
                    worksheet.Cells[row, 7].Value = equipment.Location?.Segment;
                    row++;
                }

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

             
                equipmentList.Clear();

                for (int row = 2; row <= rowCount; row++)
                {
                    string serialNumber = worksheet.Cells[row, 1].Value?.ToString();
                    string name = worksheet.Cells[row, 2].Value?.ToString();
                    string category = worksheet.Cells[row, 3].Value?.ToString();
                    bool isFunctional = worksheet.Cells[row, 4].Value?.ToString() == "Да";
                    int locationNumber = int.Parse(worksheet.Cells[row, 5].Value?.ToString());
                    string locationName = worksheet.Cells[row, 6].Value?.ToString();
                    string locationSegment = worksheet.Cells[row, 7].Value?.ToString();

                    if (!string.IsNullOrEmpty(serialNumber) && !string.IsNullOrEmpty(name) && !string.IsNullOrEmpty(category))
                    {
                        Equipment equipment = new Equipment
                        {
                            SerialNumber = serialNumber,
                            Name = name,
                            Category = category,
                            IsFunctional = isFunctional,
                            Location = new Location
                            {
                                Number = locationNumber,
                                Name = locationName,
                                Segment = locationSegment
                            }
                        };
                        equipmentList.Add(equipment);
                    }
                }
            }
        }



    }
}
