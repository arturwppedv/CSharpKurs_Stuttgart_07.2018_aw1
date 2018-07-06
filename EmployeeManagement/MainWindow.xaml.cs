using System;
using System.Collections.Generic;
using System.Windows;
using EmployeeManagement.Model;
using EmployeeManagement.Services;

namespace EmployeeManagement
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        enum EmployeeType
        {
            Trainee,
            Developer,
            ProjectLeader
        }

        //Ist kein Modifier angegeben, so gilt die Variable immer als Private
        List<Employee> _EmployeeList;

        public MainWindow()
        {
            InitializeComponent();
            VacationService.CalculateVacationDays(DateTime.Now, DateTime.Now);
            _EmployeeList = new List<Employee>();

            EmployeeService personService = new EmployeeService();

            //Startwerte werden gesetzt
            _EmployeeList = personService.GetEmployees();
            lstv_Employees.ItemsSource = _EmployeeList;

            cmb_EmployeeType.Items.Add(EmployeeType.Trainee);
            cmb_EmployeeType.Items.Add(EmployeeType.Developer);
            cmb_EmployeeType.Items.Add(EmployeeType.ProjectLeader);

            cmb_EmployeeType.SelectedIndex = 0;
            dp_Birthday.SelectedDate = DateTime.Now;
            dp_EntryDay.SelectedDate = DateTime.Now;
            //string date = DateTime.Now.ToShortTimeString();
        }

        private void btn_AddEmployee_Click(object sender, RoutedEventArgs e)
        {
            EmployeeService personService = new EmployeeService();

            switch ((cmb_EmployeeType.SelectedItem))
            {
                case EmployeeType.Trainee:

                    Trainee trainee;

                    if (string.IsNullOrEmpty(txt_Salary.Text))
                    {
                        trainee = new Trainee(txt_Firstname.Text, txt_Lastname.Text,
                            dp_Birthday.SelectedDate, dp_EntryDay.SelectedDate,
                            Convert.ToInt32(txt_IncuranceId.Text));
                    }
                    else
                    {
                        trainee = new Trainee(txt_Firstname.Text, txt_Lastname.Text,
                            dp_Birthday.SelectedDate, dp_EntryDay.SelectedDate,
                            Convert.ToInt32(txt_IncuranceId.Text), Convert.ToDouble(txt_Salary.Text));
                    }

                    personService.InsertEmployee(trainee);
                    _EmployeeList.Add(trainee);

                    break;
                case EmployeeType.Developer:

                    Developer developer;
                    if (string.IsNullOrEmpty(txt_Salary.Text))
                    {
                        developer = new Developer(txt_Firstname.Text, txt_Lastname.Text,
                            dp_Birthday.SelectedDate, dp_EntryDay.SelectedDate,
                            Convert.ToInt32(txt_IncuranceId.Text));
                    }
                    else
                    {
                        developer = new Developer(txt_Firstname.Text, txt_Lastname.Text,
                            dp_Birthday.SelectedDate, dp_EntryDay.SelectedDate,
                            Convert.ToInt32(txt_IncuranceId.Text), Convert.ToDouble(txt_Salary.Text));
                    }

                    personService.InsertEmployee(developer);
                    _EmployeeList.Add(developer);

                    break;
                case EmployeeType.ProjectLeader:

                    ProjectLeader projectLeader;

                    if (string.IsNullOrEmpty(txt_Salary.Text))
                    {
                        projectLeader = new ProjectLeader(txt_Firstname.Text, txt_Lastname.Text,
                            dp_Birthday.SelectedDate, dp_EntryDay.SelectedDate,
                            Convert.ToInt32(txt_IncuranceId.Text));
                    }
                    else
                    {
                        projectLeader = new ProjectLeader(txt_Firstname.Text, txt_Lastname.Text,
                            dp_Birthday.SelectedDate, dp_EntryDay.SelectedDate,
                            Convert.ToInt32(txt_IncuranceId.Text), Convert.ToDouble(txt_Salary.Text));
                    }

                    personService.InsertEmployee(projectLeader);
                    _EmployeeList.Add(projectLeader);

                    break;
            }

            lstv_Employees.Items.Refresh();
        }

        private void btn_DelteEmployee_Click(object sender, RoutedEventArgs e)
        {
            EmployeeService personService = new EmployeeService();

            Employee employee = (lstv_Employees.SelectedItem as Employee);
            personService.DeleteEmployee(employee);

            _EmployeeList.Remove(employee);
            lstv_Employees.Items.Refresh();
        }

        private void btn_IncreaseSalary_Click(object sender, RoutedEventArgs e)
        {
            EmployeeService personService = new EmployeeService();
            int index = lstv_Employees.SelectedIndex;

            //Listeneintrag aktualisieren
            _EmployeeList[index].IncreaseSalary();

            //In Datenbank aktualisieren
            personService.UpdateEmployee(_EmployeeList[index]);

            //ListView Items aktualisieren
            lstv_Employees.Items.Refresh();
        }
    }
}
