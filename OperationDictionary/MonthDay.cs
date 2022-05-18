﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperationDictionary
{
    internal class MonthDay
    {
        public int Day { get; set; }
        public int Month { get; set; }
        public MonthDay(int month, int day)
        {
            this.Month = month; this.Day = day;
            this.Day = day;
        }

        // MonthDay どうし の 比較 を する
        public override bool Equals( object obj) 
        {
            var other = obj as MonthDay;
            if (other == null) 
                throw new ArgumentException();
            return this.Day == other.Day && this.Month == other.Month;
        }

        public override int GetHashCode()
        {
            return Month.GetHashCode()*31 * Day.GetHashCode();
        }
    }
}
