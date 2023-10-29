namespace WebAPI_1.Models
{
    public static class CompanyRepository
    {
        public static List<Employee> employees { get; set; } = new List<Employee>
            {
                new Employee { Emp_Id = 1, Emp_Name = "Salil", Emp_Age = 22, Emp_City = "Nagpur"},
                new Employee { Emp_Id = 2, Emp_Name = "anchal", Emp_Age = 22, Emp_City = "Koradi"}
            };
    }
}
