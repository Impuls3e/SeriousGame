using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class sahne : MonoBehaviour
{
   public void aLoadNextScene(){
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void aQuit(){
        Application.Quit();
    }

     public  void aLoadAnaMenu(){
        SceneManager.LoadScene("anaekran");
    }

   public void LoadHafizaLevelSelect(){
        SceneManager.LoadScene("memory");
    }

    public void LoadSurukleBirakSelect(){
        SceneManager.LoadScene("suruklebirak");
    }

     public  void LoadMatchSelect(){
        SceneManager.LoadScene("anaekran");
    }

     public  void LoadJigsawSelect(){
        SceneManager.LoadScene("anaekran");
    }

     public  void LoadActivitySelect(){
        SceneManager.LoadScene("anaekran");
    }

     public  void LoadPuzzleSelect(){
        SceneManager.LoadScene("anaekran");
    }

    


   public void MemorySea(){
        SceneManager.LoadScene("memory_sea_1");
    }

   public  void MemoryAnimal(){
        SceneManager.LoadScene("memory_animal_1");
    }

   public void MemoryFruit(){
        SceneManager.LoadScene("memory_fruit_1");
    }

    public void SurukleDuygular(){
        SceneManager.LoadScene("suruke_duygular_1");
    }

     public void SurukleSayalim(){
        SceneManager.LoadScene("suruke_sayalim_1");
    }

    public void Match(){
        SceneManager.LoadScene("Match1");
    }

    public void Jigsaw(){
        SceneManager.LoadScene("jigsaw_1");
    }

    public void Activity(){
        SceneManager.LoadScene("activity1");
    }

    public void Resim(){
        SceneManager.LoadScene("resim1");
    }






}
