using JetBrains.Annotations;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private float movementSpeed = 5f;
    private InputSystem _playerActions;
    private Rigidbody2D _rb;
    [SerializeField] private Vector2 _moveDirection;
    public Vector2 MoveDirection => _moveDirection;

    void Awake()
    {
        _playerActions = new InputSystem(); 
    }
    void Start()
    {
        _rb = GetComponent<Rigidbody2D>();
        
    }

    private void OnEnable(){
        _playerActions.PlayerInGame.Enable();
    }

    private void OnDisable(){
        _playerActions.PlayerInGame.Disable();
    }

    private void FixedUpdate(){
        _moveDirection = _playerActions.PlayerInGame.Movement.ReadValue<Vector2>();
        _rb.linearVelocity = _moveDirection * movementSpeed;
        Flip();
    }

    private void Flip(){
        if (_moveDirection.x > 0){
            gameObject.transform.localScale = new Vector3(1,1,1);

        } else if (_moveDirection.x < 0){
            gameObject.transform.localScale = new Vector3(-1,1,1);
        }
    }
   
}
