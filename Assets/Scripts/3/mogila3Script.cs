using UnityEngine;
using System.Collections;

public class mogila3Script : MonoBehaviour {

    public GameObject patno;
    public GameObject sister3;
    public SchetchicVoron SchetchicVoron;

    private int sobitieKrov = 0;
    private int sobitieBesheniPrizrak = 0;

    
    public float Timer1; //Время в секундах которое отсчитает таймер
    private float TimerDown; //Изменяемая переменная для внутренних операций

    //-----------------------------------------------------------
    //переход на следующий уровень
    public PerehodNaUroven PerehodNaUroven;

    //-----------------------------------------------------------
    //обнуление статичных переменных
    public diedflover diedflover;

    public AudioClip abigail3Sound;

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            if (SchetchicVoron.SobranoVoron == SchetchicVoron.maxVoron)
            {
                PerehodNaUroven.ZapretDvijenia = 1;
                sobitieKrov = 1;
                SpriteRenderer sp = GetComponent<SpriteRenderer>();
                sp.sprite = Resources.Load<Sprite>("Sprites/object/1mogila2");
                GetComponent<AudioSource>().PlayOneShot(abigail3Sound);
            }
           
        }
    }

    void Start()
    {
        TimerDown = Timer1; //Задаем временной переменной значение которое нужно отсчитать
    }

    void Update()
    {
        if (sobitieKrov == 1 && sobitieBesheniPrizrak == 0)
        {
            if (TimerDown > 0) TimerDown -= Time.deltaTime; //Если время которое нужно отсчитать еще осталось убавляем от него время обновления экрана (в одну секунду будет убавляться полная единица)
            if (TimerDown < 0) TimerDown = 0; //Если временная переменная ушла в отрицательное число (все возможно) то приравниваем ее к нулю
            if (TimerDown == 0)
            {
                Timer1 += 1;
                TimerDown = Timer1; //Благодаря этой строке таймер запустится заново после выполнения всех действий в скобках

                sister3.SetActive(true);//Сюда дописываем действия которые произойдут после конца отсчета

                sobitieBesheniPrizrak = 1;
            }

        }
        if (sobitieBesheniPrizrak == 1)
        {
            if (TimerDown > 0) TimerDown -= Time.deltaTime; //Если время которое нужно отсчитать еще осталось убавляем от него время обновления экрана (в одну секунду будет убавляться полная единица)
            if (TimerDown < 0) TimerDown = 0; //Если временная переменная ушла в отрицательное число (все возможно) то приравниваем ее к нулю
            if (TimerDown == 0)
            {
                PerehodNaUroven.MaxVozmUroven = 4;
                PerehodNaUroven.ZapretDvijenia = 0;
                diedflover.UTsvetka = 0;

                diedflover.videlaRaz = 0;

                Application.LoadLevel("GameMenu");

            }

        }
    }

    
}
