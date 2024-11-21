using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlipCards
{
    internal class FlashcardGame
    {
        //private List<Flashcard> flashcards = new List<Flashcard>();
        private int score = 0;


        public void AddCard(List<IFlashcard> cards)
        {
            Console.WriteLine("Enter title: ");
            string title = Console.ReadLine();

            Console.WriteLine("Enter question: ");
            string question = Console.ReadLine();

            Console.WriteLine("Enter: option 1: ");
            string option1 = Console.ReadLine();

            Console.WriteLine("Enter: option 2: ");
            string option2 = Console.ReadLine();

            Console.WriteLine("Enter: option 3: ");
            string option3 = Console.ReadLine();

            Console.WriteLine("Enter the right answer 1/2/3");
            string answer = Console.ReadLine();

            string correctAnswer;

            if (answer == "1")
            {
                correctAnswer = option1;
            }
            else if (answer == "2")
            {
                correctAnswer = option2;
            }
            else if (answer == "3")
            {
                correctAnswer = option3;
            }
            else
            {
                Console.WriteLine("Invalid answer choice. Please enter 1, 2, or 3.");
                return; 
            }


            cards.Add(new Flashcard(title, question, option1, option2, option3, correctAnswer));
            Console.WriteLine($"Flashcard {title} was added!");
        }

        public void RemoveCard(List<IFlashcard> cards)
        {
            Console.WriteLine("Delete card\nList of current cards");
            Console.WriteLine("Enter the title of the card you want to delete:");
            string titleToDelete = Console.ReadLine().Trim();

            // Find the card
            IFlashcard cardToRemove = cards.FirstOrDefault(card => card.Title.Equals(titleToDelete, StringComparison.OrdinalIgnoreCase));

            
            if (cardToRemove != null)
            {
                // Delete card
                cards.Remove(cardToRemove);
                Console.WriteLine($"Card with title '{titleToDelete}' has been deleted.");
            }
            else
            {
                // If the card is not found
                Console.WriteLine($"No card found with the title '{titleToDelete}'.");
            }



        }

        public void ShuffleCards(List<IFlashcard> cards)
        {
            Random shuffle = new Random(); // skapar en random "shuffle"
            flashcards = flashcards.OrderBy(x => shuffle.Next()).ToList(); //LINQ som ändrar ordningen på korten enligt random "shuffle"
            Console.WriteLine("All cards have been shuffled!");
        }

        public void PlayRound()
        {

        }

        public string GetScore()
        {
            return $"";
        }
    }
}
