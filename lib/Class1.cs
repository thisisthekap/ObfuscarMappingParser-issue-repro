using System;

namespace lib
{
    public class SomethingFancy
    {
        public void DoIt()
        {
            SomeSecretStuff("a");
        }

        private void SomeSecretStuff(string s)
        {
            Console.WriteLine("Das ist ein Test: " + MakeUpperCase(null));
        }

        private string MakeUpperCase(string s)
        {
            return s.ToUpperInvariant();
        }
    }
}