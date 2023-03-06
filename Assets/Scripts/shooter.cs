using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Animations;

public class shooter : MonoBehaviour
{
    public CharacterController cont;
    public float potencia;
    //public float poder;
    private Vector3 pos;
    public int Vidas;
    public bool ded = false;
    LoseMenu Los;
    //adminmove Points;

    // Start is called before the first frame update
    void Start()
    {
        pos = this.transform.position;
        cont = GetComponent<CharacterController>();
        Vidas = 3;
        ded = false;
        GameObject.Find("manager").GetComponent<adminmove>().Lifes(Vidas);
    }

    // Update is called once per frame
    void Update()
    {
        /*
        if (Input.GetKeyDown(KeyCode.Space))
        {
            poder = 1;
        }
        if (Input.GetKey(KeyCode.Space)) {
            poder = poder + Time.deltaTime;
        }
        if (Input.GetKeyUp(KeyCode.Space))
        {
            this.GetComponent<Rigidbody>().AddForce(Vector3.forward * poder * potencia);
            Invoke("reinicia", 8);
        } */
        Vector3 direction = new Vector3(0, Input.GetAxis("Vertical"), Input.GetAxis("Horizontal"));
        Vector3 Velocity = direction * potencia;
        Velocity = transform.transform.TransformDirection(Velocity);
        cont.Move(Velocity * Time.deltaTime);

        /*if (Input.GetKeyUp(KeyCode.S))
        {
            reinicia();
        }*/
    }

    public void Die()
    {
        ded = true;
        this.gameObject.SetActive(false);
       // Los.Lose();
        
    }
    private void OnTriggerEnter(Collider collision)
    {
        //GameObject.Find("manager").GetComponent<adminmove>().sumarpuntos(1);
        if (collision.gameObject.CompareTag("Obs"))
        {
            Vidas = Vidas - 1;
            GameObject.Find("manager").GetComponent<adminmove>().Lifes(Vidas);
            if(Vidas <= 0){
                Die();
            }
            
        }
        // Invoke("reinicia", 5);
        this.GetComponent<SphereCollider>().enabled = false;
        //reinicia();
    }

    /*void reinicia()
    {
        this.GetComponent<Rigidbody>().velocity = new Vector3(0,0,0);
        this.transform.position = pos;
        this.GetComponent<SphereCollider>().enabled = true;
    }*/
}
