public class Scripture{


    //constructor
    public Scripture(Reference reference, string scripture){
        _reference = reference;
        _words = NewWordList(scripture);

    }
    //setters and getters
    private Reference _reference;

    private Reference GetRef(){
        return _reference;
    }

    public void SetRef(Reference reference){
        _reference = reference;
    }

    private List<Word> _words;

    private List<Word> GetList(){
        return _words;
    }

    private void SetList(string scripture){
        _words = NewWordList(scripture);

    }

    private List<Word> NewWordList(string scripture){
        var wordList = new List<Word>();

        foreach(var word in scripture.Split(" ")){
            wordList.Add(new Word(word));
        }
        return wordList;
    }

    public void HideWords()
{
        foreach (var word in _words){
            if(!word.IsHidden()){
                var random = new Random();
                if(random.Next(3) == 0){
                    word.HideWord();
                }
            }
        }

        


            
        
    }

    public string Display(){
        string scripture = " ";
        scripture += _reference.Display() + " ";
        foreach(var word in _words){
            scripture += $"{word.Display()} ";

        }
        return scripture;
    }


    public bool IsCompletelyHidden(){
        foreach(var word in _words){
            if(!word.IsHidden()){
                return false;
            }


        }
        return true;
    }






}
