using Gamekit3D;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CChomperBehavior : MonoBehaviour
{
    //애니메이션 해쉬 값 캐싱
    public static readonly int hashInPursuit = Animator.StringToHash("InPursuit");
    public static readonly int hashAttack = Animator.StringToHash("Attack");
    public static readonly int hashHit = Animator.StringToHash("Hit");
    public static readonly int hashVerticalDot = Animator.StringToHash("VerticalHitDot");
    public static readonly int hashHorizontalDot = Animator.StringToHash("HorizontalHitDot");
    public static readonly int hashThrown = Animator.StringToHash("Thrown");
    public static readonly int hashGrounded = Animator.StringToHash("Grounded");
    public static readonly int hashVerticalVelocity = Animator.StringToHash("VerticalVelocity");
    public static readonly int hashSpotted = Animator.StringToHash("Spotted");
    public static readonly int hashNearBase = Animator.StringToHash("NearBase");

    public static readonly int hashIdleState = Animator.StringToHash("ChomperIdle");

}
