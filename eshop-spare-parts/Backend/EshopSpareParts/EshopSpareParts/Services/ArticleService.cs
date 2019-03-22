using AutoMapper;
using EshopSpareParts.Models;
using EshopSpareParts.Models.CustomReturnCodes;
using EshopSpareParts.Models.Db;
using EshopSpareParts.Models.DTO;
using EshopSpareParts.Models.DTO.ServicesReturnClasses;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace EshopSpareParts.Services
{
    public class ArticleService
    {

        private ApplicationDbContext _context;

        public ArticleService(ApplicationDbContext context)
        {
            this._context = context;
        }
        public async Task<ArticleServiceDto> CreateArticleAsync(ArticleDto articleDto)
        {
            var article = Mapper.Map<ArticleDto, Article>(articleDto);
            article.Created = DateTime.Now;

            _context.Articles.Add(article);

            await _context.SaveChangesAsync();

            articleDto.id = article.Id;

            return new ArticleServiceDto { ArticleDto = articleDto, StatusCode = ReturnCodes.Created };
        }

        public async Task<ArticleServiceDto> EditArticleAsync(ArticleDto articleDto)
        {
            var article = Mapper.Map<ArticleDto, Article>(articleDto);
            var articleInDb = await _context.Articles.SingleOrDefaultAsync(c => c.Id == articleDto.id);

            articleInDb.Header = article.Header;
            articleInDb.Content = article.Content;

            await _context.SaveChangesAsync();

            return new ArticleServiceDto { ArticleDto = articleDto, StatusCode = ReturnCodes.Ok };
        }


        public async Task<ArticleServiceDto> DeleteArticleAsync(int articleId)
        {
            var articleInDb = await _context.Articles.SingleOrDefaultAsync(c => c.Id == articleId);

            _context.Articles.Remove(articleInDb);

            await _context.SaveChangesAsync();

            return new ArticleServiceDto { StatusCode = ReturnCodes.Ok };
        }

        public async Task<ArticleServiceDto> GetArticlesAsync()
        {
            var articles = await _context.Articles.ToListAsync();

            var articlesDto = new List<ArticleDto>();

            foreach (var article in articles)
            {
                var articleDto = Mapper.Map<Article, ArticleDto>(article);

                articlesDto.Add(articleDto);
            }

            return new ArticleServiceDto { ArticlesDto = articlesDto, StatusCode = ReturnCodes.Ok };
        }
        public async Task<ArticleServiceDto> GetArticleAsync (int articleId)
        {
            var articleInDb = await _context.Articles.SingleOrDefaultAsync(c => c.Id == articleId);

            var article = Mapper.Map<Article, ArticleDto>(articleInDb);

            return new ArticleServiceDto { ArticleDto = article, StatusCode = ReturnCodes.Ok };
        }
        public async Task<ArticleServiceDto> GetLastInsertedArticles(int itemCount)
        {
            var articles = await _context.Articles.OrderByDescending(c => c.Id).Take(itemCount).ToListAsync();

            var articlesDto = new List<ArticleDto>();

            foreach (var article in articles)
            {
                var articleDto = Mapper.Map<Article, ArticleDto>(article);

                articlesDto.Add(articleDto);
            }

            return new ArticleServiceDto { ArticlesDto = articlesDto, StatusCode = ReturnCodes.Ok };
        }


    }


}

