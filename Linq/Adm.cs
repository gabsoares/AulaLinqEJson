namespace Linq
{
    internal class Adm
    {

        public static List<Person> LoadData()
        {
            var people = new List<Person>();
            people.Add(new Person() { Id = 1, Name = "Gabriel", Age = 17, Phone = "16981906098" });
            people.Add(new Person() { Id = 2, Name = "Jose", Age = 55, Phone = "16981905555" });
            people.Add(new Person() { Id = 3, Name = "Taciana", Age = 49, Phone = "16981904444" });
            people.Add(new Person() { Id = 3, Name = "Alberto", Age = 42, Phone = "16981904144" });
            people.Add(new Person() { Id = 3, Name = "albertinho", Age = 42, Phone = "16981904144" });
            people.Add(new Person() { Id = 3, Name = "albe", Age = 42, Phone = "16981904144" });
            people.Add(new Person() { Id = 3, Name = "oi", Age = 42, Phone = "16981904144" });
            return people;
        }
        public static void PrintData(List<Person> people)
        {
            foreach (var person in people)
            {
                Console.WriteLine(person);
            }
        }

        //public static List<Person> FilterByAge(List<Person> people)
        //{
        //    List<Person> p_temp = new();
        //    foreach (var person in people)
        //    {
        //        if (person.Age >= 18)
        //        {
        //            p_temp.Add(person);
        //        }
        //    }
        //    return p_temp;
        //}

        public static List<Person> FilterByAgeUseLinq(List<Person> people) => people.Where(person => person.Age >= 18).ToList();

        public static List<Person> FilterByNameUseLinq(List<Person> people) => people.Where(person => person.Name[0] == 'A' || person.Name[0] == 'a').ToList();

        public static List<Person> OrderByNameUseLinq(List<Person> people) => people.OrderBy(p => p.Name).ToList();

        public static List<Person> OrderByNameDescendingUseLinq(List<Person> people) => people.OrderByDescending(p => p.Name).ToList();

        public static List<Person> FilterByNameAndLengthUseLinq(List<Person> people) => people.Where(p => p.Name.Length > 3 && (p.Name.Contains("a") || p.Name.Contains("a"))).ToList();
    }
}