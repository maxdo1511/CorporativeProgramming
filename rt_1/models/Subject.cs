namespace CorporativeProgramming_2.rt_1.models;

public class Subject
{
    public string subjectCode;
    public string name;
    public int lectureHovers;
    public int practiceHovers;

    public string Code
    {
        get => subjectCode;
        set => subjectCode = value ?? throw new ArgumentNullException(nameof(value));
    }

    public string Name
    {
        get => name;
        set => name = value ?? throw new ArgumentNullException(nameof(value));
    }

    public int LectureHovers
    {
        get => lectureHovers;
        set => lectureHovers = value;
    }

    public int PracticeHovers
    {
        get => practiceHovers;
        set => practiceHovers = value;
    }
}