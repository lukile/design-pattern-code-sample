//Visitor
class PaidTimeOffVisitor : IVisitor {
    public void Visit(Element element) {
        Employee employee = element as Employee;

        employee.PaidTimeOffDays += 3;
    }
}