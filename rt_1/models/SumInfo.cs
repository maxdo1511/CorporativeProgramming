namespace CorporativeProgramming_2.rt_1.models;

public class SumInfo
{
    public List<Student> students = new List<Student>();
    public List<Subject> subjects = new List<Subject>();
    public List<LearnProgram> learnPrograms = new List<LearnProgram>();

    public List<Student> Students
    {
        get => students;
        set => students = value ?? throw new ArgumentNullException(nameof(value));
    }

    public List<Subject> Subjects
    {
        get => subjects;
        set => subjects = value ?? throw new ArgumentNullException(nameof(value));
    }

    public List<LearnProgram> LearnPrograms
    {
        get => learnPrograms;
        set => learnPrograms = value ?? throw new ArgumentNullException(nameof(value));
    }
}