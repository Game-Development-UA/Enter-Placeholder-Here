using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoadChunkLevel : MonoBehaviour
{
    public Transform nextChunkLoc;
    public GameObject curChunk;
    //public GameObject nextChunk;
    public GameObject Prefab1;
    public GameObject Prefab2;
    public GameObject Prefab3;
     

    List<GameObject> prefabList = new List<GameObject>();

    void Start()
    {
        prefabList.Add(Prefab1);
        prefabList.Add(Prefab2);
        prefabList.Add(Prefab3);

        

    }

    void OnTriggerEnter(Collider col)
    {
        int prefabIndex = UnityEngine.Random.Range(0, 3);

        PlayerController player = col.GetComponent<PlayerController>();

        if (player)
        {
            GameObject newChunk = Instantiate(prefabList[prefabIndex]); //Instantiate<GameObject>(nextChunk);
            newChunk.transform.position = nextChunkLoc.position;

            Destroy(curChunk, 5f);
        }
    }
}
