using System;

namespace Game_of_Life
{
    public class LeerArchivo
    {

    public string ReadAchive()
    {
        string url = "PII_Ejercicios_Expert_SRP-master\\Ejercicio 4\\board.txt";
        string content = File.ReadAllText(url);
        string[] contentLines = content.Split('\n');
        bool[,] board = new bool[contentLines.Length, contentLines[0].Length];

        for (int  y = 0; y<contentLines.Length; y++)
        {
            for (int x = 0; x<contentLines[y].Length; x++)
            {
                if(contentLines[y][x]=='1')
                {
                    board[x,y]=true;
                }
            } 
        }
    }
}
}
