//using AirLook;
//using DG.Tweening;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;
//using XLua;

public class PlayerMovement : MonoBehaviour
{
    public float moveSpeed = 5f;

    public Transform player;

    //public GameObject[] controller_obj;

    //public MonoBehaviour[] scripts;

    //public ActionBasedSnapTurnProvider actionBasedSnapTurnProvider;

    private void Awake()
    {
        player.localPosition = new Vector3(player.localPosition.x, 0f, player.localPosition.z);
    }
    // Update is called once per frame
    void Update()
    {
        float moveX = 0, moveZ = 0;

        // 获取W和S键的输入
        if (Input.GetKey(KeyCode.W))
        {
            moveZ = moveSpeed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.S))
        {
            moveZ = -moveSpeed * Time.deltaTime;
        }

        // 获取A和D键的输入
        if (Input.GetKey(KeyCode.A))
        {
            moveX = -moveSpeed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.D))
        {
            moveX = moveSpeed * Time.deltaTime;
        }

        // 根据获取的输入移动角色
        player.Translate(moveX, 0, moveZ);

        if (Input.GetKeyDown(KeyCode.Q))
        {
            player.Rotate(0, 45, 0);
        }
        if (Input.GetKeyDown(KeyCode.E))
        {
            player.Rotate(0, -45, 0);
        }

        //if (Input.GetKey(KeyCode.Space))
        //{
        //    Boot.GetInstance().is_open_controller = !Boot.GetInstance().is_open_controller;
        //    for (int i = 0; i < controller_obj.Length; i++)
        //    {
        //        controller_obj[i].SetActive(Boot.GetInstance().is_open_controller);
        //    }
        //    for (int i = 0;i < scripts.Length; i++)
        //    {
        //        scripts[i].enabled = Boot.GetInstance().is_open_controller;
        //    }
        //    actionBasedSnapTurnProvider.enabled = Boot.GetInstance().is_open_controller;
        //}
        //if (Input.GetKey(KeyCode.Alpha1))
        //{
        //    AppConst.TimeScale = 1;
        //    Time.timeScale = 1;
        //}

        //if (Input.GetKey(KeyCode.Alpha2))
        //{
        //    AppConst.TimeScale = 2;
        //    Time.timeScale = 2;
        //}

        //if (Input.GetKey(KeyCode.Alpha3))
        //{
        //    AppConst.TimeScale = 3;
        //    Time.timeScale = 3;
        //}

        //if (Input.GetKey(KeyCode.Alpha4))
        //{
        //    AppConst.TimeScale = 4;
        //    Time.timeScale = 4;
        //}

        //if (Input.GetKey(KeyCode.Alpha5))
        //{
        //    AppConst.TimeScale = 5;
        //    Time.timeScale = 5;
        //}

        //if (Input.GetKey(KeyCode.Alpha6))
        //{
        //    AppConst.TimeScale = 6;
        //    Time.timeScale = 6;
        //}
    }
}