using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using SignalR.BusinessLayer.Abstract;
using SignalR.DtoLayer.TestimonialDto;
using SignalR.EntityLayer.Entities;

namespace SignalRApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TestimonialController : ControllerBase
    {
        private readonly ITestimonialService _TestimonialService;
        private readonly IMapper _mapper;

        public TestimonialController(ITestimonialService TestimonialService, IMapper mapper)
        {
            _TestimonialService = TestimonialService;
            _mapper = mapper;
        }

        [HttpGet]
        public IActionResult TestimonialList()
        {
            var value = _mapper.Map<List<ResultTestimonialDto>>(_TestimonialService.TGetListAll());
            return Ok(value);
        }
        [HttpPost]
        public IActionResult CreateTestimonial(CreateTestimonialDto createTestimonialDto)
        {
            _TestimonialService.TAdd(new Testimonial()
            {
              Comment = createTestimonialDto.Comment,
              ImageUrl = createTestimonialDto.ImageUrl,
              Name = createTestimonialDto.Name,
              Status = createTestimonialDto.Status,
              Title = createTestimonialDto.Title
            });
            return Ok("Müşteri Yorum Bilgisi Eklendi");
        }
        [HttpDelete("{id}")]
        public IActionResult DeleteTestimonial(int id)
        {
            var value = _TestimonialService.TGetByID(id);
            _TestimonialService.TDelete(value);
            return Ok("Müşteri Yorum Bilgisi Silindi");
        }
        [HttpGet("GetTestimonial")]
        public IActionResult GetTestimonial(int id)
        {
            var value = _TestimonialService.TGetByID(id);
            return Ok(value);
        }
        [HttpPut]
        public IActionResult UpdateTestimonial(UpdateTestimonialDto updateTestimonialDto)
        {
            _TestimonialService.TUpdate(new Testimonial()
            {
                TestimonialID = updateTestimonialDto.TestimonialID,
                Comment = updateTestimonialDto.Comment,
                ImageUrl = updateTestimonialDto.ImageUrl,
                Name = updateTestimonialDto.Name,
                Status = updateTestimonialDto.Status,
                Title = updateTestimonialDto.Title
            });
            return Ok("Müşteri Yorum Bilgisi Güncellendi");
        }
    }
}