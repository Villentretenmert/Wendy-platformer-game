using UnityEngine;
using System.Collections;

public class abigailMoveScript : MonoBehaviour {
   
    //----------------------------------------------------------------------------
    //поворот персонажа
    private float tekTochkaX = 1f;
    private float proshTochkaX = 1f;
    //----------------------------------------------------------------------------
    //связь с игроком
    public Transform _playerTransform;
    //----------------------------------------------------------------------------
    //вращение
    public float radius=2;
    public float SkorostVrashenia = 1;
    private float RealSkorostVrashenia = 1;
    private float NapravlenieVrashenia = 1;

    private float Angle = 135;
    private float AngleRad;
    private float AbiailX;
    private float AbiailY;


    //----------------------------------------------------------------------------------
    //успокоение
    public ShetchicPaukov ShetchicPaukov;

    private void Start()
    {
        RealSkorostVrashenia = SkorostVrashenia;
        AngleRad = Angle * Mathf.Deg2Rad;
        AbiailX=Mathf.Cos(AngleRad) * radius;

        AbiailY = Mathf.Sin(AngleRad) * radius;
        //связь с игроком
        transform.position = new Vector3(_playerTransform.position.x + AbiailX, _playerTransform.position.y + AbiailY, -1);

        proshTochkaX = _playerTransform.position.x;
    }


    

    private void FixedUpdate()
    {
        tekTochkaX = _playerTransform.position.x;

        

        if (tekTochkaX == proshTochkaX)
            RealSkorostVrashenia = SkorostVrashenia;
        else
            RealSkorostVrashenia = 3*SkorostVrashenia;


        if (Angle < 360)
        {
            AngleRad = Angle * Mathf.Deg2Rad;
            AbiailX = Mathf.Cos(AngleRad) * radius;

            AbiailY = Mathf.Sin(AngleRad) * radius;
            //связь с игроком
            transform.position = new Vector3(_playerTransform.position.x + AbiailX, _playerTransform.position.y + AbiailY, -1);
            Angle += 1* RealSkorostVrashenia * NapravlenieVrashenia;
        }
        else
            Angle = 0;
        proshTochkaX = _playerTransform.position.x;

        if (ShetchicPaukov.SobranoPaukov == 7)
        {
            SpriteRenderer sp = GetComponent<SpriteRenderer>();
            sp.sprite = Resources.Load<Sprite>("Sprites/object/1abigail");
        }

    }
    }
