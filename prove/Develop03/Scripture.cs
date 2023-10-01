class Scripture
{
    private Reference _reference;
    private List<Word> _words = new List<Word>();

    public Scripture(Reference Reference, string text)
    {
        _reference = Reference;
                
        string[] splitted = text.Split(' ');

        foreach (string str in splitted)
        {
            Word word = new Word(str);
            _words.Add(word);
        }

    }

    public void HideRandomWords()
    {
        Random random = new Random();

        //number of words to hide
        int wordsToHide = (int)(0.1 * _words.Count);

        for (int i = 0; i < wordsToHide; i++)
        {
            int randomIndex;

            //Stretch challenge: generate random indexes until an unhidden word is found
            do
            {
                randomIndex = random.Next(_words.Count);
            } while (_words[randomIndex].IsHidden()); // Check if the word is already hidden

            _words[randomIndex].Hide();
        }
        
    }



    public string GetDisplayText()
    {
        string fullScrip = "";
        
        //iterate through _words object list and call the GetDisplayText method from the Word class
        foreach (Word wordObject in _words)
        {
            string word = wordObject.GetDisplayText(); 

            fullScrip = $"{fullScrip} {word}";

        }

        //call GetDisplayText method from Reference class
        string refScrip = _reference.GetDisplayText();

        string fullText = $"{refScrip}{fullScrip}";

        return fullText;
    }

    public bool IsCompletelyHidden()
    {
        foreach (Word wordObject in _words)
        { 
            bool hidden = wordObject.IsHidden();

            // Check if the word is not hidden
            if (!hidden)
            {
                // If any word is not hidden, return false
                return false;
            }

        }
        
        // If all words are hidden, return true
        return true;    
    }
}