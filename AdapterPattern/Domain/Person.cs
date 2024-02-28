namespace AdapterPattern
{
    internal class Person
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Course { get; set; }
        public decimal MonthlyPayment { get; set; }
        
        public Person (int id, string name,string course, decimal monthlyPayment)
        {
            Id = id;
            Name = name;
            Course = course;
            MonthlyPayment = monthlyPayment;
        }
    }
}
