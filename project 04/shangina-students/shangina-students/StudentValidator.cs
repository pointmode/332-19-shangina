using System;
using System.Text.RegularExpressions;

namespace StudentManager
{
    public static class StudentValidator
    {
        private static readonly string[] AllowedDomains = { "yandex.ru", "gmail.com", "icloud.com" };
        public static bool Validate(Student student, out string error)
        {
            if (string.IsNullOrWhiteSpace(student.LastName))
            {
                error = "Заполните фамилию.";
                return false;
            }
            if (string.IsNullOrWhiteSpace(student.FirstName))
            {
                error = "Заполните имя.";
                return false;
            }
            if (string.IsNullOrWhiteSpace(student.MiddleName))
            {
                error = "Заполните отчество.";
                return false;
            }
            if (student.Course < 1 || student.Course > 6)
            {
                error = "Курс должен быть от 1 до 6.";
                return false;
            }
            if (string.IsNullOrWhiteSpace(student.Group))
            {
                error = "Заполните группу.";
                return false;
            }
            if (student.BirthDate < new DateTime(1992, 1, 1) || student.BirthDate > DateTime.Today)
            {
                error = "Дата рождения должна быть с 01.01.1992 по сегодня.";
                return false;
            }
            if (!ValidateEmail(student.Email, out error))
            {
                return false;
            }
            error = string.Empty;
            return true;
        }

        public static bool ValidateEmail(string email, out string error)
        {
            error = string.Empty;
            if (string.IsNullOrWhiteSpace(email))
            {
                error = "Заполните электронную почту.";
                return false;
            }
            var match = Regex.Match(email, @"^.{3,}@([a-zA-Z0-9.-]+)$");
            if (!match.Success)
            {
                error = "Некорректный формат электронной почты.";
                return false;
            }
            var domain = match.Groups[1].Value.ToLower();
            bool allowed = false;
            foreach (var d in AllowedDomains)
            {
                if (domain == d)
                {
                    allowed = true;
                    break;
                }
            }
            if (!allowed)
            {
                error = $"Почта должна быть только на доменах: {string.Join(", ", AllowedDomains)}.";
                return false;
            }
            return true;
        }
    }
} 