using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;                                                  //引入DoTween插件


public class PlayController : MonoBehaviour
{

    public CharacterController playController;
    public Animator playAnimtor;
    public float MoveLRSpeed = 1;
    private Transform thisTransform;
    private float targetSlotValue;
    public Vector3 MoveIncrements;
    [SerializeField]
    float transverseSpeed = 5.0f;                                   //玩家横向的移动速度
    public float moveSpeed = 0.0f;                                  //玩家的游戏移动速度
    public float jumpPower;                                         //玩家的跳跃高度
    [HideInInspector]
    public GameObject nowRoad;                                      //现在玩家脚下的道路
    Position standPosition;
    Position fromPosition;
    Vector3 xDirection;
    Vector3 moveDirection;
    bool isTurnleftEnd = true;                                      //左转向是否完成
    bool isTurnRightEnd = true;                                     //右转向是否完成
    bool isJumpState;                                               //现在是否是转向状态
    bool isSlideState = false;

    RuntimeAnimatorController nowController;                        //现在的动画控制器
    AnimationClip[] cilps;
    //public bool checkturn = false;
    //// Start is called before the first frame update
    //void OnTriggerEnter(Collider turning)
    //{
    //    if (turning.tag == "Turn")
    //    {
    //        checkturn = true;
    //        Debug.Log("ok");
    //    }
    //}

    void Start()
    {
        jumpPower = 3.0f;
        playController = GetComponent<CharacterController>();
        playAnimtor = GetComponent<Animator>();
        standPosition = Position.Middle;
        nowController = playAnimtor.runtimeAnimatorController;
        cilps = nowController.animationClips;



    }
    void Update()
    {
        //moveSpeed += Time.deltaTime * 0.003f;
        //moveDirection.z = moveSpeed;
        //playController.Move((xDirection*10 + moveDirection) * Time.deltaTime);
        //playController.Move(new Vector3(0, 0, moveSpeed * Time.deltaTime));
        float moveDir = Input.GetAxis("Horizontal");

        MoveIncrements = transform.forward * moveSpeed * Time.deltaTime;
        
        playController.Move(MoveIncrements);
        playAnimtor.SetFloat("MoveSpeed", playController.velocity.magnitude);                            //动画状态更新

    }


    IEnumerator UpdateAction()
    {
        while (true)
        {

            yield return 0;
        }
    }

    public enum Position
    {
        Left,
        Middle,
        Right
    }
}