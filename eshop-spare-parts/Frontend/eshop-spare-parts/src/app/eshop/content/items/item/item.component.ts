import { ShoppingCartService } from './../../../../services/others/shopping-cart.service';
import { Component, OnInit, Input, ViewEncapsulation } from '@angular/core';
import { Item } from '../../../../models/dbModels/item.model';

@Component({
  selector: 'app-item',
  templateUrl: './item.component.html',
  styleUrls: ['./item.component.scss'],
  encapsulation: ViewEncapsulation.None
})
export class ItemComponent implements OnInit {

  @Input()
  item: Item;

  constructor(private shoppingCart: ShoppingCartService) { }

  ngOnInit() {
  }

  onItemAdd(){
    this.shoppingCart.addItem(this.item);
  }

}


