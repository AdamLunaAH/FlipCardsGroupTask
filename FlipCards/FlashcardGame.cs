using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlipCards
{
    internal class FlashcardGame
    {
        private List<Flashcard> flashcards = new List<Flashcard>();
        private int score = 0;


        public void AddCard(int cardId, string title, string question, string option1, string option2, string option3, string answer)
        {

        }

        public void RemoveCard(int cardId)
        {

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
