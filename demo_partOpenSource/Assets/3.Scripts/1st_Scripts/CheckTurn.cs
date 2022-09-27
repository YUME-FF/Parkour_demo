using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckTurn : MonoBehaviour
{
    public static bool checkturn = false;
    public static int turn=0;
    // Start is called before the first frame update
    public void OnTriggerEnter(Collider turning)
    {
        if (turning.tag == "Player")
        {
            checkturn = true;
            turn++;
            print(turn);
            
        }
    }
    //private void OnTriggerExit(Collider turning)
    //{
    //    if (turning.tag == "Player")
    //    {
    //        checkturn = false;
    //        //turn = 0;
    //        //print(checkturn);

    //    }
    //}

}
