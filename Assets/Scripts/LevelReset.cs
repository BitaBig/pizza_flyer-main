using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelReset : MonoBehaviour
{
    public GameObject player;
    public ParticleSystem explosion;
    
    public void Reload()
    {
        SceneManager.LoadScene(1);   
    }

    public void GameOver()
    {
        player.SetActive(false);
        Invoke("Reload", 2f);
        explosion.Play();
    }

    private void Start()
    {
        explosion.Stop();
    }

    private void FixedUpdate()
    {
        explosion.transform.position = player.transform.position;
    }
}


