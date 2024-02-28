namespace AdapterPattern
{
    internal class PersonAdapter : ITarget
    {
        public void ProcessMonthlyPayment(string[,] PersonsArray)
        {
            List<Person> persons = new();

            for (int i = 0; i < PersonsArray.GetLength(0); i++)
            {
                string id = String.Empty;
                string name = String.Empty;
                string course = String.Empty;
                string monthlyPayment = String.Empty;

                for (int j = 0; j < PersonsArray.GetLength(1); j++)
                {
                    switch (j)
                    {
                        case 0: id = PersonsArray[i,j]; break;
                        case 1: name = PersonsArray[i, j]; break;
                        case 2: course = PersonsArray[i, j]; break;
                        default: monthlyPayment = PersonsArray[i, j]; break;
                    }
                }
                persons.Add(new Person(Convert.ToInt32(id), name, course, Convert.ToInt32(monthlyPayment)));
            }

            Console.WriteLine("Converted Array to List<>");

            MonthlyPaymentSystem.CalcMonthlyPayment(persons);
        }
    }
}
