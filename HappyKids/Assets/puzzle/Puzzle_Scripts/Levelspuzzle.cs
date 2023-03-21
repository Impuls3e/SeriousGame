using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Levelspuzzle : MonoBehaviour
{
    public int Level;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void BackToMenu()
    {

        SceneManager.LoadScene("Menu");
    }
    public void Scene()
    {

        SceneManager.LoadScene(Level);



    }
}
