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


        public void AddCard(int cardId, string title, string question, string option1, string option2, string option3, string answer)
        {

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
