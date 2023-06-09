﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class atteluParadisana : MonoBehaviour {

	public GameObject bikses1;
    public GameObject bikses2;
    public GameObject bikses3;
    public GameObject bikses4;

    public GameObject apavi1;
    public GameObject apavi2;
    public GameObject apavi3;

    public GameObject krekli1;
    public GameObject krekli2;
    public GameObject krekli3;
    public GameObject krekli4;

    public GameObject mati1;
    public GameObject mati2;
    public GameObject mati3;
    public GameObject mati4;



    public GameObject mainigaAttels;
    public Sprite[] atteluMasivs;

    public GameObject izmSlaidersBikses;
    public GameObject izmSlaidersApavi;
    public GameObject izmSlaiderskrekli;
    public GameObject izmSlaidersMati;

    public GameObject biezumuSlaiders;
    public GameObject platumuSlaiders;


    public void biksesAttelosana(bool vertiba)
    {
        bikses1.SetActive(vertiba);
        bikses2.SetActive(vertiba);
        bikses3.SetActive(vertiba);
        bikses4.SetActive(vertiba);

        izmSlaidersBikses.GetComponent<Slider>().interactable = vertiba;

    }
    public void MatuAttelosana(bool vertiba)
    {
        mati1.SetActive(vertiba);
        mati2.SetActive(vertiba);
        mati3.SetActive(vertiba);
        mati4.SetActive(vertiba);

        izmSlaidersMati.GetComponent<Slider>().interactable = vertiba;
    }
    public void ApavuAttelsana(bool vertiba)
    {
        apavi1.SetActive(vertiba);
        apavi2.SetActive(vertiba);
        apavi3.SetActive(vertiba);

        izmSlaidersApavi.GetComponent<Slider>().interactable = vertiba;
    }
    public void KrekluAttelosana(bool vertiba)
    {
        krekli1.SetActive(vertiba);
        krekli2.SetActive(vertiba);
        krekli3.SetActive(vertiba);
        krekli4.SetActive(vertiba);

        izmSlaiderskrekli.GetComponent<Slider>().interactable = vertiba;
    }

    public void Izkritosais(int skaitlis)
    {
        switch (skaitlis) {
         case 0:
                mainigaAttels.GetComponent<Image>().sprite = atteluMasivs[0];break;
        
         case 1:
                mainigaAttels.GetComponent<Image>().sprite = atteluMasivs[1]; break;
        
        }

}

    public void mainitLielimuBikses()
    {
        float pasreizejaVartiba = izmSlaidersBikses.GetComponent<Slider>().value;
        bikses1.transform.localScale = new Vector3(pasreizejaVartiba, pasreizejaVartiba, pasreizejaVartiba);
        bikses2.transform.localScale = new Vector3(pasreizejaVartiba, pasreizejaVartiba, pasreizejaVartiba);
        bikses3.transform.localScale = new Vector3(pasreizejaVartiba, pasreizejaVartiba, pasreizejaVartiba);
        bikses4.transform.localScale = new Vector3(pasreizejaVartiba, pasreizejaVartiba, pasreizejaVartiba);
    }


    public void mainitLielimuApavi()
    {
        float pasreizejaVartiba = izmSlaidersApavi.GetComponent<Slider>().value;
        apavi1.transform.localScale = new Vector3(pasreizejaVartiba, pasreizejaVartiba, pasreizejaVartiba);
        apavi2.transform.localScale = new Vector3(pasreizejaVartiba, pasreizejaVartiba, pasreizejaVartiba);
        apavi3.transform.localScale = new Vector3(pasreizejaVartiba, pasreizejaVartiba, pasreizejaVartiba);
        
    }

    public void mainitLielimuKrekli()
    {
        float pasreizejaVartiba = izmSlaiderskrekli.GetComponent<Slider>().value;
        krekli1.transform.localScale = new Vector3(pasreizejaVartiba, pasreizejaVartiba, pasreizejaVartiba);
        krekli2.transform.localScale = new Vector3(pasreizejaVartiba, pasreizejaVartiba, pasreizejaVartiba);
        krekli3.transform.localScale = new Vector3(pasreizejaVartiba, pasreizejaVartiba, pasreizejaVartiba);
        krekli4.transform.localScale = new Vector3(pasreizejaVartiba, pasreizejaVartiba, pasreizejaVartiba);
    }

    public void mainitLielimuMates()
    {
        float pasreizejaVartiba = izmSlaidersMati.GetComponent<Slider>().value;
        mati1.transform.localScale = new Vector3(pasreizejaVartiba, pasreizejaVartiba, pasreizejaVartiba);
        mati2.transform.localScale = new Vector3(pasreizejaVartiba, pasreizejaVartiba, pasreizejaVartiba);
        mati3.transform.localScale = new Vector3(pasreizejaVartiba, pasreizejaVartiba, pasreizejaVartiba);
        mati4.transform.localScale = new Vector3(pasreizejaVartiba, pasreizejaVartiba, pasreizejaVartiba);
    }

    public void mainitCilveku() {
        float pasreizejaVartiba = biezumuSlaiders.GetComponent<Slider>().value;
        float pasreizejaVartiba2 = platumuSlaiders.GetComponent<Slider>().value;
        mainigaAttels.transform.localScale = new Vector3(pasreizejaVartiba, pasreizejaVartiba2,1);
    }

   
}
