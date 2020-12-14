import {Routes} from '@angular/router';
import {StudentManagementComponent} from '../../../pages/student-management/student-management.component';
import {ProfessorLayoutComponent} from './professor-layout.component';
import {CoursesManagementComponent} from '../../../pages/courses-management/courses-management.component';
import {AuthGuard} from '../../../core/guards/auth.guard';

export const ProfessorLayoutRoutes: Routes = [
  {
    path: 'teacher', component: ProfessorLayoutComponent,
    canActivate: [AuthGuard],
    children:
      [
        {path: 'student-management', component: StudentManagementComponent},
        {path: 'courses-management', component: CoursesManagementComponent},
      ]
  }
];
