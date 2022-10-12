// See https://aka.ms/new-console-template for more information

using HelloWorld;

//Console.WriteLine("Hello World!");
Employee obj = new Employee();

//obj.ShowEmployee();

//EmplyoeeOT.Salaries();
//UC5_CalculateWageFor20DaysInMonth.SalaryFor20DaysInMonth();
//UC3_PartTimeStatement.DayWages();
UC4_SwitchStatement.EmployeeWagesUsingSwitch();
//UC6_CalculateWage100Hrs_or_20Is_Reached.EmpSalaryFor100Hrs();
//UC7_ComputeEmpWageUsingClassMethod.ComputeSalaryUsingClassMethod();
//UC8_ComputeEmpWageForMultipleCompanies.ComputeEmpWage("DMart", 20, 2, 10);
//UC8_ComputeEmpWageForMultipleCompanies.ComputeEmpWage("Amazon", 10, 4, 20);
UC9EachCompanywage dmart = new UC9EachCompanywage("Dmart", 20, 2, 30);
dmart.ComputeEmpWage();
Console.WriteLine(dmart.toString());