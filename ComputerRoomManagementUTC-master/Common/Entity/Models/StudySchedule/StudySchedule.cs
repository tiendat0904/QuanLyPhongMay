using System;
using System.Collections.Generic;
using System.Text;

namespace Common.Entity.Models.StudySchedule
{
    public class StudySchedule
    {
        public int PK_Id { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public int DayOfWeek { get; set; }
        public string ClassName { get; set; }
        public int FK_ClassId { get; set; }
        public string ComputerRoomName { get; set; }
        public int FK_ComputeRoomId { get; set; }
        public int FK_EmployeeId { get; set; }
        public string EmployeeName { get; set; }
        public int FK_ShiftId { get; set; }
        public string ShiftName { get; set; }
        public int FK_SubjectId { get; set; }
        public string SubjectName { get; set; }
        public int FK_TeacherId { get; set; }
        public string TeacherName { get; set; }
        public int Status { get; set; }
    }
}
