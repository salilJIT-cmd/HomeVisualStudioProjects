using System;
using System.Collections.Generic;

class Person
{
    public string Name { get; set; }
    public string Email { get; set; }
    public string City { get; set; }
}

class randomPrac2
{
    public static void Main()
    {
        List<Person> peopleList = new List<Person>();
        Random random = new Random();

        int numberOfPeople = 2; // Change this to the number of people you want to generate.

        for (int i = 0; i < numberOfPeople; i++)
        {
            Person person = new Person
            {
                Name = GenerateRandomName(),
                Email = GenerateRandomEmail(),
                City = GenerateRandomCity()
            };

            peopleList.Add(person);
        }

        // Now, peopleList contains your random data.
        foreach (var person in peopleList)
        {
            Console.WriteLine($"Name: {person.Name}, Email: {person.Email}, City: {person.City}");
        }
    }

    static string GenerateRandomName()
    {
        // You can use a list of names and choose one randomly.
        string[] names = { "Alice", "Bob", "Charlie", "David", "Eva", "Frank", "Grace", "Hank", "Ivy" };
        Random random = new Random();
        return names[random.Next(names.Length)];
    }

    static string GenerateRandomEmail()
    {
        // Generate a random email address.
        return $"user{Guid.NewGuid().ToString().Substring(0, 8)}@example.com";
    }

    static string GenerateRandomCity()
    {
        // You can use a list of cities and choose one randomly.
        string[] cities = { "New York", "Los Angeles", "Chicago", "Houston", "Miami" };
        Random random = new Random();
        return cities[random.Next(cities.Length)];
    }
}