using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    [SerializeField] private Transform _target;
    [SerializeField] private float _smoothing;
    [SerializeField] private Vector2 _maxPosition;
    [SerializeField] private Vector2 _minPosition;
    [SerializeField] private float _inaccurate;
    
    void FixedUpdate()
    {
        if (Vector2.Distance(_target.position, transform.position) < _inaccurate) return;
        Vector2 targetPosition = _target.position;
        
        targetPosition.x = Mathf.Clamp(targetPosition.x, _minPosition.x, _maxPosition.x);
        targetPosition.y = Mathf.Clamp(targetPosition.y, _minPosition.y, _maxPosition.y);

        transform.position = Vector2.Lerp(transform.position, targetPosition, _smoothing);
    }
}