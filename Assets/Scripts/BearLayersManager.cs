using UnityEngine;

public class BearLayersManager : MonoBehaviour
{
    public SpriteRenderer[] layers;
    public PieceInformation[] gos;

    public void ResetLayers()
    {
        gos = gameObject.GetComponentsInChildren<PieceInformation>(true);

        foreach (PieceInformation go in gos)
        {
            go.gameObject.SetActive(false);
        }
    }

    public void ResetSorting()
    {
        layers = gameObject.GetComponentsInChildren<SpriteRenderer>(true);

        for (int i = 0; i < layers.Length; i++)
        {
            layers[i].sortingOrder = i;
        }
    }
}
