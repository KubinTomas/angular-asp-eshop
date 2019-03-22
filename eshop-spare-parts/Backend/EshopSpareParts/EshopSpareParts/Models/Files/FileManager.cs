using EshopSpareParts.Models.Db;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace EshopSpareParts.Models.Files
{
    public class FileManager
    {
        private ApplicationDbContext _context;
        private string _defaultFolderPath;

        private UploadedType _currentUploadedType;

        private enum UploadedType
        {
            Preview,
            OtherImages,
            Article
        }

        public FileManager(ApplicationDbContext context)
        {
            this._context = context;
            _defaultFolderPath = "~/images/"; //  local -> ~/bin/media/"
           // _defaultFolderPath = "~/bin/media/"; //  local -> ~/bin/media/"
        }

        public string GetFolderPath()
        {
            return _defaultFolderPath;
        }

        public void CreateItemFolder(int itemId)
        {
            System.IO.Directory.CreateDirectory(ConstructItemPath("", "item_" + itemId));
        }

        /// <summary>
        /// Save file on into specific path and override existing item
        /// </summary>
        /// <param name="file"></param>
        /// <param name="parameters"></param>
        public async Task SaveFileWithOverride(HttpPostedFile file, FolderUploadParametrs parameters)
        {
            var filePath = ConstructItemPath(GetPathFromParams(parameters), Guid.NewGuid() + Path.GetExtension(file.FileName));

            try
            {
                DeleteFile(filePath);

                file.SaveAs(filePath);

                await EditUrlInDbObject(filePath, parameters);
            }
            catch (Exception)
            {

                throw;
            }
        }
        private string SplitPath(string filePath)
        {
            var splittedPath = filePath.Split('\\');
            bool canAdd = false;

            var newPath = "";

            foreach (var part in splittedPath)
            {
                if (part == "images")
                    canAdd = true;

                if (canAdd)
                    newPath += "/" + part;
            }

            return newPath;
        }
        private async Task EditUrlInDbObject(string filePath, FolderUploadParametrs parameters)
        {
            filePath = SplitPath(filePath);

            switch (_currentUploadedType)
            {
                case UploadedType.Preview:
                    var itemInDb = await _context.Items.SingleAsync(c => c.Id == parameters.ItemId);
                    itemInDb.ImagePath = filePath;
                    await _context.SaveChangesAsync();
                    break;
                case UploadedType.OtherImages:
                    var itemImage = new ItemImage { ItemId = parameters.ItemId.Value, ImagePath = filePath };
                    _context.ItemImages.Add(itemImage);
                    await _context.SaveChangesAsync();
                    break;
                case UploadedType.Article:
                    var articleInDb = await _context.Articles.SingleAsync(c => c.Id == parameters.ArticleId);
                    articleInDb.ImagePath = filePath;
                    await _context.SaveChangesAsync();
                    break;
                default:
                    break;
            }


        }
        private string GetPathFromParams(FolderUploadParametrs parameters)
        {
            if (parameters.IsPreviewImage.HasValue && parameters.IsPreviewImage.Value)
                _currentUploadedType = UploadedType.Preview;
            else if (parameters.ArticleId.HasValue)
                _currentUploadedType = UploadedType.Article;
            else
                _currentUploadedType = UploadedType.OtherImages;

            if (parameters.ArticleId.HasValue)
            {
                return "articles/";
            }
            if (parameters.ItemId.HasValue)
            {
                return "item_" + parameters.ItemId.Value + "/";
            }

            return "";
        }
        /// <summary>
        /// Check if item (picture, pdf), already is in the folder
        /// </summary>
        public bool DoesItemExists(string path)
        {
            return File.Exists(path);
        }
        public void DeleteFile(string path)
        {
            if (DoesItemExists(path))
                File.Delete(path);
        }
        private string ConstructItemPath(string path, string fileName)
        {
            return HttpContext.Current.Server.MapPath(_defaultFolderPath + path + fileName);
        }
    }
}