
public struct User
{
    public string id;
    public string name;
    public string department;
    public string director;

}

public struct AttendanceData
{
    public string recordKey;
    public string date;
    public string attendanceTime;
    public string leavingTime;
    public string restTime;
}

public struct AllIndivisualData
{
    public User userData;
    public AttendanceData attendanceData;
}