using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bg : MonoBehaviour
{
    [SerializeField] private Transform targetToFollow;



    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(
          transform.position.x,
targetToFollow.position.y,




transform.position.z);
    }
}
