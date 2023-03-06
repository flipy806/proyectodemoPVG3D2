using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Meta : MonoBehaviour
{
    public float Vida = 5;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    void Muere()
    {
        Vida = Vida - 1;
        if(Vida == 0)
        {
            Destroy(this.gameObject);
        }
    }
    
    void OnCollisionEnter(Collision collision)
    {
        if(collision.collider.tag == "enemigo")
        {
            Muere();
        }
    }
}
