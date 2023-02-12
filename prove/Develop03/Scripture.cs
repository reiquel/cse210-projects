    // Proverbs class
    class Scripture
    {
        private string _proverbs;
        private string _hiddenProverbs;

        // Randomise method to randomise words
        public void Randomise()
        {
            _proverbs = "Trust in the Lord with all your heart and lean not on your own understanding; in all your ways acknowledge Him, and He will make your paths straight.";
        }

        // HideWord method to hide words
        public void HideWord()
        {
            // Split the proverbs into words
            string[] words = _proverbs.Split(' ');
            // Randomly hide words
            Random rand = new Random();
            for (int i = 0; i < words.Length; i++)
            {
                // Generate a random number
                int randomNumber = rand.Next(0, 6);
                if (randomNumber % 2 == 0)
                {
                    // Replace the word with underscore
                    words[i] = "_";
                }
            }

            // Create a string with the hidden words
            _hiddenProverbs = String.Join(" ", words);
        }

        // ShowResult method to display the result
        public void ShowResult()
        {
            Console.WriteLine("Original Proverbs: ");
            Console.WriteLine(_proverbs);
            Console.WriteLine("\nHidden Proverbs: ");
            Console.WriteLine(_hiddenProverbs);
        }
    }
