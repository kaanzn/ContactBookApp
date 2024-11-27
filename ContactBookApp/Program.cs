namespace ContactBookApp
{
    public class Program
    {
        static Dictionary<string, string> contacts = new Dictionary<string, string>();
        public static void Main()
        {
            bool isRunning = true;

            Console.Clear();
            Console.WriteLine("Welcome to the AddressBook App!");
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
                            Console.WriteLine("");
                            break;
                        case 3:
                            Console.WriteLine("");
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

        static void AddContact()
        {
            Console.Write("Enter the name of your contact: ");
            string? name = Console.ReadLine();
            Console.Write("Enter the email of your contact: ");
            string? email = Console.ReadLine();
            if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(email))
            {
                Console.WriteLine("Invalid Input.");
            }
            else if (contacts.ContainsKey(name))
            {
                System.Console.WriteLine("A contact with this name already exists.");
            }
            else
            {
                contacts.Add(name, email);
                Console.WriteLine("Contact added successfully!");
                Console.WriteLine("Press any key to continue...");
                
            }
            WaitForKey();
        }
    }
}