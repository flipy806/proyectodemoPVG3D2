using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelMang : MonoBehaviour
{
    Animator m_Animator;
    float m_MySliderValue;
    public float Speed;
    Vector3 Angulos;
    Quaternion Rotacion;
    // Start is called before the first frame update
    void Start()
    {
        
        /*m_Animator = gameObject.GetComponent<Animator>();
        m_Animator.speed = 0.25f;*/
    }
    
     void Update() {
        Angulos += new Vector3(0.0f,90.0f,0.0f) * Time.deltaTime * Speed;
        Rotacion.eulerAngles = Angulos; 
        this.transform.rotation = Rotacion;
    }
   /*void OnGUI()
    {
        //Create a Label in Game view for the Slider
        //GUI.Label(new Rect(0, 25, 40, 60), "Speed");
        //Create a horizontal Slider to control the speed of the Animator. Drag the slider to 1 for normal speed.

        m_MySliderValue = GUI.HorizontalSlider(new Rect(45, 25, 200, 60), m_MySliderValue, 0.0F, 1.0F);
        //Make the speed of the Animator match the Slider value
        m_Animator.speed = m_MySliderValue;
    }*/
}
