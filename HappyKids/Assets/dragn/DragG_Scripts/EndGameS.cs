using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndGameS : MonoBehaviour
{
    private int pointsToWin;
    public GameObject assets;
    public GameObject EndGame;
    private int currentPoints;




    // Start is called before the first frame update
    void Start()
    {
        pointsToWin = 3;
    }

    // Update is called once per frame
    void Update()
    {

        if (currentPoints == pointsToWin)
        {

            EndGame.SetActive(true);
           


        }
        
    }

    public void Points()
    {


        currentPoints++;
    }
    public void LoadMenu()
    {


        SceneManager.LoadScene("DragG_Menu");
    }
}
