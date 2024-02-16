using CorporativeProgramming_2.rt_1.models;
using Newtonsoft.Json;

namespace CorporativeProgramming_2.rt_1;

public class RT_1
{

    private SumInfo sumInfos;

    public RT_1()
    {
        loadFromJSON("C:\\Users\\Max\\RiderProjects\\CorporativeProgramming_2\\json\\suminfo.json");
        Console.WriteLine(sumInfos);
    }

    public void saveToJSON(string path)
    {
        string _data = JsonConvert.SerializeObject(sumInfos);
        File.WriteAllText(path, _data);
    }
    
    public void loadFromJSON(string path)
    {
        string _data = File.ReadAllText(path);
        sumInfos = (SumInfo) JsonConvert.DeserializeObject<SumInfo>(_data);
    }
    
    public void AddStudent(string code, string name, string surname, string patronimic)
    {
        sumInfos.Students.Add(new Student(){Code = code, Name = name, Surname = surname, Patronimic = patronimic});
    }

    public List<StudentMarksInfo> GetStudentMarksInfo(string studentId)
    {
        var query = from curriculum in sumInfos.LearnPrograms
            where curriculum.studentCode == studentId
            join subject in sumInfos.Subjects on curriculum.subjectCode equals subject.subjectCode
            select new
            {
                SubjectName = subject.name,
                Mark = curriculum.mark
            };

        var totalMarks = query.Count();
        var excellentPercentage = query.Count(m => m.Mark == 5) * 100.0 / totalMarks;
        var goodPercentage = query.Count(m => m.Mark == 4) * 100.0 / totalMarks;
        var satisfactoryPercentage = query.Count(m => m.Mark <= 3) * 100.0 / totalMarks;

        Console.WriteLine($"Excellent: {excellentPercentage}%");
        Console.WriteLine($"Good: {goodPercentage}%");
        Console.WriteLine($"Satisfactory: {satisfactoryPercentage}%");
        return new List<StudentMarksInfo>(query.Select(x => new StudentMarksInfo(){SubjectName = x.SubjectName, Mark = x.Mark}));
    }
    
    public void AddSubject(string code, string name, int lectureHovers, int practiceHovers)
    {
        sumInfos.Subjects.Add(new Subject(){Code = code, Name = name, LectureHovers = lectureHovers, PracticeHovers = practiceHovers});
    }

    public void AddLearnProgram(string studentCode, string subjectCode, int mark)
    {
        sumInfos.LearnPrograms.Add(new LearnProgram(){StudentCode = studentCode, SubjectCode = subjectCode, Mark = mark});
    }
    
    public void AddMark(string studentCode, string subjectCode, int mark)
    {
        if (mark < 2 || mark > 5)
        {
            throw new ArgumentException("Mark must be between 2 and 5");
        }
        
        if (sumInfos.Students.Find(x => x.Code == studentCode) == null)
        {
            throw new ArgumentException("Student with this code doesn't exist");
        }
        
        if (sumInfos.Subjects.Find(x => x.Code == subjectCode) == null)
        {
            throw new ArgumentException("Subject with this code doesn't exist");
        }
        
        sumInfos.LearnPrograms.Add(new LearnProgram(){StudentCode = studentCode, SubjectCode = subjectCode, Mark = mark});
    }

}