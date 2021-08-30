using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    // Создаем метод для загрузки следующей сцены.
    private void LoadNextScene()
    {
        // Получаем доступ к сцене которая активна т.е. на которой находится Player.
        int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
        // Переходим с активной сцены на следующую.
        SceneManager.LoadScene(currentSceneIndex + 1);
    }

    // создаем метод для загрузки начального экрана
    private void LoadStartScene()
    {
        // Загружаем начальный экран, или пишем 0 за место "Start Menu"
        SceneManager.LoadScene("Start Menu");
    }

    // создаем метод для выхода из игры
    private void QuitGame()
    {
        // выходим из игры.
        Application.Quit();
    }
}
