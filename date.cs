using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratornaya1_SafiullinIR_BPI_24_01
{

        public class myDate
        {
        private int _day;
        private int _month;
        private int _year;

        public int Day
        {
            get { return _day; }
            set {
                if (value >= 1 && value <= 31)
                    _day = value;
                else
                    throw new ArgumentException("День должен быть в диапозоне от 1 до 31");
            }
        }

        public int Month
        {
            get { return _month; }
            set
            {
                if (value >= 1 && value <= 12)
                    _month = value;
                else
                    throw new ArgumentException("Месяц должен быть в диапозоне от 1 до 12");
            }
        }

        public int Year
        {
            get { return _year; }
            set
            {
                if (value >= 0)
                    _year = value;
                else
                    throw new ArgumentException("Год не может быть отрицательным");
            }
        }

        public string equalMonthAndDay()
            {
                if (_day == _month)
                    return "Месяц и число дня совпадает";
                else
                    return "Месяц и число дня не совпадает";

            }
            public void increaseMonth()
            {
                if (_month > 11)
                {
                    _month = 1;
                     _year += 1;
                }
                else
                {
                    _month += 1;
                }
            }

            public string showDate()
            {
                return $"{_day}.{_month}.{_year}";
            }
        }
    }
