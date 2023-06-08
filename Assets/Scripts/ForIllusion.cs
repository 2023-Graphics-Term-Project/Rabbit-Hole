using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ForIllusion : MonoBehaviour
{
    public GameObject levelObject;

    private float initialPosY;
    // Start is called before the first frame update
    void Start()
    {
        initialPosY = transform.position.y;
    }

    // Update is called once per frame
    void Update()
    {
        float levelAngle = levelObject.transform.rotation.eulerAngles.z;

        if (levelAngle >= 180)
            levelAngle -= 180;
        Debug.Log(levelAngle);

        //0, 180에서 이 오브젝트의 rotation.eulerAngles.x는 20
        //90, 270에서 0을 찍고 그 사이를 부드럽게 움직임
        float thr1 = 20f;
        float thr2 = 160f;

        if (0 <= levelAngle && levelAngle < thr1)
        {
            float proportion = levelAngle / thr1;
            float anglePoint = 180 * proportion;
            float value = Mathf.Cos(anglePoint * Mathf.Deg2Rad) + 1;

            transform.rotation = Quaternion.Euler(10 * value, 0, 0);
        }
        else if (thr1 <= levelAngle && levelAngle < thr2)
        {
            //현재 각도 유지
        }
        else if (thr2 <= levelAngle && levelAngle < 180)
        {
            float proportion = (levelAngle - thr2) / (180 - thr2);
            float anglePoint = 180 * proportion;
            float value = -Mathf.Cos(anglePoint * Mathf.Deg2Rad) + 1;

            transform.rotation = Quaternion.Euler(10 * value, 0, 0);
        }
    }
}
