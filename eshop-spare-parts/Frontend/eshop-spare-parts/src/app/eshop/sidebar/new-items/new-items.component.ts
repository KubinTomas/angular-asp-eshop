import { ItemManagerService } from 'src/app/services/others/item-manager.service';
import { ShoppingCartService } from 'src/app/services/others/shopping-cart.service';
import { Component, OnInit, ViewEncapsulation } from '@angular/core';
import { Item } from '../../../models/dbModels/item.model';
import * as $ from 'jquery';
import 'slick-carousel';

@Component({
  selector: 'app-new-items',
  templateUrl: './new-items.component.html',
  styleUrls: ['./new-items.component.scss'],
  providers: [ItemManagerService],
  encapsulation: ViewEncapsulation.None
})
export class NewItemsComponent implements OnInit {
  constructor(
    public itemManager: ItemManagerService,
    private shoppingCart: ShoppingCartService
  ) { }

  item: Item;

  newItems;
  isSlickInit;

  subscription;
  isLoading;

  ngOnInit() {
    this.isLoading = true;
    this.isSlickInit = false;

    this.subscription = this.itemManager
      .getOnNewItemsLoadedEmitter()
      .subscribe(item => {
        this.initSlick();
      });
  }
  ngOnDestroy() {
    this.subscription.unsubscribe();
  }
  initSlick() {
    this.isLoading = false;

    $(document).ready(function() {
      $('#slickVertical').slick({
        dots: false,
        arrows: false,
        vertical: true,
        slidesToShow: 3,
        slidesToScroll: 1,
        autoplay: true,
        autoplaySpeed: 1700
      });
    });

    setTimeout(() => {
      this.isSlickInit = true;
    }, 500);

  }
  onItemAdd(item) {
    this.shoppingCart.addItem(item);
  }

  getOpacity() {
    if (this.isSlickInit) return 1;
    else return 0;
  }
  getDisplay() {
    if (this.isSlickInit) return 'initial';
    else return 'none';
  }
}
