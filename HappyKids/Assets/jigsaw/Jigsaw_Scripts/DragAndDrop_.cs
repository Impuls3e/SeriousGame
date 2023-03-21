using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.SceneManagement;
public class DragAndDrop_ : MonoBehaviour
{

    public GameObject GameMenu;
    public GameObject EndMenu;
    public GameObject SelectedPiece;
    public AudioSource[] sesler;
   
    public int PlacedPieces = 0;
    int layer = 1;
    
    
    void Start()
    {
        
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            RaycastHit2D hit = Physics2D.Raycast(Camera.main.ScreenToWorldPoint(Input.mousePosition), Vector2.zero);
            if (hit.transform.CompareTag("Puzzle"))
            {
                if (!hit.transform.GetComponent<piceseScript>().InRightPosition)
                {
                    SelectedPiece = hit.transform.gameObject;
                    SelectedPiece.GetComponent<piceseScript>().Selected = true;
                   
                    SelectedPiece.GetComponent<SortingGroup>().sortingOrder = layer;
                    layer++;
                  

                   
                }
            }
        }

        if (Input.GetMouseButtonUp(0))
        {
            if (SelectedPiece != null)
            {
                SelectedPiece.GetComponent<piceseScript>().Selected = false;
                SelectedPiece = null;
            }
        }
        if (SelectedPiece != null)
        {
            Vector3 MousePoint = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            SelectedPiece.transform.position = new Vector3(MousePoint.x,MousePoint.y,0);
        }

        if (PlacedPieces == 4)
        {

            //GameMenu.SetActive(false);
            //EndMenu.SetActive(true);
            Invoke("EndMenuActive", 1f);






        }
       
        



    }

     void EndMenuActive (){
            EndMenu.SetActive(true);
            GameMenu.SetActive(false);
        }

    public void Nextlevel()
    {
        
        StartCoroutine(LevelRootine());
        sesler[0].Play();
    }

    IEnumerator LevelRootine()
    {
        

        yield return new WaitForSeconds(1.5f);
      

        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);

    }
    public void BacktoMenu()
    {
        SceneManager.LoadScene("Menu");
    }

    
}