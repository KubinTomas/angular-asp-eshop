import { GlobalConst } from './../../../../models/others/cons.model';
import { Item } from './../../../../models/dbModels/item.model';
import { ShoppingCartService } from './../../../../services/others/shopping-cart.service';
import { Component, OnInit, ViewEncapsulation } from '@angular/core';

@Component({
  selector: 'app-cart-summary',
  templateUrl: './cart-summary.component.html',
  styleUrls: ['./cart-summary.component.scss'],
  encapsulation: ViewEncapsulation.None
})
export class CartSummaryComponent implements OnInit {

  constructor(public shoppingCart: ShoppingCartService) { }

  dphMultiplicator;

  ngOnInit() {
    this.dphMultiplicator = GlobalConst.DphMultiplicator;
  }
  onItemDelete(item) {
    this.shoppingCart.removeItemFromCart(item);
  }
  onItemCountChange(input, item: Item) {
    let itemCount = input.srcElement.value;

    if (itemCount == 0) {
      this.shoppingCart.removeItemFromCart(item);
    }else if(item.countInCart != itemCount){
      this.shoppingCart.updateItemCount(item, itemCount);
    }
   

  }

}
