namespace _15_ManualSportSequence
{
    using System.Collections.Generic;

    enum Sport { Football, Baseball, Basketball, Hockey, Boxing, Rugby, Fencing }

    class ManualSportSequence : IEnumerable<Sport>
    {
        public IEnumerator<Sport> GetEnumerator()
        {
            return new ManualSportEnumerator();
        }
        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }



    class ManualSportEnumerator : IEnumerator<Sport>
    {
        int current = -1;
        public Sport Current { get { return (Sport)current; } }
        public void Dispose() { return; } // О методе Dispose будет рассказано в главе 10.
        object System.Collections.IEnumerator.Current { get { return Current; } }
        public bool MoveNext()
        {
            var maxEnumValue = Enum.GetValues(typeof(Sport)).Length;
            if ((int)current >= maxEnumValue - 1)
                return false;
            current++;
            return true;
        }
        public void Reset() { current = 0; }
    }

    class BetterSportSequence : IEnumerable<Sport>
    {
        public IEnumerator<Sport> GetEnumerator()
        {
            int maxEnumValue = Enum.GetValues(typeof(Sport)).Length - 1;
            for (int i = 0; i <= maxEnumValue; i++)
            {
                yield return (Sport)i;
            }
        }
        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public Sport this[int index]
        {
            get => (Sport)index;
        }
    }


    internal class Program
    {
        static void Main(string[] args)
        {
            var sportsM = new ManualSportSequence();
            foreach (var sport in sportsM)
                Console.WriteLine(sport);

            var sportsB = new BetterSportSequence();
            foreach (var sport in sportsB)
                Console.WriteLine(sport);
        }
    }
}
