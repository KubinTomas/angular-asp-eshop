import { SnackBarService } from 'src/app/services/others/snack-bar.service';
import { Article } from './../../../../models/dbModels/article.model';
import { Component, OnInit, ViewChild } from '@angular/core';
import { ArticleService } from '../../../../services/http/article.service';
import { MatPaginator, MatTableDataSource, MatSort } from '@angular/material';

@Component({
  selector: 'app-adm-articles-output',
  templateUrl: './adm-articles-output.component.html',
  styleUrls: ['./adm-articles-output.component.scss'],
  providers: [ArticleService]
})
export class AdmArticlesOutputComponent implements OnInit {
  isLoading;
  articles: Article[] = [];
  displayedColumns: string[] = ['id', 'header', 'created', 'settings'];
  dataSource = new MatTableDataSource<Article>(this.articles);


  constructor(
    private articleService: ArticleService,
    private snackBarService: SnackBarService
  ) { }


  @ViewChild(MatPaginator) paginator: MatPaginator;
  @ViewChild(MatSort) sort: MatSort;

  ngOnInit() {
    this.isLoading = true;
    this.loadArticles();

   
  }

  loadArticles() {
    this.articleService
      .getAll(this.articleService.getArticlesUrl)
      .subscribe(response => {
        this.articles = response.ArticlesDto;
        this.dataSource = new MatTableDataSource<Article>(this.articles);
        setTimeout(() => this.dataSource.paginator = this.paginator);
        setTimeout(() => this.dataSource.sort = this.sort);
        this.isLoading = false;

      });

  }

  onDelete(article) {
    const index = this.articles.indexOf(article);
    if (index !== -1) {
      this.articleService.delete(article.id, this.articleService.deleteArticleUrl)
        .subscribe(response => {
          this.snackBarService.openSnackBar('Článek byl smazán.', 'Ok');
          this.articles.splice(index, 1);
        });

    }
  }

  applyFilter(filterValue: string) {
    this.dataSource.filter = filterValue.trim().toLowerCase();
  }
}
export interface Article {
  id: number;
  header: string;
  created: string;
  settings: string;
}
