using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MatchScene : MonoBehaviour
{
    public AudioSource[] ses;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void FoodScene()
    {
    
        SceneManager.LoadScene("MatchFood");

    }

    public void EmotionScene()
    {
        ses[0].Play();
        SceneManager.LoadScene("MatchEmotions");



    }


    public void NumberScene()
    {
        ses[0].Play();
        SceneManager.LoadScene("MatchNumbers");
    }

    public void AnimalsScene()
    {

        ses[0].Play();
        SceneManager.LoadScene("MatchAnimals");
    }
}

