using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class ibent : MonoBehaviour {

    int karad;
    public GameObject[] ibrek;
    public GameObject stfa;
    public GameObject gamemane;
    int a = 3, b = 0;
    float fadeSpeed = 0.018f;
    float fadeSpeed1 = 0.02f;
    public TextMeshProUGUI day;
    float red, green, blue, alfa;
    float red1, green1, blue1, alfa1;
    public Image fadeImage;
    public TextMeshProUGUI serif;
    public SpriteRenderer fadeImage1;
    public SpriteRenderer fadeImage2;
    public SpriteRenderer fadeImage3;
    public SpriteRenderer fadeImage4;
    public GameObject moya2;
    public GameObject ya;
    public static int ibrek1;
    int uramodo;
    void Start()
    {
        uramodo = GAMESTART.Ura2();
    }
    void Update()
    {
        if (a == 1)
        {
            StartFadeOut();
        }
        else if (a == 0)
        {
            StartFadeIn();
        }
        if (b == 1)
        {
            StartFadeOut2();
        }
        else if (a == 0)
        {
            StartFadeIn2();
        }
    }

    void StartFadeIn()
    {

        alfa1 -= fadeSpeed1;
        alfa -= fadeSpeed1;
        SetAlpha();
        if (alfa <= 0)
        {
            fadeImage.enabled = false;
            stfa.SetActive(false);
            a = 3;
            BGM.Play(0);
        }
    }

    void StartFadeOut()
    {
        fadeImage.enabled = true;
        alfa += fadeSpeed1;
        alfa1 += fadeSpeed1;
        SetAlpha();
        if (alfa >= 1)
        {

            BGM.Stop();
            SE.play(0);
            ibrek[karad].SetActive(false);
            if (uramodo == 0)
            {
                karad = UnityEngine.Random.Range(0, 16);
            }
            else if (uramodo == 1)
            {
                karad = 7;
            }
            gamemane.GetComponent<sentak>().keltutei();
            gamemane.GetComponent<start>().end();
            ibrek[karad].SetActive(true);
            a = 0;
            gamemane.GetComponent<parameter>().iro();
        }
    }

    void SetAlpha()
    {
        fadeImage.color = new Color(red, green, blue, alfa);
        day.color = new Color(red1, green1, blue1, alfa1);
    }
    public void Startfro()
    {
        a = 1;
        red = fadeImage.color.r;
        green = fadeImage.color.g;
        blue = fadeImage.color.b;
        alfa = fadeImage.color.a;

        red1 = day.color.r;
        green1 = day.color.g;
        blue1 = day.color.b;
        alfa1 = day.color.a;
        stfa.SetActive(true);
    }



    void StartFadeIn2()
    {

        alfa1 -= fadeSpeed;
        alfa -= fadeSpeed;
        SetAlpha2();
        if (alfa <= 0)
        {
            b = 3;
        }
    }

    void StartFadeOut2()
    {
        fadeImage.enabled = true;
        alfa += fadeSpeed;
        alfa1 += fadeSpeed;
        SetAlpha2();
        if (alfa >= 1)
        {
            ya.SetActive(true);
            b = 3;
        }
    }

    void SetAlpha2()
    {
        fadeImage1.color = new Color(red, green, blue, alfa);
        fadeImage2.color = new Color(red, green, blue, alfa);
        fadeImage3.color = new Color(red, green, blue, alfa);
        fadeImage4.color = new Color(red, green, blue, alfa);
        serif.color = new Color(red1, green1, blue1, alfa1);
    }




    public void setumei1()
    {
        SE.play(2);
        moya2.SetActive(true);
        b = 1;
        serif.GetComponentInChildren<TextMeshProUGUI>().text = "食べ物がくさりました\nもう食べることはできません";
    }
    public void setumei2()
    {
        SE.play(2);
        moya2.SetActive(true);
        b = 1;
        serif.GetComponentInChildren<TextMeshProUGUI>().text = "アライグマが倉庫に入りました\n食べ物が取られました";
    }
    public void setumei3()
    {
        SE.play(2);
        moya2.SetActive(true);
        b = 1;
        serif.GetComponentInChildren<TextMeshProUGUI>().text = "日照り\nざんねん自然には勝てません";
    }
    public void setumei4()
    {
        SE.play(2);
        moya2.SetActive(true);
        b = 1;
        serif.GetComponentInChildren<TextMeshProUGUI>().text = "あなたはうっかり水をこぼしました";
    }
    public void setumei5()
    {
        SE.play(2);
        moya2.SetActive(true);
        b = 1;
        serif.GetComponentInChildren<TextMeshProUGUI>().text = "親子があなたの所に来ました\n水をせがまれした\nしつこく付きまとわれました";
    }
    public void setumei6()
    {
        SE.play(2);
        moya2.SetActive(true);
        b = 1;
        serif.GetComponentInChildren<TextMeshProUGUI>().text = "じしん\nざんねん自然には勝てません";
    }
    public void setumei7()
    {
        SE.play(2);
        moya2.SetActive(true);
        b = 1;
        serif.GetComponentInChildren<TextMeshProUGUI>().text = "しっけがひどい日でした\nあなたはいつもよりつかれました";
    }
    public void setumei8()
    {
        SE.play(2);
        moya2.SetActive(true);
        b = 1;
        serif.GetComponentInChildren<TextMeshProUGUI>().text = "おおかみに追われました\nあなたはにげまどいました";
    }
    public void setumei9()
    {
        SE.play(2);
        moya2.SetActive(true);
        b = 1;
        serif.GetComponentInChildren<TextMeshProUGUI>().text = "火事\nざんねん自然には勝てません";
    }        
    public void setumei10()
    {
        SE.play(2);        SE.play(2);
        moya2.SetActive(true);
        b = 1;
        serif.GetComponentInChildren<TextMeshProUGUI>().text = "沼に落ちました\n体が大変よごれました";
    }
    public void setumei11()
    {
        SE.play(2);
        moya2.SetActive(true);
        b = 1;
        serif.GetComponentInChildren<TextMeshProUGUI>().text = "あなたは返り血をあびました";
    }
    public void setumei12()
    {
        SE.play(2);
        moya2.SetActive(true);
        b = 1;
        serif.GetComponentInChildren<TextMeshProUGUI>().text = "雷雨\nざんねん自然には勝てません";
    }
    public void setumei13()
    {
        SE.play(2);
        moya2.SetActive(true);
        b = 1;
        serif.GetComponentInChildren<TextMeshProUGUI>().text = "未来の自分を見ました";
    }
    public void setumei14()
    {
        SE.play(2);
        moya2.SetActive(true);
        b = 1;
        serif.GetComponentInChildren<TextMeshProUGUI>().text = "家族の写真を見ました\n悲しい気持ちになりました";
    }
    public void setumei15()
    {
        SE.play(2);
        moya2.SetActive(true);
        b = 1;
        serif.GetComponentInChildren<TextMeshProUGUI>().text = "ふぶき\nざんねん自然には勝てません";
    }
    public void setumei16()
    {
        SE.play(2);
        moya2.SetActive(true);
        b = 1;
        serif.GetComponentInChildren<TextMeshProUGUI>().text = "イナゴの大群\n野宿のあなたになす術はありません";
    }
    public void Next()
    {
        ya.SetActive(false);
        switch (karad)
        {
            case 0:
                gamemane.GetComponent<parameter>().minus0();
                break;
            case 1:
                gamemane.GetComponent<parameter>().minus1();
                break;
            case 2:
                gamemane.GetComponent<parameter>().minus2();
                break;
            case 3:
                gamemane.GetComponent<parameter>().minus3();
                break;
            case 4:
                gamemane.GetComponent<parameter>().minus4();
                break;
            case 5:
                gamemane.GetComponent<parameter>().minus5();
                break;
            case 6:
                gamemane.GetComponent<parameter>().minus6();
                break;
            case 7:
                gamemane.GetComponent<parameter>().minus7();
                break;
            case 8:
                gamemane.GetComponent<parameter>().minus8();
                break;
            case 9:
                gamemane.GetComponent<parameter>().minus9();
                break;
            case 10:
                gamemane.GetComponent<parameter>().minus10();
                break;
            case 11:
                gamemane.GetComponent<parameter>().minus11();
                break;
            case 12:
                gamemane.GetComponent<parameter>().minus12();
                break;
            case 13:
                gamemane.GetComponent<parameter>().minus13();
                break;
            case 14:
                gamemane.GetComponent<parameter>().minus14();
                break;
            case 15:
                gamemane.GetComponent<parameter>().minus15();
                break;
        }
    }
    public void riset()
    {
        moya2.SetActive(false);
        b = 0;
        ibrek[karad].SetActive(false);
    }
}
