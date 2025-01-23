using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Follower : MonoBehaviour
{
    public Transform player;
    public float followSpeed = 100f;

    void Update()
    {
        if (player != null)
        {
            Vector3 direction = player.position - transform.position;
            float distance = direction.magnitude;
            direction.Normalize();
            transform.position += direction * followSpeed * Time.deltaTime;
        }
    }

    public void FollowPlayer(GameObject playerObj)
    {
        player = playerObj.transform;
    }
}
