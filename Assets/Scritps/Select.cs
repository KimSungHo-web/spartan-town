using UnityEngine;
using UnityEngine.UI;

public class Select : MonoBehaviour
{
    public GameObject selectUIPanel; // Select UI �г� (ĳ���� ����â)
    public Image playerUIImage; // playerUI�� ǥ�õ� �̹���
    public Sprite character1Sprite; // ù ��° ĳ���� �̹���
    public Sprite character2Sprite; // �� ��° ĳ���� �̹���
    public string selectedCharacter = ""; // ���õ� ĳ���� ����

    void Start()
    {
        // ó���� �ƹ��͵� ���õ��� �ʾҴٸ� �⺻���� Character1���� ����
        if (string.IsNullOrEmpty(selectedCharacter))
        {
            SetDefaultCharacter();
        }

        // ����â�� ó���� ��Ȱ��ȭ ����
        selectUIPanel.SetActive(false);
    }

    // �⺻ ĳ���� ���� (Character1)
    void SetDefaultCharacter()
    {
        selectedCharacter = "Character1";
        PlayerPrefs.SetString("SelectedCharacter", selectedCharacter); // �⺻ ĳ���͸� PlayerPrefs�� ����
        playerUIImage.sprite = character1Sprite; // �⺻ ĳ���� �̹��� ����
        Debug.Log("Default Character 1 Selected");
    }

    // ù ��° ĳ���� ����
    public void SelectCharacter1()
    {
        selectedCharacter = "Character1";
        Debug.Log("Character 1 Selected");
        PlayerPrefs.SetString("SelectedCharacter", selectedCharacter); // ���õ� ĳ���͸� PlayerPrefs�� ����
        playerUIImage.sprite = character1Sprite; // playerUI �̹��� ����
        HideSelectionUI(); // ���� �� UI �����
    }

    // �� ��° ĳ���� ����
    public void SelectCharacter2()
    {
        selectedCharacter = "Character2";
        Debug.Log("Character 2 Selected");
        PlayerPrefs.SetString("SelectedCharacter", selectedCharacter); // ���õ� ĳ���͸� PlayerPrefs�� ����
        playerUIImage.sprite = character2Sprite; // playerUI �̹��� ����
        HideSelectionUI(); // ���� �� UI �����
    }

    // ����â�� Ȱ��ȭ�ϴ� �Լ� (playerUI ��ư Ŭ�� �� ȣ��)
    public void ShowSelectionUI()
    {
        selectUIPanel.SetActive(true); // ����â Ȱ��ȭ
    }

    // ����â�� ��Ȱ��ȭ�ϴ� �Լ�
    void HideSelectionUI()
    {
        selectUIPanel.SetActive(false); // ����â ��Ȱ��ȭ
    }

    public string GetSelectedCharacter()
    {
        return selectedCharacter;
    }
}