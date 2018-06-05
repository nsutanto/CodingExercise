using System;
using System.IO;
using System.Collections.Generic;
using System.Text;

public static class Program
{
    static void Main()
    {
        using (StreamReader reader = new StreamReader(Console.OpenStandardInput()))
            while (!reader.EndOfStream)
            {
                string line = reader.ReadLine();

                string output = "True";
                char[,] board = InitBoard();


                int row = 0;
                int column = 0;
                for (int i = 0; i <= line.Length - 1; i++)
                {
                    if (i == 0)
                    {
                        if (line[i] != board[0, 0])
                        {
                            output = "False";
                            break;
                        }
                    }
                    else
                    {
                        bool charFound = false;
                        if (row < 2)
                        {
                            if (line[i] == board[row + 1, column])
                            {
                                row = row + 1;
                                charFound = true;
                            }

                        }
                        if (row > 0 && !charFound)
                        {
                            if (line[i] == board[row - 1, column])
                            {
                                row = row - 1;
                                charFound = true;
                            }
                        }
                        if (column < 3 && !charFound)
                        {
                            if (line[i] == board[row, column + 1])
                            {
                                column = column + 1;
                                charFound = true;
                            }
                        }
                        if (column > 0 && !charFound)
                        {
                            if (line[i] == board[row, column - 1])
                            {
                                column = column - 1;
                                charFound = true;
                            }
                        }

                        if (charFound == false)
                        {
                            output = "False";
                            break;
                        }
                    }
                }
                Console.WriteLine(output);
            }
    }

    static void Test(string line)
    {
        string output = "True";
        char[,] board = InitBoard();

        int row = 0;
        int column = 0;
        for (int i = 0; i < line.Length - 1; i++)
        {
            if (i == 0)
            {
                if (line[i] != board[0, 0])
                {
                    output = "False";
                    break;
                }
            }
            else
            {
                bool charFound = false;
                if (row < 2)
                {
                    if (line[i] == board[row + 1, column])
                    {
                        row = row + 1;
                        charFound = true;
                    }
                    else if (line[i] == board[row - 1, column])
                    {
                        row = row - 1;
                        charFound = true;
                    }
                }
                if (column < 3 && !charFound)
                {
                    if (line[i] == board[row, column + 1])
                    {
                        column = column + 1;
                        charFound = true;
                    }
                    else if (line[i] == board[row, column - 1])
                    {
                        column = column - 1;
                        charFound = true;
                    }
                }

                if (charFound == false)
                {
                    output = "False";
                    break;
                }
            }
        }

        Console.WriteLine(output);
    }

    static char[,] InitBoard()
    {
        char[,] board = new char[3, 4] {
            {'A', 'B', 'C', 'E'} ,  
            {'S', 'F', 'C', 'S'} ,   
            {'A', 'D', 'E', 'E'}   
        };

        return board;
    }

    
    /*
    static void Main()
    {
        using (StreamReader reader = new StreamReader(Console.OpenStandardInput()))
        while (!reader.EndOfStream)
        {
            string line = reader.ReadLine();

            line = line.ToLower();  

            Dictionary<char, int> dictionary = InitDictionary();

            foreach(char c in line)
            {
                if (dictionary.ContainsKey(c))
                {
                    int counter = dictionary[c];
                    counter++;
                    dictionary[c] = counter;
                }    
            }

            List<char> listCharNotUsed = new List<char>();
            foreach(var item in dictionary)
            {
                if (item.Value == 0)
                {
                    listCharNotUsed.Add(item.Key);
                }
            }

            StringBuilder stringBuilder = new StringBuilder();
            foreach(char c in listCharNotUsed)
            {
                stringBuilder.Append(c);
            }

            if (stringBuilder.Length == 0)
            {
                Console.WriteLine("NULL");
            }
            else
            {
                Console.WriteLine(stringBuilder.ToString());
            }


        }
    }

    static Dictionary<char,int> InitDictionary()
    {
        Dictionary<char, int> listChar = new Dictionary<char, int>();

        listChar.Add('a', 0);
        listChar.Add('b', 0);
        listChar.Add('c', 0);
        listChar.Add('d', 0);
        listChar.Add('e', 0);
        listChar.Add('f', 0);
        listChar.Add('g', 0);
        listChar.Add('h', 0);
        listChar.Add('i', 0);
        listChar.Add('j', 0);
        listChar.Add('k', 0);
        listChar.Add('l', 0);
        listChar.Add('m', 0);
        listChar.Add('n', 0);
        listChar.Add('o', 0);
        listChar.Add('p', 0);
        listChar.Add('q', 0);
        listChar.Add('r', 0);
        listChar.Add('s', 0);
        listChar.Add('t', 0);
        listChar.Add('u', 0);
        listChar.Add('v', 0);
        listChar.Add('w', 0);
        listChar.Add('x', 0);
        listChar.Add('y', 0);
        listChar.Add('z', 0);


        return listChar;

    }
    */
}