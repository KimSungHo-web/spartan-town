using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform target;    // 따라다닐 플레이어 (대상)
    public float smoothSpeed = 0.125f; // 카메라가 부드럽게 따라가는 속도
    public Vector3 offset;      // 카메라가 플레이어와의 거리 (오프셋)

    private void LateUpdate()
    {
        if (target != null)
        {
            // 플레이어 위치에 오프셋을 적용한 카메라 위치 설정
            Vector3 desiredPosition = target.position + offset;

            // 부드러운 카메라 이동 처리 (Lerp 함수 사용)
            Vector3 smoothedPosition = Vector3.Lerp(transform.position, desiredPosition, smoothSpeed);

            // 카메라 위치 갱신
            transform.position = smoothedPosition;
        }
    }

    // 외부에서 카메라 타겟을 업데이트하는 함수
    public void SetTarget(Transform newTarget)
    {
        target = newTarget;
    }
}
