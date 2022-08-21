using UnityEngine;
using UnityEngine.UI;

public class NewBehaviourScript : MonoBehaviour
{
    public Text goldText;
    public Text rubText;

    public InputField inputField;

    [Space]

    public Text goldText_new;
    public Text rubText_new;

    public InputField inputField_new;

    public void CalculateGold()
    {
        if (inputField.text == "" || inputField.text == null) Debug.Log("String is empty or null.");

        if (double.TryParse(inputField.text, out double number))
        {
            //������ ������, ��� ������� �������
            //Amber ���/ ����
            //1� - 2.1 � / 1.4 ���
            //Ruby, ��� / ����
            //1� - 1,7� / 1.2 ���
            //Topaz, ��� / ����
            //1� - 1,7� / 1.2 ���
            //�� ������ ������ ������ ���

            goldText.text = $"{number:N}";

            double result = number;
            {
                goldText.text = $"{number:N}";

                if (number <= 100)
                    result = number / 1000 * 1.7;
                else if (number > 100 && number <= 1000)
                    result = number / 1000 * 1.7;
                else if (number > 1000 && number <= 10000)
                    result = number / 1000 * 1.7;
                else if (number > 10000 && number <= 100000)
                    result = number / 1000 * 1.7;
                else if (number > 100000 && number <= 1000000)
                    result = number / 1000 * 1.7;
                else if (number > 1000000 && number <= 10000000)
                    result = number / 1000 * 1.7;
                else if (number > 10000000 && number <= 100000000)
                    result = number / 1000 * 1.7;
                else
                    Debug.Log("Error");

                rubText.text = $"{result:C}";
            }

            rubText.text = $"{result:C}";
        }
    }

    public void CalculateRub()
    {
        if (inputField_new.text == "" || inputField_new.text == null) Debug.Log("String is empty or null.");

        if (double.TryParse(inputField_new.text, out double number))
        {
            goldText_new.text = $"{number:N}";

            double result = number;
            {
                goldText_new.text = $"{number:N}";

                if (number <= 100)
                    result = number * 1000 / 1.7;
                else if (number > 100 && number <= 1000)
                    result = number * 1000 / 1.7;
                else if (number > 1000 && number <= 10000)
                    result = number * 1000 / 1.7;
                else if (number > 10000 && number <= 100000)
                    result = number * 1000 / 1.7;
                else if (number > 100000 && number <= 1000000)
                    result = number * 1000 / 1.7;
                else if (number > 1000000 && number <= 10000000)
                    result = number * 1000 / 1.7;
                else if (number > 10000000 && number <= 100000000)
                    result = number * 1000 / 1.7;
                else
                    Debug.Log("Error");

                rubText_new.text = $"{result:N}";
            }

            rubText_new.text = $"{result:N}";
        }
    }
}