using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

public class person
{
   
    public int Id { get; set; }
    [Required]
    public string firstname { get; set; }
    [Required]
    public string lastname { get; set; }
    public string Address { get; set; }
    public char? Sex { get; set; } = 'M';
    public double? Salary { get; set; }

    public static List<person> Getempolyees()
    {
        person emp1 = new person() { firstname = "Raabi", lastname = "Neupane", Address = "ktm", Salary = 2000 };
        person emp2 = new person() { firstname = "Akash", lastname = "Khadka", Address = "ktm", Salary = 1000 };
        person emp3 = new person() { firstname = "Raabin", lastname = "Neupane", Address = "ktm", Salary = 200 };
        List<person> employees = new List<person>() { emp1, emp2, emp3 };
        return employees;
    }
}