using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnCaws : MonoBehaviour
{
    public GameObject[] CowArr;
    public GameObject Cow;
    public GameObject tempCow;

    public float xPos;
    public float yPos;
    public int cows;
    void Start()
    {
        cows = Random.Range(4, 8);
        xPos = transform.position.x;

        SpawnCows();
    }

    void Update()
    {
        
    }

    public void SpawnCows()
    {
        for (int i = 0; i < cows; i++)
        {
            xPos += 3.5f;
            tempCow = Instantiate(CowArr[Random.Range(0,2)], new Vector3(xPos , transform.position.y, transform.position.z), Quaternion.identity);
            tempCow.transform.Rotate(0, 180,0, Space.Self);
        }
    }
}
