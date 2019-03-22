import { ItemService } from 'src/app/services/http/item.service';
import { Component, OnInit, ViewChild } from '@angular/core';
import { SnackBarService } from 'src/app/services/others/snack-bar.service';
import { MatPaginator, MatTableDataSource, MatSort } from '@angular/material';

@Component({
  selector: 'app-adm-items-output',
  templateUrl: './adm-items-output.component.html',
  styleUrls: ['./adm-items-output.component.scss'],
  providers: [ItemService]
})

export class AdmItemsOutputComponent implements OnInit {
  isLoading;
  items;
  displayedColumns: string[] = ['id', 'title', 'itemAvailabilityId','price', 'fakeDiscount' , 'deliveryDate', 'itemStateId', 'Settings'];
  dataSource;

  @ViewChild(MatPaginator) paginator: MatPaginator;
  @ViewChild(MatSort) sort: MatSort;

  constructor(
    private itemService: ItemService,
    private snackBarService: SnackBarService,
    ) {}

  ngOnInit() {
    this.isLoading = true;
    this.loadItems();
  }

  loadItems() {
    this.itemService.getAll(this.itemService.getItemsUrl)
      .subscribe(response => {
        this.items = response.ItemsDto;
        console.log(this.items);
        this.dataSource = new MatTableDataSource(this.items);
        setTimeout(() => this.dataSource.paginator = this.paginator);
        setTimeout(() => this.dataSource.sort = this.sort);
        this.isLoading = false;
      });
  }

  onDelete(item) {
    const index = this.items.indexOf(item);
    if (index !== -1) {
      this.itemService.delete(item.id, this.itemService.deleteItemUrl)
        .subscribe(response => {
          this.snackBarService.openSnackBar('Item byl smazán.', 'Ok');
          this.items.splice(index, 1);
        });

    }
  }

}
