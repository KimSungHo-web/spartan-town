using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform target;    // ����ٴ� �÷��̾� (���)
    public float smoothSpeed = 0.125f; // ī�޶� �ε巴�� ���󰡴� �ӵ�
    public Vector3 offset;      // ī�޶� �÷��̾���� �Ÿ� (������)

    private void LateUpdate()
    {
        if (target != null)
        {
            // �÷��̾� ��ġ�� �������� ������ ī�޶� ��ġ ����
            Vector3 desiredPosition = target.position + offset;

            // �ε巯�� ī�޶� �̵� ó�� (Lerp �Լ� ���)
            Vector3 smoothedPosition = Vector3.Lerp(transform.position, desiredPosition, smoothSpeed);

            // ī�޶� ��ġ ����
            transform.position = smoothedPosition;
        }
    }

    // �ܺο��� ī�޶� Ÿ���� ������Ʈ�ϴ� �Լ�
    public void SetTarget(Transform newTarget)
    {
        target = newTarget;
    }
}
