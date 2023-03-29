using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class DestroyObjects : MonoBehaviour
{
    public string targetTag; // ָ���� Tag ����

    private void Start()
    {
       
    }


    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag(targetTag))
        {

            Destroy(collision.gameObject);

        }
    }



}




