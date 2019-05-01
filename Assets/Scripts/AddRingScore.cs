using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddRingScore : MonoBehaviour
{
    public GameObject ring;
    public GameObject ring1;
    public GameObject ring2;
    public GameObject ring3;
    public GameObject ring4;
    public GameObject ring5;


    private void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.name == "Player")
            this.transform.parent = col.transform;
            Score.singleton.SetScore(10);
    }

}
