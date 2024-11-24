using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PieceInformation : MonoBehaviour
{
    public GameObject[] pieceConflicts;

    public bool AmConflict(GameObject piece)
    {
        foreach (GameObject child in pieceConflicts)
        {
            if (child == piece)
            {
                return true;
            }
        }

        return false;
    }

    public void TurnOffConflicts()
    {
        foreach (GameObject child in pieceConflicts)
        {
            if (child.activeInHierarchy)
            {
                child.SetActive(false);
            }
        }
    }
}
