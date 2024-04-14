using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;

namespace TestCode.Models
{
    public class ReadText
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

                dataList = dataList.OrderBy(entity => entity.EmploymentDate).ToList();

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
            MyEntity entity = new MyEntity
            {
                ID = values[0].Trim(),
                Name = values[1].Trim(),
                Age = int.Parse(values[2].Trim()),
                Gender = values[3].Trim(),
                EmploymentDate = DateTime.Parse(values[4].Trim())
            };
            return entity;
        }
    }
}
public class MyEntity
{
    public string ID { get; set; }
    public string Name { get; set; }
    public int Age { get; set; }
    public string Gender { get; set; }
    public DateTime EmploymentDate { get; set; }

    public override string ToString()
    {
        return $"ID: {ID}, Name: {Name}, Age: {Age}, Gender: {Gender}, Employment Date: {EmploymentDate}";
    }
}