namespace Linq
{
    internal class Person
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Phone { get; set; }
        public int Age { get; set; }

        public override string? ToString() => $"Id: {Id}, Name: {Name}, Age: {Age}, Phone: {Phone}";

    }
}
