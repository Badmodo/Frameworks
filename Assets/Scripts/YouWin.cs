using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class YouWin : MonoBehaviour
{
    public GameObject youWin;
    public GameObject player;

    private void OnTriggerEnter(Collider other)
    {
        youWin.SetActive(true);
    }

    public void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        Destroy(player);
    }

}
