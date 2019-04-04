using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoadChunkLevel : MonoBehaviour
{
    public Transform nextChunkLoc;
    public GameObject curChunk;
    public GameObject nextChunk;

    private void OnTriggerEnter(Collider col)
    {
        PlayerController player = col.GetComponent<PlayerController>();

        if (player)
        {
            GameObject newChunk = Instantiate<GameObject>(nextChunk);
            newChunk.transform.position = nextChunkLoc.position;

            Destroy(curChunk, 5f);
        }
    }
}
