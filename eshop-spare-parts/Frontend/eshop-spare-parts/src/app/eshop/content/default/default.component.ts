import { Component, OnInit, ViewEncapsulation } from '@angular/core';
import * as $ from 'jquery';
import 'slick-carousel';
import { ItemManagerService } from 'src/app/services/others/item-manager.service';

@Component({
  selector: 'app-default',
  templateUrl: './default.component.html',
  styleUrls: ['./default.component.scss'],
  encapsulation: ViewEncapsulation.None
})
export class DefaultComponent implements OnInit {


  newItemsSubscription;

  mainSlickIsLoading;
  isMainSlickInit;

  constructor(public itemManager: ItemManagerService) { }

  ngOnInit() {


    this.mainSlickIsLoading = true;
    this.isMainSlickInit = false;

    this.newItemsSubscription = this.itemManager
      .getOnNewItemsLoadedEmitter()
      .subscribe(item => {
        this.initNewItems();
      });


    $('#mainSlick').slick({
      dots: false,
      arrows: true,
      infinite: true,
      autoplay: true,
      speed: 500,
      fade: true,
      cssEase: 'linear'
    });

   

    if (this.itemManager.lastInsertedItems)
      this.initNewItems();
  }
  ngOnDestroy() {
    this.newItemsSubscription.unsubscribe();
  }
  initNewItems() {
    this.mainSlickIsLoading = false;

    $(document).ready(function () {
      $('.slick-items').slick({
        rows: 2,
        dots: false,
        arrows: true,
        infinite: true,
        autoplay: true,
        slidesToShow: 4,
        slidesToScroll: 1,
        speed: 2000
      });
    });

    setTimeout(() => {
      this.isMainSlickInit = true;
    }, 500);
  }
  getMainSlickDisplay() {
    if (this.isMainSlickInit) return 'initial';
    else return 'none';
  }
}
