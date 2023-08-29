using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibMenu
{
    public interface IUserInterface
    {
        void WriteLine(string message);
        string ReadLine();
        int ReadInt();
    }


    public class AdvanceMenu
    {
        private string[] menuItems;
        private int languageChoice;
        private IUserInterface userInterface;

        public AdvanceMenu(string[] items, IUserInterface ui, int initialLanguageChoice = 1)
        {
            menuItems = items;
            userInterface = ui;
            languageChoice = initialLanguageChoice;
        }

        public int Display()
        {
            userInterface.WriteLine("Menu:");
            for (int i = 0; i < menuItems.Length; i++)
            {
                userInterface.WriteLine($"{i + 1}. {menuItems[i]}");
            }

            int choice = GetValidChoice();
            return choice;
        }

        private int GetValidChoice()
        {
            while (true)
            {
                userInterface.WriteLine("Enter your choice: ");
                int choice = userInterface.ReadInt();

                if (choice >= 1 && choice <= menuItems.Length)
                {
                    return choice;
                }
                else
                {
                    userInterface.WriteLine("Invalid choice. Please enter a valid number.");
                }
            }
        }

    }
}
