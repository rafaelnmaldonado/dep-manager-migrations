namespace dep_manager_singleton.Entities
{
    public class Employee
    {
        public Employee()
        {
            IsDeleted = false;
        }

        public int Id { get; private set; }
        public string? Name { get; set; }
        public string? Picture { get; set; }
        public string? Rg { get; set; }
        public int? IdDepartment { get; set; }
        public bool IsDeleted { get; private set; }

        public void Update(string? name, string? picture, string? rg, int? idDep)
        {
            Name = name;
            Picture = picture;
            Rg = rg;
            IdDepartment = idDep;
        }

        public void Delete()
        {
            IsDeleted = true;
        }

    }
}