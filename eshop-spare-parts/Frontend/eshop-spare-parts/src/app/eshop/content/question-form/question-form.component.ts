import { OrderService } from 'src/app/services/http/order.service';
import { FormBuilder, Validators } from '@angular/forms';
import { Router } from '@angular/router';
import { SnackBarService } from 'src/app/services/others/snack-bar.service';
import { Component, OnInit, ViewEncapsulation } from '@angular/core';

@Component({
  selector: 'app-question-form',
  templateUrl: './question-form.component.html',
  styleUrls: ['./question-form.component.scss'],
  providers: [OrderService],
  encapsulation: ViewEncapsulation.None
})
export class QuestionFormComponent implements OnInit {

  form;


  constructor(
    private snackBarService: SnackBarService,
    private router: Router,
    private fb: FormBuilder,
    private orderService: OrderService
  ) { }

  ngOnInit() {
    this.buildForm();
  }
  submit(form) {
    this.create(form.value);
  }
  create(question) {
    this.orderService.create(question,  this.orderService.getQuestionUrl)
      .subscribe(response => {
        
      });
  }


  afterSuccessSubmit(message) {
    this.snackBarService.openSnackBar(message, 'Ok');
    this.router.navigate(['']);
  }
  buildForm() {
    this.form = this.fb.group({
      email: ['', Validators.required],
      title: ['', Validators.required],
      content: ['', Validators.required]
    });
  }
  onBack(){
    
  }
}
