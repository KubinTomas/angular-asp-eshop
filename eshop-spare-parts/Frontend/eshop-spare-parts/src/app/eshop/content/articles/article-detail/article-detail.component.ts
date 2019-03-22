import { ActivatedRoute } from '@angular/router';
import { Article } from './../../../../models/dbModels/article.model';
import { Component, OnInit, ViewEncapsulation } from '@angular/core';
import { ArticleService } from '../../../../services/http/article.service';
import * as $ from 'jquery';


@Component({
  selector: 'app-article-detail',
  templateUrl: './article-detail.component.html',
  styleUrls: ['./article-detail.component.scss'],
  providers: [ArticleService],
  encapsulation: ViewEncapsulation.None
})
export class ArticleDetailComponent implements OnInit {

  article: Article;

  isLoading;

  constructor(
    private articleService: ArticleService,
    private route: ActivatedRoute
    ) { }

  ngOnInit() {
    this.isLoading = true;
    this.route.paramMap.subscribe(response => {
      let id = response.get('id');
      this.loadArticle(id);
    });

    $(document).ready(function () {
      var set = false;
      setTimeout(function () {
        if (!set) {
            var text = $('.description').text();
            $('.description').html(text);
          set = true;
        } else {
          return false;
        }
      }, 2000);
    });
  }

  loadArticle(id) {
    this.articleService
      .get(id, this.articleService.getArticleUrl)
      .subscribe(response => {
        this.article = response.ArticleDto;
        this.isLoading = false;
      });
  }


}
