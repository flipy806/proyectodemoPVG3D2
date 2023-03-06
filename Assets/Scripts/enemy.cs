using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class enemy : MonoBehaviour
{
    public GameObject endPoint;
    public float Vida = 3;
    // Start is called before the first frame update
    void Start()
    {
        this.GetComponent<NavMeshAgent>().SetDestination(endPoint.transform.position);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void Daño()
    {
        Vida = Vida - 1;
        if (Vida == 0)
        {
            Destroy(this.gameObject);
        }
    }
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.collider.name == "meta")
        {
            Destroy(this.gameObject);
        }

        if (collision.collider.tag == "Bullet")
        {
            Daño();
        }
    }

}
