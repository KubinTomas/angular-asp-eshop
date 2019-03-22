import { ItemService } from './../../services/http/item.service';
import { Component, OnInit, ViewEncapsulation } from '@angular/core';
import * as $ from 'jquery';

@Component({
  selector: 'app-sidebar',
  templateUrl: './sidebar.component.html',
  styleUrls: ['./sidebar.component.scss'],
  providers: [ItemService],
  encapsulation: ViewEncapsulation.None
})
export class SidebarComponent implements OnInit {
  constructor(private itemService: ItemService) {}

  categories;
  isLoading = true;

  ngOnInit() {
    this.loadCategories();
  }
  loadCategories() {
    this.itemService
      .get('', this.itemService.getCategoriesUrl)
      .subscribe(response => {
        this.categories = response.CategoriesDto;
        this.isLoading = false;
        console.log(this.categories);
        this.initSidebarMenu();
      });
  }
  initSidebarMenu() {
    $(document).on('click', '.site-menu-item ', function(e) {
      e.stopPropagation();
      if ($(this).hasClass('open')) {
        $(this).removeClass('open');
        $(this)
          .children('.site-menu-submenu')
          .slideUp('slow');
      } else {
        $(this).addClass('open');
        $(this)
          .children('.site-menu-submenu')
          .slideDown('slow');
      }
    });

    $(document).on(
      {
        mouseenter: function(e) {
          e.stopPropagation();
          $(this)
            .addClass('hovered')
            .children('a')
            .addClass('hovered');
        },
        mouseleave: function(event) {
          $(this)
            .removeClass('hovered')
            .children('a')
            .removeClass('hovered');
          var e = event.toElement || event.relatedTarget;
          if (e == this) {
            $(this)
              .removeClass('hovered')
              .children('a')
              .removeClass('hovered');
          }
        }
      },
      '.site-menu-item'
    );

    $(document).ready(function() {
      var padding_left = 25;
      $('.site-menu')
        .children()
        .each(function() {
          if (
            $(this)
              .find('.site-menu-submenu')
              .children().length > 0
          ) {
            $(this)
              .children('a')
              .find('.site-menu-title')
              .css('padding-left', padding_left + 'px');
            setPaddingToChild($(this), 10);
          } else {
            $(this)
              .children('a')
              .find('.site-menu-title')
              .css('padding-left', padding_left + 'px');
          }
        });
    });

    function setPaddingToChild(parent, left) {
      let childOffset = 14;

      $(parent)
        .children('.site-menu-submenu')
        .children()
        .each(function() {
          if (
            $(this)
              .find('.site-menu-submenu')
              .children().length > 0
          ) {
            $(this)
              .children('a')
              .find('.site-menu-title')
              .css('padding-left', left + 'px');
            setPaddingToChild($(this), left + +childOffset);
          } else {
            $(this)
              .children('a')
              .find('.site-menu-title')
              .css('padding-left', left + 'px');
          }
        });
    }
  }
}
