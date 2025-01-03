﻿using System.Text.Json;

namespace web.qlts.Domain.MISAException
{
    /// <summary>
    /// Base xử lý lỗi
    /// </summary>
    public class BaseException
    {
        #region Constructor
        public BaseException()
        {
        }

        public BaseException(Exception exception, object ex)
        {
        }
        #endregion

        /// <summary>
        /// Mã lỗi
        /// </summary>
        public int ErrorCode { get; set; }

        /// <summary>
        /// Message cho Dev
        /// </summary>
        public string? DevMsg { get; set; }

        /// <summary>
        /// Message cho User
        /// </summary>
        public string? UserMsg { get; set; }

        /// <summary>
        /// TraceId của lỗi
        /// </summary>
        public string? TraceId { get; set; }

        /// <summary>
        /// Object lỗi
        /// </summary>
        public object? DataError { get; set; }

        /// <summary>
        /// Override ToString
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return JsonSerializer.Serialize(this);
        }
    }
}
