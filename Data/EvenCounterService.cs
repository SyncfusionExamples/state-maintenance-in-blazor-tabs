namespace BlazorStateMaintenance.Data
{
    public class EvenCounterService
    {
        public int Count { get; private set; }
        public void Increment()
        {
            Count += 2;
        }
    }
}