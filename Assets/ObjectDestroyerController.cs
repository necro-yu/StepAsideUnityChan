using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectDestroyerController : MonoBehaviour
{
    //Unity�����̃I�u�W�F�N�g
    private GameObject unitychan;
    //Unity�����ƃI�u�W�F�N�g�f�X�g���C���[�̋���
    private float difference;

    // Use this for initialization
    void Start()
    {
        //Unity�����̃I�u�W�F�N�g���擾
        this.unitychan = GameObject.Find("unitychan");
        //Unity�����Ƃ̈ʒu�iz���W�j�̍������߂�
        this.difference = unitychan.transform.position.z - this.transform.position.z;
    }

    // Update is called once per frame
    void Update()
    {
        //Unity�����̈ʒu�ɍ��킹�ăI�u�W�F�N�g�f�X�g���C���[�̈ʒu���ړ�
        this.transform.position = new Vector3(0, this.transform.position.y, this.unitychan.transform.position.z - difference);
    }

    /// <summary>
    /// �Փ˔��莞�̓���
    /// </summary>
    /// <param name="collision"></param>
    private void OnCollisionEnter(Collision collision)
    {
        // �Ԃ����������j�󂷂�B
        GameObject.Destroy(collision.gameObject);
    }
}
