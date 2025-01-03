﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace web.qlts.Application.Dto.Member
{
    public class MemberInsertDto
    {
        /// <summary>
        /// Id ban giao nhận 
        /// </summary>
        public Guid MemberId { get; set; }

        /// <summary>
        /// Họ tên 
        /// </summary>
        public string? FullName { get; set; }

        /// <summary>
        /// Đai diện ban giao nhận 
        /// </summary>
        public string? Representation { get; set; }

        /// <summary>
        /// Chức vụ
        /// </summary>
        public string? PositionName { get; set; }

        /// <summary>
        /// Số thứ tự 
        /// </summary>
        public int STT { get; set; }
    }
}
