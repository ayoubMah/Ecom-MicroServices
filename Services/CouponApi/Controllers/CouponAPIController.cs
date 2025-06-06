using Micro.Services.CouponApi.Model;
using Micro.Services.CouponApi.Model.DTO;
using Microsoft.AspNetCore.Mvc;
using Services.CouponApi.Data;

namespace Services.CouponApi.Controllers
{
    [Route("api/coupons")]
    [ApiController]
    public class CouponAPIController : Controller
    {
        private readonly AppDbContext _context;
        private ResponseDTO  _response;

        public CouponAPIController(AppDbContext context)
        {
            _context = context;
            _response = new ResponseDTO();
        }

        [HttpGet]
        public ResponseDTO Get()
        {
            try
            {
                IEnumerable<Coupon> objList = _context.Coupons.ToList();
                _response.Result = objList;
            }
            catch (Exception e)
            {
                _response.IsSuccess = false;
                _response.Message = e.Message;
            }
            return _response;
        }
        
        [HttpGet]
        [Route("{id:int}")]
        public ResponseDTO Get(int id)
        {
            try
            {
                Coupon objList = _context.Coupons.First(u =>u.CouponId == id);
                _response.Result = objList;
            }
            catch (Exception e)
            {
                _response.IsSuccess = false;
                _response.Message = e.Message;
            }
            return _response;
        }
    }
}

