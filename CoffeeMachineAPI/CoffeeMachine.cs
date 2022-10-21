namespace CoffeeMachineAPI
{
    public class CoffeeMachine
    {
        public string Message { get; set; } = "Your piping hot coffee is ready";
        public string Prepared { get; set; } = DateTime.Now.ToString("yyyy-MM-ddTHH:mm:ssK");

    }
}
