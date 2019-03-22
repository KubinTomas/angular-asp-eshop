import { Component, OnInit, ViewEncapsulation } from '@angular/core';
import { ArticleService } from '../../../../services/http/article.service';
import * as $ from 'jquery';
import 'slick-carousel';

@Component({
  selector: 'app-new-articles',
  templateUrl: './new-articles.component.html',
  styleUrls: ['./new-articles.component.scss'],
  providers: [ArticleService],
  encapsulation: ViewEncapsulation.None
})
export class NewArticlesComponent implements OnInit {


  isLoading;
  articles;
  isSlickInit;

  constructor(
    private articleService: ArticleService,
  ) { }

  ngOnInit() {
    this.isLoading = true;
    this.isSlickInit = false;

    this.loadLastInsertedArticles();
  }

  loadLastInsertedArticles(itemCount = 12) {
    this.articleService.get(itemCount, this.articleService.getLastInsertedArticlesUrl)
      .subscribe(response => {
        this.articles = response.ArticlesDto;
        this.isLoading = false;

        this.initSlider();
      });
  }
  initSlider() {
    $(document).ready(function () {
      $('.slick-articles').slick({
        dots: false,
        arrows: true,
        infinite: true,
        autoplay: true,
        slidesToShow: 3,
        slidesToScroll: 1,
        speed: 2000
      });

    });
    setTimeout(() => {
      this.isSlickInit = true;
    }, 500);
  }
  getSlickDisplay() {
    if (this.isSlickInit) return 'initial';
    else return 'none';
  }
}
