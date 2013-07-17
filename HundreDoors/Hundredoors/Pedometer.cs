namespace Hundredoors
{
    public class Pedometer
    {
        private int count;

        public Pedometer()
        {
            count = 0;
        }

        public int Count()
        {
            return count;
        }

        public void Add(Footage footage)
        {
            count += footage.Length();
        }

    }
}