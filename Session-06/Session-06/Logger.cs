namespace Calculator
{
    public class Logger
    {
        public string[] NumberListLogger { get; set; }
        public Logger()
        {
            string[] NumberListLogger = new string[30];

        }
        public int Insert(string digits)
        {
            
            for (int i = 0; i < NumberListLogger.Length; i++)
            {
                if (NumberListLogger[i] == null)
                {
                    NumberListLogger[i] = digits;
                }
            }


            return 0;
        }

    }
}