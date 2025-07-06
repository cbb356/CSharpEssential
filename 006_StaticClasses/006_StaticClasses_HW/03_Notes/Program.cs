using System;

namespace Book
{
    /*
     * Використовуючи Visual Studio, створіть проект за шаблоном Console Application. 
     * Розширте приклад уроку 005_Book, створивши в класі Book, вкладений клас Notes, 
     * який дозволить зберігати замітки читача. 
     */

    internal class Book
    {
        public void FindNext(string str)
        {
            Console.WriteLine("Пошук рядка : " + str);
        }

        public class Notes
        {
            private string[] notes = new string[0];
            private int count = 0;

            public void AddNote(string note)
            {
                string[] tempNotes = new string[count + 1];
                for (int i = 0; i < count; i++)
                {
                    tempNotes[i] = notes[i];
                }
                tempNotes[count] = note;
                notes = tempNotes;
                count++;
                Console.WriteLine($"{note} has been saved");
            }

            public void ShowAllNotes()
            {
                Console.WriteLine("\nThe list of notes in the book:");
                foreach (string item in notes)
                {
                    Console.WriteLine(item);
                }
            }
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Book.Notes notes = new Book.Notes();
            notes.AddNote("First note");
            notes.AddNote("Second note");
            notes.AddNote("Third note");
            notes.ShowAllNotes();

            // Delay.
            Console.ReadKey();
        }
    }
}
