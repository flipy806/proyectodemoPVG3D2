using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{
    public GameObject Canv;

    
    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale = 0;
        Canv.SetActive (true);
        
    }

    public void Update() {

    if(Time.timeScale == 1 && Input.GetKeyDown(KeyCode.Escape)){ 
        Time.timeScale = 0;
        Canv.SetActive (true);
        
     }

     else if (Time.timeScale == 0 && Input.GetKeyDown(KeyCode.Escape)){
        Time.timeScale = 1;
        Canv.SetActive (false);
        
     }
    }

    public void StartGame() {

        Time.timeScale = 1;
        Canv.SetActive (false);
        

    }

    public void QuitGame () {
        Application.Quit();
    }

    public void PauseGame () {

         Time.timeScale = 0;
        Canv.SetActive (true);
        
    }

    public void RetryGame () {

                SceneManager.LoadScene(SceneManager.GetActiveScene().name);

    }
}
