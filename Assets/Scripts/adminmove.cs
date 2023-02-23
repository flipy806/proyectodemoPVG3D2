using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class adminmove : MonoBehaviour
{
    public int puntos;
    
    public TMP_Text textoPuntos;
    public TMP_Text Vidas;
    // Start is called before the first frame update
    void Start()
    {
        puntos = 0;
        
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void Lifes (int count) {
        Vidas.text = "x " + count;
    }

    public void sumarpuntos(int score)
    {
        puntos = puntos + score;
        textoPuntos.text = puntos.ToString();
    }
}
