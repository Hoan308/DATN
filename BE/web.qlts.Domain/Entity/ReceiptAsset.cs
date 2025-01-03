﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace web.qlts.Domain.Entity;
public class ReceiptAsset
{

    /// <summary>
    ///  Id tài sản
    /// </summary>
    [Required]

    public Guid ReceiptId { get; set; }

    public Guid AssetId { get; set; }
    /// <summary>
    ///  Id bộ phận sử dụng sau khi thêm chứng từ
    /// </summary>
    public Guid? DepartmentReceiptId { get; set; }
    /// <summary>
    ///  Tên bộ phận sử dụng sau khi thêm chứng từ
    /// </summary>
    public string? DepartmentReceipt { get; set; }

    /// <summary>
    /// Lý do điều chuyển của tài sản
    /// </summary>
    public string? Reason { get; set; }

    /// <summary>
    /// Id bộ phận cũ
    /// </summary>
    public Guid? OldDepartmentId { get; set; }

    /// <summary>
    /// Nhân viên điều chuyển
    /// </summary>
    public string? Employee { get; set; }

    /// <summary>
    /// SỐ lướng
    /// </summary>
    public decimal? Quantity { get; set; }


}