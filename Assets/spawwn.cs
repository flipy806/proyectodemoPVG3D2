using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawwn : MonoBehaviour
{
    public GameObject []Obstaculos;
    // Start is called before the first frame update
    void Start()
    {
         StartCoroutine(TimerObstaculos());
    }

    IEnumerator TimerObstaculos(){
    while (true)
    {
        int RandomObs = Random.Range(0,4);
        Instantiate(Obstaculos[RandomObs], new Vector3(-0.1830787f,Random.Range(0.0962088f,0.04f),0.5814769f),new Quaternion(0.0f,-11.673f,0.0f,1));
       yield return new  WaitForSeconds (2.0f);
    }
}
}
