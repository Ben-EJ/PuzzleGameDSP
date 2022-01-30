using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Net;
using UnityEngine;

public class POST : MonoBehaviour
{
    public void httpRequestPost(string userName, string score, string url)
    {
        var httpWebRequest = (HttpWebRequest)WebRequest.Create("http://192.168.1.158:8765/restpost/");
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
