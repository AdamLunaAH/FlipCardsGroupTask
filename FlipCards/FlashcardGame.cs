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
            Console.WriteLine("List of flashcards:");
            foreach (var card in cards)
            {
                Console.WriteLine($"Title: {card.Title}");
                Console.WriteLine($"Question: {card.Question}");
                Console.WriteLine($"1: {card.Option1}, 2: {card.Option2}, 3: {card.Option3}");
                Console.WriteLine($"Answer: {card.Answer}");
                Console.WriteLine();
            }
            string titleToDelete = Console.ReadLine().Trim();

            // Find the card
            IFlashcard cardToRemove = cards.FirstOrDefault(card => card.Title.Equals(titleToDelete, StringComparison.OrdinalIgnoreCase));

            
            if (cardToRemove != null)
            {
                // Delete card
                cards.Remove(cardToRemove);
                Console.WriteLine($"Card with title '{titleToDelete}' has been deleted.\nPress a button to continue.");
                Console.ReadKey();
            }
            else
            {
                // If the card is not found
                Console.WriteLine($"No card found with the title '{titleToDelete}'.\nPress a button to continue.");
                Console.ReadKey();
            }



        }

        public void ShuffleCards(List<IFlashcard> cards)
        {
            Random shuffle = new Random(); // skapar en random "shuffle"
            cards = cards.OrderBy(x => shuffle.Next()).ToList(); //LINQ som ändrar ordningen på korten enligt random "shuffle"
            Console.WriteLine("All cards have been shuffled!");
        }

        public void PlayRound(List<IFlashcard> cards)
        {
            if (cards.Count == 0)
            {
                Console.WriteLine("No flashcards to play. Add some cards first!");
                return;
            }

            // Slumpa ett kort från listan
            Random random = new Random();
            Flashcard currentCard = (Flashcard)cards[random.Next(cards.Count)];

            // Visa frågan och alternativen
            Console.WriteLine($"Question: {currentCard.Question}");
            Console.WriteLine($"1. {currentCard.Option1}");
            Console.WriteLine($"2. {currentCard.Option2}");
            Console.WriteLine($"3. {currentCard.Option3}");


            Console.WriteLine("Choose your answer 1/2/3");
            string answer = Console.ReadLine();


            bool isCorrect = false;
            if ((answer == "1" && currentCard.Answer == currentCard.Option1) ||
                (answer == "2" && currentCard.Answer == currentCard.Option2) ||
                (answer == "3" && currentCard.Answer == currentCard.Option3))
            {
                isCorrect = true;
                score++;
            }

            if (isCorrect)
            {
                Console.WriteLine("Right answer");
                Console.ReadKey();
            }

            else
            {
                Console.WriteLine($"Wrong answer. Right answer was {currentCard.Answer}");
                Console.ReadKey();
            }

            Console.WriteLine($"Current score: {score}\nPress a button to continue.");
            Console.ReadKey();

        }

        public string GetScore()
        {
            return $"Current score: {score}";
        }
    }
}
