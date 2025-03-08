namespace Distante.functions;

public class UnSon
{
    public string NewService { get; set; }
    public string NewClient { get; set; }
    public DateOnly NewDate { get; set; }

    public UnSon(string newService, string newClient, DateOnly newDate)
    {
        NewService = newService;
        NewClient = newClient;
        NewDate = newDate;
    }
}