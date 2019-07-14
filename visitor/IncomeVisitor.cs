//Visitor
class IncomeVisitor : IVisitor {
    public void Visit(Element element) {
        Employee employee = element as Employee;

        employee.AnnualSalary *= 1.10;
    }
}
