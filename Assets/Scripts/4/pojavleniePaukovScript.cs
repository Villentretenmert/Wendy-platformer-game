using UnityEngine;
using System.Collections;

public class pojavleniePaukovScript : MonoBehaviour {

    public GameObject pauk1;
    private float ubijstvoPauka1=0;
    public GameObject pauk2;
    private float ubijstvoPauka2 = 0;
    public GameObject pauk3;
    private float ubijstvoPauka3 = 0;
    public GameObject pauk4;
    private float ubijstvoPauka4 = 0;
    public GameObject pauk5;
    private float ubijstvoPauka5 = 0;
    public GameObject pauk6;
    private float ubijstvoPauka6 = 0;

    public GameObject paukan1;
    private float ubijstvoPaukana1 = 0;

    public paukScript pauk1Script;
    public paukScript pauk2Script;
    public paukScript pauk3Script;
    public paukScript pauk4Script;
    public paukScript pauk5Script;
    public paukScript pauk6Script;

    public float Timer1;
    public float Timer2;
    private float TimerDown; //Изменяемая переменная для внутренних операций

    public AudioClip krikPaukaSound;

    void Start()
    {
        TimerDown = Timer1; //Задаем временной переменной значение которое нужно отсчитать
        GetComponent<AudioSource>().PlayOneShot(krikPaukaSound);
    }


    void Update()
    {
        //1
        if (ubijstvoPauka1 == 0)
        {
            
            if (TimerDown > 0) TimerDown -= Time.deltaTime; //Если время которое нужно отсчитать еще осталось убавляем от него время обновления экрана (в одну секунду будет убавляться полная единица)
            if (TimerDown < 0) TimerDown = 0; //Если временная переменная ушла в отрицательное число (все возможно) то приравниваем ее к нулю
            if (TimerDown == 0)
            {
                TimerDown = Timer1; //Благодаря этой строке таймер запустится заново после выполнения всех действий в скобках

                pauk1.SetActive(true);//Сюда дописываем действия которые произойдут после конца отсчета
                ubijstvoPauka1 = 1;
            }
        }
        //2
        if (ubijstvoPauka1 == 1 && ubijstvoPauka2 == 0 && pauk1Script.HpPauka == 0)
        {
            if (TimerDown > 0) TimerDown -= Time.deltaTime; //Если время которое нужно отсчитать еще осталось убавляем от него время обновления экрана (в одну секунду будет убавляться полная единица)
            if (TimerDown < 0) TimerDown = 0; //Если временная переменная ушла в отрицательное число (все возможно) то приравниваем ее к нулю
            if (TimerDown == 0)
            {
                TimerDown = Timer1; //Благодаря этой строке таймер запустится заново после выполнения всех действий в скобках

                pauk2.SetActive(true);//Сюда дописываем действия которые произойдут после конца отсчета
                ubijstvoPauka2 = 1;
            }
        }
        //3
        if (ubijstvoPauka1 == 1 && ubijstvoPauka2 == 1 && ubijstvoPauka3 == 0 )
        {
            if (TimerDown > 0) TimerDown -= Time.deltaTime; //Если время которое нужно отсчитать еще осталось убавляем от него время обновления экрана (в одну секунду будет убавляться полная единица)
            if (TimerDown < 0) TimerDown = 0; //Если временная переменная ушла в отрицательное число (все возможно) то приравниваем ее к нулю
            if (TimerDown == 0)
            {
                TimerDown = Timer1; //Благодаря этой строке таймер запустится заново после выполнения всех действий в скобках

                pauk3.SetActive(true);//Сюда дописываем действия которые произойдут после конца отсчета
                ubijstvoPauka3 = 1;
            }
        }
        //4
        if (ubijstvoPauka1 == 1 && ubijstvoPauka2 == 1 && ubijstvoPauka3 == 1 && ubijstvoPauka4 == 0 && pauk3Script.HpPauka == 0 && pauk2Script.HpPauka == 0)
        {
            if (TimerDown > 0) TimerDown -= Time.deltaTime; //Если время которое нужно отсчитать еще осталось убавляем от него время обновления экрана (в одну секунду будет убавляться полная единица)
            if (TimerDown < 0) TimerDown = 0; //Если временная переменная ушла в отрицательное число (все возможно) то приравниваем ее к нулю
            if (TimerDown == 0)
            {
                TimerDown = Timer1; //Благодаря этой строке таймер запустится заново после выполнения всех действий в скобках

                pauk4.SetActive(true);//Сюда дописываем действия которые произойдут после конца отсчета
                ubijstvoPauka4 = 1;
            }
        }
        //5
        if (ubijstvoPauka1 == 1 && ubijstvoPauka2 == 1 && ubijstvoPauka3 == 1 && ubijstvoPauka4 == 1 && ubijstvoPauka5 == 0)
        {
            if (TimerDown > 0) TimerDown -= Time.deltaTime; //Если время которое нужно отсчитать еще осталось убавляем от него время обновления экрана (в одну секунду будет убавляться полная единица)
            if (TimerDown < 0) TimerDown = 0; //Если временная переменная ушла в отрицательное число (все возможно) то приравниваем ее к нулю
            if (TimerDown == 0)
            {
                TimerDown = Timer1; //Благодаря этой строке таймер запустится заново после выполнения всех действий в скобках

                pauk5.SetActive(true);//Сюда дописываем действия которые произойдут после конца отсчета
                ubijstvoPauka5 = 1;
            }
        }
        //6
        if (ubijstvoPauka1 == 1 && ubijstvoPauka2 == 1 && ubijstvoPauka3 == 1 && ubijstvoPauka4 == 1 && ubijstvoPauka5 == 1 && ubijstvoPauka6 == 0)
        {
            if (TimerDown > 0) TimerDown -= Time.deltaTime; //Если время которое нужно отсчитать еще осталось убавляем от него время обновления экрана (в одну секунду будет убавляться полная единица)
            if (TimerDown < 0) TimerDown = 0; //Если временная переменная ушла в отрицательное число (все возможно) то приравниваем ее к нулю
            if (TimerDown == 0)
            {
                TimerDown = Timer2; //Благодаря этой строке таймер запустится заново после выполнения всех действий в скобках

                pauk6.SetActive(true);//Сюда дописываем действия которые произойдут после конца отсчета
                ubijstvoPauka6 = 1;
            }
        }
        //7
        if (ubijstvoPaukana1 ==0 && pauk4Script.HpPauka == 0 && pauk5Script.HpPauka == 0 && pauk6Script.HpPauka == 0)
        {
            if (TimerDown > 0) TimerDown -= Time.deltaTime; //Если время которое нужно отсчитать еще осталось убавляем от него время обновления экрана (в одну секунду будет убавляться полная единица)
            if (TimerDown < 0) TimerDown = 0; //Если временная переменная ушла в отрицательное число (все возможно) то приравниваем ее к нулю
            if (TimerDown == 0)
            {
                TimerDown = Timer2; //Благодаря этой строке таймер запустится заново после выполнения всех действий в скобках

                paukan1.SetActive(true);//Сюда дописываем действия которые произойдут после конца отсчета
                GetComponent<AudioSource>().PlayOneShot(krikPaukaSound);
                ubijstvoPaukana1 = 1;
            }
        }
    }
}
