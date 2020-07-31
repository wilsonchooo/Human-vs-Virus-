using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class EnemyMower : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag =="enemy")
        {
            Destroy(collision.gameObject);
            Debug.Log("game over");
            SceneManager.LoadScene(2);
        }

        if (collision.gameObject.tag == "White Blood Cell")
        {
            Destroy(collision.gameObject);
        }


    }
}
