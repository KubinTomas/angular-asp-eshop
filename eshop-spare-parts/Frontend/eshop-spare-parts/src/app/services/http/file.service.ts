import { Http } from '@angular/http';
import { Injectable } from '@angular/core';
import { url } from '../../models/others/url';


@Injectable({
  providedIn: 'root'
})
export class FileService {

  constructor(private http: Http) { }

  uploadFile(formData, itemId?: string, isPreviewImage?: string, articleId?: string) {
    console.log(url + 'api/upload/image/' + itemId + '/' + isPreviewImage + '/' + articleId);
    return this.http.post(url + 'api/upload/image/' + itemId + '/' + isPreviewImage + '/' + articleId, formData);

    // return this.http.post(url + 'api/upload/image'+ (itemId?('?itemId=' + itemId):'?') + (isPreviewImage?('&isPreviewImage=' + isPreviewImage): '?') + (articleId?('&articleId=' + articleId): ''), formData);
  }

  getImageName(imgPath: string) {

    if (!imgPath)
      return "";

    let splittedPath = imgPath.split("\\");

    return splittedPath[splittedPath.length - 1];
  }

}
