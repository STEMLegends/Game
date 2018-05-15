using UnityEngine;
using System.Collections;

public class FollowCamera : MonoBehaviour
{
    public GameObject runner;
    float xDistanceToPlayer;
    // Use this for initialization
    void Start()
    {
        xDistanceToPlayer = runner.transform.position.x - this.transform.position.x;

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        Vector3 desiredPosition = this.transform.position;
        desiredPosition.x = runner.transform.position.x - xDistanceToPlayer;
        this.transform.position = Vector3.Lerp (this.transform.position, desiredPosition, 0.2f);
    }
}
