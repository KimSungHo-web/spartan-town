using UnityEngine;
using UnityEngine.UI;

public class GameSceneManager : MonoBehaviour
{
    public GameObject character1Prefab; // ù ��° ĳ���� ������
    public GameObject character2Prefab; // �� ��° ĳ���� ������
    public Transform spawnPoint; // ĳ���Ͱ� ������ ��ġ
    public Text nameText; // �÷��̾� �Ӹ� ���� ǥ���� �ؽ�Ʈ

    private GameObject activeCharacter; // ���� Ȱ��ȭ�� ĳ����
    private CameraFollow cameraFollow; // CameraFollow ��ũ��Ʈ ����

    void Start()
    {
        // CameraFollow ��ũ��Ʈ �ڵ����� �Ҵ�
        cameraFollow = Camera.main.GetComponent<CameraFollow>();

        // ����� �г��Ӱ� ���õ� ĳ���� ������ �ҷ���
        string playerName = PlayerPrefs.GetString("PlayerName", "Player");
        string selectedCharacter = PlayerPrefs.GetString("SelectedCharacter", "Character1");
        Debug.Log("Selected Character: " + selectedCharacter); // ���õ� ĳ���� �α� Ȯ��

        // �г��� ǥ��
        nameText.text = playerName;

        // ������ ĳ���͸� ���� ������ ����
        if (selectedCharacter == "Character1")
        {
            activeCharacter = Instantiate(character1Prefab, spawnPoint.position, Quaternion.identity);
            activeCharacter.name = "Character1"; // �̸� ����
        }
        else if (selectedCharacter == "Character2")
        {
            activeCharacter = Instantiate(character2Prefab, spawnPoint.position, Quaternion.identity);
            activeCharacter.name = "Character2"; // �̸� ����
        }

        // ī�޶��� Ÿ���� ������ ĳ���ͷ� ����
        cameraFollow.target = activeCharacter.transform;
    }

    void Update()
    {
        // �÷��̾� �Ӹ� ���� �г����� �׻� ǥ��
        if (activeCharacter != null)
        {
            Vector3 characterPosition = activeCharacter.transform.position;
            nameText.transform.position = Camera.main.WorldToScreenPoint(new Vector3(characterPosition.x, characterPosition.y + 1.5f, characterPosition.z));
        }
    }
}
