using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
using UnityEngine.SceneManagement;

public class OyunKontrol : MonoBehaviour
{
    int ilkSecimDegeri;
    GameObject secilenButon;
    GameObject butonunKendisi;
    public Sprite defaultSprite;
    public AudioSource[] sesler;
    public GameObject[] Butonlar;
    public GameObject[] OyunSonuPaneller;
    
    

    public int hedefBasari;
    int anlikBasari;

    public GameObject Grid;
    public GameObject Havuz;
    bool olusturmadurumu;
    int olusturmaSayisi;
    int ToplamResimSayisi;

    void Start()
    {
        ilkSecimDegeri = 0;
        olusturmadurumu = true;
        olusturmaSayisi = 0;
        ToplamResimSayisi = Havuz.transform.childCount;
        StartCoroutine(Olustur());
        
        
       // Debug.Log(Havuz.transform.GetChild(rastgelesayi).name);
    }

    void Win(){
        OyunSonuPaneller[0].SetActive(true);

    }

    
    
    

    

    IEnumerator Olustur(){
        yield return new WaitForSeconds(.1f);

        while(olusturmadurumu)
        {
            int rastgelesayi = Random.Range(0, Havuz.transform.childCount -1);

            if(Havuz.transform.GetChild(rastgelesayi).gameObject != null) {

                Havuz.transform.GetChild(rastgelesayi).transform.SetParent(Grid.transform);
                olusturmaSayisi++;

                if(olusturmaSayisi == ToplamResimSayisi){
                    olusturmadurumu = false;
                    Destroy(Havuz.gameObject);
                }


            }
            

        }
    }

   /* public void Scene(){
        SceneManager.LoadScene(scene);
    } */

    public void ObjeVer(GameObject objem)
    {
        butonunKendisi = objem;
        butonunKendisi.GetComponent<Image>().sprite = butonunKendisi.GetComponentInChildren<SpriteRenderer>().sprite;
        sesler[1].Play();
        butonunKendisi.GetComponent<Image>().raycastTarget = false;

    }

    void ButonlarinDurumu(bool durum)
    {

        foreach (var item in Butonlar)
        {

            if (item != null)
            {

                item.GetComponent<Image>().raycastTarget = durum;
            }



        }
    }

    public void ButonTikladi(int deger)
    {
        Kontrol(deger);



    }

    void Kontrol(int gelendeger)
    {

        if (ilkSecimDegeri == 0)
        {

            ilkSecimDegeri = gelendeger;
            secilenButon = butonunKendisi;

        }

        else
        {

            StartCoroutine(kontroletbakalim(gelendeger));

        }

    }
    IEnumerator kontroletbakalim(int gelendeger)
    {

        ButonlarinDurumu(false);

        yield return new WaitForSeconds(1);

        if (ilkSecimDegeri == gelendeger)
        {
            anlikBasari++;
            secilenButon.GetComponent<Image>().enabled = false;
            //secilenButon.GetComponent<Button>().enabled = false;

            butonunKendisi.GetComponent<Image>().enabled = false;
            //butonunKendisi.GetComponent<Button>().enabled = false;
            /*Destroy(secilenButon.gameObject);
            Destroy(butonunKendisi.gameObject);*/
            ilkSecimDegeri = 0;
            secilenButon = null;
            ButonlarinDurumu(true);

            if(anlikBasari==hedefBasari){
                
               Invoke("Win", .1f);
               // Win();
            }
        }

        else
        {
            sesler[2].Play();
            secilenButon.GetComponent<Image>().sprite = defaultSprite;
            butonunKendisi.GetComponent<Image>().sprite = defaultSprite;
            ilkSecimDegeri = 0;
            secilenButon = null;
            ButonlarinDurumu(true);
        }

    }
}
