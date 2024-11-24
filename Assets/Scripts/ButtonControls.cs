using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonControls : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void ShowHidePiece(GameObject piece)
    {
        if (piece != null)
        {
            if (piece.activeSelf)
            {
                piece.SetActive(false);
            }
            else
            {
                piece.SetActive(true);
                PieceInformation info = piece.GetComponent<PieceInformation>();
                if (info != null)
                {
                    info.TurnOffConflicts();
                }
            }
        }
    }

    public void TestDouble(GameObject piece, Button button)
    {

    }
}
