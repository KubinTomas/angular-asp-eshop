import { Http } from '@angular/http';
import { Injectable } from '@angular/core';
import { ServiceService } from './service.service';

@Injectable({
  providedIn: 'root'
})
export class ArticleService extends ServiceService {

  public createArticleUrl = "api/create/article";

  public getArticlesUrl = "api/get/articles";

  public getArticleUrl = "api/get/article/";

  public editArticleUrl = "api/edit/article/";

  public deleteArticleUrl = "api/delete/article/";

  public getLastInsertedArticlesUrl = "api/get/last/inserted/articles/";


  constructor(public http: Http) {
    super(http);
  }

}
