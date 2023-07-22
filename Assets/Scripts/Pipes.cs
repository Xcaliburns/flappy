
using UnityEngine;
using UnityEngine.UIElements;

public class Pipes : MonoBehaviour
{
    public float speed = 5.0f;
    private float leftEdge;
    private float edgeOffset=1.0f;


    private void Start()
    {
        leftEdge = Camera.main.ScreenToWorldPoint(Vector3.zero).x - edgeOffset;
    }

    private void Update()
    {
        transform.position += Vector3.left * speed *Time.deltaTime;

        if(transform.position.x < leftEdge)
        {
            Destroy(gameObject);
        }
    }
}
