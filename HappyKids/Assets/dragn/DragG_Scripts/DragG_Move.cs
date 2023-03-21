using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DragG_Move : MonoBehaviour
{
    public GameObject correctForm;
    private bool moving;
    private float startPosX;
    private float startPosY;
    private bool finish;
    public AudioSource[] sesler;
    public ParticleSystem Fx;


    private Vector3 resetPosition;
    void Start()
    {
        resetPosition = this.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if (finish == false)
        {
            if (moving)
            {
                Vector3 mousePos;
                mousePos = Input.mousePosition;
                mousePos = Camera.main.ScreenToWorldPoint(mousePos);

                this.gameObject.transform.position = new Vector3(mousePos.x - startPosX, mousePos.y - startPosY, this.gameObject.transform.position.z);
            }

        }
        
        
        
        
    }

    private void OnMouseDown()
    {
        if (Input.GetMouseButtonDown(0))
        {

            Vector3  mousePos;
            mousePos = Input.mousePosition;
            mousePos = Camera.main.ScreenToWorldPoint(mousePos);

            startPosX = mousePos.x - this.transform.position.x;
            startPosY = mousePos.y - this.transform.position.y;
            moving = true;
            
        }
        
    }
    private void OnMouseUp()
    {
        moving = false;

        if (Mathf.Abs(this.transform.position.x - correctForm.transform.position.x) <= 0.7f && Mathf.Abs(this.transform.position.y - correctForm.transform.position.y) <= 0.7f)
        { 
            this.transform.position = new Vector3(correctForm.transform.position.x, correctForm.transform.position.y, correctForm.transform.position.z);
            finish = true;
            StartCoroutine(WaitForD());
            Fx.Play();
            sesler[0].Play();
           

        }
        else
        {

            this.transform.position = new Vector3(resetPosition.x, resetPosition.y, resetPosition.z);
            sesler[1].Play();
        }
    
}
    IEnumerator WaitForD()
    {
       
        yield return new WaitForSeconds(1.2f);
        Destroy(gameObject);
        GameObject.Find("GameController").GetComponent<EndGameS>().Points();

    }

}
