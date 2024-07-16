using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class PlayerMover : MonoBehaviour
{
    private const float _speedCoef = 50;
    [SerializeField] private float _speedX = 1f;
    private Rigidbody2D _rigidbody;
    
    private void Start()
    {
        _rigidbody = GetComponent<Rigidbody2D>();
    }

    private void FixedUpdate()
    {
        _rigidbody.velocity = new Vector2(_speedX * Time.fixedDeltaTime * _speedCoef, _rigidbody.velocity.y);
    }
}
