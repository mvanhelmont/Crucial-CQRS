﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crucial.Framework.DesignPatterns.CQRS.Events
{
    [Serializable]
    public class Event : IEvent
    {
        public int Version { get; set; }
        public int AggregateId { get; set; }
        public int Id { get; set; }
        public DateTime Timestamp { get; set; }
    }
}