import { EventEmitter } from '@angular/core';
import { map } from 'rxjs/operators';
import { ItemService } from './../http/item.service';
import { Injectable, Output } from '@angular/core';
import { ActivatedRoute } from '@angular/router';

@Injectable({
  providedIn: 'root'
})
export class ItemManagerService {
  public items;

  public lastInsertedItems;

  isReadyStatus = false;
  areLastItemsReadyStatus = false;

  currentCategoryId;

  categoryInPage;
  categories;
  categoriesFilterWord = [];

  mostExpensiveItem: number;

  @Output()
  onItemsLoadedEmitter: EventEmitter<void> = new EventEmitter();
  @Output()
  onNewItemsLoadedEmitter: EventEmitter<void> = new EventEmitter();

  @Output()
  onMainPageNewItemsLoadedEmitter: EventEmitter<void> = new EventEmitter();

  @Output()
  onFilteredWords: EventEmitter<void> = new EventEmitter();

  constructor(private itemService: ItemService, private route: ActivatedRoute) {
    this.route.params.subscribe(response => {
      let categoryId = response['categoryId'];

      if (!categoryId) {
        this.loadItems();
      } else {
        if (categoryId != this.currentCategoryId) {
          this.currentCategoryId = categoryId;

          this.filerItemsByCategoryId(this.currentCategoryId);

          this.loadCategoryInPage(this.currentCategoryId, this.categories);
        }
      }
    });

    this.loadMostExpensiveItem();
    this.loadCategories();
    this.loadLastInsertedItems();
  }
  loadMostExpensiveItem() {
    this.mostExpensiveItem = 100000;

    return this.itemService.getAll(this.itemService.getMostExpensiveItemUrl);
  }
  getMostExpensiveItem() {
    return this.mostExpensiveItem;
  }
  loadCategories(parentId = 1) {
    this.itemService
      .get('', this.itemService.getCategoriesUrl)
      .subscribe(response => {
        this.categories = response.CategoriesDto;

        this.loadCategoriesWithFilteredWord();
        this.loadCategoryInPage(parentId, this.categories);
      });
  }
  loadCategoriesWithFilteredWord() {
    this.itemService
      .get('', this.itemService.getFilteredCategoriesUrl)
      .subscribe(response => {
        this.categoriesFilterWord = response;
        this.onFilteredWords.emit();
      });
  }
  loadCategoryInPage(parentId, categories, firstCall = true) {
    if (categories) {
      for (var category of categories) {
        if (category.id == parentId) {
          this.categoryInPage = category.CategoriesDto;
        } else {
          this.loadCategoryInPage(parentId, category.CategoriesDto, false);
        }
      }
    } else {
      if (firstCall) this.loadCategories(parentId);
    }
  }
  loadItems() {
    this.itemService
      .getAll(this.itemService.getItemsUrl)
      .subscribe(response => {
        this.items = response;
        this.isReadyStatus = true;

        this.onItemsLoadedEmitter.emit();
      });
  }

  getOnItemsLoadedEmitter() {
    return this.onItemsLoadedEmitter;
  }
  getOnNewItemsLoadedEmitter() {
    return this.onNewItemsLoadedEmitter;
  }
  getOnMainPageNewItemsLoadedEmitter() {
    return this.onMainPageNewItemsLoadedEmitter;
  }
  getOnFilteredWords() {
    return this.onFilteredWords;
  }

  filerItemsByCategoryId(categoryId) {
    this.isReadyStatus = false;

    this.itemService.getItemsInCategory(categoryId).subscribe(response => {
      this.items = response;
      this.isReadyStatus = true;

      this.onItemsLoadedEmitter.emit();
    });
  }
  loadLastInsertedItems(itemCount = 12) {
    this.itemService
      .get(itemCount, this.itemService.getLastInsertedItems)
      .subscribe(response => {
        this.lastInsertedItems = response;

        this.areLastItemsReadyStatus = true;

        if (itemCount == 12) {
          this.onMainPageNewItemsLoadedEmitter.emit();
        }

        this.onNewItemsLoadedEmitter.emit();
      });
  }

  isReady() {
    return this.isReadyStatus;
  }
  areLastItemsReady() {
    return this.areLastItemsReadyStatus;
  }
}
