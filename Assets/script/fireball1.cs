using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fireball1 : MonoBehaviour
{
    public Vector2 startingVelo;
    // Start is called before the first frame update
    void Start()
    {
        GetComponent<Rigidbody2D>().velocity = startingVelo;
        Destroy(gameObject, 10);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        var enemy = collision.collider.GetComponent<enemy>();
        enemy?.Die();
        Destroy(gameObject);
    }
}
