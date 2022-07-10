using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpriteMaskFollow : MonoBehaviour
{
    private Camera _camera;

    // Start is called before the first frame update
    void Start()
    {
        _camera = GameObject.Find("Main Camera").GetComponent<Camera>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(_camera.ScreenToWorldPoint(Input.mousePosition).x, _camera.ScreenToWorldPoint(Input.mousePosition).y, 0);
    }
}
