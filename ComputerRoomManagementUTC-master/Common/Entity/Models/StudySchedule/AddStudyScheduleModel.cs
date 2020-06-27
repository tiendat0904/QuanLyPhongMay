using System;
using System.Collections.Generic;
using System.Text;

namespace Common.Entity.Models.StudySchedule
{
    public class AddStudyScheduleModel
    {
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public int ClassId { get; set; }
        public int ComputerRoomId { get; set; }
        public int EmployeeId { get; set; }
        public int ShiftId { get; set; }
        public int SubjectId { get; set; }
        public int TeacherId { get; set; }
        public int DayOfWeek { get; set; }
        public int Status { get; set; }
        public string CreatedBy { get; set; }
    }
}
