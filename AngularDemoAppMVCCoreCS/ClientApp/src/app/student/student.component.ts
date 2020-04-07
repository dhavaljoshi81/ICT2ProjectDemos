import { Component, Inject } from '@angular/core';
import { HttpClient } from '@angular/common/http';


@Component({
  selector: 'app-student',
  templateUrl: './student.component.html'
})

export class StudentComponent {
  public students: Student[];

  constructor(http: HttpClient, @Inject('BASE_URL') baseUrl: string) {
    http.get<Student[]>(baseUrl + 'student').subscribe(result => {
      this.students = result;
    }, error => console.error(error));
  }
}

interface Student {
  ID: number;
  Name: string;
  Age: number;
  City: string;
}
