using UnityEngine;
using System.Collections;
using System.IO;
using LitJson;

public class ReadJSON : MonoBehaviour {

    private string jsonString;
    private JsonData itemData;

    //Matrix<double> matrix = DelimitedReader.Read<double>(Application.dataPath + "/Resouces/carsexample.csv");

    // Use this for initialization
    void Start () {
        //Debug.Log(matrix);
	}
	

    JsonData GetInternalJsonData(string iJsonName)
    {
        jsonString = File.ReadAllText(Application.dataPath + "/Resources/" + iJsonName + ".json");
        itemData = JsonMapper.ToObject(jsonString);
        return itemData;
    }

    
}
