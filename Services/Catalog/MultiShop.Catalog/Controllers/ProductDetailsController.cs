using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MultiShop.Catalog.Dtos.ProductDetailDtos;
using MultiShop.Catalog.Dtos.ProductImageDtos;
using MultiShop.Catalog.Services.ProductDetailServices;
using MultiShop.Catalog.Services.ProductImageServices;

namespace MultiShop.Catalog.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class ProductDetailsController : ControllerBase
	{
		private readonly IProductDetailService _productDetailService;

		public ProductDetailsController(IProductDetailService productDetailService)
		{
			_productDetailService = productDetailService;
		}

		[HttpGet]
		public async Task<IActionResult> ProductDetailList()
		{
			var values = await _productDetailService.GetAllProductDetailAsync();
			return Ok(values);
		}

		[HttpGet("{id}")]

		public async Task<IActionResult> GetByIdProductDetailAsync(string id)
		{
			var values = await _productDetailService.GetByIdProductDetailAsync(id);
			return Ok(values);
		}

		[HttpPost]
		public async Task<IActionResult> CreateProductDetail(CreateProductDetailDto createProductDetailDto)
		{
			await _productDetailService.CreateProductDetailAsync(createProductDetailDto);
			return Ok("ProductDetail Başarıyla Eklendi");
		}

		[HttpDelete]
		public async Task<IActionResult> DeleteProductDetail(string id)
		{
			await _productDetailService.DeleteProductDetailAsync(id);
			return Ok("ProductDetail Başarı Şekilde Silindi");
		}

		[HttpPut]
		public async Task<IActionResult> UpdateProductDetail(UpdateProductDetailDto updateProductDetailDto)
		{
			await _productDetailService.UpdateProductDetailAsync(updateProductDetailDto);
			return Ok("ProductDetail Güncellendi");
		}













	}
}
