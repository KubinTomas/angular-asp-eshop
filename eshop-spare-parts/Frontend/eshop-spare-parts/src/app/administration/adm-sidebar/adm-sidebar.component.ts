import { Component, OnInit } from '@angular/core';
import * as $ from 'jquery';

@Component({
  selector: 'app-adm-sidebar',
  templateUrl: './adm-sidebar.component.html',
  styleUrls: ['./adm-sidebar.component.scss']
})
export class AdmSidebarComponent implements OnInit {

  constructor() { }

  ngOnInit() {
    $(document).on('click', '.nav-item', function (e) {
      e.stopPropagation();
      var submenu = $('> .nav-menu-sub', this);
      var item = $(this);

      if (item.hasClass('open')) {
        item.removeClass('open');
        submenu.slideUp('slow');
      } else {
        item.addClass('open');
        submenu.slideDown('slow');
      }
    });

    $(".nav-item").on({
      mouseenter: function (e) {
        e.stopPropagation();
        $(this).addClass('hover');
      },
      mouseleave: function (e) {
        e.stopPropagation();
        $(this).removeClass('hover');
      }
    });
  }

}
