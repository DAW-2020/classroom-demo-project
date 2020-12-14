import {BrowserModule} from '@angular/platform-browser';
import {NgModule} from '@angular/core';
import {FormsModule, ReactiveFormsModule} from '@angular/forms';
import {HttpClientModule, HTTP_INTERCEPTORS} from '@angular/common/http';
import {RouterModule} from '@angular/router';

import {AppComponent} from './app.component';
import {BrowserAnimationsModule} from '@angular/platform-browser/animations';
import {HomeComponent} from './pages/home/home.component';
import {LandingComponent} from './pages/landing/landing.component';
import {MatCardModule, MatListModule, MatToolbarModule} from '@angular/material';
import {AuthLayoutComponent} from './shared/layouts/auth-layout/auth-layout.component';
import {StudentLayoutComponent} from './shared/layouts/student-layout/student-layout.component';
import {ProfessorLayoutComponent} from './shared/layouts/professor-layout/professor-layout.component';
import {AuthGuard} from './core/guards/auth.guard';
import {AuthLayoutModule} from './shared/layouts/auth-layout/auth-layout.module';
import {StudentLayoutModule} from './shared/layouts/student-layout/student-layout.module';
import {ProfessorLayoutModule} from './shared/layouts/professor-layout/professor-layout.module';
import {ToastrModule} from 'ngx-toastr';

@NgModule({
  declarations: [
    AppComponent,
    HomeComponent,
    LandingComponent
  ],
  imports: [
    BrowserModule.withServerTransition({appId: 'ng-cli-universal'}),
    HttpClientModule,
    FormsModule,
    AuthLayoutModule,
    StudentLayoutModule,
    ProfessorLayoutModule,
    ToastrModule.forRoot(),
    RouterModule.forRoot([
      {path: '', component: LandingComponent, pathMatch: 'full'},
      {path: 'home', component: HomeComponent, pathMatch: 'full'},
      {
        path: '',
        component: AuthLayoutComponent,
        children: [
          {
            path: '',
            loadChildren:
              () => import('./shared/layouts/auth-layout/auth-layout.module').then(m => m.AuthLayoutModule)
          }
        ]
      },
      {
        path: '',
        component: StudentLayoutComponent,
        children: [
          {
            path: '',
            loadChildren:
              () => import('./shared/layouts/student-layout/student-layout.module').then(m => m.StudentLayoutModule)
          }
        ]
      },
      {
        path: '',
        component: ProfessorLayoutComponent,
        children: [
          {
            path: '',
            loadChildren:
              () => import('./shared/layouts/professor-layout/professor-layout.module').then(m => m.ProfessorLayoutModule)
          }
        ]
      },
    ]),
    BrowserAnimationsModule,
    MatCardModule,
    MatListModule,
    MatToolbarModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule {
}
