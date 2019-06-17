using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;
public class start : MonoBehaviour
{
    public GameObject gemane;
    public GameObject koukyusya;
    public GameObject[] sentaku1;
    public GameObject[] sentaku2;
    public GameObject[] sentaku3;
    int deyi = 0;
    public GameObject deytext;
    public GameObject stfa;
    int a = 1;
    float fadeSpeed = 0.013f;
    float fadeSpeed1 = 0.018f;
    public TextMeshProUGUI day;
    float red, green, blue, alfa;
    float red1, green1, blue1, alfa1;
    public Image fadeImage;
    public bool isFadeOut = false;  //フェードアウト処理の開始、完了を管理するフラグ
    public bool isFadeIn = false;   //フェードイン処理の開始、完了を管理するフラグ
    int endf;
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
        Startfro();
        red = fadeImage.color.r;
        green = fadeImage.color.g;
        blue = fadeImage.color.b;
        alfa = fadeImage.color.a;

        red1 = day.color.r;
        green1 = day.color.g;
        blue1 = day.color.b;
        alfa1 = day.color.a;
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

        alfa1 -= fadeSpeed1;
        alfa -= fadeSpeed1;                //a)不透明度を徐々に下げる
        SetAlpha();                      //b)変更した不透明度パネルに反映する
        if (alfa <= 0)
        {                    //c)完全に透明になったら処理を抜ける
            isFadeIn = false;
            fadeImage.enabled = false;    //d)パネルの表示をオフにする
            stfa.SetActive(false);
            a = 3;
            BGM.Play(2);
        }
    }

    void StartFadeOut()
    {
        fadeImage.enabled = true;  // a)パネルの表示をオンにする
        alfa += fadeSpeed;
        alfa1 += fadeSpeed;  // b)不透明度を徐々にあげる
        SetAlpha();               // c)変更した透明度をパネルに反映する
        if (alfa >= 1)
        {             // d)完全に不透明になったら処理を抜ける
            gemane.GetComponent<parameter>().mainaus();
            gemane.GetComponent<parameter>().iro();
            koukyusya.SetActive(false);
            isFadeOut = false;
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
                a = 0;
            }else if(endf == 1)
            {
                endButton.SetActive(true);
            }
        }
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
        a = 1;
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
        a = 1;
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
    