using UnityEngine;

public class Popup : MonoBehaviour
{
    [SerializeField] private GameObject _popupPanel;
    
    public void CloseWindow()
    {
        _popupPanel.SetActive(false);
    }
}
