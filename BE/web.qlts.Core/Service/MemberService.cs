﻿using AutoMapper;
using AutoMapper.Execution;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using web.qlts.Application.Dto.Member;
using web.qlts.Application.Interface;
using web.qlts.Domain.Entity;
using web.qlts.Domain.Interface.Repository;

namespace web.qlts.Application.Service
{
    public class MemberService : BaseService<MemberReceipt, MemberDto, MemberInsertDto, MemberUpdateDto, MemberTranferDto>, IMemberService
    {
        #region Field
        private readonly IMemberRepository _memberRepository;
        #endregion

        #region contructor
        public MemberService(IMemberRepository memberRepository, IMapper mapper, IUnitOfWork unitOfWork) : base(memberRepository, mapper, unitOfWork)
        {
            _memberRepository = memberRepository;

        }

        /// <summary>
        /// Hàm lấy ra ds ban giao nhận theo Id của chừn từ
        /// </summary>
        /// <param name="receiptId">Id chứng từ</param>
        /// <returns>Danh sách ban giao nhận</returns>
        /// Author: HMDUC(06/08/2023)
        public async Task<List<MemberDto>> GetMemberByReceiptId(Guid receiptId)
        {
            var response = await _memberRepository.GetMemberByReceiptIdAsync(receiptId);

            var result = _mapper.Map<List<MemberDto>>(response);

            var listOrder = result.OrderBy(item => item.STT).ToList();

            return listOrder;
        }

        #endregion

        /// <summary>
        /// Hàm lấy ra ds ban giao nhận trước đó
        /// </summary>
        /// <returns>Danh sách ban giao nhận</returns>
        /// Author: HMDUC (05/08/2023)
        public async Task<List<MemberDto>> GetPrevMemberAsync()
        {
            var response = await _memberRepository.GetPrevMemberAsync();

            var result = _mapper.Map<List<MemberDto>>(response);

            return result;
        }



    }
}
