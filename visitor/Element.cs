abstract class Element {
    public abstract void Accept(IVisitor visitor);
}

class Employee : Element {
    public string Name { get; set; }
    public double AnnualSalary { get; set; }
    public int PaidTimeOffDays { get; set; }

    public Employee(string name, double annualSalary, int paidTimeOffDays) {
        
    }
}