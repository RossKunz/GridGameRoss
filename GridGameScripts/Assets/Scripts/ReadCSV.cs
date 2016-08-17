using UnityEngine;
using System.Collections;
using System.IO;
using System.Collections.Generic;

public class ReadCSV : MonoBehaviour
{

    public string fileName;

    static public List<List<string>> MyCSVReader(string pathToCsv)
    {
        StreamReader sr = new StreamReader(File.OpenRead(Application.dataPath + "/Resources/" + pathToCsv + ".txt"));
        List<List<string>> mainList = new List<List<string>>();
        while (!sr.EndOfStream)
        {
            var line = sr.ReadLine();
            var values = line.Split(',');
            List<string> sublist = new List<string>();
            foreach (string element in values)
            {
                sublist.Add(element);
            }
            mainList.Add(sublist);

        }
        return (mainList);
    }

}

