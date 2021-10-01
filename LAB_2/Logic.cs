using System;
using System.Collections.Generic;
using System.Text;

namespace LAB_2
{
    //Логика программы
    public class Logic
    {
        #region [Методы для задания на if]
        //Проверка пользовательского ввода для задания 1
        public static ProgrammeResult InputCheckTask1(ref string inputHours, ref string inputMinutes)
        {
            bool result;
            ProgrammeResult inputCheckResult = new ProgrammeResult("-", true);
            try
            {
                short hours = short.Parse(inputHours);
                short minutes = short.Parse(inputMinutes);
            }
            catch (ArgumentNullException)
            {
                result = false;
                inputCheckResult = new ProgrammeResult("Данные не были введены!", result);
            }
            catch (FormatException)
            {
                result = false;
                inputCheckResult = new ProgrammeResult("Необходимо ввести числовое значение!", result);
            }
            catch (OverflowException)
            {
                result = false;
                inputCheckResult = new ProgrammeResult("Введено слишком большое число!", result);
            }

            if (inputCheckResult.GetSuccessStatus())
            {
                short hours = short.Parse(inputHours);
                short minutes = short.Parse(inputMinutes);
                if (hours >= 0 && hours <= 23 && minutes >= 0 && minutes <= 59)
                {
                    result = true;
                    inputCheckResult = new ProgrammeResult("Получены корректные входные данные", result);
                }
                else if (hours == 24)
                {
                    inputHours = "0";
                    result = true;
                    inputCheckResult = new ProgrammeResult("Получены корректные входные данные", result);
                }
                else
                {
                    result = false;
                    inputCheckResult = new ProgrammeResult("Значения не удовлетворяют диапазону в условии задания!", result);
                }
            }

            return inputCheckResult;
        }

        //Определение, стоит ли поезд на платформе
        public static ProgrammeResult GetTrainPosition(string[] hours, string[] minutes)
        {
            Time arrivalTime = new Time(short.Parse(hours[0]), short.Parse(minutes[0]));
            Time departureTime = new Time(short.Parse(hours[1]), short.Parse(minutes[1]));
            Time passengerTime = new Time(short.Parse(hours[2]), short.Parse(minutes[2]));

            //Определение положения поезда
            bool isOnPlatform;
            short time = departureTime.GetHours();//счетчик для определения вхождения времени в диапазон от отправления до прибытия, сравнивается с временем прибытия пассажира
            byte correctHours = 0;//Сигнал о том, что часы входят в диапазон
            while (time != arrivalTime.GetHours() && correctHours == 0)
            {
                if (time == passengerTime.GetHours())
                    correctHours = 1;
                --time;
                if (time == -1)
                    time = 23;
            }

            if (time == passengerTime.GetHours())
                correctHours = 1;

            ProgrammeResult result;
            if (correctHours == 1)
            {
                if (passengerTime.GetMinutes() >= arrivalTime.GetMinutes() && passengerTime.GetMinutes() < departureTime.GetMinutes())
                {
                    isOnPlatform = true;
                    result = new ProgrammeResult("Поезд стоит на платформе!", isOnPlatform);
                }
                else if (passengerTime.GetMinutes() >= departureTime.GetMinutes() && passengerTime.GetHours() != departureTime.GetHours())
                {
                    isOnPlatform = true;
                    result = new ProgrammeResult("Поезд стоит на платформе!", isOnPlatform);
                }
                else if (passengerTime.GetMinutes() <= arrivalTime.GetMinutes() && passengerTime.GetHours() != arrivalTime.GetHours())
                {
                    isOnPlatform = true;
                    result = new ProgrammeResult("Поезд стоит на платформе!", isOnPlatform);
                }
                else
                {
                    isOnPlatform = false;
                    result = new ProgrammeResult("Поезда на платформе нет!", isOnPlatform);
                }
            }
            else
            {
                isOnPlatform = false;
                result = new ProgrammeResult("Поезда на платформе нет!", isOnPlatform);
            }

            return result;
        }
        #endregion [Методы для задания на if]

        #region [Методы для задания на for]
        public static ProgrammeResult InputCheckTask2(string inputData)
        {
            ProgrammeResult result = new ProgrammeResult("Получены корректные входные данные", true);
            try
            {
                short value = short.Parse(inputData);
            }
            catch (ArgumentNullException)
            {
                result.SetMessage("Некорректные входные данные: данные не были введены!");
                result.SetSuccessStatus(false);
            }
            catch (FormatException)
            {
                result.SetMessage("Некорректные входные данные: введите целое число!");
                result.SetSuccessStatus(false);
            }
            catch (OverflowException)
            {
                result.SetMessage("Некорректные входные данные: введите положительное значение не более 32767!");
                result.SetSuccessStatus(false);
            }

            if (result.GetSuccessStatus())
                if (short.Parse(inputData) <= 0)
                {
                    result.SetMessage("Некорректные входные данные: введите положительное число!");
                    result.SetSuccessStatus(false);
                }

            return result;
        }

        public static ProgrammeResult FindGroup(string groupSize, string[] nums)
        {
            short buffNum = short.Parse(nums[0]);
            short numCounter = 1;
            int pos = -1; ;
            ProgrammeResult result;
            for (int i = 1; i < nums.Length && pos == -1; ++i)
            {
                if (short.Parse(nums[i]) == buffNum)
                    ++numCounter;
                else
                {
                    numCounter = 1;
                    buffNum = short.Parse(nums[i]);
                }

                if (numCounter == short.Parse(groupSize))
                    pos = i + 1 - numCounter;
            }

            if (pos != -1)
            {
                string indexesList = "";
                for (short i = short.Parse(groupSize); i > 0; --i)
                {
                    if (short.Parse(groupSize) != 1)
                        ++pos;
                    indexesList += pos;
                    indexesList += ", ";
                }
                result = new ProgrammeResult("В последовательности найдена искомая группа чисел!\nНомера её элементов: " + indexesList.Remove(indexesList.Length - 2), true);
            }
            else
                result = new ProgrammeResult("В последовательности не найдена искомая группа чисел!", false);

            return result;
        }
        #endregion[Методы для задания на for]

        #region[Методы для задания на строки]
        //Проверка пользовательского ввода
        public static ProgrammeResult InputCheckTask3(string inputData)
        {
            bool isCorrect = true;
            byte digitsCounter = 0; //Подсчет цифр в числе
            byte signsCounter = 0; //Детектор соседних знаков (если в строке содержится ++ или +- или -+ или --, то вернуть false)
            byte signDetector = 0;//Сигнал о наличии хотя бы одного знака
            byte oneNumberDetector = 0;//Определение одного числа в строке
            int i = 0;
            //Обход строки посимвольно. Проверка соблюдения шаблона a1+/-a2+/-a3+/-...+/-an, 0 <= ai <= 999999
            while (isCorrect && i < inputData.Length)
            {
                if (char.IsDigit(inputData[i]))
                {
                    signsCounter = 0;
                    ++digitsCounter;
                    if (digitsCounter == 20)
                        isCorrect = false;
                }
                else if ((inputData[i] == '+' || inputData[i] == '-') && i > 0 && i != inputData.Length - 1 && signsCounter != 1)
                {
                    signsCounter = 1;
                    signDetector = 1;
                    digitsCounter = 0;
                }
                else
                    isCorrect = false;

                ++i;
            }

            //Проверка условия n > 1
            if (signDetector == 0)
            {
                oneNumberDetector = 1;
                isCorrect = false;
            }


            ProgrammeResult result;
            if (isCorrect)
                result = new ProgrammeResult("Получены корректные входные данные", isCorrect);
            else if (signsCounter > 0)
                result = new ProgrammeResult("Некорректные входные данные!\nНельзя вводить два и более знаков арифметических операций подряд", isCorrect);
            else if (digitsCounter == 20)
                result = new ProgrammeResult("Некорректные входные данные!\nЧисла должны содержать в своей записи от 1 до 19 цифр", isCorrect);
            else if (oneNumberDetector == 1)
                result = new ProgrammeResult("Некорректные входные данные!\nВ строке должно быть записано выражение, состоящее хотя бы из двух чисел", isCorrect);
            else
                result = new ProgrammeResult("Некорректные входные данные!\nВ строке могут содержаться только цифры и знаки +, -", isCorrect);

            return result;
        }

        //Вычисление суммы
        public static ProgrammeResult CalculateSum(string inputData)
        {
            long sum = 0;
            long num = 0;
            char sign = '+';
            int i = 0;
            while (i < inputData.Length)
            {
                if (inputData[i] == '+' || inputData[i] == '-' || i == inputData.Length - 1)
                {
                    if (i != inputData.Length - 1)
                        num /= 10;
                    else
                        num += inputData[i] - '0';

                    if (sign == '+')
                        sum += num;
                    else
                        sum -= num;

                    num = 0;
                    sign = inputData[i];
                }
                else
                {
                    num += inputData[i] - '0';
                    num *= 10;
                }

                ++i;
            }

            ProgrammeResult result = new ProgrammeResult("Вычисленная сумма: " + sum, true);

            return result;
        }
        #endregion[Методы для задания на строки]
    }
}
