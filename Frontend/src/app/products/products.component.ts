import { Component, OnInit } from '@angular/core';
import { HttpClient } from '@angular/common/http';

@Component({
  selector: 'products',
  templateUrl: './products.component.html',
  styleUrls: ['./products.component.css'],
})
export class ProductsComponent implements OnInit {
  constructor(private http: HttpClient) {
    http.get('http://localhost:5160/api/users/').subscribe((data) => {
      //this.records = data;
      console.log(data);
    });
  }

  ngOnInit(): void {}
}
