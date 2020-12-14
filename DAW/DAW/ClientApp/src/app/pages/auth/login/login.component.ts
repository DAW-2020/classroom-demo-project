import {Component, OnInit} from '@angular/core';
import {FormBuilder, Validators} from '@angular/forms';
import {AuthenticationService} from '../../../core/services/authentification/authentication.service';
import {ActivatedRoute, Router} from '@angular/router';
import {ToastrService} from 'ngx-toastr';

@Component({
  selector: 'app-login',
  templateUrl: './login.component.html',
  styleUrls: ['./login.component.css']
})
export class LoginComponent {
  public hide = true;
  public loginForm = this.fb.group({
    Email: ['', Validators.email],
    Password: ['', Validators.required]
  });

  constructor(private fb: FormBuilder,
              private authenticationService: AuthenticationService,
              private router: Router,
              private toastService: ToastrService,
              private route: ActivatedRoute) {
  }

  login() {
    this.authenticationService.login(this.loginForm.value)
      .subscribe(data => {
          console.log('Successfully logged in.', data);
          this.router.navigateByUrl('home');
        },
        () => {
          this.toastService.error('The data provided is not valid!');
        }
      );
  }

}
