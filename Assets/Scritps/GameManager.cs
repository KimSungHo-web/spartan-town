using UnityEngine;
using UnityEngine.UI;

public class GameSceneManager : MonoBehaviour
{
    public GameObject character1Prefab; // 첫 번째 캐릭터 프리팹
    public GameObject character2Prefab; // 두 번째 캐릭터 프리팹
    public Transform spawnPoint; // 캐릭터가 생성될 위치
    public Text nameText; // 플레이어 머리 위에 표시할 텍스트

    private GameObject activeCharacter; // 현재 활성화된 캐릭터
    private CameraFollow cameraFollow; // CameraFollow 스크립트 참조

    void Start()
    {
        // CameraFollow 스크립트 자동으로 할당
        cameraFollow = Camera.main.GetComponent<CameraFollow>();

        // 저장된 닉네임과 선택된 캐릭터 정보를 불러옴
        string playerName = PlayerPrefs.GetString("PlayerName", "Player");
        string selectedCharacter = PlayerPrefs.GetString("SelectedCharacter", "Character1");
        Debug.Log("Selected Character: " + selectedCharacter); // 선택된 캐릭터 로그 확인

        // 닉네임 표시
        nameText.text = playerName;

        // 선택한 캐릭터를 스폰 지점에 생성
        if (selectedCharacter == "Character1")
        {
            activeCharacter = Instantiate(character1Prefab, spawnPoint.position, Quaternion.identity);
            activeCharacter.name = "Character1"; // 이름 설정
        }
        else if (selectedCharacter == "Character2")
        {
            activeCharacter = Instantiate(character2Prefab, spawnPoint.position, Quaternion.identity);
            activeCharacter.name = "Character2"; // 이름 설정
        }

        // 카메라의 타겟을 생성된 캐릭터로 설정
        cameraFollow.target = activeCharacter.transform;
    }

    void Update()
    {
        // 플레이어 머리 위에 닉네임을 항상 표시
        if (activeCharacter != null)
        {
            Vector3 characterPosition = activeCharacter.transform.position;
            nameText.transform.position = Camera.main.WorldToScreenPoint(new Vector3(characterPosition.x, characterPosition.y + 1.5f, characterPosition.z));
        }
    }
}
