using UnityEngine;
using System.Collections;

public class enotVpalatke : MonoBehaviour
{

    //-----------------------------------------------------------
    // все предметы
    public GameObject predmet1;
    public int predmet1enot = 0;

    public GameObject predmet2;
    public int predmet2enot = 0;

    public GameObject predmet3;
    public int predmet3enot = 0;

    public GameObject predmet4;
    public int predmet4enot = 0;

    public GameObject predmet5;
    public int predmet5enot = 0;

    public GameObject predmet6;
    public int predmet6enot = 0;

    public GameObject predmet7;
    public int predmet7enot = 0;

    public GameObject predmet9;
    public int predmet9enot = 0;

    public GameObject predmet10;
    public int predmet10enot = 0;

    public GameObject predmet11;
    public int predmet11enot = 0;

    public GameObject predmet12;
    public int predmet12enot = 0;

    public GameObject predmet13;
    public int predmet13enot = 0;

    public GameObject predmet14;
    public int predmet14enot = 0;


    public enot enot;
    public AudioClip enotSound;
    private int audioenot = 0;
    //-----------------------------------------------------------
    //таймер


    public float Timer1;
    private float TimerDown1; //Изменяемая переменная для внутренних операций

    private float Timer2 = 3;
    private float TimerDown2;
    //-----------------------------------------------------------
    // случайная величина
    public float NomerPredmet = 0;
    public float lastNomerPredmet = 0;

    //-----------------------------------------------------------
    // жизни енота
    public int EnotLife = 0;

    public int konez = 0;
    void Start()
    {
        TimerDown1 = Timer1; //Задаем временной переменной значение которое нужно отсчитать
        TimerDown2 = Timer2;
    }



    void Update()
    {


        if (EnotLife < 5 && enot.vidimiEnot == 0)
        {
            if (audioenot == 0)
            {
                GetComponent<AudioSource>().PlayOneShot(enotSound);
                audioenot = 1;
            }

            if (TimerDown1 > 0) TimerDown1 -= Time.deltaTime; //Если время которое нужно отсчитать еще осталось убавляем от него время обновления экрана (в одну секунду будет убавляться полная единица)
            if (TimerDown1 < 0) TimerDown1 = 0; //Если временная переменная ушла в отрицательное число (все возможно) то приравниваем ее к нулю
            if (TimerDown1 == 0)
            {
                TimerDown1 = Timer1 * Random.Range(0.5f, 2f); //Благодаря этой строке таймер запустится заново после выполнения всех действий в скобках


                NomerPredmet = Mathf.Ceil(Random.Range(0f, 14f));

                if (NomerPredmet == 1)
                {
                    SpriteRenderer sp1 = predmet1.GetComponent<SpriteRenderer>();
                    sp1.sprite = Resources.Load<Sprite>("enotVpalatke/1e");
                    predmet1enot = 1;
                }
                else if (NomerPredmet == 2)
                {
                    SpriteRenderer sp2 = predmet2.GetComponent<SpriteRenderer>();
                    sp2.sprite = Resources.Load<Sprite>("enotVpalatke/2e");
                    predmet2enot = 1;
                }
                else if (NomerPredmet == 3)
                {
                    SpriteRenderer sp3 = predmet3.GetComponent<SpriteRenderer>();
                    sp3.sprite = Resources.Load<Sprite>("enotVpalatke/3e");
                    predmet3enot = 1;
                }
                else if (NomerPredmet == 4)
                {
                    SpriteRenderer sp4 = predmet4.GetComponent<SpriteRenderer>();
                    sp4.sprite = Resources.Load<Sprite>("enotVpalatke/4e");
                    predmet4enot = 1;
                }
                else if (NomerPredmet == 5)
                {
                    SpriteRenderer sp5 = predmet5.GetComponent<SpriteRenderer>();
                    sp5.sprite = Resources.Load<Sprite>("enotVpalatke/5e");
                    predmet5enot = 1;
                }
                else if (NomerPredmet == 6)
                {
                    SpriteRenderer sp6 = predmet6.GetComponent<SpriteRenderer>();
                    sp6.sprite = Resources.Load<Sprite>("enotVpalatke/6e");
                    predmet6enot = 1;
                }
                else if (NomerPredmet == 7)
                {
                    SpriteRenderer sp7 = predmet7.GetComponent<SpriteRenderer>();
                    sp7.sprite = Resources.Load<Sprite>("enotVpalatke/7e");
                    predmet7enot = 1;
                }
                else if (NomerPredmet == 9)
                {
                    SpriteRenderer sp9 = predmet9.GetComponent<SpriteRenderer>();
                    sp9.sprite = Resources.Load<Sprite>("enotVpalatke/9e");
                    predmet9enot = 1;
                }

                else if (NomerPredmet == 10)
                {
                    SpriteRenderer sp10 = predmet10.GetComponent<SpriteRenderer>();
                    sp10.sprite = Resources.Load<Sprite>("enotVpalatke/10e");
                    predmet10enot = 1;
                }
                else if (NomerPredmet == 11)
                {
                    SpriteRenderer sp11 = predmet11.GetComponent<SpriteRenderer>();
                    sp11.sprite = Resources.Load<Sprite>("enotVpalatke/11e");
                    predmet11enot = 1;
                }
                else if (NomerPredmet == 12)
                {
                    SpriteRenderer sp12 = predmet12.GetComponent<SpriteRenderer>();
                    sp12.sprite = Resources.Load<Sprite>("enotVpalatke/12e");
                    predmet12enot = 1;
                }
                else if (NomerPredmet == 13)
                {
                    SpriteRenderer sp13 = predmet13.GetComponent<SpriteRenderer>();
                    sp13.sprite = Resources.Load<Sprite>("enotVpalatke/13e");
                    predmet13enot = 1;
                }
                else if (NomerPredmet == 14)
                {
                    SpriteRenderer sp14 = predmet14.GetComponent<SpriteRenderer>();
                    sp14.sprite = Resources.Load<Sprite>("enotVpalatke/14e");
                    predmet14enot = 1;
                }


                if (lastNomerPredmet == 1)
                {
                    SpriteRenderer sp1e = predmet1.GetComponent<SpriteRenderer>();
                    sp1e.sprite = Resources.Load<Sprite>("enotVpalatke/1");
                                    }
                else if (lastNomerPredmet == 2)
                {
                    SpriteRenderer sp2e = predmet2.GetComponent<SpriteRenderer>();
                    sp2e.sprite = Resources.Load<Sprite>("enotVpalatke/2");
                    }
                else if (lastNomerPredmet == 3)
                {
                    SpriteRenderer sp3e = predmet3.GetComponent<SpriteRenderer>();
                    sp3e.sprite = Resources.Load<Sprite>("enotVpalatke/3");
                    }
                else if (lastNomerPredmet == 4)
                {
                    SpriteRenderer sp4e = predmet4.GetComponent<SpriteRenderer>();
                    sp4e.sprite = Resources.Load<Sprite>("enotVpalatke/4");
                    }
                else if (lastNomerPredmet == 5)
                {
                    SpriteRenderer sp5e = predmet5.GetComponent<SpriteRenderer>();
                    sp5e.sprite = Resources.Load<Sprite>("enotVpalatke/5");
                    }
                else if (lastNomerPredmet == 6)
                {
                    SpriteRenderer sp6e = predmet6.GetComponent<SpriteRenderer>();
                    sp6e.sprite = Resources.Load<Sprite>("enotVpalatke/6");
                   }
                else if (lastNomerPredmet == 7)
                {
                    SpriteRenderer sp7e = predmet7.GetComponent<SpriteRenderer>();
                    sp7e.sprite = Resources.Load<Sprite>("enotVpalatke/7");
                  }
                else if (lastNomerPredmet == 9)
                {
                    SpriteRenderer sp9e = predmet9.GetComponent<SpriteRenderer>();
                    sp9e.sprite = Resources.Load<Sprite>("enotVpalatke/9");
                    }
                else if (lastNomerPredmet == 10)
                {
                    SpriteRenderer sp10e = predmet10.GetComponent<SpriteRenderer>();
                    sp10e.sprite = Resources.Load<Sprite>("enotVpalatke/10");
                   }
                else if (lastNomerPredmet == 11)
                {
                    SpriteRenderer sp11e = predmet11.GetComponent<SpriteRenderer>();
                    sp11e.sprite = Resources.Load<Sprite>("enotVpalatke/11");
                  }
                else if (lastNomerPredmet == 12)
                {
                    SpriteRenderer sp12e = predmet12.GetComponent<SpriteRenderer>();
                    sp12e.sprite = Resources.Load<Sprite>("enotVpalatke/12");
                  }
                else if (lastNomerPredmet == 13)
                {
                    SpriteRenderer sp13e = predmet13.GetComponent<SpriteRenderer>();
                    sp13e.sprite = Resources.Load<Sprite>("enotVpalatke/13");
                }
                else if (lastNomerPredmet == 14)
                {
                    SpriteRenderer sp14e = predmet14.GetComponent<SpriteRenderer>();
                    sp14e.sprite = Resources.Load<Sprite>("enotVpalatke/14");
                 }


                lastNomerPredmet = NomerPredmet;
            }


        }

        if (EnotLife == 5)
        {
            if (lastNomerPredmet == 1)
            {
                SpriteRenderer sp1e = predmet1.GetComponent<SpriteRenderer>();
                sp1e.sprite = Resources.Load<Sprite>("enotVpalatke/1");
                predmet1enot = 0;
            }
            else if (lastNomerPredmet == 2)
            {
                SpriteRenderer sp2e = predmet2.GetComponent<SpriteRenderer>();
                sp2e.sprite = Resources.Load<Sprite>("enotVpalatke/2");
                predmet2enot = 0;
            }
            else if (lastNomerPredmet == 3)
            {
                SpriteRenderer sp3e = predmet3.GetComponent<SpriteRenderer>();
                sp3e.sprite = Resources.Load<Sprite>("enotVpalatke/3");
                predmet3enot = 0;
            }
            else if (lastNomerPredmet == 4)
            {
                SpriteRenderer sp4e = predmet4.GetComponent<SpriteRenderer>();
                sp4e.sprite = Resources.Load<Sprite>("enotVpalatke/4");
                predmet4enot = 0;
            }
            else if (lastNomerPredmet == 5)
            {
                SpriteRenderer sp5e = predmet5.GetComponent<SpriteRenderer>();
                sp5e.sprite = Resources.Load<Sprite>("enotVpalatke/5");
                predmet5enot = 0;
            }
            else if (lastNomerPredmet == 6)
            {
                SpriteRenderer sp6e = predmet6.GetComponent<SpriteRenderer>();
                sp6e.sprite = Resources.Load<Sprite>("enotVpalatke/6");
                predmet6enot = 0;
            }
            else if (lastNomerPredmet == 7)
            {
                SpriteRenderer sp7e = predmet7.GetComponent<SpriteRenderer>();
                sp7e.sprite = Resources.Load<Sprite>("enotVpalatke/7");
                predmet7enot = 0;
            }
            else if (lastNomerPredmet == 9)
            {
                SpriteRenderer sp9e = predmet9.GetComponent<SpriteRenderer>();
                sp9e.sprite = Resources.Load<Sprite>("enotVpalatke/9");
                predmet9enot = 0;
            }
            else if (lastNomerPredmet == 10)
            {
                SpriteRenderer sp10e = predmet10.GetComponent<SpriteRenderer>();
                sp10e.sprite = Resources.Load<Sprite>("enotVpalatke/10");
                predmet10enot = 0;
            }
            else if (lastNomerPredmet == 11)
            {
                SpriteRenderer sp11e = predmet11.GetComponent<SpriteRenderer>();
                sp11e.sprite = Resources.Load<Sprite>("enotVpalatke/11");
                predmet11enot = 0;
            }
            else if (lastNomerPredmet == 12)
            {
                SpriteRenderer sp12e = predmet12.GetComponent<SpriteRenderer>();
                sp12e.sprite = Resources.Load<Sprite>("enotVpalatke/12");
                predmet12enot = 0;
            }
            else if (lastNomerPredmet == 13)
            {
                SpriteRenderer sp13e = predmet13.GetComponent<SpriteRenderer>();
                sp13e.sprite = Resources.Load<Sprite>("enotVpalatke/13");
                predmet13enot = 0;
            }
            else if (lastNomerPredmet == 14)
            {
                SpriteRenderer sp14e = predmet14.GetComponent<SpriteRenderer>();
                sp14e.sprite = Resources.Load<Sprite>("enotVpalatke/14");
                predmet14enot = 0;
            }

            konez = 1;

            if (TimerDown2 > 0) TimerDown2 -= Time.deltaTime; //Если время которое нужно отсчитать еще осталось убавляем от него время обновления экрана (в одну секунду будет убавляться полная единица)
            if (TimerDown2 < 0) TimerDown2 = 0; //Если временная переменная ушла в отрицательное число (все возможно) то приравниваем ее к нулю
            if (TimerDown2 == 0)
            {

                
                Application.LoadLevel("2Noon");//Сюда дописываем действия которые произойдут после конца отсчета
        
            }
        }
    }
}
