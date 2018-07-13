namespace ConsoleApptest
{
    public class Phone : Product
    {
        public override double computeTax()
        {
            return Price * 10 / 100;
        }

    }
}