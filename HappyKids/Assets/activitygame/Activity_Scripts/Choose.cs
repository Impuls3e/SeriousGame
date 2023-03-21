using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Choose : MonoBehaviour
{
    
    public GameObject[] options;
    public List<QA> Qa;
    public int currentQuestion;
    
    public GameObject QuizPanel;
    public GameObject GoPanel;
    public Text ScoreText;
    public Button nextlvlbutton;
    

    int totalQuestions = 0;
    public int score;
    

    private void Start()
    {
       
        totalQuestions = Qa.Count;
        GoPanel.SetActive(false);
        GenerateQuestion();

    }

    public void Retry()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);

    }

   /* void GameOver()
    {
        QuizPanel.SetActive(false);
        GoPanel.SetActive(true);
        ScoreText.text= score + "/" + totalQuestions;
    } */
    public void Correct()
    {
       
       // score += 1;
        
        //Qa.RemoveAt(currentQuestion);
       
        StartCoroutine(WaitForNext());
        nextlvlbutton.interactable = true;
        

       




    }

   

    public void Wrong()
    {
      
        // Qa.RemoveAt(currentQuestion);
        
        StartCoroutine(WaitForNext());
        

    }
    IEnumerator WaitForNext()
    {
        yield return new WaitForSeconds(1);
      
       GenerateQuestion();
    }

    void SetAnswers()
    {

        for(int i = 0; i < options.Length; i++)
        {
            options[i].GetComponent<Answers>().isCorrect = false;

            options[i].transform.GetChild(0).GetComponent<Image>().sprite = Qa[currentQuestion].Answers[i];
            options[i].GetComponent<Image>().color = options[i].GetComponent<Answers>().startColor;
            


            if (Qa[currentQuestion].CorrectAnswer == i + 1)
            {
                options[i].GetComponent<Answers>().isCorrect = true;
                




            }
        }
    }
    void GenerateQuestion()
    {

        if (Qa.Count > 0)
        {
            currentQuestion = Random.Range(0, Qa.Count);

            
            
            SetAnswers();


        }
        else
        {

            Debug.Log("No Question Left");
            
        } 
   
       


    }
}


