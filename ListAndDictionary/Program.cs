namespace ListAndDictionary
{
    internal class Program
    {
        // List variable containing names of persons
        private static List<string> personList = new List<string>();

        // Dictionary containing person name and age where the string TKey is for name and the int TValue is for age
        private static Dictionary<string, int> personAgeDictionary = new Dictionary<string, int>();

        public static void Main()
        {
            Console.WriteLine("Welcome to the Person Manager!");
            bool running = true;
            while (running)
            {
                Console.WriteLine("\nPlease select an option:");
                Console.WriteLine("1. Add New Person");
                Console.WriteLine("2. Remove Person");
                Console.WriteLine("3. Find Person");
                Console.WriteLine("4. List All Persons");
                Console.WriteLine("5. Exit");

                string option = Console.ReadLine();
                switch (option)
                {
                    case "1":
                        AddPerson();
                        break;
                    case "2":
                        RemovePerson();
                        break;
                    case "3":
                        FindPerson();
                        break;
                    case "4":
                        DisplayAllPersons();
                        break;
                    case "5":
                        running = false;
                        break;
                    default:
                        Console.WriteLine("Invalid option, please try again.");
                        break;
                }
            }
        }

        public static void AddPerson()
        {
            // TODO 1: Request user input for the person's name.
            // TODO 2: Validate if the person already exists in the personList.
            // TODO 3: Add the person to the personList if they don't already exist.
            // TODO 4: Provide user feedback for successful addition or if the person already exists in personList.
            // TODO 5: Validate if the person already exists in the personAgeDictionary.
            // TODO 6: If they don't exist, request age input and add the person to the personAgeDictionary.
            //         NOTE!: Remember to add both TKey and TValue
            // TODO 7: Provide user feedback for successful addition or if the person already exists in personAgeDictionary.
            Console.WriteLine("Enter the person's name:");
            string name = Console.ReadLine();

            bool isPersonInList = false;
            foreach (string person in personList)
            {
                if (person == name)
                {
                    isPersonInList = true;
                    break;
                }
            }

            if (!isPersonInList)
            {
                personList.Add(name);
                Console.WriteLine("Person '" + name + "' added to the list.");

                bool isPersonInDictionary = personAgeDictionary.ContainsKey(name);
                if (!isPersonInDictionary)
                {
                    Console.WriteLine("Enter the person's age:");
                    int age = int.Parse(Console.ReadLine());
                    personAgeDictionary[name] = age;
                    Console.WriteLine("Person '" + name + "' added to the dictionary with age " + age + ".");
                }
                else
                {
                    Console.WriteLine("Person '" + name + "' already exists in the age dictionary.");
                }
            }
            else
            {
                Console.WriteLine("Person '" + name + "' already exists in the list.");
            }
        }

        public static void RemovePerson()
        {
            // TODO 8: Request user input for the name of the person to remove.
            // TODO 9: Remove the person from personList if they exist.
            // TODO 10: Provide user feedback for successful removal or if the person doesn't exist in personList.
            // TODO 11: Remove the person from personAgeDictionary if they exist.
            // TODO 12: Provide user feedback for successful removal or if the person doesn't exist in personAgeDictionary.
            Console.WriteLine("Enter the person's name to remove:");
            string name = Console.ReadLine();

            bool isPersonInList = false;
            foreach (string person in personList)
            {
                if (person == name)
                {
                    isPersonInList = true;
                    break;
                }
            }

            if (isPersonInList)
            {
                personList.Remove(name);
                Console.WriteLine("Person '" + name + "' removed from the list.");

                bool isPersonInDictionary = personAgeDictionary.ContainsKey(name);
                if (isPersonInDictionary)
                {
                    personAgeDictionary.Remove(name);
                    Console.WriteLine("Person '" + name + "' removed from the age dictionary.");
                }
                else
                {
                    Console.WriteLine("Person '" + name + "' does not have an age in the dictionary.");
                }
            }
            else
            {
                Console.WriteLine("Person '" + name + "' not found in the list.");
            }
        }

        public static void FindPerson()
        {
            // TODO 13: Request user input for the name of the person to find.
            // TODO 14: Check if the person is in personList and provide appropriate feedback.
            // TODO 15: Check if the person is in personAgeDictionary and provide appropriate feedback.
            Console.WriteLine("Enter the name of the person to find:");
            Console.WriteLine("Enter the person's name to find:");
            string name = Console.ReadLine();

            bool isPersonInList = false;
            foreach (string person in personList)
            {
                if (person == name)
                {
                    isPersonInList = true;
                    break;
                }
            }

            if (isPersonInList)
            {
                Console.WriteLine("Person '" + name + "' found in the list.");
            }
            else
            {
                Console.WriteLine("Person '" + name + "' not found in the list.");
            }

            bool isPersonInDictionary = personAgeDictionary.ContainsKey(name);

            if (isPersonInDictionary)
            {
                Console.WriteLine("Person '" + name + "' found in the age dictionary with age " + personAgeDictionary[name] + ".");
            }
            else
            {
                Console.WriteLine("Person '" + name + "' not found in the age dictionary.");
            }
        }

        public static void DisplayAllPersons()
        {
            // TODO 16: Iterate over personList and display each person's name.
            // TODO 17: Iterate over personAgeDictionary and display each person's name and age.
            // TODO 18: Consider handling the case where the lists are empty by providing feedback to the user.
            if (personList.Count > 0)
            {
                Console.WriteLine("Persons in the list:");
                foreach (string person in personList)
                {
                    Console.WriteLine(person);
                }
            }
            else
            {
                Console.WriteLine("No persons in the list.");
            }

            if (personAgeDictionary.Count > 0)
            {
                Console.WriteLine("\nPersons and their ages in the dictionary:");
                foreach (KeyValuePair<string, int> pair in personAgeDictionary)
                {
                    Console.WriteLine(pair.Key + ": " + pair.Value + " years old");
                }
            }
            else
            {
                Console.WriteLine("\nNo persons in the age dictionary.");
            }
        }
    }
}
