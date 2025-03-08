namespace Distante.functions;

public class UnSon
{
    public string NewService { get; set; }
    public string NewClient { get; set; }
    public string NewDate { get; set; }

    public UnSon(string newService, string newClient, string newDate)
    {
        NewService = newService;
        NewClient = newClient;
        NewDate = newDate;
    }
}