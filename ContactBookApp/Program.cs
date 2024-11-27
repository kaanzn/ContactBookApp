namespace ContactBookApp
{
    public class Program
    {
        static Dictionary<string, string> contacts = new Dictionary<string, string>();
        public static void Main()
        {
            bool isRunning = true;

            Console.Clear();
            Console.WriteLine("Welcome to the ContactBook App!");
            Thread.Sleep(1000);
            WaitForKey();
            
            do
            {
                Console.Clear();
                Console.WriteLine("Available Actions: ");
                Console.WriteLine("1. Add Contact\n2. Delete Contact\n3. View Contacts\n4. Edit Contact\n5. Exit");

                if (int.TryParse(Console.ReadLine(), out int result))
                {
                    switch (result)
                    {
                        case 1:
                            AddContact();
                            break;
                        case 2:
                            DeleteContact();
                            break;
                        case 3:
                            ViewContacts();
                            break;
                        case 4:
                            Console.WriteLine("");
                            break;
                        case 5:
                            isRunning = false;
                            break;
                        default:
                            System.Console.WriteLine("Invalid Input");
                            WaitForKey();
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Invalid Input...");
                    WaitForKey();
                }
            }while (isRunning);
            
        }

        static void WaitForKey()
        {
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
        }
        static string GetValidInput()
        {
            string? input;
            do
            {
                input = Console.ReadLine();

                if (string.IsNullOrWhiteSpace(input))
                {
                    Console.WriteLine("Input cannot be empty. Please try again.");
                }
            }while (string.IsNullOrWhiteSpace(input));

            return input;
        }

        static void AddContact()
        {
            Console.Write("Enter the name of your contact: ");
            string? name = GetValidInput();

            Console.Write("Enter the email of your contact: ");
            string? email = GetValidInput();

            if (contacts.ContainsKey(name))
            {
                Console.WriteLine($"{name} already exists.");
            }
            else
            {
                contacts.Add(name.ToLower(), email);
                Console.WriteLine("Contact added successfully!");
            }
            WaitForKey();
        }
        static void DeleteContact()
        {
            Console.Write("Enter the name of the contact you wish to delete: ");

            string name = GetValidInput();

            if (!contacts.ContainsKey(name))
            {
                Console.WriteLine($"{name} does not exist.");
            }
            else
            {
                contacts.Remove(name.ToLower());
                Console.WriteLine("Contact was successfully deleted.");

            }
            WaitForKey();
            
        }
        static void ViewContacts()
        {
            if (contacts.Count == 0)
            {
                Console.WriteLine("No contacts found.");
            }
            else
            {
                foreach (var contact in contacts)
                {
                    Console.WriteLine($"Name: {contact.Key} - Email: {contact.Value}");   
                }
            }
            WaitForKey();
        }
    }
}