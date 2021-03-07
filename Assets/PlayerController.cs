using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    public Animator anim;
    private bool isAttacking;
    public float detectInterval;

    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
        isAttacking = anim.GetBool("isAttacking");
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.E))
        {
            anim.SetBool("isAttacking", !isAttacking);
            isAttacking = !isAttacking;
        }
    }

    public void KeepAttacking()
    {
        StartCoroutine(CKeepAttacking());
    }

    IEnumerator CKeepAttacking()
    {
        print("协程启动！");
        // print("这TM是多少帧啊:" + detectInterval / Time.deltaTime);
        print("波到哪儿了啊" + anim.GetCurrentAnimatorStateInfo(0).normalizedTime);
        float interval = detectInterval;
        while (interval - Time.deltaTime > 0)
        {
            if (Input.GetMouseButton(0))
            {
                // 如果玩家按下左键，那么说明希望继续攻击，那么我们结束迭代，继续播放动画
                yield break;
            }
            yield return null;
        }
        // 如果玩家在interval期限内，始终没有按下左键，那么结束攻击动画，切换回idle站立状态
        anim.SetBool("isAttacking", false);
    }
}
