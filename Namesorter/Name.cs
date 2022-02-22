namespace NameSorter
{
    public class Name
    {
        public string FirstNames { get; set; }
        public string LastName { get; set; }

        public string FullName
        {
            get
            {
                return $"{FirstNames} {LastName}";
            }
        }

    }

}