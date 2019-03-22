import { Component, OnInit, ViewEncapsulation } from '@angular/core';
import * as $ from 'jquery';

@Component({
  selector: 'app-faq',
  templateUrl: './faq.component.html',
  styleUrls: ['./faq.component.scss'],
  encapsulation: ViewEncapsulation.None
})
export class FaqComponent implements OnInit {

  constructor() { }

  ngOnInit() {
    $(document).on('click', '.question header', function (e) {
      e.stopPropagation();
      if ($(this).parent().children('main').css('display') == 'block') {
        $(this).parent().children('main').slideUp('slow');
       
      } else {
        $(this).parent().children('main').slideDown('slow');
      }
    });
  }

}
