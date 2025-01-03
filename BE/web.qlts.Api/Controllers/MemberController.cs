﻿using Microsoft.AspNetCore.Mvc;
using web.qlts.Application.Dto.Member;
using web.qlts.Application.Interface;

namespace web.qlts.Api.Controllers
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public class MemberController : BaseController<MemberDto, MemberInsertDto, MemberUpdateDto, MemberTranferDto>
    {
        private readonly IMemberService _memberService;

        public MemberController(IMemberService memberService) : base(memberService)
        {
            _memberService = memberService;
        }


        /// <summary>
        /// Api lấy ra ban giao được trc đó
        /// </summary>
        /// <returns>Danh sách ban giao nhận</returns>
        /// Author: HMDUC (06/08/2023)
        [HttpGet("GetPrevMember")]
        public async Task<IActionResult> GetPrevMember()
        {
            var result = await _memberService.GetPrevMemberAsync();

            return Ok(result);
        }

        /// <summary>
        /// Api lấy ra danh sách ban  giao  nhận theo Id của chứng từ
        /// </summary>
        /// <param name="receiptId"></param>
        /// <returns>Danh sách ban giao nhận</returns>
        /// Author: HMDUC (06/08/2023)
        [HttpGet("ReceiptId/{receiptId}")]
        public async Task<IActionResult> GetMemberByReceiptId(Guid receiptId)
        {
            var result = await _memberService.GetMemberByReceiptId(receiptId);

            return Ok(result);
        }

    }
}
