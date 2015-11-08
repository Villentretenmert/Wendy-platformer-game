using UnityEngine;
using System.Collections;

public class SchetchikHeals : MonoBehaviour
{

    public  int Heals = 10;

    //-------------------------------------------
    //исчезновение персонажа и появление привидения
    public float Timer1;
    private float TimerDown;
    private float sobitieSmert=0;
    public AudioClip diedSound;

    private int HealsBilo = 0;
    private int HealsStalo = 0;
    private int ischezanieKrovi = 0;
    public GameObject Hpblood;

    public float Timer2;
    private float TimerDown2;

    //----------------------------------------------
    //надпись при поедании гриба
    public int videlaRaz = 0;
    public int Ugriba = 0;
    public float Timer3;
    public float TimerDown3;

    void Start()
    {
        TimerDown2 = Timer2;
        TimerDown = Timer1;
        TimerDown3 = Timer3;
        HealsBilo = Heals;
    }

    private void Update()
    {
       

        if (Heals == 0)
        {
            Hpblood.SetActive(false);
            SpriteRenderer sp = GetComponent<SpriteRenderer>();
            sp.sprite = Resources.Load<Sprite>("Sprites/object/wendyDied");
            if (sobitieSmert == 0)
            {
                GetComponent<AudioSource>().PlayOneShot(diedSound);
                sobitieSmert = 1;
            }

            if (TimerDown > 0) TimerDown -= Time.deltaTime; //Если время которое нужно отсчитать еще осталось убавляем от него время обновления экрана (в одну секунду будет убавляться полная единица)
            if (TimerDown < 0) TimerDown = 0; //Если временная переменная ушла в отрицательное число (все возможно) то приравниваем ее к нулю
            if (TimerDown == 0)
            {
               Application.LoadLevel("GameMenu");
            }
        }
        else
        {
            HealsStalo = Heals;

            if (HealsStalo > HealsBilo && videlaRaz == 0)
            {
                videlaRaz += 1;
                Ugriba = 1;
                
                
            }
            if(Ugriba ==1)
            {
                if (TimerDown3 > 0) TimerDown3 -= Time.deltaTime; //Если время которое нужно отсчитать еще осталось убавляем от него время обновления экрана (в одну секунду будет убавляться полная единица)
                if (TimerDown3 < 0) TimerDown3 = 0; //Если временная переменная ушла в отрицательное число (все возможно) то приравниваем ее к нулю
                if (TimerDown3 == 0)
                    Ugriba = 0;

            }

            if (HealsStalo < HealsBilo && Heals>0)
            {
                Hpblood.SetActive(true);
                ischezanieKrovi = 1;
            }
            HealsBilo = Heals;
            if (ischezanieKrovi == 1)
            {

               

                if (TimerDown2 > 0)
                    TimerDown2 -= 1; //Если время которое нужно отсчитать еще осталось убавляем от него время обновления экрана (в одну секунду будет убавляться полная единица)
                else
                {
                    ischezanieKrovi = 0;
                    Hpblood.SetActive(false);
                    TimerDown2 = Timer2;
                }
            }
            
        }
    }
}
