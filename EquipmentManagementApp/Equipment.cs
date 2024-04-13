
using System;

namespace EquipmentManagementApp
{
    public class Equipment
    {
        public string SerialNumber { get; set; }
        public string Name { get; set; }
        public string Category { get; set; }
        public bool IsFunctional { get; set; }
        internal Location Location { get; set; }

        public void ChangeLocation(Location newLocation)
        {
            Location = newLocation;
        
        }

        public void Move(Location newLocation)
        {
            Console.WriteLine($"Оборудование {Name} перемещено на новую локацию: {newLocation.Name}.");
        }

        // Переопределение метода ToString()
        public override string ToString()
        {
            // Формируем строку с нужными данными для отображения
            return $"Серийный номер\tНаименование\tКатегория\tРабочий/не рабочий\tНомер склада/отвественного\tНазвание склада/Фио отвественного\tИмя физ.лица/наименование юр.лица\n" +
                   $"{SerialNumber}\t{Name}\t{Category}\t{(IsFunctional ? "Да" : "Нет")}\t{Location?.Number}\t{Location?.Name}\t{Location?.Segment}";
        }

    }
}