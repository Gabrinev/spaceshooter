using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawn : MonoBehaviour
{   
    public GameObject ship;
    public float interval = 3;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnNext", interval, interval);
    }

    // Update is called once per frame
    void SpawnNext()
    {
        Instantiate(ship, transform.position, Quaternion.identity);
    }
}
