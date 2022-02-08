using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Net;
using UnityEngine;

public class POST : MonoBehaviour
{
    public static void httpRequestPost8Queens(string userName, string score)
    {
        Debug.Log("Sending 8 Queens data");
        var httpWebRequest = (HttpWebRequest)WebRequest.Create("http://192.168.1.158:8765/rest8QueensPost/");
        httpWebRequest.ContentType = "application/json";
        httpWebRequest.Method = "POST";

        using (var streamWriter = new StreamWriter(httpWebRequest.GetRequestStream()))
        {
            // Example: "{\"userName\" : \"RESTAPITEST\", \"score\":\"5000\"}"
            string jsonData = " {\"userName\" : " + "\"" + userName + "\"" + "," + "\"score\"" + ":\"" + score + "\"" + "} ";
            streamWriter.Write(jsonData);
        }
        Debug.Log("Sending POST");
        var httpResponse = (HttpWebResponse)httpWebRequest.GetResponse();
        using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
        {
            var result = streamReader.ReadToEnd();
            Debug.Log(result);
        }
    }
    public static void httpRequestPost2048(string userName, string score)
    {
        Debug.Log("Sending 2048 Data");
        var httpWebRequest = (HttpWebRequest)WebRequest.Create("http://127.0.0.1:8000/rest2048Post/");
        httpWebRequest.ContentType = "application/json";
        httpWebRequest.Method = "POST";

        using (var streamWriter = new StreamWriter(httpWebRequest.GetRequestStream()))
        {
            // Example: "{\"userName\" : \"RESTAPITEST\", \"score\":\"5000\"}"
            string jsonData = " {\"userName\" : " + "\"" + userName + "\"" + "," + "\"score\"" + ":\"" + score + "\"" + "} ";
            streamWriter.Write(jsonData);
        }
        Debug.Log("Sending POST");
        var httpResponse = (HttpWebResponse)httpWebRequest.GetResponse();
        using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
        {
            var result = streamReader.ReadToEnd();
            Debug.Log(result);
        }
    }


}
