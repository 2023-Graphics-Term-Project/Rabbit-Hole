using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraZoom : MonoBehaviour
{
    [SerializeField] private Camera cam;
    [SerializeField] private Transform zoomTarget;
    public float minZoom = 2f;
    public float maxZoom = 8f;

    private bool startZooming = false;
    private float zoom;
    private float zoomMultiplier = 2f;
    private float smoothTime = 0.1f;
    private float velocity;
    private Vector3 initialPosition;
    private Vector3 targetPosition;

    // Start is called before the first frame update
    void Start()
    {
        zoom = cam.orthographicSize;
        targetPosition = cam.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if (startZooming)
        {
            targetPosition = Vector3.Lerp(initialPosition, zoomTarget.position, smoothTime);
            initialPosition = zoomTarget.position;
            cam.transform.position = Vector3.Lerp(cam.transform.position, targetPosition, Time.deltaTime * 2);

            zoom -= Time.deltaTime * zoomMultiplier;
            zoom = Mathf.Clamp(zoom, minZoom, maxZoom);
            cam.orthographicSize = Mathf.SmoothDamp(cam.orthographicSize, zoom, ref velocity, smoothTime);
        }
    }

    public void StartZoom()
    {
        initialPosition = zoomTarget.position;
        startZooming = true;
    }
}
