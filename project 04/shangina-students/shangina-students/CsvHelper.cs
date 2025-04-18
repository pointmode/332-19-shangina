using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;

namespace StudentManager
{
    public static class CsvHelper
    {
        public static List<Student> ImportFromCsv(string path)
        {
            var students = new List<Student>();
            if (!File.Exists(path)) return students;
            var lines = File.ReadAllLines(path, Encoding.UTF8);
            foreach (var line in lines)
            {
                var parts = line.Split(';');
                if (parts.Length != 7) continue;
                if (!int.TryParse(parts[3], out int course)) continue;
                if (!DateTime.TryParseExact(parts[5], "dd.MM.yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime birthDate)) continue;
                students.Add(new Student
                {
                    LastName = parts[0],
                    FirstName = parts[1],
                    MiddleName = parts[2],
                    Course = course,
                    Group = parts[4],
                    BirthDate = birthDate,
                    Email = parts[6]
                });
            }
            return students;
        }

        public static void ExportToCsv(string path, List<Student> students)
        {
            var lines = new List<string>();
            foreach (var s in students)
            {
                lines.Add($"{s.LastName};{s.FirstName};{s.MiddleName};{s.Course};{s.Group};{s.BirthDate:dd.MM.yyyy};{s.Email}");
            }
            File.WriteAllLines(path, lines, Encoding.UTF8);
        }
    }
} 