public class Reference{
    //constructors
    public Reference(string book, int chapter, int verse){
        _book = book;
        _chapter = chapter;
        _verse = verse;
    }

    public Reference(string book, int chapter, int verse, int endVerse){
        _book = book;
        _chapter = chapter;
        _verse = verse;
        _endVerse = endVerse;
    }

    private string _book;

    private string GetBook(){
        return _book;
    }
    public void SetBook(string book){
        _book = book;
    }
    private int _chapter;

    private int GetChapter(){
        return _chapter;
    }

    public void SetChapter(int chapter){
        _chapter = chapter;
    }
    private int _verse;

    private int GetVerse(){
        return _verse;
    }
     public void SetVerse(int verse){
        _verse = verse;
     }

    private int _endVerse;

    private int GetEndVerse(){
        return _endVerse;
    }

    public void SetEndVerse(int endVerse){
        _endVerse = endVerse;
    }

    public string Display(){
        if(_endVerse < 0){
            return ($"{_book} {_chapter}: {_verse} - {_endVerse}");
        }
        else{
            return($"{_book} {_chapter}: {_verse}");

        }

    }


}