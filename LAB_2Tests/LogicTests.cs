using Microsoft.VisualStudio.TestTools.UnitTesting;
using LAB_2;
using System;
using System.Collections.Generic;
using System.Text;

namespace LAB_2.Tests
{
    [TestClass()]
    public class LogicTests
    {
        #region[Тесты задания 1]
        public void IncorrectInputDataOddSymbols()
        {
            string[] hours = new string[] { "10", "2A", "13" };
            string[] minutes = new string[] { "7", "16", "45" };
            byte i = 0;
            ProgrammeResult inputCheckResult = new ProgrammeResult("-", true);
            while (i < hours.Length && inputCheckResult.GetSuccessStatus())
            {
                inputCheckResult = Logic.InputCheckTask1(ref hours[i], ref minutes[i]);
                ++i;
            }
            ProgrammeResult programmeResult;
            if (inputCheckResult.GetSuccessStatus())
                programmeResult = Logic.GetTrainPosition(hours, minutes);
            else
                programmeResult = new ProgrammeResult();

            Assert.AreEqual("Необходимо ввести числовое значение!", inputCheckResult.GetMessage());
            Assert.AreEqual("Не были получены входные данные для расчёта", programmeResult.GetMessage());
        }

        [TestMethod()]
        public void IncorrectInputDataWrongTime()
        {
            string[] hours = new string[] { "10", "2", "130" };
            string[] minutes = new string[] { "79", "16", "45" };
            byte i = 0;
            ProgrammeResult inputCheckResult = new ProgrammeResult("-", true);
            while (i < hours.Length && inputCheckResult.GetSuccessStatus())
            {
                inputCheckResult = Logic.InputCheckTask1(ref hours[i], ref minutes[i]);
                ++i;
            }
            ProgrammeResult programmeResult;
            if (inputCheckResult.GetSuccessStatus())
                programmeResult = Logic.GetTrainPosition(hours, minutes);
            else
                programmeResult = new ProgrammeResult();

            Assert.AreEqual("Значения не удовлетворяют диапазону в условии задания!", inputCheckResult.GetMessage());
            Assert.AreEqual("Не были получены входные данные для расчёта", programmeResult.GetMessage());
        }

        [TestMethod()]
        public void IncorrectInputDataOverflow()
        {
            string[] hours = new string[] { "10", "2", "13043094304950434343434343" };
            string[] minutes = new string[] { "59", "16", "45" };
            byte i = 0;
            ProgrammeResult inputCheckResult = new ProgrammeResult("-", true);
            while (i < hours.Length && inputCheckResult.GetSuccessStatus())
            {
                inputCheckResult = Logic.InputCheckTask1(ref hours[i], ref minutes[i]);
                ++i;
            }
            ProgrammeResult programmeResult;
            if (inputCheckResult.GetSuccessStatus())
                programmeResult = Logic.GetTrainPosition(hours, minutes);
            else
                programmeResult = new ProgrammeResult();

            Assert.AreEqual("Введено слишком большое число!", inputCheckResult.GetMessage());
            Assert.AreEqual("Не были получены входные данные для расчёта", programmeResult.GetMessage());
        }

        [TestMethod()]
        public void TrainOnPlatform()
        {
            string[] hours = new string[] { "22", "1", "23" };
            string[] minutes = new string[] { "45", "16", "45" };
            byte i = 0;
            ProgrammeResult inputCheckResult = new ProgrammeResult("-", true);
            while (i < hours.Length && inputCheckResult.GetSuccessStatus())
            {
                inputCheckResult = Logic.InputCheckTask1(ref hours[i], ref minutes[i]);
                ++i;
            }
            ProgrammeResult programmeResult;
            if (inputCheckResult.GetSuccessStatus())
                programmeResult = Logic.GetTrainPosition(hours, minutes);
            else
                programmeResult = new ProgrammeResult();

            Assert.AreEqual("Получены корректные входные данные", inputCheckResult.GetMessage());
            Assert.AreEqual("Поезд стоит на платформе!", programmeResult.GetMessage());
        }

        [TestMethod()]
        public void TrainNotOnPlatform()
        {
            string[] hours = new string[] { "10", "2", "9" };
            string[] minutes = new string[] { "7", "16", "45" };
            byte i = 0;
            ProgrammeResult inputCheckResult = new ProgrammeResult("-", true);
            while (i < hours.Length && inputCheckResult.GetSuccessStatus())
            {
                inputCheckResult = Logic.InputCheckTask1(ref hours[i], ref minutes[i]);
                ++i;
            }
            ProgrammeResult programmeResult;
            if (inputCheckResult.GetSuccessStatus())
                programmeResult = Logic.GetTrainPosition(hours, minutes);
            else
                programmeResult = new ProgrammeResult();

            Assert.AreEqual("Получены корректные входные данные", inputCheckResult.GetMessage());
            Assert.AreEqual("Поезда на платформе нет!", programmeResult.GetMessage()); ;
        }
        #endregion[Тесты задания 1]

        #region[Тесты задания 2]
        [TestMethod()]
        public void IncorrectInputDataWrongFormat()
        {
            string groupSize = "abc";
            string[] nums = new string[] { "1", "2", "3" };
            ProgrammeResult groupSizeCheckResult = Logic.InputCheckTask2(groupSize);
            ProgrammeResult numsCheckResult = new ProgrammeResult("-", true);
            int i = 0;
            while (i < nums.Length && numsCheckResult.GetSuccessStatus())
            {
                numsCheckResult = Logic.InputCheckTask2(nums[i]);
                ++i;
            }
            ProgrammeResult programmeResult;
            if (groupSizeCheckResult.GetSuccessStatus() && numsCheckResult.GetSuccessStatus())
                programmeResult = Logic.FindGroup(groupSize, nums);
            else
                programmeResult = new ProgrammeResult();

            Assert.AreEqual("Некорректные входные данные: введите целое число!", groupSizeCheckResult.GetMessage());
            Assert.AreEqual("Получены корректные входные данные", numsCheckResult.GetMessage());
            Assert.AreEqual("Не были получены входные данные для расчёта", programmeResult.GetMessage());
        }

        [TestMethod()]
        public void IncorrectInputDataOverflowTask2()
        {
            string groupSize = "2";
            string[] nums = new string[] { "1", "2", "2", "71668660" };
            ProgrammeResult groupSizeCheckResult = Logic.InputCheckTask2(groupSize);
            ProgrammeResult numsCheckResult = new ProgrammeResult("-", true);
            int i = 0;
            while (i < nums.Length && numsCheckResult.GetSuccessStatus())
            {
                numsCheckResult = Logic.InputCheckTask2(nums[i]);
                ++i;
            }
            ProgrammeResult programmeResult;
            if (groupSizeCheckResult.GetSuccessStatus() && numsCheckResult.GetSuccessStatus())
                programmeResult = Logic.FindGroup(groupSize, nums);
            else
                programmeResult = new ProgrammeResult();

            Assert.AreEqual("Получены корректные входные данные", groupSizeCheckResult.GetMessage());
            Assert.AreEqual("Некорректные входные данные: введите положительное значение не более 32767!", numsCheckResult.GetMessage());
            Assert.AreEqual("Не были получены входные данные для расчёта", programmeResult.GetMessage());
        }

        [TestMethod()]
        public void IncorrectInputDataWrongValue()
        {
            string groupSize = "2";
            string[] nums = new string[] { "1", "-2", "2", "2" };
            ProgrammeResult groupSizeCheckResult = Logic.InputCheckTask2(groupSize);
            ProgrammeResult numsCheckResult = new ProgrammeResult("-", true);
            int i = 0;
            while (i < nums.Length && numsCheckResult.GetSuccessStatus())
            {
                numsCheckResult = Logic.InputCheckTask2(nums[i]);
                ++i;
            }
            ProgrammeResult programmeResult;
            if (groupSizeCheckResult.GetSuccessStatus() && numsCheckResult.GetSuccessStatus())
                programmeResult = Logic.FindGroup(groupSize, nums);
            else
                programmeResult = new ProgrammeResult();

            Assert.AreEqual("Получены корректные входные данные", groupSizeCheckResult.GetMessage());
            Assert.AreEqual("Некорректные входные данные: введите положительное число!", numsCheckResult.GetMessage());
            Assert.AreEqual("Не были получены входные данные для расчёта", programmeResult.GetMessage());
        }

        [TestMethod()]
        public void CorrectInputDataGroupExists()
        {
            string groupSize = "2";
            string[] nums = new string[] { "1", "2", "2", "2", "3", "3" };
            ProgrammeResult groupSizeCheckResult = Logic.InputCheckTask2(groupSize);
            ProgrammeResult numsCheckResult = new ProgrammeResult("-", true);
            int i = 0;
            while (i < nums.Length && numsCheckResult.GetSuccessStatus())
            {
                numsCheckResult = Logic.InputCheckTask2(nums[i]);
                ++i;
            }
            ProgrammeResult programmeResult;
            if (groupSizeCheckResult.GetSuccessStatus() && numsCheckResult.GetSuccessStatus())
                programmeResult = Logic.FindGroup(groupSize, nums);
            else
                programmeResult = new ProgrammeResult();

            Assert.AreEqual("Получены корректные входные данные", groupSizeCheckResult.GetMessage());
            Assert.AreEqual("Получены корректные входные данные", numsCheckResult.GetMessage());
            Assert.AreEqual("В последовательности найдена искомая группа чисел!\nНомера её элементов: 2, 3", programmeResult.GetMessage());
        }

        [TestMethod()]
        public void CorrectInputDataGroupNotFound()
        {
            string groupSize = "3";
            string[] nums = new string[] { "1", "2", "2", "5", "3", "3" };
            ProgrammeResult groupSizeCheckResult = Logic.InputCheckTask2(groupSize);
            ProgrammeResult numsCheckResult = new ProgrammeResult("-", true);
            int i = 0;
            while (i < nums.Length && numsCheckResult.GetSuccessStatus())
            {
                numsCheckResult = Logic.InputCheckTask2(nums[i]);
                ++i;
            }
            ProgrammeResult programmeResult;
            if (groupSizeCheckResult.GetSuccessStatus() && numsCheckResult.GetSuccessStatus())
                programmeResult = Logic.FindGroup(groupSize, nums);
            else
                programmeResult = new ProgrammeResult();

            Assert.AreEqual("Получены корректные входные данные", groupSizeCheckResult.GetMessage());
            Assert.AreEqual("Получены корректные входные данные", numsCheckResult.GetMessage());
            Assert.AreEqual("В последовательности не найдена искомая группа чисел!", programmeResult.GetMessage());
        }
        #endregion[Тесты задания 2]

        #region[Тесты задания 3]
        [TestMethod()]
        public void IncorrectInputDataWrongFormatTask3()
        {
            string expression = "120++7-16";
            ProgrammeResult inputCheckResult = Logic.InputCheckTask3(expression);
            ProgrammeResult programmeResult;
            if (inputCheckResult.GetSuccessStatus())
                programmeResult = Logic.CalculateSum(expression);
            else
                programmeResult = new ProgrammeResult();

            Assert.AreEqual("Некорректные входные данные!\nНельзя вводить два и более знаков арифметических операций подряд", inputCheckResult.GetMessage());
            Assert.AreEqual("Не были получены входные данные для расчёта", programmeResult.GetMessage());
        }

        [TestMethod()]
        public void IncorrectInputDataOddSymbolsTask3()
        {
            string expression = "120+7a-16B";
            ProgrammeResult inputCheckResult = Logic.InputCheckTask3(expression);
            ProgrammeResult programmeResult;
            if (inputCheckResult.GetSuccessStatus())
                programmeResult = Logic.CalculateSum(expression);
            else
                programmeResult = new ProgrammeResult();

            Assert.AreEqual("Некорректные входные данные!\nВ строке могут содержаться только цифры и знаки +, -", inputCheckResult.GetMessage());
            Assert.AreEqual("Не были получены входные данные для расчёта", programmeResult.GetMessage());
        }

        [TestMethod()]
        public void IncorrectInputDataOverFlow()
        {
            string expression = "120+30-77605695049605690569059605434343434343434343";
            ProgrammeResult inputCheckResult = Logic.InputCheckTask3(expression);
            ProgrammeResult programmeResult;
            if (inputCheckResult.GetSuccessStatus())
                programmeResult = Logic.CalculateSum(expression);
            else
                programmeResult = new ProgrammeResult();

            Assert.AreEqual("Некорректные входные данные!\nЧисла должны содержать в своей записи от 1 до 19 цифр", inputCheckResult.GetMessage());
            Assert.AreEqual("Не были получены входные данные для расчёта", programmeResult.GetMessage());
        }

        [TestMethod()]
        public void IncorrectInputDataWrongQuantity()
        {
            string expression = "120";
            ProgrammeResult inputCheckResult = Logic.InputCheckTask3(expression);
            ProgrammeResult programmeResult;
            if (inputCheckResult.GetSuccessStatus())
                programmeResult = Logic.CalculateSum(expression);
            else
                programmeResult = new ProgrammeResult();

            Assert.AreEqual("Некорректные входные данные!\nВ строке должно быть записано выражение, состоящее хотя бы из двух чисел", inputCheckResult.GetMessage());
            Assert.AreEqual("Не были получены входные данные для расчёта", programmeResult.GetMessage());
        }

        [TestMethod()]
        public void CorrectInputData()
        {
            string expression = "120+16-7";
            ProgrammeResult inputCheckResult = Logic.InputCheckTask3(expression);
            ProgrammeResult programmeResult;
            if (inputCheckResult.GetSuccessStatus())
                programmeResult = Logic.CalculateSum(expression);
            else
                programmeResult = new ProgrammeResult();

            Assert.AreEqual("Получены корректные входные данные", inputCheckResult.GetMessage());
            Assert.AreEqual("Вычисленная сумма: " + 129, programmeResult.GetMessage());
        }
        #endregion[Тесты задания 3]
    }
}