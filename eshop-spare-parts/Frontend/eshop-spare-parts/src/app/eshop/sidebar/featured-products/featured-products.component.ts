import { Component, OnInit } from '@angular/core';
import { ItemManagerService } from 'src/app/services/others/item-manager.service';

@Component({
  selector: 'app-featured-products',
  templateUrl: './featured-products.component.html',
  styleUrls: ['./featured-products.component.scss'],
  providers: [ItemManagerService]
})
export class FeaturedProductsComponent implements OnInit {

  constructor(public itemManager: ItemManagerService) { }

  ngOnInit() {
  }

}
