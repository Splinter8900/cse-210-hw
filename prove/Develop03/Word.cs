
public class Word {
    //constructor
    public  Word(string word){
        _word = word;
        _isHidden =  false;
    }

    // getters and setters

        private string _word;
    private string GetWord(){
        return _word;
    }

    public void SetWord(string word){
        _word = word;
    }


    private bool _isHidden {get;set;}
    

    public bool IsHidden(){
        return _isHidden;
    }

    public void HideWord(){
        _isHidden = true;
    }

    public string Display(){
        if(IsHidden()){
            var word = "";
            foreach(var letter in _word){
                word += "_";

            }
            return word;
        }

        return _word;
    }




   
    
    
    

    

    

    
    

       
    

}