using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Levels : MonoBehaviour
{

    public int Level;
   


    public void Scene()
    {
      
        SceneManager.LoadScene(Level);



    }
    
}
