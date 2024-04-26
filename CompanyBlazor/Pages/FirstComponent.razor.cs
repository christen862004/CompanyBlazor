namespace CompanyBlazor.Pages
{
    public partial class FirstComponent
    {
        public int No { get; set; }
        public string Msg { get; set; } = "Hiiiiiiiii";
        //C#
        void ShowMessage(string msg)
        {
            Console.WriteLine($"Hi From C# Handel Click Event {msg}");
        }
        void Change()
        {
            Msg = "byyyyyyyyyyyyy";
        }
    }
}
