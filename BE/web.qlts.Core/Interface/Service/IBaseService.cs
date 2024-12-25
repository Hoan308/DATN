namespace web.qlts.Application.Interface.Service
{
    public interface IBaseService<TEntityDto, TEntityInsertDto, TEntityUpdateDto>
    {
        /// <summary>
        ///  Function get all Asset
        /// </summary>
        /// <returns>List Entity</returns>
        /// Author: HMDUC (16/06/2023)
        Task<List<TEntityDto>> GetAllAsync();


        /// <summary>
        /// Function  Get Entity by Id
        /// </summary>
        /// <param name="id"></param>
        /// <returns>Entity</returns>
        /// Author: HMDUC (16/06/2023)
        Task<TEntityDto> GetByIdAsync(Guid id);



        /// <summary>
        /// Function Insert Entity 
        /// </summary>
        /// <param name="asset"></param>
        /// <returns>
        /// New Asset
        /// </returns>
        /// Author: HMDUC (16/06/2023)
        Task<int> InsertAsync(TEntityInsertDto entityInsert);

        /// <summary>
        /// Function Update Entity
        /// </summary>
        /// <param name="asset"></param>
        /// <returns>
        ///  Asset
        /// </returns>
        ///  Author: HMDUC (16/06/2023)
        Task<int> UpdateAsync(TEntityUpdateDto entityUpdateDto);


        /// <summary>
        /// Function Delete Entity by ID
        /// </summary>
        /// <param name="assetId"></param>
        /// <returns>
        ///  Count Row Affect
        /// </returns>
        /// Author: HMDUC (16/06/2023)
        Task<int> DeleteAsync(Guid id);

        /// <summary>
        /// Function Delete Multiple Entity
        /// </summary>
        /// <param name="assetIds">List Id</param>
        /// <returns>
        /// Count Row Affect
        /// </returns>
        /// Author: HMDUC (16/06/2023)
        Task<int> DeleteMulAsync(List<Guid> ids);



    }
}
