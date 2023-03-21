using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameControl : MonoBehaviour
{
    [SerializeField] private Transform[] pictures;
   
    public static bool youWin;
    public GameObject EndMenu;
    public GameObject EndPieces;









    // Start is called before the first frame update
    void Start()
    {
      
        youWin = false;

    }

    void endmenuactivate(){
        EndMenu.SetActive(true);
        EndPieces.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (pictures[0].rotation.z ==0 &&
            pictures[1].rotation.z == 0 &&
            pictures[2].rotation.z == 0 &&
            pictures[3].rotation.z == 0 &&
            pictures[4].rotation.z == 0 &&
            pictures[5].rotation.z == 0)
            
        {
            Invoke("endmenuactivate", 0.5f);
            //EndPieces.SetActive(false);
            youWin = true;

            
            
            
        }
        
        
    }




    public void NextLevel()
    {

        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void BackToMenu()
    {

        SceneManager.LoadScene("Puzzle_Menu");
    }
   
}
