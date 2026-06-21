using GameCoreSimpleSeaBattle.CoreGame;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

/// <summary>
/// Контроллер игры для управления игровым процессом, 
/// обработки взаимодействий: клики по полю и обработка завершения игры
/// </summary>
public class GameController : MonoBehaviour
{
    [Header("UI Settings")]
    [SerializeField] private GameObject panelGameOver;
    [SerializeField] private TMP_Text countStepsText;

    [Header("GameObject Settings")]
    [SerializeField] private GameObject prefabShip;

    private Map _map;
    private GameLogic _gameLogic;

    private void Start()
    {
        panelGameOver.SetActive(false);

        _map = new Map(5, 5);
        _gameLogic = new GameLogic(_map);
        _gameLogic.StartGame();
        _gameLogic.OnGameOver += HandleGameOver;
    }

    private void OnDisable()
    {
        _gameLogic.OnGameOver -= HandleGameOver;
    }

    private void HandleGameOver(int countSteps)
    {
        panelGameOver.SetActive(true);
        countStepsText.text = $"Количество шагов: {countSteps} - победа";
    }

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

            if (Physics.Raycast(ray, out RaycastHit hit, 200))
            {
                CellView cellView = hit.collider.GetComponent<CellView>();

                if (cellView)
                {
                    Shoot(cellView.X, cellView.Y, cellView);
                }
            }
        }
    }

    private void Shoot(int x, int y, CellView cellView)
    {
        try
        {
            if (_gameLogic.Step(x, y))
            {
                cellView.Got(prefabShip);
            }
            else
            {
                cellView.Miss();
            }
        }
        catch (System.Exception ex) // дорогая обработка исключений для предотвращения сбоев при кликах по полю
        {
            Debug.LogError($"Ошибка при выстреле: {ex.Message}");
            return;
        }
    }

    public void OnClick_NewGame()
    {
        int indexThisScene = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(indexThisScene);
    }
}