using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelLoad : MonoBehaviour
{
  public void LoadEmotion()
    {

        SceneManager.LoadScene("ActivityCardEmotions");
    }
    public void LoadGeneral()
    {
        SceneManager.LoadScene("ActivityCardGenel");

    }

    public void LoadActivitiy()
    {
        SceneManager.LoadScene("ActivityCardActivities");
    }
    public void LoadMenu()
    {
        SceneManager.LoadScene("ActivityMenu");
    }
}
