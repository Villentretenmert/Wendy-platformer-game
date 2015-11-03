using UnityEngine;
using System.Collections;

public class KotelScript : MonoBehaviour
{
    
    public GameObject tefteli;
    public SchetchicEda SobrE;
    private int sobitieOgon = 0;
    public AudioClip tefteliSound;
    private int sobitieTefteli = 0;
    

    public float Timer; //Время в секундах которое отсчитает таймер
    private float TimerDown; //Изменяемая переменная для внутренних операций

    //-----------------------------------------------------------
    //переход на следующий уровень
    public PerehodNaUroven PerehodNaUroven;

    //-----------------------------------------------------------
    //обнуление статичных переменных
    public Palatka2 Palatka2;

    void Start()
    {
        TimerDown = Timer; //Задаем временной переменной значение которое нужно отсчитать
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            if (SobrE.SobranoEda == SobrE.maxEda)
            {
                SobrE.SobranoEda = 7;
                sobitieOgon = 1;
                SpriteRenderer sp = GetComponent<SpriteRenderer>();
                sp.sprite = Resources.Load<Sprite>("Sprites/object/22kotel");
                GetComponent<AudioSource>().PlayOneShot(tefteliSound);
            }

            
            
        }

    }

    void Update()
    {
        if (sobitieOgon == 1)
        {
            if (TimerDown > 0) TimerDown -= Time.deltaTime; //Если время которое нужно отсчитать еще осталось убавляем от него время обновления экрана (в одну секунду будет убавляться полная единица)
            if (TimerDown < 0) TimerDown = 0; //Если временная переменная ушла в отрицательное число (все возможно) то приравниваем ее к нулю
            if (TimerDown == 0)
            {
                TimerDown = Timer; //Благодаря этой строке таймер запустится заново после выполнения всех действий в скобках
                tefteli.SetActive(true);
                SpriteRenderer sp = GetComponent<SpriteRenderer>();
                sp.sprite = Resources.Load<Sprite>("Sprites/object/23kotel");
                sobitieTefteli = 1;
            }

        }

        if (sobitieTefteli == 1)
        {
            if (TimerDown > 0) TimerDown -= Time.deltaTime; //Если время которое нужно отсчитать еще осталось убавляем от него время обновления экрана (в одну секунду будет убавляться полная единица)
            if (TimerDown < 0) TimerDown = 0; //Если временная переменная ушла в отрицательное число (все возможно) то приравниваем ее к нулю
            if (TimerDown == 0)
            {
                TimerDown = Timer; //Благодаря этой строке таймер запустится заново после выполнения всех действий в скобках
                PerehodNaUroven.MaxVozmUroven = 3;

                Palatka2.SobranoDichi = 0;
                Palatka2.videlaRaz = 0;
    Application.LoadLevel("GameMenu");
            }

        }

    }

    
}