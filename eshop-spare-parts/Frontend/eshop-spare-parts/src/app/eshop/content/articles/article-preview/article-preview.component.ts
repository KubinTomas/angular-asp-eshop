import { Article } from './../../../../models/dbModels/article.model';
import { Component, OnInit, Input, ViewEncapsulation } from '@angular/core';
import * as $ from 'jquery';

@Component({
  selector: 'app-article-preview',
  templateUrl: './article-preview.component.html',
  styleUrls: ['./article-preview.component.scss'],
  encapsulation: ViewEncapsulation.None
})
export class ArticlePreviewComponent implements OnInit {

  
  @Input()
  article: Article;

  constructor() { }

  ngOnInit() {}

}
