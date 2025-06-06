class Program
{
    static void Main(string[] args)
    {
        List<Scripture> scriptureLibrary = GetScriptureLibrary();
        Random rand = new Random();
        Scripture selectedScripture = scriptureLibrary[rand.Next(scriptureLibrary.Count)];

        while (true)
        {
            Console.Clear();
            selectedScripture.Display();

            if (selectedScripture.AllWordsHidden())
            {
                Console.WriteLine("\nAll words are hidden. Program will end.");
                break;
            }

            Console.Write("\nPress Enter to hide more words or type 'quit' to exit: ");
            string input = Console.ReadLine().Trim().ToLower();

            if (input == "quit")
                break;

            selectedScripture.HideRandomWords();
        }
    }

    static List<Scripture> GetScriptureLibrary()
    {
        return new List<Scripture>
            {
                new Scripture(
                    new Reference("John", 3, 16),
                    "For God so loved the world that he gave his one and only Son, that whoever believes in him shall not perish but have eternal life."
                ),
                new Scripture(
                    new Reference("Proverbs", 3, 5, 6),
                    "Trust in the Lord with all your heart and lean not on your own understanding; in all your ways submit to him, and he will make your paths straight."
                ),
                new Scripture(
                    new Reference("Psalm", 23, 1),
                    "The Lord is my shepherd, I lack nothing."
                ),
                new Scripture(
                    new Reference("2 Timothy", 1, 7),
                    "For the Spirit God gave us does not make us timid, but gives us power, love and self-discipline."
                ),
                new Scripture(
                    new Reference("Ether", 12, 41),
                    "And now. I would commend you to seek this Jesus of whom the prophets and apostles have written, that the grace of God the Father, and also the Lord Jesus Christ, and the Holy Ghost, which beareth record of them, may be and abide in you forever. Amen"
                ),
                new Scripture(
                    new Reference("1 Nephi", 3, 7),
                    "...I will go and do the things which the Lord hath commanded, for I know that the Lord giveth no commandments unto the children of men, save he shall prepare a way to accomplish the thing which he commanded them"
                ),
                new Scripture(
                    new Reference("Alma", 26, 22),
                    "Yea, he that repenteth and exerciseth faith, and bringeth forth good works, and prayeth continually without ceasing-unto such it is given to know the mysteries of God, yea, unto such it shall be given to reveal things which never have been revealed; yea, and it shall be given unto such to bring thousands of souls to repentance, even as it has been given unto us to bring these our brethren to repentance"
                )
            };
    }
}
