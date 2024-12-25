using Dapper;
using System.Reflection;
using web.qlts.Domain.Entity;
using web.qlts.Domain.Interface.Repository;

namespace web.qlts.Infrastructure.Repository
{
    public class AccountRepository : BaseRepository<Account>, IAccountRepo
    {

        public AccountRepository(IUnitOfWork unitOfWork) : base(unitOfWork)
        {

        }

        /// <summary>
        /// Lấy thông tin người dùng
        /// </summary>
        /// <param name="account"></param>
        /// <returns></returns>
        public async Task<Account> GetAccount(Account account)
        {
            var sqlCommand = "SELECT * FROM Accounts a WHERE a.Email = @Email AND a.Password = @Password";
            DynamicParameters param = new DynamicParameters();
            param.Add("@Email", account.Email);
            param.Add("@Password", account.Password);

            var lst = await _uow.Connection.QueryAsync<Account>(sqlCommand, param);


            var result = lst.ToList();

            return result.FirstOrDefault();
        }

        /// <summary>
        /// Thêm mới người dùng
        /// </summary>
        /// <param name="account"></param>
        /// <returns></returns>
        public async Task<bool> InsertAccount(Account account)
        {
            var properties = typeof(Account).GetProperties(BindingFlags.Public | BindingFlags.Instance);

            // Build cột và tham số SQL động
            var columnNames = string.Join(", ", properties.Select(p => p.Name)); // Tên cột
            var paramNames = string.Join(", ", properties.Select(p => "@" + p.Name)); // Tên tham số

            // Tạo câu SQL động
            string sql = $"INSERT INTO Accounts ({columnNames}) VALUES ({paramNames})";

            // Tạo DynamicParameters
            var parameters = new DynamicParameters();
            foreach (var property in properties)
            {
                // Lấy giá trị của từng property
                var value = property.GetValue(account);

                // Nếu là property AccountId và giá trị null, gán Guid mới
                if (property.Name == "AccountId")
                {
                    value = Guid.NewGuid();
                    property.SetValue(account, value);
                }

                // Thêm tham số vào DynamicParameters
                parameters.Add("@" + property.Name, value);
            }

            var rowEff = await _uow.Connection.ExecuteAsync(sql, parameters);

            return rowEff > 0;
        }
    }
}
