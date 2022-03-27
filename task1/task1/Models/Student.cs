using System;
using System.Collections.Generic;
using System.Text;

namespace task1.Models
{
    class Student : Person
    {
        public int IQRank { get; set; }
        public int LanguageRank { get; set; }

        public Student()
        {

        }
        public Student(int IQRank, int LanguageRank) : base()
        {
            this.IQRank = IQRank;
            this.LanguageRank = LanguageRank;
        }
        public string ExamResult()
        {
            try
            {
            if (Age < 6 || Age > 20)
            {
                return "sehv melumat siz sagird deyilsiniz";
            }
            int PassTheExam = IQRank + LanguageRank;
            string answer = ($"imtahan neticeniz:{PassTheExam}");
            if (PassTheExam >= 120)
            {
                answer = "imtahandan kecdiniz";
            }
            else
            {
                answer = "imtahandan kesildiniz";
            }
            return answer;

            }
            catch (NullReferenceException)
            {
                throw new Exception("sdfdjfvdj");
            }
        }
    }
}
