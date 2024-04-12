using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EquipmentManagementApp
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }

    public class Location
    {
        public int Number { get; set; }
        public string Name { get; set; }
        public string Segment { get; set; }
    }

    public class Equipment
    {
        public string SerialNumber { get; set; }
        public string Name { get; set; }
        public string Category { get; set; }
        public bool IsFunctional { get; set; }
        public string Location { get; internal set; }
    }

    public class EquipmentManager
    {
        private List<Equipment> equipmentList;

        public EquipmentManager()
        {
            equipmentList = new List<Equipment>();
        }

        public void AddEquipment(Equipment equipment)
        {
            equipmentList.Add(equipment);
        }

        public void RemoveEquipment(string serialNumber)
        {
            equipmentList.RemoveAll(e => e.SerialNumber == serialNumber);
        }

        public void ReallocateEquipment(string serialNumber, Location newLocation)
        {
            var equipment = equipmentList.Find(e => e.SerialNumber == serialNumber);
            if (equipment != null)
            {
                // Допустим, что у нас есть метод для изменения местоположения оборудования
                // equipment.ChangeLocation(newLocation);
            }
        }

        public void MoveEquipment(string serialNumber, Location newLocation)
        {
            var equipment = equipmentList.Find(e => e.SerialNumber == serialNumber);
            if (equipment != null)
            {
                // Допустим, что у нас есть метод для перемещения оборудования
                // equipment.Move(newLocation);
            }
        }

        public List<Equipment> SearchByLocation(string location)
        {
            return equipmentList.Where(e => e.Location == location).ToList();
        }

        public List<Equipment> SearchByCategory(string category)
        {
            return equipmentList.Where(e => e.Category == category).ToList();
        }

    }

}
