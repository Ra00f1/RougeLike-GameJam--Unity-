using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TorchadnDoorSc : MonoBehaviour
{ 
    public GameObject[] Walls;
   void Start()
    {
        int rand = Random.Range(0, Walls.Length);
        Instantiate(Walls[rand], transform.position, transform.rotation);
    }
}
