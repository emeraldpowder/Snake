using UnityEngine;

public class SnakeSimpleMovement : MonoBehaviour
{
    public float Speed = 2;

    private Rigidbody2D componentRigidbody;
    private SnakeTail componentSnakeTail;

    private void Start()
    {
        componentRigidbody = GetComponent<Rigidbody2D>();
        componentSnakeTail = GetComponent<SnakeTail>();

        componentSnakeTail.AddCircle();
        componentSnakeTail.AddCircle();
        componentSnakeTail.AddCircle();
        componentSnakeTail.AddCircle();
    }

    private void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.UpArrow))
        {
            componentRigidbody.velocity = Vector2.up * Speed;
        }

        if (Input.GetKey(KeyCode.DownArrow))
        {
            componentRigidbody.velocity = Vector2.down * Speed;
        }

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            componentRigidbody.velocity = Vector2.left * Speed;
        }

        if (Input.GetKey(KeyCode.RightArrow))
        {
            componentRigidbody.velocity = Vector2.right * Speed;
        }
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            componentSnakeTail.AddCircle();
        }
        if (Input.GetKeyDown(KeyCode.D))
        {
            componentSnakeTail.RemoveCircle();
        }
    }
}
