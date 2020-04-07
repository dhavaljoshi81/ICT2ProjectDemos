import { Component, Inject } from '@angular/core';
import { HttpClient } from '@angular/common/http';


@Component({
  selector: 'app-book',
  templateUrl: './book.component.html'
})

export class BookComponent {
  public books: Book[];

  constructor(http: HttpClient, @Inject('BASE_URL') baseUrl: string) {
    http.get<Book[]>(baseUrl + 'book').subscribe(result => {
      this.books = result;
    }, error => console.error(error));
  }
}

interface Book {
  Id: number;
  Title: string;
  Author: string;
  Price: number;  
}
