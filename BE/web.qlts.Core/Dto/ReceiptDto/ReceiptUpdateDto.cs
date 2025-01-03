﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace web.qlts.Application.Dto.ReceiptDto;
/// <summary>
/// Entity Update Dto 
/// </summary>
public class ReceiptUpdateDto
{

    /// <summary>
    /// ID của chứng từ
    /// </summary>
    public Guid ReceiptId { get; set; }
    /// <summary>
    /// Mã chứng từ
    /// </summary>
    public string? ReceiptCode { get; set; }

    /// <summary>
    /// Ngày lập chứng từ
    /// </summary>
    [Required]
    public DateTime ReceiptDate { get; set; }

    /// <summary>
    /// Ngày điều chuyển tài sản
    /// </summary>
    [Required]
    public DateTime TranferDate { get; set; }

    /// <summary>
    /// Ghi chú
    /// </summary>
    public string? Note { get; set; }

    /// <summary>
    /// Ngày tạo chứng từ
    /// </summary>
    public DateTime CreatedDate { get; set; }
}


