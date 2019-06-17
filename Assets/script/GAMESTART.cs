using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GAMESTART : MonoBehaviour {

    float fadeSpeed = 0.015f;        //透明度を変えるスピード
    float red, green, blue, alfa;   //パネルの色、不透明度を保持用

    public GameObject kuro;//ゲームスタート時暗転用
    public Image fadeImage;//ゲームスタート時暗転用

    int gamemode = 0;//選択ステージの判断変数

    public static int endret = 0;//通常モードかエンドレスか判断
    public static int ura = 0;//裏ステージか判断

    bool isFadeIn;   //フェードイン処理の開始、完了を管理するフラグ


    void Start()//暗転用のパネルの色を取得
    {
        red = fadeImage.color.r;
        green = fadeImage.color.g;
        blue = fadeImage.color.b;
        alfa = fadeImage.color.a;
    }

    void SetAlpha()//パネルの色の更新
    {
        fadeImage.color = new Color(red, green, blue, alfa);
    }


    IEnumerator fadeout()   //④フェードアウトコルーチン
    {
        while (StartFadeOut())  //⑤StartFadeOutからfalseが返ってくるまで実行
        {
            yield return null;  //⑫ループを１フレームの間止める
        }
    }


    public void normal()//通常モード
    {
        kuro.SetActive(true);//暗転用パネルの表示
        StartCoroutine(fadeout());  //フェードアウトをするコルーチンを実行
        gamemode = 1;//モード選択
    }

    public void mugen()//エンドレスモード
    {
        kuro.SetActive(true);//暗転用パネルの表示
        StartCoroutine(fadeout());  //フェードアウトをするコルーチンを実行
        gamemode = 2;//モード選択
    }

    public void ura1()//裏モード
    {
        kuro.SetActive(true);//暗転用パネルの表示
        StartCoroutine(fadeout());  //フェードアウトをするコルーチンを実行
        gamemode = 3;//モード選択
    }
    public static int getHitPoint()//通常モード判断フラグ確認用
    {
        return endret;
    }
    public static int Ura2()//裏モード判断フラグ確認用
    {
        return ura;
    }

    bool StartFadeOut() //コルーチンに呼び出される
    {
        alfa += fadeSpeed;         //不透明度を徐々にあげる
        SetAlpha();               //変更した透明度をパネルに反映する
        if (alfa >= 1)//完全に不透明になったら処理を抜ける
        {             
            if (gamemode == 1)//通常モード
            {
                SceneManager.LoadScene("SampleScene");//シーン切り替え
            }else if(gamemode == 2)//エンドレスモード
            {
                endret = 1;//エンドレスON
                SceneManager.LoadScene("SampleScene");//シーン切り替え
            }
            else if (gamemode == 3)//裏モード
            {
              SE.play(0);//遠吠え
              endret = 1;//エンドレスON
                ura = 1;//裏モードON
                SceneManager.LoadScene("SampleScene");//シーン切り替え
            }
            return false;   //コルーチンのループを止める
        }
        return true;    //コルーチンのループに戻る
    }
}