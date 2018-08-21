using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[ExecuteInEditMode]
[SelectionBase]
public class CubeEditor : MonoBehaviour
{
    [SerializeField] [Range(1f, 20f)] float gridSize = 10f;

    TextMesh textMesh;

    void Start()
    {

    }

    void Update()
    {
        Vector3 snapPos;

        snapPos.x = Mathf.RoundToInt(transform.position.x / gridSize) * gridSize; //snaps by a factor of 10
        snapPos.z = Mathf.RoundToInt(transform.position.z / gridSize) * gridSize;

        textMesh = GetComponentInChildren<TextMesh>();
        textMesh.text = snapPos.x / gridSize + "," + snapPos.z / gridSize;

        transform.position = new Vector3(snapPos.x, 0f, snapPos.z);
    }
}
