using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Answers : MonoBehaviour
{

    public bool isCorrect = false;
    public Choose choose;
    public Color startColor;
    public AudioSource[] sesler;
    public ParticleSystem wrongparticle;
    public ParticleSystem trueparticle;
   GameObject[] butons;

    private void Start()
    {
        //startColor = GetComponent<Image>().color;
    }
    public void Answer()
    {
        if (isCorrect)
        {
            sesler[0].Play();
            GetComponent<Image>().color = Color.green;
            Debug.Log("Correct");
            choose.Correct();
            butons = GameObject.FindGameObjectsWithTag("Buton");
            foreach(var item in butons) {
                item.GetComponent<Button>().interactable = false; 

                trueparticle.Play();
            } 
           
          // GetComponent<Button>().interactable = false; 

           
           

        }

        else
        {
            sesler[1].Play();
            GetComponent<Image>().color = Color.blue;
            Debug.Log("Wrong");
            choose.Wrong();
            wrongparticle.Play();
            GetComponent<Button>().interactable = false; 
          
           

        }

    
}
    
    
}
