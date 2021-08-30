using UnityEngine;
using TMPro;

public class NumberWizard : MonoBehaviour
{
    // максимальное значение которого можно достичь.
    [SerializeField] int max;
    // минимальное значение которого можно достичь.
    [SerializeField] int min;
    // создаем класс TextMeshProUGUI, чтобы он был виден в инспекторе и поместим в него guessText.
    [SerializeField] TextMeshProUGUI guessText;
    // переменная которая будет уменьшаться или увеличиваться в зависимости от действий игрока.
    int guess;

    void Start()
    {
        // Запускам метод StartGame() для отображения информации при запуске игры.
        StartGame();
    }

    // создаем метод StartGame() для запуска отображения информации при старте игры в методе Start().
    void StartGame()
    {
        // получаем готовый результат подсчета из метода NextGuess()
        NextGuess();
    }

    // создаем метод, для нажатия кнопки Higher в игре.
    private void OnPressHigher()
    {
        // минимальное значение будет от стартового рандомного значения до 1 в зависимости от количества нажатий.
        min = guess + 1;
        // получаем готовый результат подсчета из метода NextGuess()
        NextGuess();
    }

    // создаем метод, для нажатия кнопки Lower в игре.
    private void OnPressLower()
    {
        // максимальное значение будет от стартового рандомного значения до 1000 в зависимости от количества нажатий.
        max = guess - 1;
        // получаем готовый результат подсчета из метода NextGuess()
        NextGuess();
    }

    // создаем метод NextGuess() для того чтобы упростить код и избежать повторов и вычислить значение guess при нажатии мышкой на кнопки Lower и Higher.
    void NextGuess()
    {
        // Задаем рандомное значение guess между минимальным и максимальным значением + 1
        guess = Random.Range(min, max + 1);
        // получаем доступ к текстовому полю Guess Text в Canvas - GuessBackground и присваиваем ему числовое значение guess 
        // конвертированное в строку при помощи метода ToString().
        guessText.text = guess.ToString();
    }
}
