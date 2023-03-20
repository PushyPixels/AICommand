/* Create a c# editor script that will generate a random sentence and save it to a txt file. It provides its functionality as a menu item placed \"Edit\" > \"RandomPrompt\".\n */

using UnityEngine;
using UnityEditor;
using System.IO;

public class GenerateRandomPrompt : Editor
{
    [MenuItem("Edit/RandomPrompt")]
    public static void DoTask()
    {
        string[] adjectives = { "happy", "energetic", "curious", "adventurous", "confused", "surprised", "calm", "sleepy", "bored" };
        string[] verbs = { "ran", "ate", "laughed", "slept", "danced", "discovered", "learned", "created", "played" };
        string[] nouns = { "dog", "cake", "friend", "book", "beach", "mountain", "painting", "song", "car" };

        System.Random rnd = new System.Random();
        string sentence = adjectives[rnd.Next(adjectives.Length)] + " " + verbs[rnd.Next(verbs.Length)] + " " + nouns[rnd.Next(nouns.Length)];
        Debug.Log(sentence);

        string path = Application.dataPath + "/GeneratedSentence.txt";
        StreamWriter writer = new StreamWriter(path, true);
        writer.WriteLine(sentence);
        writer.Close();
    }
}