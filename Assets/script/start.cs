using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;


public class start : MonoBehaviour
{
    public GameObject gemane;   //ゲームマネージャー
    public GameObject koukyusya;    //黒塗りの高級板
    public GameObject[] sentaku1;   //左端のカード
    public GameObject[] sentaku2;   //真ん中のカード
    public GameObject[] sentaku3;   //右端のカード

    int deyi = 9;   //現在の日付
    public TextMeshProUGUI day; //日付のテキスト

    float fadeSpeed = 0.013f;   //フェードスピード
    float fadeSpeed1 = 0.018f;

    float red, green, blue, alfa;   //黒背景の色の保持
    float red1, green1, blue1, alfa1;   //日付の色の保持

    public GameObject stfa; //日付の黒いパネル
    public Image fadeImage; 

    int endf = 0;
    public static int keltuka1;
    public static int keltuka2;
    public static int keltuka3;
    public GameObject endButton;
    int endret;
    int syuryou = 0;
    int uramodo;



    void Start()
    {
        endret = GAMESTART.getHitPoint();
        uramodo = GAMESTART.Ura2();

        red = fadeImage.color.r;
        green = fadeImage.color.g;
        blue = fadeImage.color.b;
        alfa = fadeImage.color.a;

        red1 = day.color.r;
        green1 = day.color.g;
        blue1 = day.color.b;
        alfa1 = day.color.a;

        Startfro();
    }

    IEnumerator fadein()
    {
        while (StartFadeIn())
        {
            yield return null;
        }
    }



    bool StartFadeIn()
    {

        alfa1 -= fadeSpeed1;
        alfa -= fadeSpeed1;
        SetAlpha();
        if (alfa <= 0)
        {
            fadeImage.enabled = false;
            stfa.SetActive(false);
            BGM.Play(2);
            return false;
        }
        return true;
    }



    IEnumerator fadeout()
    {
        while (StartFadeOut())
        {
            yield return null;
        }
    }



    bool StartFadeOut()
    {
        fadeImage.enabled = true;
        alfa += fadeSpeed;
        alfa1 += fadeSpeed;
        SetAlpha();
        if (alfa >= 1)
        {
            gemane.GetComponent<parameter>().mainaus();
            gemane.GetComponent<parameter>().iro();
            koukyusya.SetActive(false);
            gemane.GetComponent<parameter>().iro();
            gemane.GetComponent<ibent>().riset();
            keltuka1 = UnityEngine.Random.Range(0, 15);
            keltuka2 = UnityEngine.Random.Range(0, 15);
            keltuka3 = UnityEngine.Random.Range(0, 15);
            sentaku1[keltuka1].SetActive(true);
            sentaku2[keltuka2].SetActive(true);
            sentaku3[keltuka3].SetActive(true);
            BGM.Stop();
            SE.play(1);
            if (endf == 0)
            {
                StartCoroutine(fadein());
            }
            else if(endf == 1)
            {
                endButton.SetActive(true);
                Startfro();
            }
            return false;
        }
        return true;
    }



    public void end()
    {
        sentaku1[keltuka1].SetActive(false);
        sentaku2[keltuka2].SetActive(false);
        sentaku3[keltuka3].SetActive(false);
    }



    void SetAlpha()
    {
        fadeImage.color = new Color(red, green, blue, alfa);
        day.color = new Color(red1, green1, blue1, alfa1);
    }



    public void Startfro()
    {
        StartCoroutine(fadeout());
        stfa.SetActive(true);
        if (endret == 0)
        {
            if (deyi == 10)
            {
                endf = 1;
                day.GetComponentInChildren<TextMeshProUGUI>().text = "-GAME CLEAR-";
            }
            else
            {
                deyi++;
                day.GetComponentInChildren<TextMeshProUGUI>().text = deyi + "日目";
            }
        }
        else if(endret == 1)
        {
            deyi++;
            day.GetComponentInChildren<TextMeshProUGUI>().text = deyi + "日目";
        }
    }




    public void gamuovr()
    {
        StartCoroutine(fadeout());
        endf = 1;
        stfa.SetActive(true);
        day.GetComponentInChildren<TextMeshProUGUI>().text = "-GAME OVER-";
    }



    public void endgame()
    {
        if (uramodo == 0) {
            if (endret == 1)
            {
                if (syuryou == 0)
                {
                    naichilab.RankingLoader.Instance.SendScoreAndShowRanking(deyi);
                    syuryou = 1;
                } else {
                    SceneManager.LoadScene("title");
                }
            }

            else
            {
                SceneManager.LoadScene("title");
            }
        }else if (uramodo == 1)
        {
            SceneManager.LoadScene("title");
        }
    }
}