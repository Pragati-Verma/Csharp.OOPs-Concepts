using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckingExecution
{
    internal class StringBuilderDemo
    {
        public static void Main(string[] args)
        {
            string question = "hOW DOES mICROSOFT wORD DEAL WITH THE cAPS lOCK KEY?";
            System.Text.StringBuilder sb = new System.Text.StringBuilder(question);

            for (int j = 0; j < sb.Length; j++)
            {
                if (System.Char.IsLower(sb[j]) == true)
                    sb[j] = System.Char.ToUpper(sb[j]);
                else if (System.Char.IsUpper(sb[j]) == true)
                    sb[j] = System.Char.ToLower(sb[j]);
            }
            // Store the new string.
            string corrected = sb.ToString();
            System.Console.WriteLine(corrected);
            // Output: How does Microsoft Word deal with the Caps Lock key?
        }
    }
}
