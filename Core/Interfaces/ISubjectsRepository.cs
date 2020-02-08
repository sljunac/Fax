﻿using Core.Subjects;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Interfaces
{
    public interface ISubjectsRepository : IRepository<Subject>
    {
        IEnumerable<Subject> GetAllWithPartsOfSubject();
        IEnumerable<SubjectTimeOfTeaching> GetAllSubjectsTimeOfTeachings();
        IEnumerable<Subject> GetAllBySchedule(int scheduleId);
        IEnumerable<PartOfSubject> GetAllParts(int subjectId);
    }
}
