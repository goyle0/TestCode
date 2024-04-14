using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;

namespace TestCode.Models
{
    public sealed class ReadText
    {
        public List<MyEntity> ReadTextFile()
        {
            try
            {
                var filePath = ConfigurationManager.AppSettings["FilePath"];
                List<MyEntity> dataList;

                using (var reader = new StreamReader(filePath))
                {
                    dataList = ParseFile(reader).ToList();
                }

                dataList = dataList.OrderBy(entity => entity.ID)
                                   .ThenBy(entity => entity.EmploymentDate)
                                   .ToList();

                return dataList;
            }
            catch (Exception)
            {
                throw; // Rethrow the exception
            }
        }

        private IEnumerable<MyEntity> ParseFile(StreamReader reader)
        {
            string line;
            while ((line = reader.ReadLine()) != null)
            {
                yield return ParseLine(line);
            }
        }

        private MyEntity ParseLine(string line)
        {
            string[] values = line.Split(',');
            MyEntity entity = new MyEntity(
                id: values[0].Trim(),
                name: values[1].Trim(),
                age: int.Parse(values[2].Trim()),
                gender: values[3].Trim(),
                employmentDate: DateTime.Parse(values[4].Trim())
            );
            return entity;
        }
    }
}
public sealed class MyEntity
{
    public string ID { get; private set; }
    public string Name { get; private set; }
    public int Age { get;  private set; }
    public string Gender { get; private set; }
    public DateTime EmploymentDate { get; private set; }

    public MyEntity(string id, string name, int age, string gender, DateTime employmentDate)
    {
        ID = id;
        Name = name;
        Age = age;
        Gender = gender;
        EmploymentDate = employmentDate;
    }

    public override string ToString()
    {
        return $"ID: {ID}, Name: {Name}, Age: {Age}, Gender: {Gender}, Employment Date: {EmploymentDate}";
    }
}
