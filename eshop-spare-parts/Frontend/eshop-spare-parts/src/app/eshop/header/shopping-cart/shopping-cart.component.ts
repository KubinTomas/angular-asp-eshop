import { ShoppingCartService } from './../../../services/others/shopping-cart.service';
import { Component, OnInit, ViewEncapsulation } from '@angular/core';

@Component({
  selector: 'app-shopping-cart',
  templateUrl: './shopping-cart.component.html',
  styleUrls: ['./shopping-cart.component.scss'],
  encapsulation: ViewEncapsulation.None
})
export class ShoppingCartComponent implements OnInit {

  constructor(public shoppingCart: ShoppingCartService) { }

  ngOnInit() {

  }

}
