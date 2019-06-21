using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class manual : MonoBehaviour
{
    public GameObject gamebotab1;   //通常モードのボタン
    public GameObject gamebotab2;   //エンドレスモードのボタン
    public GameObject gamebotab3;   //説明モードのボタン
    float fadeSpeed = 0.018f;   //手前の透明度が変わるスピードを管理
    float fadeSpeed1 = 0.02f;   //奥の透明度が変わるスピードを管理
    public GameObject moya; //もやもやとか矢印のボタンをまとめたやつ
    public SpriteRenderer fadeImage;    //もやもや左上
    public SpriteRenderer fadeImage1;   //もやもや右上
    public SpriteRenderer fadeImage2;   //もやもや左下
    public SpriteRenderer fadeImage3;   //もやもや左下
    public SpriteRenderer yajirusiL;    //左矢印の画像
    public SpriteRenderer yajirusiR;    //右矢印の画像
    public GameObject taitoru1; //タイトルロゴ
    public SpriteRenderer taitoru;  //タイトルロゴの画像
    public GameObject yajirusibotanR;   //右矢印ボタン
    public GameObject yajirusibotanL;   //左矢印ボタン
    public TextMeshProUGUI kanbantxst1; //通常モード看板のテキスト
    public TextMeshProUGUI kanbantxst2; //エンドレスモード看板のテキスト
    public TextMeshProUGUI kanbantxst3; //説明モード看板のテキスト
    float red, green, blue, alfa;   //黒いもやもやの色、不透明度を管理
    float red1, green1, blue1, alfa1;   //黒いもやもやの色、不透明度を管理
    float red2, green2, blue2, alfa2;   //ボタンテキストの色、不透明度を管理
    float red3, green3, blue3, alfa3;   //タイトルロゴの色、不透明度を管理
    float red4, green4, blue4, alfa4;   //タイトルの色、不透明度を管理
    public TextMeshProUGUI serif;   //説明テキスト
    int page = 0;   //説明画面のページカウンター


    void Start()    //色々な色の取得(激うまギャグ)
    {
        red = fadeImage.color.r;
        green = fadeImage.color.g;
        blue = fadeImage.color.b;
        alfa = fadeImage.color.a;

        red1 = kanbantxst1.color.r;
        green1 = kanbantxst1.color.g;
        blue1 = kanbantxst1.color.b;
        alfa1 = kanbantxst1.color.a;

        red2 = yajirusiR.color.r;
        green2 = yajirusiR.color.g;
        blue2 = yajirusiR.color.b;
        alfa2 = yajirusiR.color.a;

        red3 = serif.color.r;
        green3 = serif.color.g;
        blue3 = serif.color.b;
        alfa3 = serif.color.a;

        red4 = taitoru.color.r;
        green4 = taitoru.color.g;
        blue4 = taitoru.color.b;
        alfa4 = taitoru.color.a;


    }



    void SetAlpha() //色の更新
    {
        fadeImage.color = new Color(red, green, blue, alfa);
        fadeImage1.color = new Color(red, green, blue, alfa);
        fadeImage2.color = new Color(red, green, blue, alfa);
        fadeImage3.color = new Color(red, green, blue, alfa);

        kanbantxst1.color = new Color(red1, green1, blue1, alfa1);
        kanbantxst2.color = new Color(red1, green1, blue1, alfa1);
        kanbantxst3.color = new Color(red1, green1, blue1, alfa1);

        yajirusiR.color = new Color(red2, green2, blue2, alfa2);
        yajirusiL.color = new Color(red2, green2, blue2, alfa2);

        serif.color = new Color(red3, green3, blue3, alfa3);
        taitoru.color = new Color(red4, green4, blue4, alfa4);
    }



    public void suta()//説明モードが選ばれた時に動くやーつ
    {
        gamebotab1.SetActive(false);    //モードボタン消しておく
        gamebotab2.SetActive(false);
        gamebotab3.SetActive(false);
        moya.SetActive(true);   //もやもやを出す
        page = 1;   //最初は1ページ目から
        serif.GetComponentInChildren<TextMeshProUGUI>().text = "このゲームはカードを選んで生き残る\nサバイバルゲームです\n\nあなたはカード選んでその日の\n最善の行動を取ってください\n\nでも結局は運";
            //壱ページ目の内容を入れておく
        StartCoroutine(fadeout());  //最初専用フェードコルーチンの呼び出し
    }
    IEnumerator fadeout()   //専用フェードコルーチン
    {
        while (StartFadeOut())
        {
            yield return null;
        }
    }

    bool StartFadeOut() //最初のフェードループ
    {
        alfa += fadeSpeed;  //もやもやを不透明にする
        alfa2 += fadeSpeed; //矢印を不透明にする
        alfa3 += fadeSpeed; //説明を不透明にする
        alfa1 -= fadeSpeed1;    //看板の文字を透明にする
        alfa4 -= fadeSpeed1;    //タイトルロゴを透明にする
        SetAlpha(); //色の更新
        if (alfa >= 1)  //もやもやが不透明なった
        {
            yajirusibotanR.SetActive(true);//矢印のボタンを出す
            yajirusibotanL.SetActive(true);
            return false;
        }
        return true;
    }

    void serifhenka()   //ページ更新の大本
    {
        switch (page)
        {
            case 0:
                yajirusibotanR.SetActive(false);    //矢印のボタンを消す
                yajirusibotanL.SetActive(false);
                StartCoroutine(setumeisyuuryou());  //説明終了コルーチンの呼び出し
                break;
            case 1:
                StartCoroutine(setumeiout());  //説明更新コルーチンを実行
                break;
            case 2:
                StartCoroutine(setumeiout());
                break;
            case 3:
                StartCoroutine(setumeiout());
                break;
            case 4:
                StartCoroutine(setumeiout());
                break;
            case 5:
                StartCoroutine(setumeiout());
                break;
            case 6:
                StartCoroutine(setumeiout());
                break;
            case 7:
                StartCoroutine(setumeiout());
                break;
            case 8:
                StartCoroutine(setumeiout());
                break;
            case 9:
                yajirusibotanL.SetActive(false);    //矢印のボタンを消す
                yajirusibotanR.SetActive(false);
                StartCoroutine(setumeisyuuryou());  //説明終了コルーチンの呼び出し
                break;
        }
    }
    IEnumerator setumeisyuuryou()//説明終了コルーチン
    {
        while (StartFadeOUT())
        {
            yield return null;
        }
    }

    bool StartFadeOUT()
    {
        alfa -= fadeSpeed;  //もやもやを透明にする
        alfa2 -= fadeSpeed; //矢印を透明にする
        alfa3 -= fadeSpeed; //説明を透明にする
        alfa1 += fadeSpeed1;    //看板の文字を不透明にする
        alfa4 += fadeSpeed1;    //タイトルロゴを不透明にする
        SetAlpha();//色の更新
        if (alfa <= 0)//透明になったってま？
        {
            gamebotab1.SetActive(true); //モードボタンを出す
            gamebotab2.SetActive(true);
            gamebotab3.SetActive(true);
            moya.SetActive(false);  //透明なもやもやを消す
            return false;
        }
        return true;
    }

    IEnumerator setumeiout()    //説明更新コルーチン
    {
        while (StartSetumei()) //説明更新ループ
        {
            yield return null;  
        }
    }

    bool StartSetumei()
    {
        alfa3 -= fadeSpeed1;    //説明を一旦透明にする
        SetAlpha(); //色の更新
        if (alfa3 <= 0) //説明文が透明になった
        {                
            switch (page)   //ページにあった説明文に更新
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
            StartCoroutine(setumeiin()); //説明文を出すコルーチンの呼び出し
            return false;
        }
        return true;
    }

    IEnumerator setumeiin() //説明文を出すコルーチン
    {
        while (OutSetumei())  //説明文を出すループの実行
        {
            yield return null;  
        }
    }

    bool OutSetumei()
    {
        alfa3 += fadeSpeed1;    //不透明にする
        SetAlpha(); //色の更新
        if (alfa3 >= 1) //見えるようになったら
        {             
            return false; 
        }
        return true;    
    }
    public void mayuaruR()  //右のボタンが押されたら
    {
        page++; //ページの移動
        serifhenka();   //ページ更新の大本の実行
    }
    public void mayuaruL()  //左のボタンが押されたら
    {
        page--; //ページの移動
        serifhenka();   //ページ更新の大本の実行
    }
}