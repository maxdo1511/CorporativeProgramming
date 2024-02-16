namespace CorporativeProgramming_2.rt_1.models;

public class LearnProgram
{
    public string studentCode;
    public string subjectCode;
    public int mark;

    public string StudentCode
    {
        get => studentCode;
        set => studentCode = value ?? throw new ArgumentNullException(nameof(value));
    }

    public string SubjectCode
    {
        get => subjectCode;
        set => subjectCode = value ?? throw new ArgumentNullException(nameof(value));
    }

    public int Mark
    {
        get => mark;
        set => mark = value;
    }
}