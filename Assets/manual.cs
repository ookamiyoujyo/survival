using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class manual : MonoBehaviour
{
    public GameObject gamebotab1;
    public GameObject gamebotab2;
    public GameObject gamebotab3;
    float fadeSpeed = 0.018f;        //透明度が変わるスピードを管理
    float fadeSpeed1 = 0.02f;        //透明度が変わるスピードを管理
    float red, green, blue, alfa;   //パネルの色、不透明度を管理
    public GameObject moya;
    public SpriteRenderer fadeImage;
    public SpriteRenderer fadeImage1;
    public SpriteRenderer fadeImage2;
    public SpriteRenderer fadeImage3;
    public SpriteRenderer yajirusi;
    public SpriteRenderer yajirusi1;
    public GameObject yajirusibotan;
    public GameObject taitoru1;
    public SpriteRenderer taitoru;
    public GameObject yajirusibotan1;
    public TextMeshProUGUI txst1;
    public TextMeshProUGUI txst2;
    public TextMeshProUGUI txst3;
    float red1, green1, blue1, alfa1;   //パネルの色、不透明度を管理
    float red2, green2, blue2, alfa2;   //パネルの色、不透明度を管理
    float red3, green3, blue3, alfa3;   //パネルの色、不透明度を管理
    float red4, green4, blue4, alfa4;   //パネルの色、不透明度を管理
    int a = 0,b = 1,c = 0;
    public TextMeshProUGUI serif;
    void Start()
    {
        red = fadeImage.color.r;
        green = fadeImage.color.g;
        blue = fadeImage.color.b;
        alfa = fadeImage.color.a;

        red1 = txst1.color.r;
        green1 = txst1.color.g;
        blue1 = txst1.color.b;
        alfa1 = txst1.color.a;

        red2 = yajirusi.color.r;
        green2 = yajirusi.color.g;
        blue2 = yajirusi.color.b;
        alfa2 = yajirusi.color.a;

        red3 = serif.color.r;
        green3 = serif.color.g;
        blue3 = serif.color.b;
        alfa3 = serif.color.a;

        red4 = taitoru.color.r;
        green4 = taitoru.color.g;
        blue4 = taitoru.color.b;
        alfa4 = taitoru.color.a;

    }

    void Update()
    {
        if (a == 1)
        {
            StartFadeIn();
        }

        if (a == 2)
        {
            StartFadeOut();
        }
        if (c == 1)
        {
            StartFadeIn1();
        }

        if (c == 2)
        {
            StartFadeOut1();
        }
    }

    void StartFadeIn()
    {
        alfa -= fadeSpeed;                //a)不透明度を徐々に下げる
        alfa2 -= fadeSpeed;                //a)不透明度を徐々に下げる
        alfa3 -= fadeSpeed;                //a)不透明度を徐々に下げる
        alfa1 += fadeSpeed1;         // b)不透明度を徐々にあげる
        alfa4 += fadeSpeed1;         // b)不透明度を徐々にあげる
        SetAlpha();               // c)変更した透明度をパネルに反映する
        if (alfa <= 0)
        {                    //c)完全に透明になったら処理を抜ける
            gamebotab1.SetActive(true);
            gamebotab2.SetActive(true);
            gamebotab3.SetActive(true);
            moya.SetActive(false);
        }
    }

    void StartFadeOut()
    {
        alfa += fadeSpeed;         // b)不透明度を徐々にあげる
        alfa2 += fadeSpeed;         // b)不透明度を徐々にあげる
        alfa3 += fadeSpeed;                //a)不透明度を徐々に下げる
        alfa1 -= fadeSpeed1;         // b)不透明度を徐々にあげる
        alfa4 -= fadeSpeed1;         // b)不透明度を徐々にあげる
        SetAlpha();               // c)変更した透明度をパネルに反映する
        if (alfa >= 1)
        {             // d)完全に不透明になったら処理を抜ける
            a = 0;
            yajirusibotan1.SetActive(true);
            yajirusibotan.SetActive(true);
        }
    }

    void SetAlpha()
    {
        fadeImage.color = new Color(red, green, blue, alfa);
        fadeImage1.color = new Color(red, green, blue, alfa);
        fadeImage2.color = new Color(red, green, blue, alfa);
        fadeImage3.color = new Color(red, green, blue, alfa);

        txst1.color = new Color(red1, green1, blue1, alfa1);
        txst2.color = new Color(red1, green1, blue1, alfa1);
        txst3.color = new Color(red1, green1, blue1, alfa1);

        yajirusi.color = new Color(red2, green2, blue2, alfa2);
        yajirusi1.color = new Color(red2, green2, blue2, alfa2);

        serif.color = new Color(red3, green3, blue3, alfa3);
        taitoru.color = new Color(red4, green4, blue4, alfa4);
    }

    public void suta()
    {
        gamebotab1.SetActive(false);
        gamebotab2.SetActive(false);
        gamebotab3.SetActive(false);
        moya.SetActive(true);
        b = 1;
        a = 2;
        serif.GetComponentInChildren<TextMeshProUGUI>().text = "このゲームはカードを選んで生き残る\nサバイバルゲームです\n\nあなたはカード選んでその日の\n最善の行動を取ってください\n\nでも結局は運";
    }

    void serifhenka()
    {
        switch (b)
        {
            case 0:
                yajirusibotan1.SetActive(false);
                yajirusibotan.SetActive(false);
                a = 1;
                break;
            case 1:
                c = 1;
                break;
            case 2:
                c = 1;
                break;
            case 3:
                c = 1;
                break;
            case 4:
                c = 1;
                break;
            case 5:
                c = 1;
                break;
            case 6:
                c = 1;
                break;
            case 7:
                c = 1;
                break;
            case 8:
                c = 1;
                break;
            case 9:
                yajirusibotan1.SetActive(false);
                yajirusibotan.SetActive(false);
                a = 1;
                break;
        }
    }


    void StartFadeIn1()
    {
        alfa3 -= fadeSpeed1;                //a)不透明度を徐々に下げる
        SetAlpha1();               // c)変更した透明度をパネルに反映する
        if (alfa3 <= 0)
        {                    //c)完全に透明になったら処理を抜ける
            c = 2;
            switch (b)
            {
                case 0:
                    break;
                case 1:
                    serif.GetComponentInChildren<TextMeshProUGUI>().text = "このゲームはカードを選んで生き残る\nサバイバルゲームです\n\nあなたはカード選んでその日の\n最善の行動を取ってください\n\nでも結局は運";
                    break;
                case 2:
                    serif.GetComponentInChildren<TextMeshProUGUI>().text = "　　　　　　　　ルール\n\n・5つのパラメーターをいじする\n\n・3枚のカードから1枚選ぶ\n\n・そのカードに対応したパラメーターが\n　プラスされる";
                    break;
                case 3:
                    serif.GetComponentInChildren<TextMeshProUGUI>().text = "　　　　　　　　ルール\n\n・選ぶとイベントカードが一枚出る\n\n・そのカードに対応したパラメーターが\n　マイナスされる\n\n・あと全部毎日 - 2される";
                    break;
                case 4:
                    serif.GetComponentInChildren<TextMeshProUGUI>().text = "通常のモード\n・10日生き残るお手軽モード\n・ランキングはない\n\nエンドレスモード\n・死ぬまで無限に遊べるモード\n・ランキングが付く";
                    break;
                case 5:
                    serif.GetComponentInChildren<TextMeshProUGUI>().text = "　　　　　　　行動カード\n下位カード\n・+10する、ないよりマシ\n\n中位カード\n・+20する、美味しい\n\n上位カード\n・+30する、来てほしい";
                    break;
                case 6:
                    serif.GetComponentInChildren<TextMeshProUGUI>().text = "　　　　　イベントカード\n下位イベント\n・-5される大したことない\n\n\n上位イベント\n・-10される、たまにつらい";
                    break;
                case 7:
                    serif.GetComponentInChildren<TextMeshProUGUI>().text = "　　　　　イベントカード\n\n災害イベント\n・-30される、めっちゃつらい\n・でもちゃんとしてれば意外と生きれる\n・来ないことをいのろう";
                    break;
                case 8:
                    serif.GetComponentInChildren<TextMeshProUGUI>().text = "　　　　　イベントカード\n\nイナゴ\n・キャッチコピーは\n　「産地直送あなたに死をお届け」\n・最凶のカード\n・大体の死因はこいつ\n・-50される、最悪出落ちもある";
                    break;
            }
        }
    }

    void StartFadeOut1()
    {
        alfa3 += fadeSpeed1;                //a)不透明度を徐々に下げる
        SetAlpha1();               // c)変更した透明度をパネルに反映する
        if (alfa3 >= 1)
        {             // d)完全に不透明になったら処理を抜ける
            c = 0;
        }
    }
    void SetAlpha1()
    {
        serif.color = new Color(red3, green3, blue3, alfa3);
    }
    public void mayuaruR()
    {
        b++;
        serifhenka();
    }
    public void mayuaruL()
    {
        b--;
        serifhenka();
    }
}