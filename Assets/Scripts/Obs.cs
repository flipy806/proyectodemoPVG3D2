using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obs : MonoBehaviour
{
    shooter Bullet;
    // Start is called before the first frame update
    void Start()
    {
        Bullet = GetComponent<shooter>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            Bullet.Die();
        }
    }
}
