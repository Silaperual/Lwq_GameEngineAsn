using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Play3DSound : MonoBehaviour
{
    private GameObject mainCamera = null;
    private Vector3 direction;
    private uint playingID = 0;
    public GameObject cubeObject = null;

    private void Awake()
    {
        //初始化坐标
        mainCamera = GameObject.Find("Main Camera");
        cubeObject = GameObject.Find("Cube");
        Vector3 tempPos = mainCamera.transform.position;
        tempPos.x -= 100;
        transform.position = tempPos;
    }

    // Start is called before the first frame update
    void Start()
    {
        //右侧移动
        direction.x = 1;
        direction.y = 0;
        direction.z = 0;
        //添加音频发声对象
        this.gameObject.AddComponent<AkGameObj>();
    }

    // Update is called once per frame
    void Update()
    {
        if (playingID == 0)
        {
            playingID = AkSoundEngine.PostEvent("Play_Firework_Random", this.gameObject);
        }

        float distance = Vector3.Distance(transform.position, mainCamera.transform.position);
        if (distance > 50)
        {
            //超过衰减距离反向移动
            direction = -direction;
        }
        transform.Translate(direction * 10 * Time.deltaTime, Space.World);
    }
}
