import {Routes} from '@angular/router';

import {AuthLayoutComponent} from './auth-layout.component';
import {LoginComponent} from '../../../pages/auth/login/login.component';
import {RegisterComponent} from '../../../pages/auth/register/register.component';

export const AuthLayoutRoutes: Routes = [
  {
    path: 'auth', component: AuthLayoutComponent,
    children:
      [
        {path: 'login', component: LoginComponent},
        {path: 'register', component: RegisterComponent},
      ]
  }
];
