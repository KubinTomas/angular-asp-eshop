import { ItemFilterPipe } from './../../../pipes/item-filter.pipe';
import { PriceFilterPipe } from './../../../pipes/price-filter.pipe';
import { Component, OnInit, ViewEncapsulation } from '@angular/core';
import { ItemManagerService } from 'src/app/services/others/item-manager.service';
import { ActivatedRoute } from '@angular/router';
import { Options } from 'ng5-slider';
import { PageEvent } from '@angular/material';

// declare var require: any;
// var $ = require('jquery');
// require('jquery-ui');

@Component({
  selector: 'app-items',
  templateUrl: './items.component.html',
  styleUrls: ['./items.component.scss'],
  providers: [ItemManagerService],
  encapsulation: ViewEncapsulation.None
})
export class ItemsComponent implements OnInit {


  // MatPaginator Inputs
  length = 1000;
  pageSize = 10;
  pageSizeOptions: number[] = [5, 10, 25, 100];

  // MatPaginator Output
  pageEvent: PageEvent;

  datasource = [];

  activePageDataChunk = []

  subscription: any;

  currentCategoryId;
  filterString;

  minValue: number = 0;
  maxValue: number = 1000;

  isLoading = true;

  originalArrayOfItems;

  options: Options = {
    floor: 0,
    minRange: this.minValue,
    translate: (value: number): string => {
      return value + ' Kč';
    }
  };

  priceFilterPipe;
  itemFilterPipe;

  constructor(
    public itemManager: ItemManagerService,
    private route: ActivatedRoute) {

    this.priceFilterPipe = new PriceFilterPipe();
    this.itemFilterPipe = new ItemFilterPipe();

    this.loadMostExpensiveItem();
    this.subscription = this.itemManager.getOnItemsLoadedEmitter()
      .subscribe(item => {
        this.loadArrayOfItems();
      });
  }
  ngOnDestroy() {
    this.subscription.unsubscribe();
  }
  onPriceSliderChange() {
    this.filterArrayWithPipes();
  }
  filterArrayWithPipes() {

    let filteredItems = this.priceFilterPipe.transform(this.originalArrayOfItems, this.minValue, this.maxValue);
    filteredItems = this.itemFilterPipe.transform(filteredItems, 'id,title,isVisible', this.filterString);
    this.setPaginator(filteredItems);
  }
  loadArrayOfItems() {
    this.originalArrayOfItems = this.itemManager.items.ItemsDto;

    this.setPaginator(this.originalArrayOfItems);
  }
  setPaginator(items) {
    this.datasource = [];

    for (let item of items) {
      this.datasource.push(item);
    }
    this.length = items.length;

    this.activePageDataChunk = this.datasource.slice(0, this.pageSize);
  }
  onSearchChange() {
    this.filterArrayWithPipes();
  }
  setPageSizeOptions(setPageSizeOptionsInput: string) {
    this.pageSizeOptions = setPageSizeOptionsInput.split(',').map(str => +str);
  }

  onPageChanged(e) {
    let firstCut = e.pageIndex * e.pageSize;
    let secondCut = firstCut + e.pageSize;
    this.activePageDataChunk = this.datasource.slice(firstCut, secondCut);
  }

  ngOnInit() { }

  loadMostExpensiveItem() {
    this.itemManager.loadMostExpensiveItem().subscribe(response => {
      this.maxValue = response;
      this.isLoading = false;
    });
  }

}
