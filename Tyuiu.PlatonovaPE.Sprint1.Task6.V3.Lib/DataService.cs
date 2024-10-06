using tyuiu.cources.programming.interfaces.Sprint1;
namespace Tyuiu.PlatonovaPE.Sprint1.Task6.V3.Lib
{
    public class DataService : ISprint1Task6V3
    {
        public string LastLetterWord(string value)
        {
            string res = "";
            string[] words = value.Split(' ');
            foreach (string word in words)
            {
                res += word[^1];
            }
            return res;
        }

    }
}
