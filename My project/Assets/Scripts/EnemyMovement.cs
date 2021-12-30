using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{

    [SerializeField] List<Waypoint> path = new List<Waypoint>();

    void Start() {
        StartCoroutine(FollowPath());
    }

    IEnumerator FollowPath() {
        foreach (Waypoint waypoint in path) {
            Debug.Log(waypoint.name);
            transform.position = waypoint.transform.position;
            yield return new WaitForSeconds(1f);
        }

    }
}
