using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class FollowScript : MonoBehaviour
{
    public Transform targetObject;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector3.MoveTowards(this.transform.position, targetObject.position, 10 * Time.deltaTime);
    }
}
