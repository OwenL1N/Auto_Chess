using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Snap : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    private void OnDrawGizmos()
    {
        SnapToGrid();
    }

    private void SnapToGrid()
    {
        var position = new Vector3(
            (Mathf.RoundToInt(this.transform.position.x / 100) * 100) + 50,
            25,
            (Mathf.RoundToInt(this.transform.position.z / 100) * 100) + 50);

        this.transform.position = position;
    }
}