namespace CraftCode
{
    public class Year
    {
        private int year;

        public Year(int value)
        {
            year = value;
        }

        public bool IsLeap()
        {
            if (year % 100 == 0 && year % 400 != 0)
                return false;

            return year % 4 == 0;
        }
    }
}
