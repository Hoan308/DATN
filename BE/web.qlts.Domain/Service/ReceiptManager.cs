using web.qlts.Domain.Enum;
using web.qlts.Domain.Interface.Manager;
using web.qlts.Domain.Interface.Repository;
using web.qlts.Domain.MISAException;
using web.qlts.Domain.Resources;

namespace web.qlts.Domain.Service
{
    public class ReceiptManager : IReceiptManager
    {
        #region Field
        private readonly IReceiptRepository _receiptRepository;
        #endregion

        #region Constructor
        public ReceiptManager(IReceiptRepository receiptRepository)
        {
            _receiptRepository = receiptRepository;
        }
        #endregion

        #region Method

        /// <summary>
        ///  Hàm check trùng mã chứng từ
        /// </summary>
        /// <param name="code">Mã chứng từ</param>
        /// <param name="receiptId">Id của chứng từ</param>
        /// <param name="isInsert">
        ///  true: Method Insert
        ///  false: Method Update
        /// </param>
        /// <exception cref="ValidateException"></exception>
        /// Author: HMDUC (20/07/2023)
        public void CheckReceiptExistBydCode(string? code, Guid? receiptId = null, bool isInsert = true)
        {
            bool isExistReceiptCode;
            var errorData = new Dictionary<string, string>();

            if (isInsert)
            {
                isExistReceiptCode = _receiptRepository.CheckIsDuplicate(code);
            }
            else
            {
                isExistReceiptCode = _receiptRepository.CheckIsDuplicate(code, receiptId);
            }

            var msgError = $"{ResourceVN.ReceiptCode} {code} {ResourceVN.Error_ReceiptCode_Dupli}";

            if (isExistReceiptCode)
            {
                errorData.Add("ReceiptCode", msgError);
                throw new ValidateException(errorData, (int)MISACode.Validate);
            }

        }

        /// <summary>
        /// Hàm check time của chứng từ
        /// </summary>
        /// <param name="receiptDate"></param>
        /// <param name="tranferDate"></param>
        /// <exception cref="ValidateException"></exception>
        /// Author: HMDUC (20/07/2023)
        public void CheckTime(DateTime? receiptDate, DateTime? tranferDate)
        {
            var errorData = new Dictionary<string, string>();

            if (tranferDate < receiptDate)
            {
                errorData.Add("TranferDate", ResourceVN.Error_TranferDate);
            }

            if (errorData.Count > 0)
            {
                throw new ValidateException(errorData, (int)MISACode.Validate);
            }
        }

        /// <summary>
        /// Hàm check phát sinh chứng từ phục vụ xóa
        /// </summary>
        /// <param name="receiptId">Mã chứng từ</param>
        /// <exception cref="ValidateException"></exception>
        /// Author: HMDUC (20/07/2023)
        public void CheckAccrued(Guid receiptId)
        {
            bool isAccrued = _receiptRepository.CheckIsAccrued(receiptId);
            var errorData = new Dictionary<string, string>();

            if (isAccrued)
            {
                errorData.Add("Accrued", ResourceVN.Err_Accrued);
            }

            if (errorData.Count > 0)
            {
                throw new ValidateException(errorData, (int)MISACode.Validate);
            }
        }

        #endregion
    }
}
