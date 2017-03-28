using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pathmaker : MonoBehaviour {

    int counter = 0;
    public Transform floorPrefab;
    public Transform floorPrefab2;
    public Transform floorPrefab3;
    Transform floorPrefabUse;
    public Transform pathmakerSphereTransform;
    float maxCounter;
    float distance;

    void Start()
    {
        maxCounter = Mathf.Floor(Random.Range(60f, 80f));
        distance = Random.Range(3.5f, 5f);
    }

	// Update is called once per frame
	void Update ()
    {
        float floorNum = Random.Range(0f, 2.5f);
        if (floorNum < 1.2)
        {
            floorPrefabUse = floorPrefab;
        }
        else if (floorNum < 2)
        {
            floorPrefabUse = floorPrefab2;
        }
        else
        {
            floorPrefabUse = floorPrefab3;
        }


        if(counter < maxCounter && TileCount.tileCount < 500)
        {
            float rand = Random.Range(0f, 1f);
            if(rand < .11)
            {
                transform.Rotate(0f, 90f, 0f);
            }
            else if (rand < .22)
            {
                transform.Rotate(0f, -90f, 0f);
            }
            else if (rand > .9)
            {
                Instantiate(pathmakerSphereTransform, transform.position, Quaternion.identity);
            }
            Instantiate(floorPrefabUse, transform.position, Quaternion.identity);
            TileCount.tileCount++;
            transform.Translate(Vector3.forward * distance);
            counter++;

        }
        else
        {
            Destroy(gameObject);
        }
	}
}
