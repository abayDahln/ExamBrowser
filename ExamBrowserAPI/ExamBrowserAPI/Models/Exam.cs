using System;
using System.Collections.Generic;

namespace ExamBrowserAPI.Models;

public partial class Exam
{
    public int Id { get; set; }

    public string ExamName { get; set; } = null!;

    public int TeacherId { get; set; }

    public int SubjectId { get; set; }

    public string GoogleFormLink { get; set; } = null!;

    public string? Token { get; set; }

    public DateTime? TokenExpiry { get; set; }

    public DateTime? CreatedDate { get; set; }

    public virtual ICollection<StudentAnswer> StudentAnswers { get; set; } = new List<StudentAnswer>();

    public virtual Subject Subject { get; set; } = null!;

    public virtual Teacher Teacher { get; set; } = null!;
}
