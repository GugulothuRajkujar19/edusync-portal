import { Component } from '@angular/core';
import { Router } from '@angular/router';

@Component({
  selector: 'app-faculty-login',
  imports: [],
  templateUrl: './faculty-login.html',
  styleUrl: './faculty-login.css'
})
export class FacultyLogin {

  constructor(private router: Router) {}

  goToFacultyDashboard() {
    this.router.navigate(['/faculty-dashboard']);
  }

}