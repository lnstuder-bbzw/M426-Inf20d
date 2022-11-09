namespace FooBarQix
{
    public class FooBarQixDeterminer
    {
        public string Determine(int num)
        {
            if (num % 3 == 0)
            {
                return "Foo";
            }
            else if (num % 5 == 0)
            {
                return "Bar";
            }
            else if (num % 7 == 0)
            {
                return "Qix";
            }
            return num.ToString();
        }
    }
}