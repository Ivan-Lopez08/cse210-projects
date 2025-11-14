using System.Dynamic;

public class Scripture
{
    private Reference _reference;
    private List<Words> _words = new List<Words>();

    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        foreach (string word in text.Split(' '))
        {
            _words.Add(new Words(word));
        }
    }

    public void GetDisplayText()
    {
        Console.Write($"\n{_reference.GetDisplayReference()} ");
        foreach(Words word in _words)
        {
            Console.Write($"{word.GetDisplayWord()} ");
        }
    }

    public void HideRandomWords(int numberToHide)
    {
        List<Words> availableWords = new List<Words>();
        Random random = new Random();

        foreach (Words word in _words)
        {
            if (!word.IsHidden())
            {
                availableWords.Add(word);
            }
        }

        if (numberToHide > availableWords.Count)
        {
            numberToHide = availableWords.Count;
        }

        for (int i = 0; i < numberToHide; i++)
        {
            int randIndex = random.Next(availableWords.Count);

            Words selectedWord = availableWords[randIndex];
            selectedWord.Hide();

            availableWords.RemoveAt(randIndex);
        }  
    }

    public bool IsCompletelyHidden()
    {
        bool IsHidden = true;
        foreach (Words word in _words)
        {
            if (!word.IsHidden())
            {
                IsHidden = false;
            }
        } 
        return IsHidden;           
    }

}