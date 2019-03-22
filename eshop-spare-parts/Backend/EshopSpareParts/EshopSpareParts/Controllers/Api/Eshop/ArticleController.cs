using EshopSpareParts.Models.DTO;
using EshopSpareParts.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Cors;

namespace EshopSpareParts.Controllers.Api.Eshop
{
    [EnableCors(methods: "*", headers: "*", origins: "*")]
    public class ArticleController : ApiController
    {
        private ArticleService _service;

        public ArticleController(ArticleService service)
        {
            _service = service;
        }

        [HttpPost, Route("api/create/article")]
        public async Task<IHttpActionResult> CreateArticle(ArticleDto articleDto)
        {
            var articleServiceDto = await _service.CreateArticleAsync(articleDto);

            return Created(new Uri(Request.RequestUri + articleServiceDto.ArticleDto.id.ToString()), articleServiceDto);
        }
        [HttpPut, Route("api/edit/article")]
        public async Task<IHttpActionResult> EditArticle(ArticleDto articleDto)
        {
            var articleServiceDto = await _service.EditArticleAsync(articleDto);

            return Ok(articleServiceDto);
        }
        [HttpDelete, Route("api/delete/article/{articleId}")]
        public async Task<IHttpActionResult> DeleteArticle(int articleId)
        {
            var articleServiceDto = await _service.DeleteArticleAsync(articleId);

            return Ok(articleServiceDto);
        }
        [HttpGet, Route("api/get/articles")]
        public async Task<IHttpActionResult> GetArticles()
        {
            var articleServiceDto = await _service.GetArticlesAsync();

            return Ok(articleServiceDto);
        }
        [HttpGet, Route("api/get/article/{itemId}")]
        public async Task<IHttpActionResult> GetArticle(int itemId)
        {
            var articleServiceDto = await _service.GetArticleAsync(itemId);

            return Ok(articleServiceDto);
        }
        [HttpGet, Route("api/get/last/inserted/articles/{itemCount}")]
        public async Task<IHttpActionResult> GetLastInsertedArticles(int itemCount)
        {
            var articleServiceDto = await _service.GetLastInsertedArticles(itemCount);

            return Ok(articleServiceDto);
        }
    }
}
