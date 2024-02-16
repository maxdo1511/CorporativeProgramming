namespace CorporativeProgramming_2.rt_1.models;

public class StudentMarksInfo
{
    public string SubjectName;
    public int Mark;

    public string SubjectName1
    {
        get => SubjectName;
        set => SubjectName = value ?? throw new ArgumentNullException(nameof(value));
    }

    public int Mark1
    {
        get => Mark;
        set => Mark = value;
    }
}