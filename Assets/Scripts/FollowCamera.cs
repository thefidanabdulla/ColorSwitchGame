using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowCamera : MonoBehaviour
{
    [SerializeField] private Transform player;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 nextPos = new Vector3(transform.position.x, player.position.y, transform.position.z);
        transform.position = Vector3.Lerp(transform.position, nextPos, .05f);
    }
}
