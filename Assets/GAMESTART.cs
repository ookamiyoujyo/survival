using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GAMESTART : MonoBehaviour {

    float fadeSpeed = 0.25f;        //透明度が変わるスピードを管理
    float fadeSpeed1 = 0.015f;        //透明度が変わるスピードを管理
    float red, green, blue, alfa;   //パネルの色、不透明度を管理

    public bool isFadeOut = false;  //フェードアウト処理の開始、完了を管理するフラグ
    public bool isFadeIn = false;   //フェードイン処理の開始、完了を管理するフラグ
    public GameObject kuro;
    public Image fadeImage;                //透明度を変更するパネルのイメージ
    int a = 0;
    int b = 0;
    public static int endret = 0;
    public static int ura = 0;
    void Start()
    {
        red = fadeImage.color.r;
        green = fadeImage.color.g;
        blue = fadeImage.color.b;
        alfa = fadeImage.color.a;
    }

    void Update()
    {
        if (a == 1)
        {
            StartFadeOut();
        }
    }


    void StartFadeOut()
    {
        alfa += fadeSpeed1;         // b)不透明度を徐々にあげる
        SetAlpha();               // c)変更した透明度をパネルに反映する
        if (alfa >= 1)
        {             // d)完全に不透明になったら処理を抜ける
            if (b == 1)
            {
                endret = 0;
                ura = 0;
                SceneManager.LoadScene("SampleScene");
            }else if(b == 2)
            {
                endret = 1;
                ura = 0;
                SceneManager.LoadScene("SampleScene");
            }
            else if (b == 3)
            {
              SE.play(0);
              endret = 1;
              ura = 1;
              SceneManager.LoadScene("SampleScene");
        }
    }
    }

    void SetAlpha()
    {
        fadeImage.color = new Color(red, green, blue, alfa);
    }
    public void normal()
    {
        kuro.SetActive(true);
        a = 1;
        b = 1;
    }
    public void mugen()
    {
        kuro.SetActive(true);
        a = 1;
        b = 2;
    }
    public void ura1()
    {
        kuro.SetActive(true);
        a = 1;
        b = 3;
    }
    public static int getHitPoint()
    {
        return endret;
    }
    public static int Ura2()
    {
        return ura;
    }
}