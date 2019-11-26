using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class fade : MonoBehaviour {
    float fadeSpeed = 0.01f, alfa = 0, speed = 0.065f;    //フェードスピード//白いパネルの透明度//カメラの前進スピード
    public Image fadeImage; //白いパネル


    private void OnTriggerEnter(Collider collision)
    {
        fadeImage.enabled = true;   //⑦透明な白いパネルを表示
        StartCoroutine(fadeout());  //③フェードアウトをするコルーチンを実行
    }
    IEnumerator fadeout()   //④フェードアウトコルーチン
    {
        while (StartFadeOut())  //⑤StartFadeOutからfalseが返ってくるまで実行
        {
            yield return null;  //⑫ループを１フレームの間止める
        }
    }
    bool StartFadeOut() //⑥コルーチンに呼び出される
    {
        fadeImage.color = new Color(255, 255, 255, alfa += fadeSpeed);   //⑧透明度下げ反映
        if (alfa >= 1)  //⑨完全に不透明になったらループを抜ける
        {
            return false;   //⑭コルーチンのループを止める
        }
        return true;    //⑩コルーチンのループに戻る
    }
}
