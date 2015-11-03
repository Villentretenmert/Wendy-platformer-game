using UnityEngine;
using System.Collections;

public class kolichestvoPredmetov1 : MonoBehaviour {

    //----------------------------------------------------------------------------
    //связь с игроком

    public SchetchicTsvetov SchetchicTsvetov;
   

    
    private void Update()
    {
        SpriteRenderer sp = GetComponent<SpriteRenderer>();

        if (SchetchicTsvetov.Sobrano == 0)
        {
            sp.sprite = Resources.Load<Sprite>("Sprites/player/Predmet/chislit/0");
            
        }

            if (SchetchicTsvetov.Sobrano == 1)
        { 
            sp.sprite = Resources.Load<Sprite>("Sprites/player/Predmet/chislit/1");
            
        }

        if (SchetchicTsvetov.Sobrano == 2)
        { 
            sp.sprite = Resources.Load<Sprite>("Sprites/player/Predmet/chislit/2");
           
        }

        if (SchetchicTsvetov.Sobrano == 3)
        { 
            sp.sprite = Resources.Load<Sprite>("Sprites/player/Predmet/chislit/3");
            
        }

        if (SchetchicTsvetov.Sobrano == 4)
        { 
            sp.sprite = Resources.Load<Sprite>("Sprites/player/Predmet/chislit/4");
            
        }

        if (SchetchicTsvetov.Sobrano == 5)
        { 
            sp.sprite = Resources.Load<Sprite>("Sprites/player/Predmet/chislit/5");
            
        }

        if (SchetchicTsvetov.Sobrano == 6)
        { 
            sp.sprite = Resources.Load<Sprite>("Sprites/player/Predmet/chislit/6");
            
        }

        if (SchetchicTsvetov.Sobrano == 7)
        { 
            sp.sprite = Resources.Load<Sprite>("Sprites/player/Predmet/chislit/7");
            
        }

        if (SchetchicTsvetov.Sobrano == 8)
        { 
            sp.sprite = Resources.Load<Sprite>("Sprites/player/Predmet/chislit/8");
           
        }

        if (SchetchicTsvetov.Sobrano == 9)
        { 
            sp.sprite = Resources.Load<Sprite>("Sprites/player/Predmet/chislit/9");
            
        }

        if (SchetchicTsvetov.Sobrano == 10)
        { 
            sp.sprite = Resources.Load<Sprite>("Sprites/player/Predmet/chislit/10");
            
        }

        if (SchetchicTsvetov.Sobrano == 11)
        { 
            sp.sprite = Resources.Load<Sprite>("Sprites/player/Predmet/chislit/11");
            
        }

        if (SchetchicTsvetov.Sobrano == 12)
        { 
            sp.sprite = Resources.Load<Sprite>("Sprites/player/Predmet/chislit/12");
            
        }

        if (SchetchicTsvetov.Sobrano == 13)
        { 
            sp.sprite = Resources.Load<Sprite>("Sprites/player/Predmet/chislit/13");
            
        }

        
    
    }
}

