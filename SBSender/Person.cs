namespace SBSender
{
    /// <summary>
    /// Represents a person with basic information.
    /// </summary>
    public class Person
    {
        /// <summary>
        /// Gets or sets the first name of the person.
        /// </summary>
        public string? FirstName { get; set; }

        /// <summary>
        /// Gets or sets the last name of the person.
        /// </summary>
        public string? LastName { get; set; }

        /// <summary>
        /// Gets or sets the birth year of the person.
        /// </summary>
        public int Year { get; set; }

        /// <summary>
        /// Gets or sets the birthday of the person with a default value of DateTime.MinValue.
        /// </summary>
        public DateTime Birthday { get; set; } = DateTime.MinValue;

        /// <summary>
        /// Gets the full name of the person by combining first and last names.
        /// </summary>
        public string FullName => FirstName + " " + LastName;
    }
}

