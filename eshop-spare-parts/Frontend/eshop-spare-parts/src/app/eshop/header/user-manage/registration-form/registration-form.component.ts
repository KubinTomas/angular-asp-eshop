import { EmailValidators } from './validators/email.validators';
import { SnackBarService } from './../../../../services/others/snack-bar.service';
import { ReturnCodes } from './../../../../models/others/return-codes.model';
import { User } from './../../../../models/DbModels/user.model';
import { AuthenticationService } from './../../../../services/http/authentication.service';
import { PasswordValidator } from './validators/password.validators';
import { Location } from '@angular/common';
import { Component, OnInit } from '@angular/core';
import { FormBuilder, Validators, FormArray, FormGroup, FormControl } from '@angular/forms';
// import { JwtHelper } from 'angular2-jwt';
import { Router } from '@angular/router';






@Component({
  selector: 'app-registration-form',
  templateUrl: './registration-form.component.html',
  styleUrls: ['./registration-form.component.scss'],
  providers: [AuthenticationService, EmailValidators]
})
export class RegistrationFormComponent implements OnInit {

  form;
  isLoading;
  submitButtonText = "Registrovat";

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
    private router: Router,
    private emailValidator: EmailValidators

  ) { }

  ngOnInit() {
    this.isLoading = false;

    this.buildForm();
  }
  submit(form) {
    this.create(form.value);
  }
  create(user: User) {

    this.authService.create(user, this.authService.createUserUrl)
      .subscribe(response => {

        let body = JSON.parse(response.text());

        let token = body.UserDto.token;

        if(body.StatusCode == ReturnCodes.Created){
          this.authService.login(token);
          this.snackBarService.openSnackBar('Účet byl úspěšně vytvořen', 'Ok');
          this.router.navigate(['/']);
        }

      });

  }

  buildForm() {
    this.form = this.fb.group({
      email: ['', [Validators.required, Validators.email] , this.emailValidator.shouldBeUnique.bind(this.emailValidator)],
      password: new FormControl('', [Validators.required, Validators.minLength(5)]),
      passwordConfirm: new FormControl('', [Validators.required]),
      agreeRegistration: ['', [Validators.requiredTrue]]
    }, {
        validator: PasswordValidator.passwordMatch
      }
    );
  }

  onBack() {
    this.location.back();
  }

}
