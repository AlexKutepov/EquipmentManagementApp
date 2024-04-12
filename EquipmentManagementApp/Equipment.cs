
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
            Console.WriteLine($"Equipment {Name} has been moved to {newLocation.Name}.");
        }
    }
}