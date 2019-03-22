import { FileService } from './../../../../services/http/file.service';
import { AuthenticationService } from './../../../../services/http/authentication.service';
import { ArticleService } from './../../../../services/http/article.service';
import { ActivatedRoute, Router } from '@angular/router';
import { Component, OnInit } from '@angular/core';
import { FormBuilder, Validators } from '@angular/forms';
import { Location } from '@angular/common';
import { SnackBarService } from 'src/app/services/others/snack-bar.service';
import { ReturnCodes } from '../../../../models/others/return-codes.model';
import { Article } from './../../../../models/dbModels/article.model';

@Component({
  selector: 'app-adm-article-form',
  templateUrl: './adm-article-form.component.html',
  styleUrls: ['./adm-article-form.component.scss'],
  providers: [ArticleService, AuthenticationService]
})
export class AdmArticleFormComponent implements OnInit {
  form;
  isLoading;
  submitButtonText = 'Vytvořit';

  article: Article;
  bgImgPath;
  previewImageFile;

  constructor(
    private fb: FormBuilder,
    private location: Location,
    private route: ActivatedRoute,
    private snackBarService: SnackBarService,
    private router: Router,
    private articleService: ArticleService,
    private authService: AuthenticationService,
    private fileService: FileService
  ) { }

  ngOnInit() {
    this.article = new Article();
    this.isLoading = true;

    this.loadArticle();
  }
  loadArticle() {
    this.route.paramMap.subscribe(response => {
      let articleId = response.get('id');

      if (articleId)
        this.articleService
          .get(articleId, this.articleService.getArticleUrl)
          .subscribe(response => {
            this.article = response.ArticleDto;
            this.submitButtonText = 'Editovat';
            this.buildForm();
          });
      else this.buildForm();
    });
  }
  submit(form) {
    if (this.article.id) this.edit(form.value);
    else this.create(form.value);
  }
  create(article: Article) {
    this.isLoading = true;
    article.userId = this.authService.currentUser.unique_name;

    this.articleService
      .create(article, this.articleService.createArticleUrl)
      .subscribe(response => {
        let body = JSON.parse(response.text());

        let articleId = body.ArticleDto.id;

        if (body.StatusCode == ReturnCodes.Created) {
          this.uploadFile(articleId, 'Článek byl upraven');

          // this.afterSuccessSubmit('Článek byl vytvořen');
        }
      });
  }
  edit(article: Article) {
    article.id = this.article.id;

    this.articleService
      .update(article, this.articleService.editArticleUrl)
      .subscribe(response => {
        let body = JSON.parse(response.text());

        let articleId = body.ArticleDto.id;

        if (body.StatusCode == ReturnCodes.Ok) {
          this.uploadFile(articleId, 'Článek byl upraven');
          // this.afterSuccessSubmit('Článek byl upraven');
        }
      });
  }
  onFileSelect(fileInput: any) {
    if (fileInput.target.files.length > 0) {
      this.bgImgPath = fileInput.target.files[0].name;
      this.previewImageFile = fileInput.target.files[0];
    } else {
      this.bgImgPath = '';
      this.previewImageFile = null;
    }
  }
  afterSuccessSubmit(message) {
    this.snackBarService.openSnackBar(message, 'Ok');
    this.router.navigate(['/administration/articles']);
  }
  buildForm() {
    this.form = this.fb.group({
      header: [this.article.header, [Validators.required]],
      content: [this.article.content, [Validators.required]]
    });

    this.isLoading = false;
  }
  uploadFile(articleId, snackBarText) {
    if (!this.previewImageFile) {
      this.afterSuccessSubmit(snackBarText);
    } else {
      let formData = new FormData();
      formData.append(this.previewImageFile.name, this.previewImageFile);

      this.fileService
        .uploadFile(formData, null, null, articleId)
        .subscribe(response => {
          this.afterSuccessSubmit(snackBarText);
        });
    }
  }

  onBack() {
    this.location.back();
  }
}
