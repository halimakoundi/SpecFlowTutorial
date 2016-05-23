namespace Example
{
    public class Calculator
    {
        public int FirstNumber {private get; set; }
        public int SecondNumber  { private get; set; }

        public int Add()
        {
            return FirstNumber + SecondNumber;
        }
    }
}
