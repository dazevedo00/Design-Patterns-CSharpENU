namespace SBSender
{
    internal static class Data
    {
        // Use private backing field for Persons
        private static List<Person>? _persons;

        /// <summary>
        /// Property for the list of persons with a null check before returning.
        /// If the list is null, it gets initialized by calling FillData().
        /// </summary>
        internal static List<Person> Persons
        {
            get
            {
                // Check if the list is null
                if (_persons == null)
                {
                    // Initialize Persons if not already done
                    FillData();
                }

                // Return the list of persons
                return _persons;
            }
            set => _persons = value;
        }

        // Method to fill the data
        internal static void FillData()
        {
            _persons = new List<Person>
            {
                new() {
                    FirstName = "Daniel",
                    LastName = "Azevedo",
                    Year = 1999,
                    Birthday = new DateTime(1999, 2, 2)
                },
                new() {
                    FirstName = "Helder",
                    LastName = "Vieira",
                    Year = 2000,
                    Birthday = new DateTime(2000, 2, 2)
                },
                new() {
                    FirstName = "José",
                    LastName = "Ramalho",
                    Year = 1988,
                    Birthday = new DateTime(1988, 2, 2)
                }
            };
        }

        // Generic method to convert data to JSON
        internal static string ConvertDataToJson<T>(T data)
        {
            try
            {
                return Newtonsoft.Json.JsonConvert.SerializeObject(data);
            }
            catch (Exception ex)
            {
                // Log or handle the exception appropriately
                return $"Error converting to JSON: {ex.Message}";
            }
        }

        // Method to convert Person list to JSON
        internal static string ConvertPersonListToJson()
        {
            return ConvertDataToJson(Persons);
        }

        // Method to convert a single Person to JSON
        internal static string ConvertPersonToJson(Person person)
        {
            return ConvertDataToJson(person);
        }
    }
}
