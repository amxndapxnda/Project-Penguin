using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField, Range(0f, 20f)] private float speed = 20f; //SerializeField - makes variables show up on Unity
    [SerializeField] private Color ColorWheel;
    [SerializeField] private Rigidbody2D rigidBodySerialized;
    private Rigidbody2D rb;
    private CircleCollider2D circleCollider;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start() //after every object is created
    {
        rb = GetComponent<Rigidbody2D>();
        //circleCollider = getComponent<CircleCollider2D>();
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 moveDirection = new Vector3(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical")) * speed;
        rb.AddForce(moveDirection);
    }
    
    
}
