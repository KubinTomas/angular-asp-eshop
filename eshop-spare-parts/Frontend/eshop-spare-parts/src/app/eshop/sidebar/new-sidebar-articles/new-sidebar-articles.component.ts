import { ArticleService } from './../../../services/http/article.service';
import { Component, OnInit, ViewEncapsulation } from '@angular/core';
import * as $ from 'jquery';
import 'slick-carousel';

@Component({
  selector: 'app-new-sidebar-articles',
  templateUrl: './new-sidebar-articles.component.html',
  styleUrls: ['./new-sidebar-articles.component.scss'],
  providers: [ArticleService],
  encapsulation: ViewEncapsulation.None
})
export class NewSidebarArticlesComponent implements OnInit {

  isLoading;
  articles;

  isSlickInit = false;

  constructor(
    private articleService: ArticleService,
  ) { }

  ngOnInit() {
    this.isLoading = true;
    this.loadLastInsertedArticles();
  }

  loadLastInsertedArticles(itemCount = 5) {
    this.articleService.get(itemCount, this.articleService.getLastInsertedArticlesUrl)
      .subscribe(response => {
        this.articles = response.ArticlesDto;

        this.initSlick();
      });
  }
  initSlick() {
    this.isLoading = false;

    $(document).ready(function() {
      $('#slickArticleVertical').slick({
        dots: false,
        arrows: false,
        vertical: true,
        slidesToShow: 3,
        slidesToScroll: 1,
        autoplay: true,
        autoplaySpeed: 1700
      });
    });

    setTimeout(() => {
      this.isSlickInit = true;
    }, 500);

  }
  getOpacity() {
    if (this.isSlickInit) return 1;
    else return 0;
  }
  getDisplay() {
    if (this.isSlickInit) return 'initial';
    else return 'none';
  }
}
