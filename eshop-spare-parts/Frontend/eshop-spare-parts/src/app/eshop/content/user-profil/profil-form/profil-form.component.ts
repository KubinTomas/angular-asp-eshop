import { FormBuilder } from '@angular/forms';
import { Router } from '@angular/router';
import { SnackBarService } from './../../../../services/others/snack-bar.service';
import { ReturnCodes } from './../../../../models/others/return-codes.model';
import { AuthenticationService } from './../../../../services/http/authentication.service';
import { User } from './../../../../models/dbModels/user.model';
import { Component, OnInit } from '@angular/core';
import { Location } from '@angular/common';

@Component({
  selector: 'app-profil-form',
  templateUrl: './profil-form.component.html',
  styleUrls: ['./profil-form.component.scss']
})
export class ProfilFormComponent implements OnInit {
  form;
  isLoading;
  errorMessage;
  user: User;

  constructor(
    private authService: AuthenticationService,
    private snackBarService: SnackBarService,
    private location: Location,
    private router: Router,
    private fb: FormBuilder
  ) {}

  ngOnInit() {
    this.isLoading = true;
    this.loadUser();
  }
  loadUser() {
    this.authService.getUser().subscribe(response => {
      this.isLoading = false;

      if (response.StatusCode == ReturnCodes.BadRequest) {
        this.errorMessage = 'Bad Request';
      } else if (response.StatusCode == ReturnCodes.Ok) {
        this.user = response.UserDto;
        this.buildForm();
      }
    });
  }
  submit(form) {
    this.edit(form.value);
  }
  edit(user: User) {
    user.id = this.user.id;
    user.email = this.user.email;

    this.authService
      .update(user, this.authService.getEditUserUrl)
      .subscribe(response => {
        let body = JSON.parse(response.text());

        if (body.StatusCode == ReturnCodes.Ok) {
          this.afterSuccessSubmit('Uživatel byl upraven');
        } else if (body.StatusCode == ReturnCodes.Ok) {
          this.errorMessage = 'Bad Request';
        }
      });
  }
  afterSuccessSubmit(message) {
    this.snackBarService.openSnackBar(message, 'Ok');
    this.router.navigate(['/profil']);
  }
  buildForm() {
    this.form = this.fb.group({
      name: [this.user.name],
      surname: [this.user.surname],
      phoneNumber: [this.user.phoneNumber],
      town: [this.user.town],
      townNumber: [this.user.townNumber],
      townStreet: [this.user.townStreet]
    });

    this.isLoading = false;
  }

  onBack() {
    this.location.back();
  }
}
