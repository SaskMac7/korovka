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
            Debug.Log("���������� �����");
        }

        if (hand.name == "RightHand")
        {
            Debug.Log("���������� ������");
        }

    }


    private void OnAttachedToHand(Hand hand)
    {
        if (hand.name == "LeftHand")
        {
            Debug.Log("���� � �����");
        }

        if (hand.name == "RightHand")
        {
            Debug.Log("���� � ������");

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