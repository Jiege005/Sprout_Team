using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerControl : MonoBehaviour
{
    Vector2 moveDir;
    public LayerMask detectLayer;
    public bool hasMoved = false;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow) || Input.GetKeyDown(KeyCode.W))
        {
            moveDir = Vector2.up;
        }

        if (Input.GetKeyDown(KeyCode.DownArrow) || Input.GetKeyDown(KeyCode.S))
        {
            moveDir = Vector2.down;
        }

        if (Input.GetKeyDown(KeyCode.LeftArrow) || Input.GetKeyDown(KeyCode.A))
        {
            moveDir = Vector2.left;
        }

        if (Input.GetKeyDown(KeyCode.RightArrow) || Input.GetKeyDown(KeyCode.D))
        {
            moveDir = Vector2.right;
        }

        if (moveDir != Vector2.zero)
        {
            if (CanMoveToDir(moveDir) && !hasMoved) 
            {
                Move(moveDir);
            }
        }
        moveDir = Vector2.zero;
    }

    public bool CanMoveToDir(Vector2 dir)
    {
        RaycastHit2D hit = Physics2D.Raycast(transform.position, dir, 100f, detectLayer);

        if (!hit)
        {
            return true;
        }
        else
        {
            /*if (hit.collider.GetComponent<box>() != null)
            {
                return hit.collider.GetComponent<box>().CanMoveToDir(dir);
            }*/
        }

        return false;
    }

    public void Move(Vector2 dir)
    {
        transform.Translate(dir * 100);
        hasMoved = true;
        OnMoveComplete();
    }

    void OnMoveComplete()
    {
        // 触发移动完成事件，通知其他对象跟随移动
        Follower[] followers = FindObjectsOfType<Follower>();
        foreach (Follower follower in followers)
        {
            follower.FollowPlayer(this.gameObject);
        }
    }
}
