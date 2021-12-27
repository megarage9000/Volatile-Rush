using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{

    [SerializeField] List<Waypoint> path = new List<Waypoint>();

    void Start() {
        PrintPath();
    }

    void PrintPath() {
        foreach (Waypoint waypoint in path) {
            Debug.Log(waypoint.name);
        }

    }
}
