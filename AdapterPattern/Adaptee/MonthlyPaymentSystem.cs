namespace AdapterPattern
{
    internal class MonthlyPaymentSystem
    {
        public static void CalcMonthlyPayment(List<Person> persons)
        {
            persons.ForEach(p => Console.WriteLine($"Name:{p.Name} - Payment:{p.MonthlyPayment}"));
        }
    }
}
