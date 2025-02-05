using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
public class ClickSpriteKill : MonoBehaviour
{
    int CurrentHp = 10;
    int Damage = 2;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            CurrentHp = CurrentHp - Damage;
            

        
        }
        if (CurrentHp ==0) 
        {
            Destroy(gameObject);
        }
        Debug.Log(CurrentHp);

    }
}
