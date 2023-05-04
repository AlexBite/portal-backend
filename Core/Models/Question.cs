using System.ComponentModel.DataAnnotations;

namespace Core.Models;

public class Question
{
    [Key]
    public int Id;
    public string Content;
}