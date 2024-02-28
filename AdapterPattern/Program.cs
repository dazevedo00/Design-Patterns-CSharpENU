using AdapterPattern;
// Notes:
// This project is created using Minimal API to assess the functionality of the Adapter Pattern.
// The main focus is on utilizing the PersonAdapter to adapt and process monthly payments
// based on the given string array representing person data.

string[,] personArray = new string[5, 4]
    {
        {"101","Maria","Artes","1000" },
        {"102","Jorge","Plt","1020" },
        {"103","Paula","Artes","1200" },
        {"104","Irm","Stud","1110" },
        {"105","Tone","Ing","1100" }
    };

ITarget target = new PersonAdapter();

Console.WriteLine("Insert Array on adapter");
target.ProcessMonthlyPayment(personArray);
Console.ReadLine();