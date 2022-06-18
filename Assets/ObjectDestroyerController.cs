using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectDestroyerController : MonoBehaviour
{
    //Unityちゃんの前方向の速度
    /// <summary>
    /// 速度[m/s]
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
    /// 衝突判定
    /// </summary>
    /// <param name="other">相手の物体</param>
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "CarTag" || other.gameObject.tag == "TrafficConeTag" || other.gameObject.tag == "CoinTag")
        {
            // ぶつかった相手を破壊する。
            GameObject.Destroy(other.gameObject);
        }

        // ぶつかった相手のタグを確認
        Debug.Log(other.gameObject.tag);
    }
}