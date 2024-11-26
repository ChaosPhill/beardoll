using UnityEngine;
using System.Runtime.InteropServices;

public static class WebGLPluginJS
{
    [DllImport("__Internal")]
    public static extern void CallFunction();

    [DllImport("__Internal")]
    public static extern void DownloadFile(byte[] array, int byteLength, string fileName);
}
