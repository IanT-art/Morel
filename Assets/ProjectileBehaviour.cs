using UnityEngine;

public class ProjectileBehaviour : MonoBehaviour
{
    //Changes Speed of Projectile
    public float Speed;
    public GameObject Impact;
    private Rigidbody2D rigidbody;

    void Start()
    {
        rigidbody = GetComponent<Rigidbody2D>();
        rigidbody.velocity = -transform.right * Speed;
    }

    private void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Instantiate(Impact, transform.position, Quaternion.identity);
        Destroy(gameObject);
    }
}
