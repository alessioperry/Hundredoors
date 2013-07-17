namespace Hundredoors
{
    public class Man
    {
        private readonly Pedometer pedometer;

        public Man()
        {
            pedometer = new Pedometer();
        }

        public void MakeStep(Footage footage)
        {
            pedometer.Add(footage);
        }

        public int StepsCunt()
        {
            return pedometer.Count();
        }
    }
}