namespace Hundredoors
{
    public class Footage
    {
        private readonly int leght;

        public Footage(int leght)
        {
            this.leght = leght;
        }

        public int Length()
        {
            return leght;
        }
    }
}