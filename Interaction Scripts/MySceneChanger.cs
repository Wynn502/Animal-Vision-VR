using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MySceneChanger : MonoBehaviour
{
    void Update()
    {

            StartCoroutine(DelayedSceneChange());
   
    }

    IEnumerator DelayedSceneChange()
    {
        yield return new WaitForSeconds(5);
        SceneManager.LoadScene("ChooseAnimal");
    }
}
