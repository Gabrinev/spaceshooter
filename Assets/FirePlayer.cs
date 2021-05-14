using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirePlayer : MonoBehaviour
{
    public GameObject bullet;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space)) {
            GameObject g = (GameObject) Instantiate(bullet,
            transform.position, Quaternion.identity);

            Physics2D.IgnoreCollision(g.GetComponent<Collider2D>(),
            transform.parent.GetComponent<Collider2D>());
        }
        
    }
}
