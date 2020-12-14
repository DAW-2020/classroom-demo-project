import {CoursesComponent} from '../../../pages/courses/courses.component';
import {StudentLayoutComponent} from './student-layout.component';
import {Routes} from '@angular/router';
import {AuthGuard} from '../../../core/guards/auth.guard';

export const StudentLayoutRoutes: Routes = [
  {
    path: 'student', component: StudentLayoutComponent,
    canActivate: [AuthGuard],
    // canActivateChild: [AuthGuard],
    children:
      [
        {path: 'dashbord', component: CoursesComponent},
      ]
  }
];
