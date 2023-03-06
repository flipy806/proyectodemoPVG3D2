using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bala : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject objetivo;
    int estado;
    public float step;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        step = 20 * Time.deltaTime; // calculate distance to move
        if (objetivo != null) {
            this.transform.position = Vector3.MoveTowards(this.transform.position, objetivo.transform.position, step);
        }
        else { return; }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision != null)
        {
            if (collision.collider.tag == "enemigo")
            {
                Destroy(this.gameObject);
            }
        }
        else { return; }
        
    }
}
