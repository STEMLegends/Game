using UnityEngine;
using System.Collections;

public class BackgroundParallax : MonoBehaviour
{
    Renderer cmpRenderer;
    public float speed = 0.1f;

    // Use this for initialization
    void Start()
    {
        cmpRenderer = GetComponent<Renderer>();
    }

    // Update is called once per frame
    void Update()
    {
        float cameraX = Camera.main.transform.position.x;
        cmpRenderer.material.mainTextureOffset = new Vector2(cameraX *speed, 0);
        this.gameObject.transform.position = new Vector3(cameraX,0, this.transform.position.z);
    }
}
