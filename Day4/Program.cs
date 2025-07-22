using System;
class StringPrograms
{
    static void Main()
    {
        string text = "CSharp$Language@invented_in_2002!";
        int length = text.Length;
        Console.WriteLine("The length of the text is :" + length);
        string subString = text.Substring(7, 8);
        Console.WriteLine("The text from a string is :" + subString);
        Console.WriteLine(text.IndexOf("harp"));
        Console.WriteLine(text.ToUpper());
        string newString = text.Replace("Csharp", "Java");
        Console.WriteLine(newString);
        Console.WriteLine(text.ToLower());
        string replaced = text.Replace(" ", "");
        Console.WriteLine("without space : " + replaced.Length);
        int pos = text.IndexOf("Language");
        Console.WriteLine(pos);
        string newText = text.Substring(pos, 8);
        Console.WriteLine("New Text Value :" + newText.ToUpper());
        

            

        string data = "CSharp,Language";
        String[] lang = data.Split(',');
        foreach (string valuess in lang)
        {
            Console.WriteLine(valuess);
        }

        string data1 = "This is the day four training class";
        string[] lang1 = data1.Split(' ');
        Console.WriteLine("The blank spaces in the above statement : " + ((lang1.Length) - 1));

        string data2 = "apple,orange,grapes,banana";
        string[] lang2 = data2.Split(',');
        Console.WriteLine("The Specail characters in the above statement : " + ((lang2.Length) - 1));

        string data3 = "This is the day four training class";
        string[] lang3 = data3.Split(' ');
        Console.WriteLine("The Number of Words in the above statement :" + (lang3.Length));


        int specialCharCount = 0;
        foreach (char c in text)
        {
            if (!char.IsLetterOrDigit(c) && !char.IsWhiteSpace(c))
                specialCharCount++;
        }
        Console.WriteLine("Total number of special characters: " + specialCharCount);

      
        string s="csharp language";
        int vowel=0;
        foreach(char ch in s)
        {
            if(ch=='a' || ch=='e' || ch=='i' || ch=='o' || ch=='u' ||ch=='A' || ch=='E' || ch=='I' || ch=='O' || ch=='U')
            {
                vowel++;
            }
        }
        Console.WriteLine("total vowel count :"+vowel);
         
       
    }
}


    

