using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;


public class start : MonoBehaviour
{
    public GameObject gemane;   //ゲームマネージャー
    public GameObject koukyusya;    //最初専用の暗転
    public GameObject[] sentaku1;   //左端のカード
    public GameObject[] sentaku2;   //真ん中のカード
    public GameObject[] sentaku3;   //右端のカード

    int deyi = 0;   //現在の日付
    public TextMeshProUGUI day; //日付のテキスト

    float fadeSpeed = 0.013f;   //フェードスピード
    float fadeSpeed1 = 0.018f;

    float red, green, blue, alfa;   //黒背景の色の保持
    float red1, green1, blue1, alfa1;   //日付の色の保持

    public GameObject stfa; //日付の黒いパネル
    public Image fadeImage; 

    int endf = 0;   //終了フラグ
    public static int keltuka1; //左端のランダム数でカード選出用
    public static int keltuka2; //真ん中のランダム数でカード選出用
    public static int keltuka3; //右端のランダム数でカード選出用

    public GameObject endButton;    //ゲーム終了ボタン

    int endret; //無限モード判断フラグ
    int uramodo;    //裏モード判断フラグ
    int syuryou = 0;    //ランキング呼び出しフラグ



    void Start()
    {
        endret = GAMESTART.getHitPoint();   //無限モードフラグの受け取り
        uramodo = GAMESTART.Ura2(); //裏モードフラグの受け取り

        red = fadeImage.color.r;    //色の取得
        green = fadeImage.color.g;
        blue = fadeImage.color.b;
        alfa = fadeImage.color.a;

        red1 = day.color.r;
        green1 = day.color.g;
        blue1 = day.color.b;
        alfa1 = day.color.a;

        daystart(); //1日目を始める
    }

    public void daystart()  //1日の始まりに実行
    {
        StartCoroutine(fadeout());  //フェードアウトの実行、及びフェード中の処理
        if (endret == 0)    //無限モードか判断
        {
            if (deyi == 10) //10日目か判断
            {
                endf = 1;   //終了フラグを立てる
                day.GetComponentInChildren<TextMeshProUGUI>().text = "-GAME CLEAR-";    //日付をゲームクリアに変える
            }
            else　　//10日前だったら続行
            {       
                deyi++; //日付の更新
                day.GetComponentInChildren<TextMeshProUGUI>().text = deyi + "日目";   //テキストの日付の更新
            }
        }
        else if (endret == 1)   //無限モードだったら
        {
            deyi++; //日付の更新
            day.GetComponentInChildren<TextMeshProUGUI>().text = deyi + "日目";    //テキストの日付の更新
        }
    }


    IEnumerator fadeout()   //フェードアウトの実行、及びフェード中の処理
    {
        stfa.SetActive(true);   //黒いパネルを出す
        while (StartFadeOut())  //暗転と暗転中の処理をするループ
        {
            yield return null;
        }
    }



    bool StartFadeOut()
    {
        fadeImage.enabled = true;
        alfa += fadeSpeed;  //不透明にする
        alfa1 += fadeSpeed;
        SetAlpha(); //色の更新
        if (alfa >= 1)  //完全に不透明になったら
        {
            gemane.GetComponent<parameter>().mainaus(); //数字の反映
            koukyusya.SetActive(false); //最初専用の暗転を消す
            gemane.GetComponent<ibent>().riset();   //イベントカードの非表示

            keltuka1 = Random.Range(0, 15); //行動カードの選出

            keltuka2 = Random.Range(0, 15); //行動カードの選出
            while (keltuka1 == keltuka2)    //被り防止
            {
                keltuka2 = Random.Range(0, 15); //行動カードの再選出
            }
            keltuka3 = Random.Range(0, 15); //行動カードの選出
            while (keltuka1 == keltuka3 || keltuka2 == keltuka3)    //被り防止
            {
                keltuka3 = Random.Range(0, 15); //行動カードの再選出
            }

            sentaku1[keltuka1].SetActive(true); //カードの表示
            sentaku2[keltuka2].SetActive(true);
            sentaku3[keltuka3].SetActive(true);

            BGM.Stop(); //BGMを止める
            SE.play(1); //開始音を鳴らす
            if (endf == 0)  //終了フラグの確認
            {
                StartCoroutine(fadein());   //操作可能にするコルーチン
            }
            else if(endf == 1)
            {
                endButton.SetActive(true);  //タイトル行く終了ボタンの表示
            }
            return false;
        }
        return true;
    }

    IEnumerator fadein()   //操作可能にするコルーチン
    {
        while (StartFadeIn())
        {
            yield return null;
        }
    }

    bool StartFadeIn()
    {

        alfa1 -= fadeSpeed1;    //透明にする
        alfa -= fadeSpeed1;
        SetAlpha();
        if (alfa <= 0)
        {
            stfa.SetActive(false);  //暗転を消す
            BGM.Play(2);    //BGMを流す
            return false;
        }
        return true;
    }


    public void end()
    {
        sentaku1[keltuka1].SetActive(false);　//行動カードを非表示
        sentaku2[keltuka2].SetActive(false);
        sentaku3[keltuka3].SetActive(false);
    }



    void SetAlpha() //色の更新
    {
        fadeImage.color = new Color(red, green, blue, alfa);
        day.color = new Color(red1, green1, blue1, alfa1);
    }



    public void gamuovr()
    {
        StartCoroutine(fadeout());  //フェードアウトの実行、及びフェード中の処理
        endf = 1;   //終了フラグをたてる
        stfa.SetActive(true); //暗転の表示
        day.GetComponentInChildren<TextMeshProUGUI>().text = "-GAME OVER-"; //ゲームオーバーの文字表示
    }



    public void endgame()   //終了関数、終了ボタンが押されたら呼び出される
    {
        if (uramodo == 0) { //裏モードか判断
            if (endret == 1)　//無限モードか判断
            {
                if (syuryou == 0)   //ランキング登録前か判断
                {
                    naichilab.RankingLoader.Instance.SendScoreAndShowRanking(deyi); //ランキングの呼び出し
                    syuryou = 1;    //ランキング登録完了フラグを立てる
                } else {
                    SceneManager.LoadScene("title");    //タイトルシーンの呼び出し
                }
            }
            else    //通常モードだったら
            {
                SceneManager.LoadScene("title");    //タイトルシーンの呼び出し
            }
        }else if (uramodo == 1) //裏モードだったら即タイトル
        {
            SceneManager.LoadScene("title");    //タイトルシーンの呼び出し
        }
    }
}