using System;

class Program
{
    static void Main(string[] args)
    {
        string book = "2 Nefi";
        int chapter = 32;
        int verse = 8;
        int endVerse = 9;

        string texto =
            "And now, my beloved brethren, I perceive that ye ponder still in your hearts; and it grieveth me that I must speak concerning this thing. For if ye would hearken unto the Spirit which teacheth a man to pray, ye would know that ye must pray; for the evil spirit teacheth not a man to pray, but teacheth him that he must not pray. But behold, I say unto you that ye must pray always, and not faint; that ye must not perform any thing unto the Lord save in the first place ye shall pray unto the Father in the name of Christ, that he will consecrate thy performance unto thee, that thy performance may be for the welfare of thy soul.";

        Reference referencia = new Reference(book, chapter, verse, endVerse);

        Scripture scripture = new Scripture(referencia, texto);

        string userChoice = "";

        bool allHidden = false;

        do
        {
            Console.Clear();
            
            Console.WriteLine(scripture.GetDisplayText());

            //blank line
            Console.WriteLine();

            //prompt user
            Console.WriteLine("Press enter to continue or type 'quit' to finish:");
            userChoice = Console.ReadLine();

            //clear the console
            Console.Clear();

            //call HideRandomWords method from the Scripture class
            scripture.HideRandomWords();

            //call GetDisplayText method from scripture to display scripture with hidden words
            Console.WriteLine(scripture.GetDisplayText());

            //call IsCompletelyHidden method from scripture class to verify hidden words
            allHidden = scripture.IsCompletelyHidden();

            //clear the console
            Console.Clear();
        } while (userChoice != "quit" && !allHidden);
    }
}
