using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class sentak : MonoBehaviour
{
    float fadeSpeed = 0.018f;
    public GameObject moya, gado;
    public SpriteRenderer fadeImage;
    public SpriteRenderer fadeImage1;
    public SpriteRenderer fadeImage2;
    public SpriteRenderer fadeImage3;
    public TextMeshProUGUI yse;
    public TextMeshProUGUI no;
    public TextMeshProUGUI serif;
    int a = 3,cardNo = 0;
    public static start keltuka1;
    float red, green, blue, alfa;
    float red1, green1, blue1, alfa1;

    public GameObject gamemane;
    public void sen1()
    {
        SE.play(2);
        a = 1;
        cardNo = 1;
        moya.SetActive(true);
        gado.SetActive(true);
        serif.GetComponentInChildren<TextMeshProUGUI>().text = "あなたは木箱を見つけました\nその中に食べ物を見つけました\nそれを持ち帰ります";
    }
    public void sen2()
    {
        SE.play(2);
        a = 1;
        cardNo = 2;
        moya.SetActive(true);
        gado.SetActive(true);
        serif.GetComponentInChildren<TextMeshProUGUI>().text = "あなたが育てていた作物が実り\n食べ物を手に入れました";
    }
    public void sen3()
    {
        SE.play(2);
        a = 1;
        cardNo = 3;
        moya.SetActive(true);
        gado.SetActive(true);
        serif.GetComponentInChildren<TextMeshProUGUI>().text = "ワナを用意しセットしたら\n動物をつかまえました\nこれにより\n大量の干し肉に入手しました";
    }
    public void sen4()
    {
        SE.play(2);
        a = 1;
        cardNo = 4;
        moya.SetActive(true);
        gado.SetActive(true);
        serif.GetComponentInChildren<TextMeshProUGUI>().text = "水の入ったボトルを見つけました\nボトルを持ち帰りました";
    }
    public void sen5()
    {
        SE.play(2);
        a = 1;
        cardNo = 5;
        moya.SetActive(true);
        gado.SetActive(true);
        serif.GetComponentInChildren<TextMeshProUGUI>().text = "きれいな池を見つけました\nあなたは水をくんで持ち帰りました";
    }
    public void sen6()
    {
        SE.play(2);
        a = 1;
        cardNo = 6;
        moya.SetActive(true);
        gado.SetActive(true);
        serif.GetComponentInChildren<TextMeshProUGUI>().text = "雨がふりました\n雨水を集め大量の水を確保しました";
    }
    public void sen7()
    {
        SE.play(2);
        a = 1;
        cardNo = 7;
        moya.SetActive(true);
        gado.SetActive(true);
        serif.GetComponentInChildren<TextMeshProUGUI>().text = "あなたはイスに座り\n休みました";
    }
    public void sen8()
    {
        SE.play(2);
        a = 1;
        cardNo = 8;
        moya.SetActive(true);
        gado.SetActive(true);
        serif.GetComponentInChildren<TextMeshProUGUI>().text = "アイマスクを使い\n少しだけ休みました";
    }
    public void sen9()
    {
        SE.play(2);
        a = 1;
        cardNo = 9;
        moya.SetActive(true);
        gado.SetActive(true);
        serif.GetComponentInChildren<TextMeshProUGUI>().text = "今日あなたはテントに入り\n体を休めました";
    }
    public void sen10()
    {
        SE.play(2);
        a = 1;
        cardNo = 10;
        moya.SetActive(true);
        gado.SetActive(true);
        serif.GetComponentInChildren<TextMeshProUGUI>().text = "片付けをしきれいにしました\n清潔になり病気になる\nリスクが減りました";
    }
    public void sen11()
    {
        SE.play(2);
        a = 1;
        cardNo = 11;
        moya.SetActive(true);
        gado.SetActive(true);
        serif.GetComponentInChildren<TextMeshProUGUI>().text = "新しい服を見つけました\n清潔になり病気になる\nリスクが減りました";
    }
    public void sen12()
    {
        SE.play(2);
        a = 1;
        cardNo = 12;
        moya.SetActive(true);
        gado.SetActive(true);
        serif.GetComponentInChildren<TextMeshProUGUI>().text = "体を洗いました\n清潔になり病気になる\nリスクが減りました";
    }
    public void sen13()
    {
        SE.play(2);
        a = 1;
        cardNo = 13;
        moya.SetActive(true);
        gado.SetActive(true);
        serif.GetComponentInChildren<TextMeshProUGUI>().text = "音楽を奏でました\nあなたはとても楽しい\n気分になりました";
    }

    public void sen14()
    {
        SE.play(2);
        a = 1;
        cardNo = 14;
        moya.SetActive(true);
        gado.SetActive(true);
        serif.GetComponentInChildren<TextMeshProUGUI>().text = "創作活動にしてみました\nあなたはとても楽しい\n気分になりました";
    }
    public void sen15()
    {
        SE.play(2);
        a = 1;
        cardNo = 15;
        moya.SetActive(true);
        gado.SetActive(true);
        serif.GetComponentInChildren<TextMeshProUGUI>().text = "本を読み過ごしました\nあなたはとても楽しい\n気分になりました";
    }

    void Start()
    {

        red = fadeImage.color.r;
        green = fadeImage.color.g;
        blue = fadeImage.color.b;
        alfa = fadeImage.color.a;

        red1 = yse.color.r;
        green1 = yse.color.g;
        blue1 = yse.color.b;
        alfa1 = yse.color.a;
    }
    public void nodes()
    {
        a = 0;
    }

    void SetAlpha()
    {
        fadeImage.color = new Color(red, green, blue, alfa);
        fadeImage1.color = new Color(red, green, blue, alfa);
        fadeImage2.color = new Color(red, green, blue, alfa);
        fadeImage3.color = new Color(red, green, blue, alfa);
        yse.color = new Color(red1, green1, blue1, alfa1);
        no.color = new Color(red1, green1, blue1, alfa1);
        serif.color = new Color(red1, green1, blue1, alfa1);
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
    }

    void StartFadeIn()
    {

        alfa -= fadeSpeed;
        alfa1 -= fadeSpeed;
        SetAlpha();
        if (alfa <= 0)
        {       

            moya.SetActive(false);
            gado.SetActive(false);
            a = 3;
        }
    }

    void StartFadeOut()
    {
       
        alfa += fadeSpeed;
        alfa1 += fadeSpeed;
        SetAlpha();
        if (alfa >= 1)
        {
            a = 3;
        }
    }
    public void keltutei()
    {
        moya.SetActive(false);
        gado.SetActive(false);
        a = 0;
        switch (cardNo)
        {
            case 1:
                gamemane.GetComponent<parameter>().plus1();
                break;
            case 2:
                gamemane.GetComponent<parameter>().plus2();
                break;
            case 3:
                gamemane.GetComponent<parameter>().plus3();
                break;
            case 4:
                gamemane.GetComponent<parameter>().plus4();
                break;
            case 5:
                gamemane.GetComponent<parameter>().plus5();
                break;
            case 6:
                gamemane.GetComponent<parameter>().plus6();
                break;
            case 7:
                gamemane.GetComponent<parameter>().plus7();
                break;
            case 8:
                gamemane.GetComponent<parameter>().plus8();
                break;
            case 9:
                gamemane.GetComponent<parameter>().plus9();
                break;
            case 10:
                gamemane.GetComponent<parameter>().plus10();
                break;
            case 11:
                gamemane.GetComponent<parameter>().plus11();
                break;
            case 12:
                gamemane.GetComponent<parameter>().plus12();
                break;
            case 13:
                gamemane.GetComponent<parameter>().plus13();
                break;
            case 14:
                gamemane.GetComponent<parameter>().plus14();
                break;
            case 15:
                gamemane.GetComponent<parameter>().plus15();
                break;
        }
    }
}
