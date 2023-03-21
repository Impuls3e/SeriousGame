using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MatchGameRun : MonoBehaviour
{
    public RuntimeAnimatorController firstAnim;
    public RuntimeAnimatorController secondAnim;
    public RuntimeAnimatorController wrongAnim;
    public RuntimeAnimatorController correctAnim;
    public GameObject gameobject;
    public GameObject questioning;
    public GameObject answering;
    public GameObject buttonnext;

    public Image[] answerImg;
    public Sprite[] answerSprite;
    public Image questionImg;
    public Button nextBtn;
    public static int questionIndex;
    string actionSpriteName;
    public Text answerText;
    public AudioSource[] sesler;
    public GameObject EndMenu;

    // Start is called before the first frame update
    void Start()
    {
        questionIndex = 1;
        nextBtn.interactable = false;
        gameobject.GetComponent<Animator>().runtimeAnimatorController = firstAnim;
        SetSprite();


            }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void EndScreen(){
        EndMenu.SetActive(true);
    }
    public void NextButton()
    {
        sesler[2].Play();
        answerText.text = "";
        if (questionIndex<9)
        {
            
            ++questionIndex;

        }
        else
        {
            Invoke("EndScreen", 0.5f);
            // EndMenu.SetActive(true);
            questioning.SetActive(false);
            answering.SetActive(false);
            buttonnext.SetActive(false);
        }
        
      
        gameobject.GetComponent<Animator>().runtimeAnimatorController = secondAnim;
        StartCoroutine(StartAnimation());


    }
    public void BackButton()
    {
        sesler[2].Play();
        SceneManager.LoadScene("MatchMenuScene");

    }
    public IEnumerator StartAnimation()
    {

        yield return new WaitForSeconds(0.5f);
        gameobject.GetComponent<Animator>().runtimeAnimatorController = firstAnim;
        SetSprite();
        answerText.text = "";
        nextBtn.interactable = false;
    }
    public void SetSprite()
    {

        questionImg.GetComponent<Image>().sprite = answerSprite[questionIndex-1];
        for (int i = 0; i < 9; i++)
        {
            answerImg[i].GetComponent<Image>().sprite = answerSprite[i];
            answerImg[i].GetComponent<Animator>().runtimeAnimatorController = null;
        }
    }

    public void CorrectAnswer()
    {
        string QuestionName = questionImg.sprite.name;
        if (QuestionName.Equals(actionSpriteName))
        {
            sesler[0].Play();
            answerText.text = "Aferin";
            answerImg[questionIndex-1].GetComponent<Animator>().runtimeAnimatorController = correctAnim;
            nextBtn.interactable = true;
        }
        else
        {
            answerText.text = "Tekrar Dene";
            sesler[1].Play();

        }


    }

    public void AnswerSpriteAction(Image image)
    {
        actionSpriteName = image.sprite.name;
        image.GetComponent<Animator>().runtimeAnimatorController = wrongAnim;
        CorrectAnswer();
   

    }
}
