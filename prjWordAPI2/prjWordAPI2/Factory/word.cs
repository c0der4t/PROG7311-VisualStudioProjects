public class word
{
    private static word instance;

    private word(){}
    public static word Instance(){
            if (instance == null)
            {
                instance = new word();
            }
            return instance;
    }

    public String[] All(String[] words){
        return words;
    }

    public String[] Sorted (String[] arrwords){
        return arrwords.OrderBy(x => x).ToArray();
    }

    public String Single(String[] arrWords){
        Random rnd = new Random();
        return arrWords[rnd.Next(arrWords.Length - 1)];
    }
}