﻿using System;
using System.Collections.Generic;

namespace HomeKitAccessory.Core
{
    public abstract class Service
    {
        public ulong Id { get; set; }
        public abstract Guid Type { get; }
        private List<Characteristic> characteristics;
        public IEnumerable<Characteristic> Characteristics => characteristics;
        public bool Hidden { get; protected set; }
        protected void AddCharacteristic(Characteristic characteristic)
        {
            characteristics.Add(characteristic);
        }
    }
}
