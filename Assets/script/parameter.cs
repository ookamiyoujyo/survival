using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class parameter : MonoBehaviour {
    int para1 = 50, para2 = 50, para3 = 50, para4 = 50, para5 = 50;
    public TextMeshProUGUI sute1, sute2, sute3, sute4, sute5;
    public GameObject a;
    public void plus1()
    {
        para1 = para1 + 10;
        if (para1 >= 1000)
        {
            para1 = 999;
        }
        sute1.GetComponentInChildren<TextMeshProUGUI>().text = para1.ToString();

    }
    public void plus2()
    {
        para1 = para1 + 20;
        if (para1 >= 1000)
        {
            para1 = 999;
        }
        sute1.GetComponentInChildren<TextMeshProUGUI>().text = para1.ToString();

    }
    public void plus3()
    {
        para1 = para1 + 30;
        if (para1 >= 1000)
        {
            para1 = 999;
        }
        sute1.GetComponentInChildren<TextMeshProUGUI>().text = para1.ToString();
  
    }
    public void plus4()
    {
        para2 = para2 + 10;
        if (para2 >= 1000)
        {
            para2 = 999;
        }
        sute2.GetComponentInChildren<TextMeshProUGUI>().text = para2.ToString();

    }
    public void plus5()
    {
        para2 = para2 + 20;
        if (para2 >= 1000)
        {
            para2 = 999;
        }
        sute2.GetComponentInChildren<TextMeshProUGUI>().text = para2.ToString();

    }
    public void plus6()
    {
        para2 = para2 + 30;
        if (para2 >= 1000)
        {
            para2 = 999;
        }
        sute2.GetComponentInChildren<TextMeshProUGUI>().text = para2.ToString();

    }
    public void plus7()
    {
        para3 = para3 + 10;
        if (para3 >= 1000)
        {
            para3 = 999;
        }
        sute3.GetComponentInChildren<TextMeshProUGUI>().text = para3.ToString();

    }
    public void plus8()
    {
        para3 = para3 + 20;
        if (para3 >= 1000)
        {
            para3 = 999;
        }
        sute3.GetComponentInChildren<TextMeshProUGUI>().text = para3.ToString();
  
    }
    public void plus9()
    {
        para3 = para3 + 30;
        if (para3 >= 1000)
        {
            para3 = 999;
        }
        sute3.GetComponentInChildren<TextMeshProUGUI>().text = para3.ToString();

    }
        public void plus10()
    {
        para4 = para4 + 10;
        if (para4 >= 1000)
        {
            para4 = 999;
        }
        sute4.GetComponentInChildren<TextMeshProUGUI>().text = para4.ToString();
 
    }
    public void plus11()
    {
        para4 = para4 + 20;
        if (para4 >= 1000)
        {
            para4 = 999;
        }
        sute4.GetComponentInChildren<TextMeshProUGUI>().text = para4.ToString();

    }
    public void plus12()
    {
        para4 = para4 + 30;
        if (para4 >= 1000)
        {
            para4 = 999;
        }
        sute4.GetComponentInChildren<TextMeshProUGUI>().text = para4.ToString();

    }
    public void plus13()
    {
        para5 = para5 + 10;
        if (para5 >= 1000)
        {
            para5 = 999;
        }
        sute5.GetComponentInChildren<TextMeshProUGUI>().text = para5.ToString();

    }
    public void plus14()
    {
        para5 = para5 + 20;
        if (para5 >= 1000)
        {
            para5 = 999;
        }
        sute5.GetComponentInChildren<TextMeshProUGUI>().text = para5.ToString();

    }
    public void plus15()
    {
        para5 = para5 + 30;
        if (para5 >= 1000)
        {
            para5 = 999;
        }
        sute5.GetComponentInChildren<TextMeshProUGUI>().text = para5.ToString();

    }
    public void minus0()
    {
        para1 = para1 - 5;
        if (para1 > 0 && para2 > 0 && para3 > 0 && para4 > 0 && para5 > 0)
        {
            a.GetComponent<start>().daystart();
        }
        else
        {
            a.GetComponent<start>().gamuovr();
        }
    }
    public void minus1()
    {

        para1 = para1 - 10;
        if (para1 > 0 && para2 > 0 && para3 > 0 && para4 > 0 && para5 > 0)
        {
            a.GetComponent<start>().daystart();
        }
        else
        {
            a.GetComponent<start>().gamuovr();
        }
    }
    public void minus2()
    {
        par2();
        para1 = para1 - 30;
        if (para1 > 0 && para2 > 0 && para3 > 0 && para4 > 0 && para5 > 0)
        {
            a.GetComponent<start>().daystart();
        }
        else
        {
            a.GetComponent<start>().gamuovr();
        }
    }

        public void minus3()
    {
        par2();
        para2 = para2 - 5;
        if (para1 > 0 && para2 > 0 && para3 > 0 && para4 > 0 && para5 > 0)
        {
            a.GetComponent<start>().daystart();
        }
        else
        {
            a.GetComponent<start>().gamuovr();
        }
    }
    public void minus4()
    {
        par2();
        para2 = para2 - 10;
        if (para1 > 0 && para2 > 0 && para3 > 0 && para4 > 0 && para5 > 0)
        {
            a.GetComponent<start>().daystart();
        }
        else
        {
            a.GetComponent<start>().gamuovr();
        }
    }
    public void minus5()
    {
        par2();
        para2 = para2 - 30;
        if (para1 > 0 && para2 > 0 && para3 > 0 && para4 > 0 && para5 > 0)
        {
            a.GetComponent<start>().daystart();
        }
        else
        {
            a.GetComponent<start>().gamuovr();
        }
    }
    public void minus6()
    {
        par2();
        para3 = para3 - 5;
        if (para1 > 0 && para2 > 0 && para3 > 0 && para4 > 0 && para5 > 0)
        {
            a.GetComponent<start>().daystart();
        }
        else
        {
            a.GetComponent<start>().gamuovr();
        }
    }
    public void minus7()
    {
        para3 = para3 - 10;
        if (para1 > 0 && para2 > 0 && para3 > 0 && para4 > 0 && para5 > 0)
        {
            a.GetComponent<start>().daystart();
        }
        else
        {
            a.GetComponent<start>().gamuovr();
        }
    }
    public void minus8()
    {
        par2();
        para3 = para3 - 30;
        if (para1 > 0 && para2 > 0 && para3 > 0 && para4 > 0 && para5 > 0)
        {
            a.GetComponent<start>().daystart();
        }
        else
        {
            a.GetComponent<start>().gamuovr();
        }
    }
    public void minus9()
    {
        par2();
        para4 = para4 - 5;
        if (para1 > 0 && para2 > 0 && para3 > 0 && para4 > 0 && para5 > 0)
        {
            a.GetComponent<start>().daystart();
        }
        else
        {
            a.GetComponent<start>().gamuovr();
        }
    }
    public void minus10()
    {
        par2();
        para4 = para4 - 10;
        if (para1 > 0 && para2 > 0 && para3 > 0 && para4 > 0 && para5 > 0)
        {
            a.GetComponent<start>().daystart();
        }
        else
        {
            a.GetComponent<start>().gamuovr();
        }
    }
    public void minus11()
    {
        par2();
        para4 = para4 - 30;
        if (para1 > 0 && para2 > 0 && para3 > 0 && para4 > 0 && para5 > 0)
        {
            a.GetComponent<start>().daystart();
        }
        else
        {
            a.GetComponent<start>().gamuovr();
        }
    }
    public void minus12()
    {
        par2();
        para5 = para5 - 5;
        if (para1 > 0 && para2 > 0 && para3 > 0 && para4 > 0 && para5 > 0)
        {
            a.GetComponent<start>().daystart();
        }
        else
        {
            a.GetComponent<start>().gamuovr();
        }
    }
    public void minus13()
    {
        par2();
        para5 = para5 - 10;
        if (para1 > 0 && para2 > 0 && para3 > 0 && para4 > 0 && para5 > 0)
        {
            a.GetComponent<start>().daystart();
        }
        else
        {
            a.GetComponent<start>().gamuovr();
        }
    }
    public void minus14()
    {
        par2();
        para5 = para5 - 30;
        if (para1 > 0 && para2 > 0 && para3 > 0 && para4 > 0 && para5 > 0)
        {
            a.GetComponent<start>().daystart();
        }
        else
        {
            a.GetComponent<start>().gamuovr();
        }
    }
    public void minus15()
    {
        para1 = para1 - 52;
        para2 = para2 - 52;
        para3 = para3 - 52;
        para4 = para4 - 52;
        para5 = para5 - 52;
        if (para1 > 0 && para2 > 0 && para3 > 0 && para4 > 0 && para5 > 0)
        {
            a.GetComponent<start>().daystart();
        }
        else
        {
            a.GetComponent<start>().gamuovr();
        }
    }
    void par2()
    {
        para1 = para1 - 2;
        para3 = para3 - 2;
        para4 = para4 - 2;
        para5 = para5 - 2;
        para2 = para2 - 2;
    }
    public void mainaus()
    {
        sute1.GetComponentInChildren<TextMeshProUGUI>().text = para1.ToString();
        sute2.GetComponentInChildren<TextMeshProUGUI>().text = para2.ToString();
        sute3.GetComponentInChildren<TextMeshProUGUI>().text = para3.ToString();
        sute4.GetComponentInChildren<TextMeshProUGUI>().text = para4.ToString();
        sute5.GetComponentInChildren<TextMeshProUGUI>().text = para5.ToString();
    }
    public void iro()
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
