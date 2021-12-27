using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

// To execute in edit/play
[ExecuteAlways]
public class TileLabeler : MonoBehaviour
{
    
    TextMeshPro label;
    Vector2Int coords = new Vector2Int();

    void Awake() {
        label = GetComponent<TextMeshPro>();
        DisplayCoords();
    }

    // Update is called once per frame
    void Update() {
        if(!Application.isPlaying) {
            DisplayCoords();
        }
    }

    void DisplayCoords() {
        coords.x = Mathf.RoundToInt(transform.parent.position.x / 
            UnityEditor.EditorSnapSettings.move.x);
        coords.y = Mathf.RoundToInt(transform.parent.position.z /
            UnityEditor.EditorSnapSettings.move.z);
        label.text = coords.ToString();
        transform.parent.name = coords.ToString();
    }
}
