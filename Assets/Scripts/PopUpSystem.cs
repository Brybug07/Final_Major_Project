using UnityEngine;

public class PopUpSystem : MonoBehaviour
{
    [SerializeField] private GameObject _popup;

    [SerializeField] private bool _isBeingInteractedWith;
    
    public void ActivateInteraction()
    {
        _popup.SetActive(true);
    }
}

