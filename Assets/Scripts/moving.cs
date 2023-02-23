using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Animations;

public class moving : MonoBehaviour
{
    private Vector3 pos;
    public float velocidad;
    public float extension;
   // public Collider Muerte;
    public Animator Anim;
    float pos_y;
    int Punt = 0;

    // Start is called before the first frame update
    void Start()
    {
        pos = this.transform.position;
        Anim = GetComponent<Animator>();
    }
/*
    // Update is called once per frame
    void Update()
    {
        /*float pos_x = extension * Mathf.Sin(2 * Mathf.PI * velocidad * Time.time);
        pos.x = pos_x;
        this.transform.position = pos;
        pos.y = pos_y;
        if( pos_y <= -1){
            Destroy(gameObject);
        }
    }
*/
    private void OnTriggerEnter(Collider Other)
    {
        if(Other.gameObject.CompareTag("Player")){
        Anim.SetInteger("estado", 1);
        Punt = Punt + 1;
        Debug.Log("Colision con " + Other.GetComponent<Collider>().name);
        GameObject.Find("manager").GetComponent<adminmove>().sumarpuntos(1);
        Destroy(gameObject, 1.5f);

        //this.GetComponent<Animator>().SetFloat("velocidad", 4);
        }
    }

/*public IEnumerator Muerto(){
    yield return new WaitForSeconds(1);
     Destroy(gameObject);
}*/
    /*public void setEstado(int est)
    {
        this.GetComponent<Animator>().SetInteger("estado", est);

    }*/
}