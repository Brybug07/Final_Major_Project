using UnityEngine;

[RequireComponent(typeof(Rigidbody2D)), RequireComponent(typeof(Animator)), DisallowMultipleComponent]
public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private float _moveSpeed;
    [SerializeField] private GameObject _sceneTrigger;


    private Rigidbody2D _rigidbody;
    private Vector2 _input;
    private Animator _animator;

    private void Start()
    {
        _animator = GetComponent<Animator>();
        _rigidbody = GetComponent<Rigidbody2D>();
    }

    private void SceneChangeTrigger()
    {
        // GameObject.Find
    }

    private void Update()
    {
        _input = GetInput();
        MoveCharacter(_input, _moveSpeed);
        UpdateAnimations();
    }

    private Vector2 GetInput()
    {
        Vector2 input;
        input.x = Input.GetAxisRaw("Horizontal");
        input.y = Input.GetAxisRaw("Vertical");
        return input;
    }

    private void UpdateAnimations()
    {
        _animator.SetFloat(Constants.moveX, _input.x);
        _animator.SetFloat(Constants.moveY, _input.y);
    }

    private void MoveCharacter(Vector2 input, float speed)
    {
        _rigidbody.velocity = input * speed;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.TryGetComponent(out Note _) && collision.TryGetComponent(out PopUpSystem popUpSystem))
        {
            popUpSystem.ActivateInteraction();
        }
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
    }
}