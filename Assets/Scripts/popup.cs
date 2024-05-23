using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class popup : MonoBehaviour
{
    public GameObject popupPanal;


    public void closewindow()
    {
        popupPanal.SetActive(false);

    }
}
