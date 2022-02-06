namespace ThreadChronometerConsole
{
    public class Chronometer
    {
        private int secondsElapsed;
        private static Mutex mutex = new Mutex();

        public Chronometer()
        {
            secondsElapsed = 0;
        }

        public void calculateElapsedSeconds()
        {
            while (true)
            {
                if (mutex.WaitOne())
                {
                    secondsElapsed++;
                    Thread.Sleep(1000);
                    mutex.ReleaseMutex();
                }
            }
        }

        public void printElapsedSeconds()
        {
            while (true)
            {
                if (mutex.WaitOne())
                {
                    Console.WriteLine($"Seconds elapsed: {secondsElapsed}");
                    mutex.ReleaseMutex();
                }
            }
        }
    }
}
