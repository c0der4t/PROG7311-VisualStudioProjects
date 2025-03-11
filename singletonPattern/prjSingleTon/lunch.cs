public class lunch
{
    private static lunch instance;
    int count = 0 ;
    string LunchOrder = "";
    private lunch(){
            LunchOrder = "eggs on the floor";
    }

    public static lunch getInstance(){
        if (instance == null)
        {
         instance = new lunch(); 
        }

        return instance;
    }

    public void setLunchOrder(string order){
        LunchOrder = order;
    }

    public string getLunchOrder(){
        return LunchOrder;
    }
}