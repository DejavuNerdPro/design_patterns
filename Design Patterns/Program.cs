using Design_Patterns.Behavioral_Design_Patterns.COR_Pattern.Services.Handlers;

public class ExecuteRun
{

    public static void Main(string[] args)
    {
        Handler tenThousand = new TenThousandHandler();
        Handler fiveThousand = new FiveThousandHandler();
        Handler thousand = new ThousandHandler();
        Handler fiveHandred = new FiveHandredHandler();
        Handler handred = new OneHandredHandler();
        Handler fifty = new FiftyHandler();

        tenThousand.setNext(fiveThousand);
        fiveThousand.setNext(thousand);
        thousand.setNext(fiveHandred);
        fiveHandred.setNext(handred);
        handred.setNext(fifty);

        tenThousand.Handle(2550);

    }
}
