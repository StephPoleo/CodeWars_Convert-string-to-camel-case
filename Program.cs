using System;

public class Program
{

  public static void Main(string[] args)
        {
            string result = toCamelCase("the-stealth-warrior");
            Console.WriteLine(result);
        }
        
  public static string toCamelCase(string str)
  {
    string camel = "";

            for (int i = 0; i < str.Length; i++){

                if (str[i] == '_' || str[i] == '-')
                {
                    char letra = str[i+1];
                    camel = camel + letra.ToString().ToUpper();
                    i++;
                }

                else
                {
                    char letra = str[i];
                    camel = camel + letra;
                }

            }

            return camel;
  }
}
