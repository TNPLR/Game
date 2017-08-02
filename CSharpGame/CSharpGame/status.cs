using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpGame
{
    class status
    {
        public status(int year, int month, int day, int hour, int minute, string timezone, string place)
        {
            this.year = year;
            this.month = month;
            this.day = day;
            this.timezone = timezone;
            this.hour = hour;
            this.minute = minute;
            this.place = place;
        }
        public status(int year, int month, int day, int hour, int minute, string timezone, string place, string weather)
        {
            this.year = year;
            this.month = month;
            this.day = day;
            this.timezone = timezone;
            this.hour = hour;
            this.minute = minute;
            this.place = place;
            this.weather = weather;
        }
        public int year;
        public int month;
        public int day;
        public int hour;
        public int minute;
        public string place;
        public string timezone;
        public string weather;
        public void setstatus(int year, int month, int day, int hour, int minute, string timezone, string place)
        {
            this.year = year;
            this.month = month;
            this.day = day;
            this.timezone = timezone;
            this.hour = hour;
            this.minute = minute;
            this.place = place;

        }
    }
}
