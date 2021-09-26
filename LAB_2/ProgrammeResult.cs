using System;
using System.Collections.Generic;
using System.Text;

namespace LAB_2
{
    //Результат программы
    public class ProgrammeResult
    {
        //Сообщение (для пользователя)
        private string message;
        //Булевый результат (для программной логики)
        private bool isSuccessfully;

        public ProgrammeResult()
        {
            message = "Не были получены входные данные для расчёта";
            isSuccessfully = false;
        }

        public ProgrammeResult(string message, bool isSuccessfully)
        {
            this.message = message;
            this.isSuccessfully = isSuccessfully;
        }

        public void SetMessage(string message)
        {
            this.message = message;
        }

        public void SetSuccessStatus(bool status)
        {
            isSuccessfully = status;
        }

        public string GetMessage()
        {
            return message;
        }

        public bool GetSuccessStatus()
        {
            return isSuccessfully;
        }
    }
}
