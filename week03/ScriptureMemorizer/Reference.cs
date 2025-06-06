using System;
using System.Collections.Generic;
using System.Linq;


    class Reference
    {
        public string Book { get; private set; }
        public int Chapter { get; private set; }
        public int StartVerse { get; private set; }
        public int EndVerse { get; private set; }

        // Constructor for single verse
        public Reference(string book, int chapter, int verse)
        {
            Book = book;
            Chapter = chapter;
            StartVerse = verse;
            EndVerse = verse;
        }

        // Constructor for verse range
        public Reference(string book, int chapter, int startVerse, int endVerse)
        {
            Book = book;
            Chapter = chapter;
            StartVerse = startVerse;
            EndVerse = endVerse;
        }

        public override string ToString()
        {
            return EndVerse == StartVerse
                ? $"{Book} {Chapter}:{StartVerse}"
                : $"{Book} {Chapter}:{StartVerse}-{EndVerse}";
        }
    }