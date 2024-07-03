using UnityEngine;
using System.Collections;

public class FollowCursor : MonoBehaviour
{
    private void Start()
    {

    }
    private void Update()
    {
        Vector3 mouseWorldPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        mouseWorldPosition.z = 0f;
        transform.position = mouseWorldPosition;

        Vector2 touchWorldPosition = Camera.main.ScreenToWorldPoint(Input.touches[0].position);
        transform.position = touchWorldPosition;
    }

}
