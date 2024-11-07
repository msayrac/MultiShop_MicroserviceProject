﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MultiShop.Catalog.Dtos.ProductDtos;
using MultiShop.Catalog.Dtos.ProductImageDtos;
using MultiShop.Catalog.Services.ProductImageServices;
using MultiShop.Catalog.Services.ProductServices;

namespace MultiShop.Catalog.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class ProductImagesController : ControllerBase
	{
		private readonly IProductImageService _productImageService;

		public ProductImagesController(IProductImageService productImageService)
		{
			_productImageService = productImageService;
		}

		[HttpGet]
		public async Task<IActionResult> ProductImageList()
		{
			var values = await _productImageService.GetAllProductImageAsync();
			return Ok(values);
		}

		[HttpGet("{id}")]

		public async Task<IActionResult> GetByIdProductImageAsync(string id)
		{
			var values = await _productImageService.GetByIdProductImageAsync(id);
			return Ok(values);
		}

		[HttpPost]
		public async Task<IActionResult> CreateProductImage(CreateProductImageDto createProductImageDto)
		{
			await _productImageService.CreateProductImageAsync(createProductImageDto);
			return Ok("ProductImage Başarıyla Eklendi");
		}

		[HttpDelete]
		public async Task<IActionResult> DeleteProductImage(string id)
		{
			await _productImageService.DeleteProductImageAsync(id);
			return Ok("ProductImage Başarı Şekilde Silindi");
		}

		[HttpPut]
		public async Task<IActionResult> UpdateProductImage(UpdateProductImageDto updateProductImageDto)
		{
			await _productImageService.UpdateProductImageAsync(updateProductImageDto);
			return Ok("ProductImage Güncellendi");
		}














	}
}
