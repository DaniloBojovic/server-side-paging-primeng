import { Injectable } from '@angular/core';
import { HttpClient, HttpParams } from '@angular/common/http';

@Injectable({
  providedIn: 'root',
})
export class CustomerService {
  constructor(private http: HttpClient) {}

  getCustomersLarge(params?: any): Promise<any> {
    debugger;
    return this.http
      .get<any>('assets/customers-large.json')
      .toPromise()
      .then((res) => res)
      .then((data) => data);
  }

  getBooks(params?: any): Promise<any> {
    let queryParams = new HttpParams();
    queryParams = queryParams.append('startRow', params.lazyEvent.first);
    queryParams = queryParams.append('endRow', params.lazyEvent.rows);
    queryParams = queryParams.append('sortField', params.lazyEvent.sortField);
    queryParams = queryParams.append('sortOrder', params.lazyEvent.sortOrder);
    return this.http
      .get<any>('http://localhost:14170/api/Book/getbooks', {
        params: queryParams,
      })
      .toPromise()
      .then((res) => res);
  }
}
