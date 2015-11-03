using UnityEngine;
using System.Collections;

public class ShetchicPaukov : MonoBehaviour
{

    public int maxPaukov = 7;
    public int SobranoPaukov = 0;


    public float Timer1;
    private float TimerDown; //Изменяемая переменная для внутренних операций

    //--------------------------------------------------------------------
    //мелодия на каждый сбор пауков

    public int PaukovBilo = 0;
    public int PaukovStalo = 0;

    public SchetchikHeals SchetchikHeals;

    public AudioClip paukSound;
    public AudioClip WinSound;
    private void Start()
    {
        PaukovBilo = 0;
        TimerDown = Timer1;
    }

    private void Update()
    {
        PaukovStalo = SobranoPaukov;
        if (PaukovStalo != PaukovBilo && SobranoPaukov < 8)
            GetComponent<AudioSource>().PlayOneShot(paukSound);
        

        if (SobranoPaukov == 7)
        {
            if ( PaukovBilo == 6)
                GetComponent<AudioSource>().PlayOneShot(WinSound);

            if (TimerDown > 0) TimerDown -= Time.deltaTime; //Если время которое нужно отсчитать еще осталось убавляем от него время обновления экрана (в одну секунду будет убавляться полная единица)
            if (TimerDown < 0) TimerDown = 0; //Если временная переменная ушла в отрицательное число (все возможно) то приравниваем ее к нулю
            if (TimerDown == 0)
            {
                TimerDown = Timer1; //Благодаря этой строке таймер запустится заново после выполнения всех действий в скобках
                if(SchetchikHeals.Heals > 0)
                    Application.LoadLevel("konez1");//Сюда дописываем действия которые произойдут после конца отсчета
                else
                    Application.LoadLevel("konez2");
            }
        }
        PaukovBilo = SobranoPaukov;
    }
}
