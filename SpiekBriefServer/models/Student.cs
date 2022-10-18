using System.ComponentModel.DataAnnotations;

namespace SpiekBriefServer.models;

public class Student
{
    [Key]
    public int id { get; set; }
    public string firstname { get; set; }
}