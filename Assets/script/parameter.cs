using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class parameter : MonoBehaviour
{
    int para1 = 50, para2 = 50, para3 = 50, para4 = 50, para5 = 50;
    public TextMeshProUGUI sute1, sute2, sute3, sute4, sute5;
    public GameObject gamemanager;
    public void plus1() //行動カード食料1
    {
        para1 = para1 + 10;
        safepara();
    }
    public void plus2()//行動カード食料2
    {
        para1 = para1 + 20;
        safepara();
    }
    public void plus3()//行動カード食料3
    {
        para1 = para1 + 30;
        safepara();
    }
    public void plus4()//行動カード水1
    {
        para2 = para2 + 10;
        safepara();
    }
    public void plus5()//行動カード水2
    {
        para2 = para2 + 20;
        safepara();
    }
    public void plus6()//行動カード水3
    {
        para2 = para2 + 30;
        safepara();
    }
    public void plus7()//行動カード体力1
    {
        para3 = para3 + 10;
        safepara();
    }
    public void plus8()//行動カード体力2
    {
        para3 = para3 + 20;
        safepara();
    }
    public void plus9()//行動カード体力3
    {
        para3 = para3 + 30;
        safepara();
    }
    public void plus10()//行動カード清潔1
    {
        safepara();
    }
    public void plus11()//行動カード清潔2
    {
        para4 = para4 + 20;
        safepara();
    }
    public void plus12()//行動カード清潔3
    {
        para4 = para4 + 30;
        safepara();
    }
    public void plus13()//行動カード娯楽1
    {
        para5 = para5 + 10;
        safepara();
    }
    public void plus14()//行動カード娯楽2
    {
        para5 = para5 + 20;
        safepara();
    }
    public void plus15()//行動カード娯楽3
    {
        para5 = para5 + 30;
        safepara();

    }
    public void safepara()//カンスト対策
    {
        if (para1 >= 1000)
        {
            para1 = 999;
        }
        if (para2 >= 1000)
        {
            para2 = 999;
        }
        if (para3 >= 1000)
        {
            para3 = 999;
        }
        if (para4 >= 1000)
        {
            para4 = 999;
        }
        if (para5 >= 1000)
        {
            para5 = 999;
        }
        mainaus();
    }
    public void minus0()
    {
        para1 = para1 - 5;
        dailydamage();
    }
    public void minus1()
    {
        para1 = para1 - 10;
        dailydamage();
    }
    public void minus2()
    {
        para1 = para1 - 30;
        dailydamage();
    }
    public void minus3()
    {
        para2 = para2 - 5;
        dailydamage();
    }
    public void minus4()
    {
        para2 = para2 - 10;
        dailydamage();
    }
    public void minus5()
    {
        para2 = para2 - 30;
        dailydamage();
    }
    public void minus6()
    {
        para3 = para3 - 5;
        dailydamage();
    }
    public void minus7()
    {
        para3 = para3 - 10;
        dailydamage();
    }
    public void minus8()
    {
        para3 = para3 - 30;
        dailydamage();
    }
    public void minus9()
    {
        para4 = para4 - 5;
        dailydamage();
    }
    public void minus10()
    { 
        para4 = para4 - 10;
        dailydamage();
    }
    public void minus11()
    {
        para4 = para4 - 30;
        dailydamage();
    }
    public void minus12()
    {
        para5 = para5 - 5;
        dailydamage();
    }
    public void minus13()
    {
        para5 = para5 - 10;
        dailydamage();
    }
    public void minus14()
    {
        para5 = para5 - 30;
        dailydamage();
    }
    public void minus15()
    {
        para1 = para1 - 50;
        para2 = para2 - 50;
        para3 = para3 - 50;
        para4 = para4 - 50;
        para5 = para5 - 50;
        dailydamage();
    }
    void dailydamage()
    {
        para1 = para1 - 2;
        para3 = para3 - 2;
        para4 = para4 - 2;
        para5 = para5 - 2;
        para2 = para2 - 2;
        nextdei();
    }
    public void nextdei()//次の日への処理
    {
        if (para1 > 0 && para2 > 0 && para3 > 0 && para4 > 0 && para5 > 0)
        {
            gamemanager.GetComponent<start>().daystart();
        }
        else
        {
            gamemanager.GetComponent<start>().gamuovr();
        }
    }
    public void mainaus()//パラメーター反映
    {
        sute1.GetComponentInChildren<TextMeshProUGUI>().text = para1.ToString();
        sute2.GetComponentInChildren<TextMeshProUGUI>().text = para2.ToString();
        sute3.GetComponentInChildren<TextMeshProUGUI>().text = para3.ToString();
        sute4.GetComponentInChildren<TextMeshProUGUI>().text = para4.ToString();
        sute5.GetComponentInChildren<TextMeshProUGUI>().text = para5.ToString();
        iro();
    }
    public void iro()//色の反映
    {
        if (para1 > 32)
        {
            sute1.color = new Color(255, 255, 255, 255);
        }
        else if (para1 > 12)
        {
            sute1.color = new Color(255, 255, 0, 255);
        }
        else
        {
            sute1.color = new Color(255, 0, 0, 255);
        }
        if (para2 > 32)
        {
            sute2.color = new Color(255, 255, 255, 255);
        }
        else if (para2 > 12)
        {
            sute2.color = new Color(255, 255, 0, 255);
        }
        else
        {
            sute2.color = new Color(255, 0, 0, 255);
        }
        if (para3 > 32)
        {
            sute3.color = new Color(255, 255, 255, 255);
        }
        else if (para3 > 12)
        {
            sute3.color = new Color(255, 255, 0, 255);
        }
        else
        {
            sute3.color = new Color(255, 0, 0, 255);
        }
        if (para4 > 32)
        {
            sute4.color = new Color(255, 255, 255, 255);
        }
        else if (para4 > 12)
        {
            sute4.color = new Color(255, 255, 0, 255);
        }
        else
        {
            sute4.color = new Color(255, 0, 0, 255);
        }
        if (para5 > 32)
        {
            sute5.color = new Color(255, 255, 255, 255);
        }
        else if (para5 > 12)
        {
            sute5.color = new Color(255, 255, 0, 255);
        }
        else
        {
            sute5.color = new Color(255, 0, 0, 255);
        }
    }
}