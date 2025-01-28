using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace TestPro2025
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            DepartmentsLV.ItemsSource = new List<Department>
            {
                new Department("Дороги России")
                {
                    SubDepartments = new List<Department>
                    {
                        new Department("Административный департамент"),
                        new Department("Академия Умные дороги"),
                    }
                },
                new Department("Общий отдел")
                {
                    SubDepartments = new List<Department>
                    {
                        new Department("Договорной отдел"),
                        new Department("Лицензионный отдел"),
                        new Department("Управление маркетинга")
                    }
                }
            };

            WorkersLV.ItemsSource = new List<Worker>
            {
                new Worker(
                    "Белоусов",
                    "Семен",
                    "Агафонович", 
                    "Административный директор-руководитель аппарата",
                    "+7 (179) 370-26-88",
                    "белоусов@гкдр.ру",
                    "402А"),
                new Worker(
                    "Матвеев",
                    "Вадим",
                    "Юрьевич",
                    "Руководитель контрольно-ревизионного направления",
                    "+7 (711) 977-16-52",
                    "матвеев@гкдр.ру",
                    "402А"),
            };
        }


    }

    public class Worker
    {
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string? MiddleName { get; set; }
        public string Position { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string CabinetName { get; set; }

        public Worker(
            string lastName,
            string firstName,
            string middleName,
            string position,
            string phone,
            string email,
            string cabinetName)
        {
            LastName = lastName;
            FirstName = firstName;
            MiddleName = middleName;
            Position = position;
            Phone = phone;
            Email = email;
            CabinetName = cabinetName;
        }
    }

    public class Department
    {
        public string Name { get; set; }

        public List<Department> SubDepartments { get; set; }

        public Department(string name)
        {
            Name = name;
            SubDepartments = [];
        }
    }
}