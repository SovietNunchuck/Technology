using System;
using System.Collections.Generic;
using System.Text;

namespace Technology
{
    public class Laptop : Computer
    {
        public double TotalBatteryLifeInHours { get; set; }
        public double RemainingBatteryLife { get; set; }

        public Laptop(string manufacturer, string operatingSystem, int storageSpaceInGigabytes, int randomAccessMemoryInGigabytes, double totalBatteryLifeInHours) : base(manufacturer, operatingSystem, storageSpaceInGigabytes, randomAccessMemoryInGigabytes)
        {
            TotalBatteryLifeInHours = totalBatteryLifeInHours;
            RemainingBatteryLife = TotalBatteryLifeInHours;
        }

        public Laptop(double totalBatteryLifeInHours)
            : this("HP", "Windows 10", 500, 8, totalBatteryLifeInHours) {}

        public Laptop()
            : this("HP", "Windows 10", 500, 8, 10.0) {}

        public void Use(double hours)
        {
            if (this.PoweredOnStatus == false)
            {
                this.PowerOn();
            }
            RemainingBatteryLife -= hours;
            if (RemainingBatteryLife <= 0)
            {
                RemainingBatteryLife = 0;
                this.PowerOff();
            }
        }

        public void Charge(double hours)
        {
            RemainingBatteryLife += 2 * hours;
            if (RemainingBatteryLife > TotalBatteryLifeInHours)
            {
                RemainingBatteryLife = TotalBatteryLifeInHours;
            }
        }
    }
}
