/*相机跟随*/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera_FoellowPlayer : MonoBehaviour
{
    /// <summary>
    /// x方向最小值
    /// </summary>
    public float xMin = 7.85f;
    /// <summary>
    /// x方向最大值
    /// </summary>
public float xMax = 56.5f;
    /// <summary>
    /// y方向最小值
    /// </summary>
public float yMin=11.43f;
    /// <summary>
    /// y方向最大值
    /// </summary>
public float yMax=30.13f;
    public Transform character;  //摄像机要跟随的人物
    public float smoothTime = 0.01f; //摄像机平滑移动的时间
    private Vector3 cameraVelocity = Vector3.zero;

    void Start()
    {
        if (!character) character=GameObject.Find("player").transform;
    }

    void Update()
    {
        transform.position = Vector3.SmoothDamp(transform.position, character.position + new Vector3(0, 0, -5), ref cameraVelocity, smoothTime);
        transform.position = new Vector3(Mathf.Clamp(transform.position.x, xMin, xMax), Mathf.Clamp(transform.position.y, yMin, yMax), transform.position.z);
    }
   

}
