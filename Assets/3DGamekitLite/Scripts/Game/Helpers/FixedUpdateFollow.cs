using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Gamekit3D
{
    //스크립트를 불러오는 순서를 조정 해서 가장 늦게 불러오게 만든다
    //캐릭터 애니메이션이 움직이고 거기에 무기가 따라가야 하기 때문에 순서를 조정한걸로 보인다
    [DefaultExecutionOrder(9999)]   
    public class FixedUpdateFollow : MonoBehaviour
    {
        public Transform toFollow;

        private void FixedUpdate()
        {
            transform.position = toFollow.position;
            transform.rotation = toFollow.rotation;
        }
    } 
}
