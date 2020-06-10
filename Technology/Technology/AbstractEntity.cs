using System;
using System.Collections.Generic;
using System.Text;

namespace Technology
{
    public abstract class AbstractEntity
    {
        public int DeviceID { get; }
        private static int classCreationCounter = 1;

        public AbstractEntity()
        {
            DeviceID = classCreationCounter;
            classCreationCounter++;
        }
    }
}
