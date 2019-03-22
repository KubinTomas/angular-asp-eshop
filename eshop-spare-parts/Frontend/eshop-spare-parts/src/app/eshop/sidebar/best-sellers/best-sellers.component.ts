import { Component, OnInit } from '@angular/core';
import { ItemManagerService } from 'src/app/services/others/item-manager.service';


@Component({
  selector: 'app-best-sellers',
  templateUrl: './best-sellers.component.html',
  styleUrls: ['./best-sellers.component.scss'],
  providers: [ItemManagerService]
})
export class BestSellersComponent implements OnInit {

  constructor(public itemManager: ItemManagerService) { }

  ngOnInit() {
  }

}
