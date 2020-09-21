using System;

namespace task_06
{
    class Program
    {
        class Employee{
        string name, position, department, email;
        double salary;
        int age;
        public Employee(string name, double salary, string position, string department, string email, int age){
            this.name= name; this.salary=salary; this.position=position; this.department=department; this.email=email; this.age=age;
        }
        public Employee(string name, double salary, string position, string department, string email){
            this.name= name; this.salary=salary; this.position=position; this.department=department; this.email=email; this.age=-1;
        }
        public Employee(string name, double salary, string position, string department, int age){
            this.name= name; this.salary=salary; this.position=position; this.department=department; this.email="n/a"; this.age=age;
        }
        public Employee(string name, double salary, string position, string department){
            this.name= name; this.salary=salary; this.position=position; this.department=department; this.email="n/a"; this.age=-1;
        }
        static public string Max(Employee[] employee, int n){
            double maxSalary=-100.10;
                double sum = 0;
                int k = 1;
            string MyDepartment="nothing";
            for(int i=0;i<n;i++){
                         k = 1;
                        sum = employee[i].salary;
                    for(int j = i+1; j < n; j++)
                    {
                       
                        if (employee[i].department==employee[j].department)
                        {
                            sum += employee[j].salary;
                            k++;
                        }
                    }
                if(sum/k>maxSalary){
                    maxSalary=sum/k;
                    MyDepartment=employee[i].department;
                }
            }
            return MyDepartment;
        }
        static public void sort(Employee[] employee, int n){
            for(int i=0;i<n;i++){
                for(int j=0;j<n;j++){
                if(employee[i].department[0]>employee[j].department[0]){
                    Employee tmp = employee[i];
                    employee[i]=employee[j];
                    employee[j]=tmp;
                }
                }
            }            
        }
        static public void output(Employee[] employee, int n, string s){
            for(int i=0;i<n;i++){
                if(employee[i].department==s){
                    Console.WriteLine($"{employee[i].name} {employee[i].salary} {employee[i].email} {employee[i].age}");
                }   
            }
        }
        }
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            Employee [] employee = new Employee[n];
            for(int i=0;i<n;i++){
                string [] s = Console.ReadLine().Split(' ');
                if(s.Length==6){employee[i] = new Employee(s[0],Convert.ToDouble(s[1]),s[2],s[3],s[4],Convert.ToInt32(s[5]));}
                if(s.Length==4){employee[i] = new Employee(s[0],Convert.ToDouble(s[1]),s[2],s[3]);}
                if(s.Length==5 && s[4][0]<'a' ){employee[i] = new Employee(s[0],Convert.ToDouble(s[1]),s[2],s[3],Convert.ToInt32(s[4]));}
                if(s.Length==5 && s[4][0]>='a') {employee[i] = new Employee(s[0],Convert.ToDouble(s[1]),s[2],s[3],s[4]);}
            }
            Console.WriteLine("");
            Console.WriteLine($"Highest Average Salary: {Employee.Max(employee,n)}");
            Employee.sort(employee,n);
            Employee.output(employee,n,Employee.Max(employee,n));
            Console.ReadKey();
        }
    }
}
