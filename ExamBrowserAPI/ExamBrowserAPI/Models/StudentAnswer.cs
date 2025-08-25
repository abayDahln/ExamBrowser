using System;
using System.Collections.Generic;

namespace ExamBrowserAPI.Models;

public partial class StudentAnswer
{
    public int Id { get; set; }

    public int StudentId { get; set; }

    public int ExamId { get; set; }

    public DateTime? SubmitDate { get; set; }

    public bool? Status { get; set; }

    public virtual Exam Exam { get; set; } = null!;

    public virtual Student Student { get; set; } = null!;
}
