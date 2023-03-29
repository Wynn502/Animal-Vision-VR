
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Refresh : MonoBehaviour
{
    public GameObject player1;
    void Awake()
    {

        //SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        player1.SetActive(false);
    }

    void Start() {

        player1.SetActive(true);
    }

}
