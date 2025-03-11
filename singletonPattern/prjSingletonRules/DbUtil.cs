public class DbUtil
{
    private static DbUtil instance;
    
    public int count = 0;

    private DbUtil(){}

    public static DbUtil getInstance(){
        if (instance == null)
        {
            instance = new DbUtil();
        }

        return instance;
    }



}