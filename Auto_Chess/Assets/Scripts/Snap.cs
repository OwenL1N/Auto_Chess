using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Snap : MonoBehaviour
{
    private void OnDrawGizmos()
    {
        SnapToGrid();
    }

    private void SnapToGrid()
    {
        var position = new Vector3(
            (Mathf.Floor(this.transform.position.x / 100) * 100) + 50,
            25,
            (Mathf.Floor(this.transform.position.z / 100) * 100) + 50);

        // x Bounds
        if (position.x < 0)
        {
            position.x = 0;
        }
        if (position.x > 950)
        {
            position.x = 950;
        }

        // z Bounds
        if (position.z < 50)
        {
            position.z = 50;
        }
        if (position.z > 950)
        {
            position.z = 950;
        }

        this.transform.position = position;
    }
}