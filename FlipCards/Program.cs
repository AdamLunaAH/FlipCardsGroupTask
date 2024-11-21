using System.Security.Cryptography.X509Certificates;

namespace FlipCards
{
    internal class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to C# Flashcards!");
            Console.WriteLine("Press any key to start...");
            Console.ReadKey();

            // TODO: Create a game instance
            List<IFlaschcard> cards = new List<IFlaschcard>
            {
                // sample data
                new Flashcard(1, "Math", "What is 2 + 2?", "3", "4", "5", "4"),
                new Flashcard(2, "Science", "What planet is known as the Red Planet?", "Earth", "Mars", "Jupiter", "Mars"),
                new Flashcard(3, "Geography", "What is the capital of France?", "Paris", "Berlin", "Rome", "Paris"),
                new Flashcard(4, "History", "Who was the first President of the United States?", "Abraham Lincoln", "George Washington", "Thomas Jefferson", "George Washington")
            };

            // test list
            Console.WriteLine("Sample Flashcards:");
            foreach (var card in cards)
            {
                Console.WriteLine($"Card ID: {card.CardId}");
                Console.WriteLine($"Title: {card.Title}");
                Console.WriteLine($"Question: {card.Question}");
                Console.WriteLine($"1: {card.Option1}, 2: {card.Option2}, 3: {card.Option3}");
                Console.WriteLine($"Answer: {card.Answer}");
                Console.WriteLine();
            }






            while (true)
            {
                // TODO: Implement menu system using ConsoleKeyInfo
                // Hint: Use Console.ReadKey() to capture keyboard input
                // Consider using switch statement for different keys
                // Example: 'A' - Add card, 'P' - Play game, 'Q' - Quit

                // TODO: Handle menu choices
                // Remember to use Console.Clear() for better UI
            }
        }
    }
}


// TODO: Create Flashcard class
// Hints:
// - What properties would a flashcard need?
// - Should the properties be read-only or modifiable?
// - Consider adding a method to check if an answer is correct

// TODO: Create FlashcardGame class
// Hints:
// - How will you store the flashcards? (List, Array, Dictionary?)
// - What methods do you need for game functionality?
// - Consider these methods:
//   * AddCard()
//   * RemoveCard()
//   * ShuffleCards()
//   * PlayRound()
//   * GetScore()

// TODO: (Optional) Create a UI helper class
// Hints:
// - Methods for common console operations
// - Color coding for correct/incorrect answers
// - Clear screen and format text

/* Possible Keyboard Controls to Implement:
 * ============================
 * A: Add new flashcard
 * P: Play game
 * S: Show all cards
 * D: Delete card
 * H: Show high score
 * Q: Quit game
 * ↑/↓: Navigate menu (optional)
 * Space: Confirm answer
 * Esc: Return to main menu
 */

/* Implementation Steps:
 * 1. Start with the Flashcard class - it's the foundation
 * 2. Create basic List<Flashcard> in FlashcardGame
 * 3. Implement simple console menu
 * 4. Add keyboard controls one by one
 * 5. Implement game logic
 * 6. Add extra features (scoring, shuffle, etc.)
 */

/* Suggested Data Structures:
 * ========================
 * - List<Flashcard> for card storage
 * - Dictionary<string, Action> for menu commands
 * - Queue<Flashcard> for play session
 */

/* Bonus Challenges:
 * ===============
 * - Add card categories
 * - Implement difficulty levels
 * - Add timer for answers
 * - Save/Load functionality
 * - Statistics tracking
 */