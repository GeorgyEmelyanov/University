using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Xml.Serialization;

namespace Lab3
{
    public class Company
    {
        private List<Employee> _employees;

        public Company()
        {
            _employees = new List<Employee>();
        }

        public float AverageSalary { get; private set; }

        public void AddEmployee(Employee employee)
        {
            employee.ID = _employees.Count + 1;
            _employees.Add(employee);
            UpdateAverageSalary();
        }

        private void UpdateAverageSalary()
        {
            AverageSalary = _employees.Average(e => e.AverageSalary);
        }

        private IEnumerable<Employee> GetSortedEmployees()
        {
            IEnumerable<Employee> sortedEmployees =
                _employees.OrderByDescending(employee => employee.AverageSalary).ThenBy(employee => employee.Fio);
            return sortedEmployees;
        }

        public IEnumerable<Employee> GetSortedEmployees(int range, bool reversed)
        {
            if (range < 0 || range > _employees.Count) return _employees;
            var sortedEmployees = GetSortedEmployees();
            return !reversed ? sortedEmployees.Take(range) : sortedEmployees.Skip(_employees.Count - range);
        }

        public void ToXml(string filename)
        {
            var serializer = new XmlSerializer(typeof(List<Employee>));

            using (var stream = File.OpenWrite(filename))
            {
                serializer.Serialize(stream, _employees);
                stream.Flush();
            }
        }

        public static Company FromXml(string filename)
        {
            var company = new Company();
            var serializer = new XmlSerializer(typeof(List<Employee>));

            using (var stream = File.OpenRead(filename))
            {
                try
                {
                    var employees = serializer.Deserialize(stream) as IEnumerable<Employee>;
                    foreach (var employee in employees)
                    {
                        company.AddEmployee(employee);
                    }
                }
                catch (Exception e)
                {
                    throw new Exception("Неверный формат файла", e);
                }
            }

            return company;
        }
    }

    [XmlInclude(typeof(HourEmployee))]
    [XmlInclude(typeof(MonthEmployee))]
    public abstract class Employee
    {
        public string Fio;
        public DateTime DateOfBirth;

        public int ID { get; set; }

        protected Employee()
        {
        }

        protected Employee(string fio, DateTime dateOfBirth)
        {
            Fio = fio;
            DateOfBirth = dateOfBirth;
        }

        public abstract float AverageSalary { get; }

        public override string ToString()
        {
            return $"ID:{ID} ФИО: {Fio}, День рождения: {DateOfBirth.ToShortDateString()}, Средняя зар.плата: {AverageSalary}";
        }
    }

    public class HourEmployee : Employee
    {
        public float HourSalary;

        public HourEmployee()
        {
        }

        public HourEmployee(string fio, DateTime dateOfBirth, float hourSalary) : base(fio, dateOfBirth)
        {
            HourSalary = hourSalary;
        }

        public override float AverageSalary => HourSalary * 8 * 20.8f;
    }

    public class MonthEmployee : Employee
    {
        public float MonthSalary;

        public MonthEmployee()
        {
        }

        public MonthEmployee(string fio, DateTime dateOfBirth, float monthSalary) : base(fio, dateOfBirth)
        {
            MonthSalary = monthSalary;
        }

        public override float AverageSalary => MonthSalary;
    }
    internal class Program
    {
        public static void Main(string[] args)
        {
            var company = new Company();

            var sotr1 = new HourEmployee("Емельянов Георгий", DateTime.Today, 600);
            var sotr2 = new HourEmployee("Емельянова Ольга", DateTime.Today, 800);
            var sotr3 = new MonthEmployee("Мушкарина Вероника", DateTime.Today, 80000);
            var sotr4 = new MonthEmployee("Петров Павел", DateTime.Today, 120000);
            var sotr5 = new MonthEmployee("Емельянова Лилия", DateTime.Today, 200000);
            company.AddEmployee(sotr1);
            company.AddEmployee(sotr2);
            company.AddEmployee(sotr3);
            company.AddEmployee(sotr4);
            company.AddEmployee(sotr5);
            while (true)
            {
                Console.WriteLine(
                    "1) Добавить сотрудника\n2) Вывести первые 5\n3) Вывести последние 3\n4) Вывести среднюю зарплату\n5) Ввод из input.json\n6) Вывод в output.json");
                var choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        Console.WriteLine("1. Почасовой\n2. Месячный");
                        var choice2 = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Введите имя");
                        var name = Console.ReadLine();
                        Console.WriteLine("Введите дату");
                        var date = Convert.ToDateTime(Console.ReadLine());

                        if (choice2 == 1)
                        {
                            Console.WriteLine("Введите почасовую зарплату");
                            var cost = Convert.ToInt32(Console.ReadLine());
                            company.AddEmployee(new HourEmployee(name, date, cost));
                        }
                        else if (choice2 == 2)
                        {
                            Console.WriteLine("Введите месячную зарплату");
                            var salary = Convert.ToInt32(Console.ReadLine());
                            company.AddEmployee(new MonthEmployee(name, date, salary));
                        }
                        else
                        {
                            Console.WriteLine("Неверный ввод");

                        }
                        break;
                    case 2:
                        var response = company.GetSortedEmployees(5, false);
                        foreach (var employee in response)
                        {
                            Console.WriteLine(employee);
                        }

                        break;
                    case 3:
                        response = company.GetSortedEmployees(3, true);
                        foreach (var employee in response)
                        {
                            Console.WriteLine(employee);
                        }

                        break;
                    case 4:
                        Console.WriteLine(company.AverageSalary);
                        break;
                    case 5:
                        try
                        {
                            company = Company.FromXml("input.xml");
                        }
                        catch (Exception e)
                        {
                            Console.WriteLine("Ошибка чтения файла");
                        }
                        break;
                    case 6:
                        company.ToXml("output.xml");
                        break;
                    default:
                        Console.WriteLine("Неверный ввод");
                        break;
                }
            }
        }
    }
}