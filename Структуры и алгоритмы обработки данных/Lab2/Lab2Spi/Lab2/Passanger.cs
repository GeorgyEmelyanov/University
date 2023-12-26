using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    internal class Passanger
    {
        public int _raise;
        public int _bag_count;
        public DateTime _date;
        public string _point;
        public string _fam;
        public double _bag_weigth;
        public Passanger(int raise, DateTime date, string point, string fam, int bag_count, double bag_weigth)
        {
            
            _raise = raise;
            _bag_count = bag_count;
            _date = date;  
            _point= point;
            _fam = fam; 
            _bag_weigth= bag_weigth;
        }
        public override string ToString()
        {

            return $"Рейс: {_raise} \t" +
                   $"Дата: {_date} \t" +
                   $"Пункт назначения: {_point} \t" +
                   $"Фамилия: {_fam} \t" +
                   $"Количество багажа: {_bag_count} \t" +
                   $"Вес багажа: {_bag_weigth} \t";
        }
    }
}
