using CorporativeProgramming_2.rt_1;
using CorporativeProgramming_2.rt_1.models;

RT_1 rt1 = new RT_1();
rt1.AddMark("001", "001", 5);
rt1.AddMark("001", "002", 5);
rt1.AddMark("001", "002", 4);

List<StudentMarksInfo> studentMarksInfos = rt1.GetStudentMarksInfo("001");
foreach (StudentMarksInfo studentMarksInfo in studentMarksInfos)
{
    Console.WriteLine(studentMarksInfo.SubjectName + " " + studentMarksInfo.Mark);
}

Console.WriteLine("end");

rt1.saveToJSON("C:\\Users\\Max\\RiderProjects\\CorporativeProgramming_2\\json\\suminfo.json");