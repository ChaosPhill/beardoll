using UnityEngine;
using UnityEngine.Experimental.Rendering;
using UnityEngine.Networking;

public class SaveButton : MonoBehaviour
{
    public RenderTexture texture;
    private byte[] textPNG;

    public void SavePNG()
    {
        
        Texture2D tempTexture = new Texture2D(1080, 1080, GraphicsFormatUtility.GetTextureFormat(GraphicsFormatUtility.GetGraphicsFormat(texture.format, true)), false);
        RenderTexture.active = texture;

        tempTexture.ReadPixels(new Rect(0, 0, texture.width, texture.height), 0, 0);
        tempTexture.Apply();

        textPNG = tempTexture.EncodeToPNG();
        Destroy(tempTexture);

        WebGLPluginJS.DownloadFile(textPNG, textPNG.Length, "beardoll.png");

    }
}
