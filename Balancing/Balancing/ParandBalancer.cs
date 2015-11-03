namespace Balancing
{
    public class ParandBalancer : IParandBalancer
    {
        const char openParand = '(';
        const char closeParand = ')';
        int counter = 0;

        public bool CheckParands(string input)
        {
            if (!string.IsNullOrEmpty(input))
            { 
                foreach (var letter in input)
                {
                    if (letter.Equals(openParand))
                    {
                        counter++;
                    }
                    if (letter.Equals(closeParand))
                    {
                        counter--;
                    }
                }
            }

            if (counter == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
