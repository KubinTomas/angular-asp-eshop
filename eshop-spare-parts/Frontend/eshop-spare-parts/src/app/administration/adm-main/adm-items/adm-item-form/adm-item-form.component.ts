import { FileService } from './../../../../services/http/file.service';
import { ReturnCodes } from './../../../../models/others/return-codes.model';
import { ItemService } from './../../../../services/http/item.service';
import { Item } from './../../../../models/dbModels/item.model';
import { Router, ActivatedRoute } from '@angular/router';
import { SnackBarService } from './../../../../services/others/snack-bar.service';
import { FormBuilder, Validators } from '@angular/forms';
import { Component, OnInit } from '@angular/core';
import { Location } from '@angular/common';
import * as $ from 'jquery';


@Component({
  selector: 'app-adm-item-form',
  templateUrl: './adm-item-form.component.html',
  styleUrls: ['./adm-item-form.component.scss'],
  providers: [ItemService]
})
export class AdmItemFormComponent implements OnInit {
  form;
  isLoading;
  submitButtonText = 'Přidat';

  previewImageFile = null;
  othersImageFiles = null;

  bgImgPath: string;

  categories;

  itemAvailabilities;
  itemStates;

  item: Item;

  constructor(
    private fb: FormBuilder,
    private location: Location,
    private route: ActivatedRoute,
    private snackBarService: SnackBarService,
    private router: Router,
    private itemService: ItemService,
    private fileService: FileService
  ) {}

  ngOnInit() {
    this.item = new Item();
    this.isLoading = true;

    this.loadAvailabilities();
    this.loadItemStates();
    this.loadCategories();
    $(document).on('click', '.category-item', function (e) {
      e.stopPropagation();
      var submenu = $('> .category-submenu', this);
      var item = $(this);

      if (item.hasClass('open')) {
        item.removeClass('open');
        submenu.slideUp('slow');
      } else {
        item.addClass('open');
        submenu.slideDown('slow');
      }
    });

    $(".nav-item").on({
      mouseenter: function (e) {
        e.stopPropagation();
        $(this).addClass('hover');
      },
      mouseleave: function (e) {
        e.stopPropagation();
        $(this).removeClass('hover');
      }
    });
  }
  loadAvailabilities() {
    this.itemService
      .getAll(this.itemService.getItemsAvailabilities)
      .subscribe(response => {
        this.itemAvailabilities = response.ItemAvailabilities;
      });
  }
  loadItemStates() {
    this.itemService
      .getAll(this.itemService.getItemStates)
      .subscribe(response => {
        this.itemStates = response.ItemStates;
      });
  }

  loadCategories() {
    this.itemService
      .get('', this.itemService.getCategoriesUrl)
      .subscribe(response => {
        this.categories = response.CategoriesDto;

        this.loadItem();
      });
  }
  loadItem() {
    this.route.paramMap.subscribe(response => {
      let itemId = response.get('id');

      if (itemId)
        this.itemService
          .get(itemId, this.itemService.getItemUrl)
          .subscribe(response => {
            this.item = response.ItemDto;
            this.submitButtonText = 'Editovat';
            this.buildForm();
          });
      else this.buildForm();
    });
  }
  submit(form) {
    if (this.item.id) this.edit(form.value);
    else this.create(form.value);
  }
  create(item: Item) {
    this.isLoading = true;

    this.itemService
      .create(item, this.itemService.createItemUrl)
      .subscribe(response => {
        let body = JSON.parse(response.text());


        if (body.StatusCode == ReturnCodes.Created) {
          if (this.previewImageFile)
            this.uploadFiles(body.ItemDto.id, 1, 'Položka byla přidána');

          if (this.othersImageFiles)
            this.uploadFiles(body.ItemDto.id, 0, 'Položka byla přidána');

          if (!this.previewImageFile && !this.othersImageFiles)
            this.afterSuccessSubmit('Položka byla přidána');
        }
      });
  }
  edit(item: Item) {
    item.id = this.item.id;

    this.itemService
      .update(item, this.itemService.editItemUrl)
      .subscribe(response => {
        let body = JSON.parse(response.text());

        if (body.StatusCode == ReturnCodes.Ok) {
          if (this.previewImageFile)
            this.uploadFiles(item.id, 1, 'Položka byla upravena');

          if (this.othersImageFiles)
            this.uploadFiles(item.id, 0, 'Položka byla upravena');

          if (!this.previewImageFile && !this.othersImageFiles)
            this.afterSuccessSubmit('Položka byla upravena');
        }
      });
  }
  afterSuccessSubmit(message) {
    this.snackBarService.openSnackBar(message, 'Ok');
    this.router.navigate(['/administration/items']);
  }
  buildForm() {
    this.form = this.fb.group({
      title: [this.item.title, [Validators.required]],
      description: [this.item.description, [Validators.required]],
      weight: [this.item.weight, [Validators.required]], 
      deliveryDate: [this.item.deliveryDate, [Validators.required]], 
      price: [this.item.price, [Validators.required]],
      fakeDiscount: [this.item.fakeDiscount, [Validators.required]],
      // available: [this.item.available],
      categoryId: [this.item.categoryId, [Validators.required]],
      itemAvailabilityId: [this.item.itemAvailabilityId, [Validators.required]],
      itemStateId: [this.item.itemStateId, [Validators.required]]
    });

    this.isLoading = false;
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
  onMultipleFileSelect(fileInput: any) {
    if (fileInput.target.files.length > 0)
      this.othersImageFiles = fileInput.target.files;
    else this.othersImageFiles = null;

  }
  uploadFiles(itemId, previewImage, snackBarText) {
    let formData = new FormData();

    if (previewImage) {
      formData.append('uploads[]', this.previewImageFile);
    } else {
      for (let file of this.othersImageFiles) {
        formData.append('uploads[]', file);
      }
    }

    this.fileService
      .uploadFile(formData, itemId, previewImage)
      .subscribe(response => {
        if (previewImage && !this.othersImageFiles)
          this.afterSuccessSubmit(snackBarText);

        if (!previewImage && this.othersImageFiles)
          this.afterSuccessSubmit(snackBarText);
      });
  }
  onBack() {
    this.location.back();
  }

  onImageDelete(image) {
    const index = this.item.images.indexOf(image);
    if (index !== -1) {
      this.itemService
        .delete(image.id, this.itemService.deleteItemImageUrl)
        .subscribe(response => {
          this.snackBarService.openSnackBar('Obrázek byl smazán.', 'Ok');
          this.item.images.splice(index, 1);
        });
    }
  }
}
