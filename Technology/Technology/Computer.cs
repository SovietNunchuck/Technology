using System;
using System.Collections.Generic;
using System.Text;

namespace Technology
{
    class Computer
    {
        public readonly string Manufacturer;
        public string OperatingSystem { get; set; }
        public int StorageSpaceInGigabytes { get; set; }
        public int RandomAccessMemoryInGigabytes { get; set; }
        public bool PoweredOnStatus { get; set; } = false;

        public Computer(string manufacturer, string operatingSystem, int storageSpaceInGigabytes, int randomAccessMemoryInGigabytes)
        {
            Manufacturer = manufacturer;
            OperatingSystem = operatingSystem;
            StorageSpaceInGigabytes = storageSpaceInGigabytes;
            RandomAccessMemoryInGigabytes = randomAccessMemoryInGigabytes;
        }

        public Computer()
            : this("HP", "Windows 10", 500, 8) {}

        public void PowerOn()
        {
            if (!PoweredOnStatus)
            {
                Console.WriteLine("Booting up...");
                PoweredOnStatus = true;
            }
            Console.WriteLine("The computer is fully powered on.");
            return;
        }

        public void PowerOff()
        {
            if (PoweredOnStatus)
            {
                Console.WriteLine("Shutting down...");
                PoweredOnStatus = false;
            }
            Console.WriteLine("The computer is fully powered off.");
            return;
        }
    }
}
