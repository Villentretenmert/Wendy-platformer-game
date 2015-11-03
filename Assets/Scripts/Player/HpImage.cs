using UnityEngine;
using System.Collections;

public class HpImage : MonoBehaviour {

    //----------------------------------------------------------------------------
    //связь с игроком
    public Transform _playerTransform;
    public SchetchikHeals SchetchikHeals;

    private void Start()
    {
        //связь с игроком
        transform.position = new Vector3(_playerTransform.position.x - 5, _playerTransform.position.y + 5, -5);
    }

    private void Update()
    {
        transform.position = new Vector3(_playerTransform.position.x - 5, _playerTransform.position.y + 5, -5);

        
        SpriteRenderer sp = GetComponent<SpriteRenderer>();

        if (SchetchikHeals.Heals == 10)
            sp.sprite = Resources.Load<Sprite>("Sprites/player/Hp/Health10");

        if (SchetchikHeals.Heals == 9)
            sp.sprite = Resources.Load<Sprite>("Sprites/player/Hp/Health9");

        if (SchetchikHeals.Heals == 8)
            sp.sprite = Resources.Load<Sprite>("Sprites/player/Hp/Health8");

        if (SchetchikHeals.Heals == 7)
            sp.sprite = Resources.Load<Sprite>("Sprites/player/Hp/Health7");

        if (SchetchikHeals.Heals == 6)
            sp.sprite = Resources.Load<Sprite>("Sprites/player/Hp/Health6");

        if (SchetchikHeals.Heals == 5)
            sp.sprite = Resources.Load<Sprite>("Sprites/player/Hp/Health5");

        if (SchetchikHeals.Heals == 4)
            sp.sprite = Resources.Load<Sprite>("Sprites/player/Hp/Health4");

        if (SchetchikHeals.Heals == 3)
            sp.sprite = Resources.Load<Sprite>("Sprites/player/Hp/Health3");

        if (SchetchikHeals.Heals == 2)
            sp.sprite = Resources.Load<Sprite>("Sprites/player/Hp/Health2");

        if (SchetchikHeals.Heals == 1)
            sp.sprite = Resources.Load<Sprite>("Sprites/player/Hp/Health1");

        if (SchetchikHeals.Heals == 0)
            sp.sprite = Resources.Load<Sprite>("Sprites/player/Hp/Health0");

    }
}
