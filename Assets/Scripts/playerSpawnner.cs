using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerSpawnner : MonoBehaviour
{

    public GameObject Player;
    public static playerSpawnner init;
    public int numberSpawn;

    // Start is called before the first frame update
    void Awake() {
        if (init == null)
        {
            init = this;
        }
    }
    void Start()
    {
        numberSpawn = 3;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
   public void spawnObject()
    {
        numberSpawn++;
        Player.GetComponent<Rigidbody2D>().gravityScale = 0f;
        GameObject play = Instantiate(Player);
        Player.transform.position = transform.position;

    }
}
