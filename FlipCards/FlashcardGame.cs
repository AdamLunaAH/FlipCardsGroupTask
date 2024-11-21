using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlipCards
{
    public class FlashcardGame
    {
        //private List<Flashcard> flashcards = new List<Flashcard>();
        private int score = 0;


        public void AddCard()
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


            flashcards.Add(new Flashcard(title, question, option1, option2, option3, correctAnswer));
            Console.WriteLine($"Flashcard {title} was added!");
        }

        public void RemoveCard(List<IFlashcard> cards)
        {
            Console.WriteLine("Delete card\nList of current cards");
            Console.WriteLine("Enter the title of the card you want to delete:");
            string titleToDelete = Console.ReadLine().Trim();

            // 
            IFlashcard cardToRemove = cards.FirstOrDefault(card => card.Title.Equals(titleToDelete, StringComparison.OrdinalIgnoreCase));

            if (cardToRemove != null)
            {
                cards.Remove(cardToRemove);
                Console.WriteLine($"Card with title '{titleToDelete}' has been deleted.");
            }
            else
            {
                Console.WriteLine($"No card found with the title '{titleToDelete}'.");
            }



        }

        public void ShuffleCards()
        {
            Random shuffle = new Random();
            int cards = flashcards.Count; // Sparar antal kort i variabeln cards

            for (int i = 0; i < cards; i++) // Loopar igenom alla kort
            {
                int j = shuffle.Next(i, cards); // .Next() slumpar ett tal mellan i och cards
                var tillfällig = flashcards[i]; // Sparar kortet
                flashcards[i] = flashcards[j]; // Byter plats index i med index j
                flashcards[j] = tillfällig; // sparar kortet på index j
            }

            Console.WriteLine("All cards has been shuffled!");
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
