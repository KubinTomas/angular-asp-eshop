import { Http } from '@angular/http';
import { Injectable } from '@angular/core';
import { ServiceService } from './service.service';
import { map } from 'rxjs/operators';
import { url } from '../../models/others/url';


@Injectable({
  providedIn: 'root'
})
export class ItemService extends ServiceService {

  public getFilteredCategoriesUrl = "api/get/category/filtered/words";
  public getCategoriesUrl = "api/get/categories";
  public createItemUrl = "api/create/item";
  public editItemUrl = "api/edit/item";
  public getItemsUrl = "api/get/items";
  public getItemUrl = "api/get/item/";
  public deleteItemUrl = "api/delete/item/";
  public deleteItemImageUrl = "api/delete/item/image/";

  public getFilteredItemsUrl = "api/get/filtered/items/";

  public getLastInsertedItems = "api/get/last/inserted/items/";

  public getItemsByCategoryUrl = "api/get/items/category/";

  public getItemsAvailabilities = "api/get/item/availabilities";

  public getMostExpensiveItemUrl = "api/get/most/expensive/item";

  public getItemStates = "api/get/item/states";

  constructor(public http: Http) {
    super(http);
  }

  getFilteredItems(filterString){
    return this.http
      .get(url + this.getFilteredItemsUrl + filterString)
      .pipe(map((response: any) => response.json()));
  }
  getItemsInCategory(categoryId){
    return this.http
      .get(url + this.getItemsByCategoryUrl + categoryId)
      .pipe(map((response: any) => response.json()));
  }
}
