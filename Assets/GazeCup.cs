using UnityEngine;

public class GazeCup : MonoBehaviour
{
    private bool lifted = false;

    void OnGazeActivate()
    {
        lifted = !lifted;
        Vector3 target = lifted
            ? transform.position + Vector3.up * 0.3f
            : transform.position - Vector3.up * 0.3f;
        transform.position = target;
        Debug.Log("Cup toggled: " + lifted);
    }
}