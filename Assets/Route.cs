using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Route : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] private Transform[] controlPoints;
    private Vector2 gizmosPosition;

    private void OnDrawGizmos()
    {
        for (float t=0;t<=1;t+=0.05f)
        {
            //gizmosPosition = Mathf.Pow(1-t,3) * controlPoints[0].position 
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
