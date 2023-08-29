namespace LibMenu
{
    public class Menu
    {
            private string[] menuItems;
            private int languageChoice;

            public Menu(string[] items, int initialLanguageChoice = 1)
            {
                menuItems = items;
                languageChoice = initialLanguageChoice;
            }

            public int Display()
            {
                Console.WriteLine("Menu:");
                for (int i = 0; i < menuItems.Length; i++)
                {
                    Console.WriteLine($"{i + 1}. {menuItems[i]}");
                }

                int choice = GetValidChoice();
                return choice;
            }

            private int GetValidChoice()
            {
                while (true)
                {
                    Console.Write("Enter your choice: ");
                    string input = Console.ReadLine() ?? string.Empty;
                
                    if (int.TryParse(input,out int choice) && choice >= 1 && choice <= menuItems.Length)
                    {
                        return choice;
                    }
                    else
                    {
                        Console.WriteLine("Invalid choice. Please enter a valid number.");
                    }
                }
            }




    }

    
}