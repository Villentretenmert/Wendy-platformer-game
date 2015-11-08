using UnityEngine;
using System.Collections;

public class diedflover : MonoBehaviour {


    public SchetchikHeals heals;
    public static int videlaRaz = 0;
    public static int UTsvetka = 0;

    private float Timer3=3;
    private float TimerDown3;

    void Start()
    {
       TimerDown3 = Timer3;
     }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player" )
        {
            if (heals.Heals > 0)
            {
                heals.Heals -= 1;
                if (videlaRaz == 0)
                {
                    UTsvetka = 1;
                    videlaRaz += 1;
                }
            }

        }
        
    }



    private void Update()
    {
        if (UTsvetka == 1)
        {
            if (TimerDown3 > 0) TimerDown3 -= Time.deltaTime; //Если время которое нужно отсчитать еще осталось убавляем от него время обновления экрана (в одну секунду будет убавляться полная единица)
            if (TimerDown3 < 0) TimerDown3 = 0; //Если временная переменная ушла в отрицательное число (все возможно) то приравниваем ее к нулю
            if (TimerDown3 == 0)
                UTsvetka = 0;
        }
    }
    }
