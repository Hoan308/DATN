﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace web.qlts.Application.Dto.DepartmentDto
{
    public class DepartmentInsertDto
    {

        /// <summary>
        /// Code Department
        /// </summary>
        public string? DepartmentCode { get; set; }

        /// <summary>
        /// Name Department
        /// </summary>
        public string? DepartmentName { get; set; }

        /// <summary>
        /// Description 
        /// </summary>
        public string? Description { get; set; }
    }
}
