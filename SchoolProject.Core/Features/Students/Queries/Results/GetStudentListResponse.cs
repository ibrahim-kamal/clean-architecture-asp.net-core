﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolProject.Core.Features.Students.Queries.Results
{
    public class GetStudentListResponse
    {
        public int StudID { get; set; }
        public string Name { get; set; }
        public string? DepartmentName { get; set; }


    }
}
