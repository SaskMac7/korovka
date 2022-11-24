using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR;
using Valve.VR.InteractionSystem;

public class Wash : MonoBehaviour
{
    public GameObject partWater;
    public GameObject RHandPlace;

    public bool isTookShlang;


    void Start()
    {

    }


    void Update()
    {

    }

    private void OnHandHoverBegin(Hand hand)
    {

        if (hand.name == "LeftHand")
        {
            Debug.Log("Дотронулся левой");
        }

        if (hand.name == "RightHand")
        {
            Debug.Log("Дотронулся правой");
        }

    }


    private void OnAttachedToHand(Hand hand)
    {
        if (hand.name == "LeftHand")
        {
            Debug.Log("Взял в левую");
        }

        if (hand.name == "RightHand")
        {
            Debug.Log("Взял в правую");

            isTookShlang = true;
            transform.SetParent(RHandPlace.transform.transform);

            /*           if (isTookShlang == true)
                       {
                           transform.SetParent(null);
                       }*/


        }
    }

    public void StartWash()
    {
        Instantiate(partWater,
            new Vector3(transform.position.x, transform.position.y, transform.position.z),
            Quaternion.identity);
    }

}