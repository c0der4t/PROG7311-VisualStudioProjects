using Microsoft.AspNetCore.Mvc;

class WordController : Controller
{
    [HttpGet("GetSingle")]
    public String getSingle(String lang){
        LangFactory factory = new LangFactory();
        iLang newlang = factory.getLanguage(lang);

        // Implenting a singleton class
        // to ensure we only have one word at any given time
        word w = word.Instance();
        return w.Single(newlang.getName());
    }

    [HttpGet("GetAll")]
    public String[] getAll(String lang)
    {
        LangFactory factory = new LangFactory();
        iLang newlang = factory.getLanguage(lang);
        word w = word.Instance();
        return w.All(newlang.getName());
    }

    [HttpGet("GetSorted")]
    public String[] getSorted(String lang)
    {
        LangFactory factory = new LangFactory();
        iLang newlang = factory.getLanguage(lang);
        word w = word.Instance();
        return w.All(newlang.getName());
    }
}