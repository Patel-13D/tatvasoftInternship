import { Component } from '@angular/core';
import { FormsModule } from '@angular/forms'; // ✅ Add this import

@Component({
  standalone: true,
  selector: 'app-root',
  templateUrl: './app.html',
  styleUrls: ['./app.css'],
  imports: [FormsModule] // ✅ Now this works
})
export class App {
  user = {
    username: '',
    password: ''
  };

  onSubmit() {
    console.log('Form Submitted:', this.user);
    alert(`Username: ${this.user.username}\nPassword: ${this.user.password}`);
  }
}
