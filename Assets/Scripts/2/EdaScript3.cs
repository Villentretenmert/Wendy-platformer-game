using UnityEngine;
using System.Collections;

public class EdaScript3 : MonoBehaviour

{

    public float edaSpeed = 1f;
    public GameObject eda;
    public SchetchicEda SobrE;
    public SchetchikHeals SchetchikHeals;
    public float nachTochka = 1f;

    private float tekTochka = 1f;
    private float proshTochka = 1f;

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player" && SchetchikHeals.Heals > 0)
        {
            if (SobrE.SobranoEda < SobrE.maxEda)
            {
                SobrE.SobranoEda += 1;
                eda.SetActive(false);
            }
            else
                Debug.Log("mne hvataet dichi dla edi");
        }

    }

    private void Start()
    {
        nachTochka = GetComponent<Transform>().position.x;
        proshTochka = nachTochka;
    }

    private void FixedUpdate()
    {
        SpriteRenderer sp = GetComponent<SpriteRenderer>();
        tekTochka = GetComponent<Transform>().position.x;

        float otnositPosition = GetComponent<Transform>().position.x - nachTochka;
       // Debug.Log(otnositPosition);

        if (otnositPosition < 3 && otnositPosition > -3)
        {
            GetComponent<Rigidbody2D>().AddForce(new Vector2(edaSpeed, 0));
            //sp.sprite= Resources.Load<Sprite>("Sprites/object/eda/1eda1");
        }

        if (otnositPosition > 3)
        {
            GetComponent<Rigidbody2D>().AddForce(new Vector2(-edaSpeed, 0));
            //sp.sprite = Resources.Load<Sprite>("Sprites/object/eda/1eda2");
        }

        if (otnositPosition < -3)
        {
            GetComponent<Rigidbody2D>().AddForce(new Vector2(-edaSpeed, 0));
            //sp.sprite = Resources.Load<Sprite>("Sprites/object/eda/1eda2");
        }


        if (tekTochka < proshTochka)
            sp.sprite = Resources.Load<Sprite>("Sprites/object/eda/3eda2");

        else
            sp.sprite = Resources.Load<Sprite>("Sprites/object/eda/3eda1");

        proshTochka = tekTochka;

    }
}
