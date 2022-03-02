namespace CompanyAndEmployee.Models
{
    public class Employees
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public int? Phone { get; set; }
        public string? Email { get; set; }
        public int? MobilePhone { get; set; }
        public string? Job { get; set; }
        public int? CompaniesId { get; set; }
        public Companies? Companies { get; set; }
    }
}
