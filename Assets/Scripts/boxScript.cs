using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class boxScript : MonoBehaviour
{
    public float directionSpeed;
    public bool initiateInput;
    public int i = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    
       GetComponent<Rigidbody2D>().gravityScale = 0f;
        if (Random.Range(0,2) ==1)
        {
            directionSpeed = -1f;

        }
        else
        {
            directionSpeed = 1f;
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        if (initiateInput == false)
        {
        if (transform.position.x > 2.3f )
        {
            directionSpeed = -1f;
        }
        if (transform.position.x < -2.2f )
        {
            directionSpeed = 1f;
        }
        transform.Translate(new Vector3(2 * Time.deltaTime * directionSpeed, 0 , 0));
        }

       if (Input.GetMouseButtonDown(0))
        {
        initiateInput = true;
        GetComponent<Rigidbody2D>().gravityScale = 1f;
        if (i == 0)
        {
            i = 1;
            Invoke("Mediator", 2f);
        }

      }
      

      if (Input.touchCount > 0){
        initiateInput = true;
        GetComponent<Rigidbody2D>().gravityScale = 1f;
        if (i == 0)
        {
            i = 1;
            Invoke("Mediator", 2f);
        }
      }

        
    }
        public void Mediator()
        {
        playerSpawnner.init.spawnObject();
        }
}
