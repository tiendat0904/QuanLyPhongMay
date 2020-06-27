using System;
using System.Collections.Generic;
using System.Text;

namespace Common.Entity.Models.StudySchedule
{
    public class StudyScheduleEditModel : AddStudyScheduleModel
    {
        public int PK_Id { get; set; }
        public string EditBy { get; set; }
    }
}
