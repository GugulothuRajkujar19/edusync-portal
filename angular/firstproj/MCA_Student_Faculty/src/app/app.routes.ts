import { Routes } from '@angular/router';
import { Home } from './home/home';
import { StudentLogin } from './student-login/student-login';
import { FacultyLogin } from './faculty-login/faculty-login';
import { Dashboard } from './dashboard/dashboard';
import { FacultyDashboard } from './faculty-dashboard/faculty-dashboard';


export const routes: Routes = [
  {
    path: '',
    component: Home
  },
  {
    path: 'student-login',
    component: StudentLogin
  },
  {
    path: 'faculty-login',
    component: FacultyLogin
  },
  {
    path: 'dashboard',
    component: Dashboard
  },
  {
    path: 'faculty-dashboard',
    component: FacultyDashboard
  }
];