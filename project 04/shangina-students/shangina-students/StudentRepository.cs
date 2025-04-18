using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;

namespace StudentManager
{
    public static class StudentRepository
    {
        public static List<Student> LoadFromJson(string path)
        {
            if (!File.Exists(path)) return new List<Student>();
            var json = File.ReadAllText(path);
            return JsonSerializer.Deserialize<List<Student>>(json) ?? new List<Student>();
        }

        public static void SaveToJson(string path, List<Student> students)
        {
            var json = JsonSerializer.Serialize(students, new JsonSerializerOptions { WriteIndented = true });
            File.WriteAllText(path, json);
        }
    }
} 