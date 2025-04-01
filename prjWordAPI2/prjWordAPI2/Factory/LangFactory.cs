class LangFactory
{
    public iLang reutrnInstance;

    public iLang getLanguage(String languageName){
        switch (languageName.ToUpper())
        {
            case "AFRIKAANS":
            reutrnInstance = new Afrikaans();
            break;

            case "XHOSA":
            reutrnInstance = new Xhosa();
            break;

            
            default:
            reutrnInstance = new English();
            break;
        }

        return reutrnInstance;
    }
    
}