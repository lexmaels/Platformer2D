using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class PlayerMover : MonoBehaviour
{
    private Rigidbody2D _rigidbody;
    [SerializeField] private float _speedX = 1f;
    [SerializeField] private float _speedY = 0f;
    private void Start()
    {
        _rigidbody = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        _rigidbody.velocity = new Vector2(_speedX, _speedY);
    }
}
