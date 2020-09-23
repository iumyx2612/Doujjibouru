using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NextLvTrigger : MonoBehaviour
{
    public GameManagement gM;
   
    void OnTriggerEnter()
    {        
        gM.NextLevel();
    }
   
}
