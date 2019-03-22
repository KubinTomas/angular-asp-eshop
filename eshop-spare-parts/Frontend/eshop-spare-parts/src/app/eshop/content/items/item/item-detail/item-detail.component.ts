import { ActivatedRoute } from '@angular/router';
import { ShoppingCartService } from './../../../../../services/others/shopping-cart.service';
import { Component, OnInit, Input, ViewEncapsulation } from '@angular/core';
import { Item } from '../../../../../models/dbModels/item.model';
import { ItemService } from 'src/app/services/http/item.service';
import * as $ from 'jquery';
import 'slick-carousel';

@Component({
  selector: 'app-item-detail',
  templateUrl: './item-detail.component.html',
  styleUrls: ['./item-detail.component.scss'],
  providers: [ItemService],
  encapsulation: ViewEncapsulation.None
})
export class ItemDetailComponent implements OnInit {
  item: Item;
  isLoading = true;
  isSlickInit = false;

  constructor(
    private route: ActivatedRoute,
    private itemService: ItemService,
    private shoppingCart: ShoppingCartService
  ) { }

  ngOnInit() {
    this.route.paramMap.subscribe(response => {
      let id = response.get('id');
      this.loadItem(id);
    });
  }

  loadItem(id) {
    this.itemService
      .get(id, this.itemService.getItemUrl)
      .subscribe(response => {
        this.item = response.ItemDto;
        this.initSlick();
      });
  }
  initSlick() {
    this.isLoading = false;

    $(document).ready(function () {
      $('#itemDetailSlick').slick({
        dots: false,
        arrows: true,
        slidesToShow: 4,
        slidesToScroll: 1,
        autoplay: true,
        autoplaySpeed: 1700
      });

      // Get the modal
      var modal = $('#myModal');

      // Get the image and insert it inside the modal - use its "alt" text as a caption
      var modalImg = $("#img01");
      var captionText = $("#caption");
      $('.img').on('click', function () {
        modal.css('display', 'block');
        modalImg.attr('src', $(this).attr('src'));
        captionText.text($(this).attr('alt'));
      });


      $(".close").on('click', function () {
        modal.css('display', 'none');
       
      });
     
    });

    setTimeout(() => {
      this.isSlickInit = true;
    }, 500);

  }
  onItemAdd() {
    this.shoppingCart.addItem(this.item);
  }

  getDisplay() {
    if (this.isSlickInit) return 'initial';
    else return 'none';
  }
}
