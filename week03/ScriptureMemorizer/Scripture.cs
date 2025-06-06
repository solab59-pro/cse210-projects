class Scripture
    {
        public Reference Reference { get; private set; }
        private List<Word> _words;
        private Random _random = new Random();

        public Scripture(Reference reference, string text)
        {
            Reference = reference;
            _words = text.Split(' ')
                         .Select(w => new Word(w))
                         .ToList();
        }

        public void Display()
        {
            Console.WriteLine(Reference.ToString());
            foreach (var word in _words)
            {
                Console.Write(word + " ");
            }
            Console.WriteLine();
        }

        public bool AllWordsHidden()
        {
            return _words.All(w => w.IsHidden);
        }

        public void HideRandomWords(int count = 3)
        {
            var visibleWords = _words.Where(w => !w.IsHidden).ToList();

            int wordsToHide = Math.Min(count, visibleWords.Count);
            for (int i = 0; i < wordsToHide; i++)
            {
                int index = _random.Next(visibleWords.Count);
                visibleWords[index].Hide();
                visibleWords.RemoveAt(index);
            }
        }
    }