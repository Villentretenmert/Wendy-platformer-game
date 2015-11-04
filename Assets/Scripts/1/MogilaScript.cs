using UnityEngine;
using System.Collections;

public class MogilaScript : MonoBehaviour {

    public GameObject Venok;
    public GameObject Sister;
    public SchetchicTsvetov Sobr;

    private int sobitieVenok = 0;
    private int sobitieSister = 0;
    
    public float Timer1; //Время в секундах которое отсчитает таймер
    public float TimerDown; //Изменяемая переменная для внутренних операций

    //-----------------------------------------------------------
    //переход на следующий уровень
    public PerehodNaUroven PerehodNaUroven;
     
    void Start()
    {
        TimerDown = Timer1; //Задаем временной переменной значение которое нужно отсчитать
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            if (Sobr.Sobrano == Sobr.maxTsvetov)
            {
                sobitieVenok = 1;
                Sobr.Sobrano = 14;
                Venok.SetActive(true);
                PerehodNaUroven.ZapretDvijenia = 1;
                           
            }
                    }
    }


    void Update()
    {
        if (sobitieVenok == 1 && sobitieSister == 0)
        {
            if (TimerDown > 0) TimerDown -= Time.deltaTime; //Если время которое нужно отсчитать еще осталось убавляем от него время обновления экрана (в одну секунду будет убавляться полная единица)
            if (TimerDown < 0) TimerDown = 0; //Если временная переменная ушла в отрицательное число (все возможно) то приравниваем ее к нулю
            if (TimerDown == 0)
            {
                Timer1 += 1;
                TimerDown = Timer1; //Благодаря этой строке таймер запустится заново после выполнения всех действий в скобках
                Sister.SetActive(true);//Сюда дописываем действия которые произойдут после конца отсчета
                
                sobitieSister = 1;
            }
                    }
        if (sobitieSister == 1)
        {
            if (TimerDown > 0) TimerDown -= Time.deltaTime; //Если время которое нужно отсчитать еще осталось убавляем от него время обновления экрана (в одну секунду будет убавляться полная единица)
            if (TimerDown < 0) TimerDown = 0; //Если временная переменная ушла в отрицательное число (все возможно) то приравниваем ее к нулю
            if (TimerDown == 0)
            {
                PerehodNaUroven.MaxVozmUroven = 2;
                PerehodNaUroven.ZapretDvijenia = 0;
                Application.LoadLevel("GameMenu");

            }
                    }
    }

    
}
