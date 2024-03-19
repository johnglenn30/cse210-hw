public class Assignment
{
    private string _studentName = "";
    private  string _topic = "";

    public string GetStudentName() {
        return _studentName; 
    }

    public void SetStudentName(string student) {
        _studentName = student;
    }
    public string GetTopic(){
        return _topic;
    }

    public void SetTopic(string topic) {
        _topic = topic;
    }

    public string GetSummary() {
        return $"{_studentName}'s topic is {_topic}"; 
    }

}