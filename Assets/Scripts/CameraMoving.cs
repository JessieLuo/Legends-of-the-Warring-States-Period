using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMoving : MonoBehaviour
{
    public float speed = 10f;
    private Camera mainCamera;
    private float mainCameraWidthRight = 40f;
    private float mainCameraHeightTop = 25f;
    private float mainCameraWidthLeft = -40f;
    private float mainCameraHeightBottom = -25f;
    // Start is called before the first frame update
    void Start()
    {
        mainCamera = GetComponent<Camera>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnGUI() 
    {
        Event Key = Event.current;
        switch (Key.keyCode)
        {
            case KeyCode.W:
                transform.Translate(Vector2.up * Time.deltaTime * speed);
                break;
            case KeyCode.S:
                transform.Translate(Vector2.down * Time.deltaTime * speed);
                break;
            case KeyCode.A:
                transform.Translate(Vector2.left * Time.deltaTime * speed);
                break;
            case KeyCode.D:
                transform.Translate(Vector2.right * Time.deltaTime * speed);
                break;
            default:
                break;
        }
    }
}
