using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Net.WebSockets;
using System;
using System.Threading;
using System.Text;

public class WebSocketClient : MonoBehaviour
{

    Uri u = new Uri("ws://dsp.neb-ej.co.uk:8765");
    ClientWebSocket clientWebSocket = null;
    ArraySegment<byte> buffer = new ArraySegment<byte>(new byte[1024]);

    void Start() {
        ConnectToServer(); 
    }

    public async void ConnectToServer()
    {
        clientWebSocket = new ClientWebSocket();
        try
        {
            await clientWebSocket.ConnectAsync(u, CancellationToken.None);
            if (clientWebSocket.State == WebSocketState.Open) Debug.Log("connected");
            initalConnectionSetupMessage();
            initalConnectionGetServerResp();
        }
        catch (Exception e) {
            Debug.Log("Connection Failed: " + e.Message); 
        }
    }

    async void initalConnectionSetupMessage()
    {
        ArraySegment<byte> b = new ArraySegment<byte>(Encoding.UTF8.GetBytes("Hello From Quest 2"));
        await clientWebSocket.SendAsync(b, WebSocketMessageType.Text, true, CancellationToken.None);
    }

    async void initalConnectionGetServerResp()
    {
        WebSocketReceiveResult r = await clientWebSocket.ReceiveAsync(buffer, CancellationToken.None);
        Debug.Log("Got: " + Encoding.UTF8.GetString(buffer.Array, 0, r.Count));
        initalConnectionGetServerResp();
    }
}
