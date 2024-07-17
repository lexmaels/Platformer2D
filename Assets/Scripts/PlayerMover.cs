using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class PlayerMover : MonoBehaviour
{
    private const float _speedCoef = 50;
    private const string _horizaontalAxis = "Horizontal";

    [SerializeField] private float _speedX = 1f;
    

    private Rigidbody2D _rigidbody;
    private float _direction;
    private string _directionMove;
    
    private void Start()
    {
        _rigidbody = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        _direction = Input.GetAxis(_horizaontalAxis);
        if(_direction > 0)
        {
            _directionMove = "вправо";
            Debug.Log("направление движения: " + _directionMove);
        }
        else if (_direction < 0)
        {
            _directionMove = "влево";
            Debug.Log("направление движения: " + _directionMove);
        }
    }

    private void FixedUpdate()
    {
        _rigidbody.velocity = new Vector2(_speedX * _direction  * _speedCoef * Time.fixedDeltaTime, _rigidbody.velocity.y);
    }
}
