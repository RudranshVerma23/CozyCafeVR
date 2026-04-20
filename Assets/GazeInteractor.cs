using UnityEngine;

public class GazeInteractor : MonoBehaviour
{
    public float gazeTime = 1.5f;
    private float timer = 0f;
    private GameObject lastHit;

    void Update()
    {
        Ray ray = new Ray(transform.position, transform.forward);
        RaycastHit hit;

        if (Physics.Raycast(ray, out hit, 10f))
        {
            if (hit.collider.gameObject == lastHit)
            {
                timer += Time.deltaTime;
                if (timer >= gazeTime)
                {
                    hit.collider.gameObject
                       .SendMessage("OnGazeActivate",
                                   SendMessageOptions.DontRequireReceiver);
                    timer = 0f;
                }
            }
            else
            {
                lastHit = hit.collider.gameObject;
                timer = 0f;
            }
        }
        else
        {
            lastHit = null;
            timer = 0f;
        }
    }
}