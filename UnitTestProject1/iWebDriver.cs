using System;

namespace UnitTestProject1
{
    internal class iWebDriver
    {
        internal object Navigate()
        {
            throw new NotImplementedException();
        }

        internal void Quit()
        {
            throw new NotImplementedException();
        }

        public static implicit operator iWebDriver(ChromeDriver v)
        {
            throw new NotImplementedException();
        }
    }
}