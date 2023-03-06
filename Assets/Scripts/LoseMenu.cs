using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoseMenu : MonoBehaviour
{
    public GameObject Death;
    public shooter Bullet;

    void Start(){

        Death.SetActive (false);
        
    }

    public void Update(){
    Lose();
    }
    public void Lose()
    {

    if(Bullet.Vidas == 0 ) {

           Death.SetActive (true);
           Time.timeScale = 0;
    }
           
        
    }
}
