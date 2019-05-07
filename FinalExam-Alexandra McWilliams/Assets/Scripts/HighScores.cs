using UnityEngine.UI;
using UnityEngine;
using System;
using System.IO;
using UnityEditor;

public class HighScores : MonoBehaviour
{
    public Text HighScoresList;
    public int numScores = 5;

    void Start()
    {
        DisplayTopScores();
    }

    public void DisplayTopScores()
    {
        string path = "Assets/scores.txt";
        string line;
        string[] fields;
        string[] players = new string[numScores];
        int[] scores = new int[numScores];
        int scoresWritten = 0;

        bool NewScore = false;
        string newName = InputField.enterPlayerName;
        int newScore = ScoreKeeper.newScore;
        string[] writeNames = new string[5];
        string[] writeScores = new string[5];

        StreamReader reader = new StreamReader(path);

        while(!reader.EndOfStream)
        {
            line = reader.ReadLine();
            fields = line.Split(',');

            if(!NewScore && scoresWritten < numScores)
            {
                if (newScore > Convert.ToUInt32(fields[1]))
                {
                    HighScoresList.text += newName + " : " + newScore + "\n";
                    writeNames[scoresWritten] = newName;
                    writeScores[scoresWritten] = newScore.ToString();
                    NewScore = true;
                    scoresWritten += 1;
                }
            }
            if(scoresWritten < numScores)
            {
                HighScoresList.text += fields[0] + " : " + fields[1] + "\n";
                writeNames[scoresWritten] = fields[0];
                writeScores[scoresWritten] = fields[1];
                scoresWritten += 1;
            }
        }
        reader.Close();

        StreamWriter writer = new StreamWriter(path);
        for(int i=0; i<scoresWritten; i++)
        {
            writer.WriteLine(writeNames[i] + ',' + writeScores[i]);
        }
        writer.Close();

        AssetDatabase.ImportAsset(path);
        TextAsset asset = (TextAsset)Resources.Load("scores");
    }
}
