using UnityEngine;
using UnityEngine.UI;

public class NameChange : MonoBehaviour
{
    public InputField nameInputField; // �̸��� �Է��� �ʵ�
    public GameObject nameUIPanel; // �̸� ���� UI �г�
    public Text characterNameText; // ĳ���� �Ӹ� ���� ǥ�õ� �̸�

    void Start()
    {
        // PlayerPrefs���� ����� �̸��� �ҷ��ͼ� ĳ���� �Ӹ� ���� ǥ��
        string savedName = PlayerPrefs.GetString("PlayerName", "Player");
        characterNameText.text = savedName;

        // InputField�� ���� ����� �̸��� �̸� ǥ��
        nameInputField.text = savedName;
    }

    // �̸� ����
    public void ChangeName()
    {
        string newName = nameInputField.text; // �Էµ� �̸�
        if (!string.IsNullOrEmpty(newName))
        {
            characterNameText.text = newName; // ĳ���� ���� �̸� ����
            PlayerPrefs.SetString("PlayerName", newName); // ���ο� �̸��� PlayerPrefs�� ����

            nameUIPanel.SetActive(false); // �̸� ���� �� UI �ݱ�
        }
        else
        {
            Debug.LogWarning("�̸��� �Էµ��� �ʾҽ��ϴ�.");
        }
    }

    // �̸� ���� UI�� �����ִ� �Լ�
    public void ShowNameUI()
    {
        nameUIPanel.SetActive(true); // �̸� ���� UI Ȱ��ȭ
    }

    // �̸� ���� UI�� ����� �Լ�
    public void HideNameUI()
    {
        nameUIPanel.SetActive(false); // �̸� ���� UI ��Ȱ��ȭ
    }
}
