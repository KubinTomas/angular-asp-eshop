import { Component, OnInit, Input, ViewEncapsulation } from '@angular/core';
import { Article } from '../../../../../models/dbModels/article.model';

@Component({
  selector: 'app-new-art-preview',
  templateUrl: './new-art-preview.component.html',
  styleUrls: ['./new-art-preview.component.scss'],
  encapsulation: ViewEncapsulation.None
})
export class NewArtPreviewComponent implements OnInit {

  @Input()
  article: Article;

  constructor() { }

  ngOnInit() {
  }

}
