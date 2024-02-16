namespace CorporativeProgramming_2.rt_1.models;

public class Student
{
    public string studentCode;
    public string surname;
    public string name;
    public string patronimic;

    public string Code
    {
        get => studentCode;
        set => studentCode = value ?? throw new ArgumentNullException(nameof(value));
    }

    public string Surname
    {
        get => surname;
        set => surname = value ?? throw new ArgumentNullException(nameof(value));
    }

    public string Name
    {
        get => name;
        set => name = value ?? throw new ArgumentNullException(nameof(value));
    }

    public string Patronimic
    {
        get => patronimic;
        set => patronimic = value ?? throw new ArgumentNullException(nameof(value));
    }
}