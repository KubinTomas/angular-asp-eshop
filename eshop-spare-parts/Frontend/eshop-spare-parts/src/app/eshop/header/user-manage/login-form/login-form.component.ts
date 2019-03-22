import { Router } from '@angular/router';
import { ReturnCodes } from './../../../../models/others/return-codes.model';
import { User } from './../../../../models/dbModels/user.model';
import { SnackBarService } from './../../../../services/others/snack-bar.service';
import { AuthenticationService } from './../../../../services/http/authentication.service';
import { Location } from '@angular/common';
import { FormBuilder, Validators } from '@angular/forms';
import { Component, OnInit, ViewEncapsulation } from '@angular/core';

@Component({
  selector: 'app-login-form',
  templateUrl: './login-form.component.html',
  styleUrls: ['./login-form.component.scss'],
  providers: [AuthenticationService],
  encapsulation: ViewEncapsulation.None
})
export class LoginFormComponent implements OnInit {

  form;
  isLoading;
  submitButtonText = "Přihlásit";

  invalidLogin = false;

  get email() {
    return this.form.get('email');
  }
  get password() {
    return this.form.get('password');
  }
  get passwordConfirm() {
    return this.form.get('passwordConfirm');
  }

  constructor(
    private fb: FormBuilder,
    private location: Location,
    private authService: AuthenticationService,
    private snackBarService: SnackBarService,
    private router: Router
  ) { }

  ngOnInit() {
    this.isLoading = false;

    this.buildForm();
  }
  submit(form) {
    this.login(form.value);
  }
  login(user: User) {
    this.authService.apiLoginUser(user.email, user.password)
      .subscribe(response => {

        if (response.StatusCode == ReturnCodes.Ok) {
          let token = response.UserDto.token;
          this.authService.login(token);
          this.snackBarService.openSnackBar('Přihlášení proběhlo úspěšně', 'Ok');
          this.router.navigate(['/']);
        } else if (response.StatusCode == ReturnCodes.NotFound) {
          this.invalidLogin = true;
        }

      });

  }

  buildForm() {
    this.form = this.fb.group({
      email: ['', [Validators.required, Validators.email]],
      password: ['', [Validators.required]]
    });
  }

  onBack() {
    this.location.back();
  }
}
