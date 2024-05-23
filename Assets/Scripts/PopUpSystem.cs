using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;


public class PopUpSystem : MonoBehaviour
{
    public GameObject popup;


    public TMP_Text popupheader;
    public TMP_Text popuptext;

    public string popupheader_text;
    public string popuptext_text;


    public bool isbeinginteractedwith;
    public void activeinteract()
    {

        popupheader.text = popupheader_text;

        popuptext.text = popuptext_text;


        popup.SetActive(true);
    }
}

