import { Component, OnInit, ViewEncapsulation } from '@angular/core';
import { ArticleService } from '../../../services/http/article.service';

@Component({
  selector: 'app-articles',
  templateUrl: './articles.component.html',
  styleUrls: ['./articles.component.scss'],
  providers: [ArticleService],
  encapsulation: ViewEncapsulation.None
})
export class ArticlesComponent implements OnInit {

 
  isLoading;
  articles;

  constructor(
    private articleService: ArticleService,
    ) { }

  ngOnInit() {
    this.isLoading = true;
    this.loadItems();
  }

  loadItems() {
    this.articleService.getAll(this.articleService.getArticlesUrl)
      .subscribe(response => {
        this.articles = response.ArticlesDto;
        this.isLoading = false;
      });
  }

}
