using UnityEngine;

public class ProjectileBehaviour : MonoBehaviour
{
    //Changes Speed of Projectile
    public float Speed;
    public GameObject Impact;
    private Rigidbody2D rigdbody;

    void Start()
    {
        rigidbody = GetComponent<Rigidbody2D>();
        GetComponent<Rigidbody>().velocity = transform.right * Speed;
    }

    private void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Destroy(gameObject);
    }
}
