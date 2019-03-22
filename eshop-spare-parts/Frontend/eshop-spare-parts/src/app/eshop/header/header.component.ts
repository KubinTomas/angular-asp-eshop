import { ItemManagerService } from 'src/app/services/others/item-manager.service';
import { Router } from '@angular/router';
import { FormControl } from '@angular/forms';
import { ItemService } from 'src/app/services/http/item.service';
import { User } from './../../models/dbModels/user.model';
import { AuthenticationService } from './../../services/http/authentication.service';
import { Component, OnInit, ViewEncapsulation } from '@angular/core';
import { startWith, map } from 'rxjs/operators';
import { Observable } from 'rxjs';
import { ShoppingCartService } from 'src/app/services/others/shopping-cart.service';
import * as $ from 'jquery';

export interface Category {
  filterWord: string;
  id: string;
}


@Component({
  selector: 'app-header',
  templateUrl: './header.component.html',
  styleUrls: ['./header.component.scss'],
  providers: [ItemService],
  encapsulation: ViewEncapsulation.None
})


export class HeaderComponent implements OnInit {

  subscription;
  myControl = new FormControl();
  //options: string[] = ['One', 'Two', 'Three'];
  options: Category[] = [];
  filteredOptions: Observable<Category[]>;

  constructor(
    public authService: AuthenticationService,
    private itemService: ItemService,
    private router: Router,
    private itemManager: ItemManagerService,
    public cart: ShoppingCartService
  ) { 
    this.subscription = this.itemManager.getOnFilteredWords()
      .subscribe(item => {
        this.initCategories();
      });
  }

  ngOnInit() {
    this.filteredOptions = this.myControl.valueChanges
      .pipe(
        startWith(''),
        map(category => category && typeof category === 'object' ? category.filterWord : category),
        map(category => this.filterCategory(category))
    );
    

    $('body').on('click', function (e) {
      $('#matMenu').slideUp('fast');
    });
  }
  initCategories(){
    this.options = this.itemManager.categoriesFilterWord;

    this.filteredOptions = this.myControl.valueChanges
    .pipe(
      startWith(''),
      map(category => category && typeof category === 'object' ? category.filterWord : category),
      map(category => this.filterCategory(category))
  );
  }
  ngOnDestroy() {
    this.subscription.unsubscribe();
  }

  public open(event) {
    event.stopPropagation();
    $('#matMenu').slideDown('fast');
  }

  public mouseEnter(event) {
    $('#cart').slideDown('fast');
  }

  public mouseLeave(event) {
    $('#cart').slideUp('fast');
  }

  onLogout() {
    this.authService.logout();
  }
  displayFn(category) {
    return category ? category.filterWord : category;
  }

  onSearchChange(input) {
    let catId = input.option.value.id;

    this.router.navigate(['/items', catId]);
  }
  filterCategory(val) {
    return val ? this.options.filter(s => s.filterWord.toLowerCase().indexOf(val.toLowerCase()) === 0)
      : this.options;
  }


}
