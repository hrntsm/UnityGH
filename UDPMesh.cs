using UnityEngine;
using System.Collections;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;

public class UDPMesh : MonoBehaviour
{
    int LOCAL_PORT = 3333;
    static UdpClient udp;
    Thread thread;
    public static string messege = "";
    public static string textRep = "";

    void Start () {
        udp = new UdpClient(LOCAL_PORT);
        thread = new Thread(new ThreadStart(ThreadMethod));
        thread.Start(); 
    }

    void Update () {
    }

    void OnApplicationQuit() {
        thread.Abort();
    }

    private static void ThreadMethod() {
        while(true) {
            IPEndPoint remoteEP = null;
            byte[] data = udp.Receive(ref remoteEP);
            string text = Encoding.ASCII.GetString(data);
            messege = text;
            textRep = text.Remove(0, 1);
            textRep = textRep.Replace("}", "");
            textRep = textRep.Replace("{", ",");
            textRep = textRep.Replace(" ", "");
        }
    } 
}