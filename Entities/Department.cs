namespace dep_manager_singleton.Entities
{
    public class Department
    {
        public Department()
        {
            IsDeleted = false;
        }
        public int Id { get; private set; }
        public string? Name { get; set; }
        public string? Acronym { get; set; }
        public bool IsDeleted { get; private set; }

        public void Update(string name, string acronym)
        {
            Name = name;
            Acronym = acronym;
        }

        public void Delete()
        {
            IsDeleted = true;
        }
    }
}
