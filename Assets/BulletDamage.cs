using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletDamage : MonoBehaviour
{
    // Start is called before the first frame update
    void OnCollisionEnter2D(Collision2D coll) {
        if (coll.gameObject.tag == "ship") {
            Destroy(coll.gameObject);
        }
        Destroy(gameObject);
    }
}
