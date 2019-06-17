using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class clear : MonoBehaviour {
    float fadeSpeed = 0.01f;        //透明度が変わるスピードを管理
    float red, green, blue, alfa;   //パネルの色、不透明度を管理
    float red1, green1, blue1, alfa1;   //パネルの色、不透明度を管理

    public GameObject f;
    public TextMeshProUGUI text1;
    public Image fadeImage1;                //透明度を変更するパネルのイメージ

    public GameObject fa;
    public TextMeshProUGUI text2;
    public Image fadeImage2;                //透明度を変更するパネルのイメージ
    int a = 0;

    void Start()
    {

        red = fadeImage1.color.r;
        green = fadeImage1.color.g;
        blue = fadeImage1.color.b;
        alfa = fadeImage1.color.a;

        red1 = fadeImage2.color.r;
        green1 = fadeImage2.color.g;
        blue1 = fadeImage2.color.b;
        alfa1 = fadeImage2.color.a;
    }

    void Update()
    {
        if (a == 2)
        {
            StartFadeOut1();
        }

        if (a == 1)
        {
            StartFadeOut2();
        }
    }


    void StartFadeOut1()
    {
        alfa -= fadeSpeed;                //a)不透明度を徐々に下げる
        SetAlpha1();                      //b)変更した不透明度パネルに反映する
        if (alfa <= 0)
        {             // d)完全に不透明になったら処理を抜ける
            a = 0;
        }
    }
    void StartFadeOut2()
    {
        alfa1 -= fadeSpeed;                //a)不透明度を徐々に下げる
        SetAlpha2();                      //b)変更した不透明度パネルに反映する
        if (alfa1 <= 0)
        {        // d)完全に不透明になったら処理を抜ける
            a = 0;
        }
    }
    void SetAlpha1()
    {
        fadeImage1.color = new Color(red, green, blue, alfa);
        text1.color = new Color(red, green, blue, alfa);
    }
    void SetAlpha2()
    {
        fadeImage2.color = new Color(red, green, blue, alfa);
        text2.color = new Color(red1, green1, blue1, alfa1);
    }
    public void cl()
    {
        a = 1;
        f.SetActive(true);
    }
    public void ovr()
    {
        a = 2;
        fa.SetActive(true);
    }
}

