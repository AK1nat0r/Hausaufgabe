using System;
using System.Collections.Generic;

namespace List_Hausaufgabe
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> liste1 = new List<string>() { "a", "b", "c",};
            List<string> liste2 = new List<string>() { "c", "d", "e" };

            List<string> links = new List<string>(); //a, b
            List<string> mitte = new List<string>(); //c
            List<string> rechts = new List<string>(); //d, e

            List<string> speicher = new List<string>();
            List<string> speicher2 = new List<string>();
            
            for (int l = 0; l < liste1.Count; l++)
            {
                string InListe1 = liste1[l];
                for (int i = 0; i < liste2.Count; i++)
                {
                    string InListe2 = liste2[i];
                    if(InListe1 == InListe2)
                    {
                        mitte.Add(InListe1);
                        speicher.Add(InListe1);
                    }
                    if(speicher.Contains(InListe2))
                    {
                        break;
                    }
                    else
                    {
                        if ((!links.Contains(InListe1)) && (!liste1.Contains(InListe2)))
                        {
                            links.Add(InListe1);
                        }
                    }
                }
            }

            for (int l = 0; l < liste2.Count; l++)
            {
                string InListe2 = liste2[l];
                for (int i = 0; i < liste1.Count; i++)
                {
                    string InListe1 = liste1[i];
                    if (InListe1 == InListe2)
                    {
                        
                        speicher2.Add(InListe1);
                    }
                    if (speicher2.Contains(InListe2))
                    {
                        break;
                    }
                    else
                    {
                        if ((!rechts.Contains(InListe2)) && (!liste1.Contains(InListe2)))
                        {
                            rechts.Add(InListe2);
                        }
                    }
                }
            }





            WriteList(links);
            Console.WriteLine("-------");
            WriteList(mitte);
            Console.WriteLine("-------");
            WriteList(rechts);
            Console.WriteLine("-------");
            static void WriteList(List<string> Liste_Einfuegen)
            {
                for (int x = 0; x < Liste_Einfuegen.Count; x++)
                {
                    Console.WriteLine(Liste_Einfuegen[x]);
                }

            }
            Console.ReadKey();

        }


    }
  
}
