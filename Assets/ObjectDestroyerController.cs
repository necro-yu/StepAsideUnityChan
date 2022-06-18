using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectDestroyerController : MonoBehaviour
{
    //Unity�����̑O�����̑��x
    /// <summary>
    /// ���x[m/s]
    /// </summary>
    private Vector3 _velocity = new Vector3(0, 0, 16f);

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.position = transform.position + (_velocity * Time.deltaTime);
    }

    /// <summary>
    /// �Փ˔���
    /// </summary>
    /// <param name="other">����̕���</param>
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "CarTag" || other.gameObject.tag == "TrafficConeTag" || other.gameObject.tag == "CoinTag")
        {
            // �Ԃ����������j�󂷂�B
            GameObject.Destroy(other.gameObject);
        }

        // �Ԃ���������̃^�O���m�F
        Debug.Log(other.gameObject.tag);
    }
}