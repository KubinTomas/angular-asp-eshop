using EshopSpareParts.Models.Files;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web;
using System.Web.Http;
using System.Web.Http.Cors;

namespace EshopSpareParts.Controllers.Api.Eshop
{
    [EnableCors(methods: "*", headers: "*", origins: "*")]
    public class FileController : ApiController
    {
        private FileManager _fileManager;

        public FileController(FileManager fileManager)
        {
            _fileManager = fileManager;
        }

        //[HttpPost, Route("api/upload/image")]
        //public async Task<IHttpActionResult> UploadFile([FromUri]int? itemId = null, [FromUri]int? isPreviewImage = null, [FromUri]int? articleId = null)
        //{
        //    HttpResponseMessage response = new HttpResponseMessage();
        //    var httpRequest = HttpContext.Current.Request;

        //    var parameters = new FolderUploadParametrs();
        //    parameters.ItemId = itemId;
        //    parameters.ArticleId = articleId;
        //    parameters.IsPreviewImage = (isPreviewImage.HasValue && isPreviewImage.Value == 1 ) ? true : false;

        //    if (httpRequest.Files.Count > 0)
        //    {
        //        foreach (string file in httpRequest.Files)
        //        {
        //            var postedFile = httpRequest.Files[file];

        //           await _fileManager.SaveFileWithOverride(postedFile, parameters);
        //        }
        //    }
        //    return Ok();
        //}
        [HttpPost, Route("api/upload/image/{itemId}/{isPreviewImage}/{articleId}")]
        public async Task<IHttpActionResult> UploadFile(int? itemId = null, int? isPreviewImage = null, int? articleId = null)
        {
            HttpResponseMessage response = new HttpResponseMessage();
            var httpRequest = HttpContext.Current.Request;

            var parameters = new FolderUploadParametrs();
            parameters.ItemId = itemId;
            parameters.ArticleId = articleId;
            parameters.IsPreviewImage = (isPreviewImage.HasValue && isPreviewImage.Value == 1) ? true : false;

            if (httpRequest.Files.Count > 0)
            {
                int counter = 0;
                foreach (string file in httpRequest.Files)
                {
                    //var postedFile = httpRequest.Files[file];
                    var postedFile = httpRequest.Files[counter];


                    await _fileManager.SaveFileWithOverride(postedFile, parameters);

                    counter++;
                }
            }
            return Ok();
        }
    }
}
