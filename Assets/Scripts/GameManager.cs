using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class GameManager : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject Cam;
    public GameObject objectSpawn;
    public GameObject PausePanel;
    public GameObject pauseButton;


    public int numberSpawn;
    void Start()
    {
        playerSpawnner.init.spawnObject();
    }

    // Update is called once per frame
    void Update()
    {
        if (playerSpawnner.init.numberSpawn == 2)
        {
            Vector3 posSpawn = new Vector3(objectSpawn.transform.position.x, objectSpawn.transform.position.y + 125, objectSpawn.transform.position.z);
            objectSpawn.transform.Translate(new Vector3 (posSpawn.x, posSpawn.y, posSpawn.z) * Time.deltaTime);
             Vector3 posCam = new Vector3(Cam.transform.position.x, Cam.transform.position.y + 125, -10);
            Cam.transform.Translate(new Vector3 (posCam.x, posCam.y, posCam.z) * Time.deltaTime);
          /*  Cam.transform.Translate(new Vector3(Cam.transform.position.x, Cam.transform.position.y + 0.5f, -10f));
            objectSpawn.transform.Translate(new Vector3(objectSpawn.transform.position.x, objectSpawn.transform.position.y + 0.5f, 0));
            */
            playerSpawnner.init.numberSpawn = 0;
        }
        
    }

   public void Resume()
    {
        PausePanel.SetActive(false);
        pauseButton.SetActive(true);
        Time.timeScale = 1f;


    }
    public void Restart()
    {
            SceneManager.LoadScene("SampleScene");
            Time.timeScale = 1f;

    }
    public void Paused()
    {
        PausePanel.SetActive(true);
        pauseButton.SetActive(false);
        Time.timeScale = 0f;


    }

}
