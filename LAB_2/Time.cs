using System;
using System.Collections.Generic;
using System.Text;

namespace LAB_2
{
    //Время
    class Time
    {
        //часы
        private short hours;
        //минуты
        private short minutes;

        public Time(short hours, short minutes)
        {
            this.hours = hours;
            this.minutes = minutes;
        }

        public void SetHours(short hours)
        {
            this.hours = hours;
        }

        public void setMinutes(short minutes)
        {
            this.minutes = minutes;
        }

        public short GetHours()
        {
            return hours;
        }

        public short GetMinutes()
        {
            return minutes;
        }
    }
}
