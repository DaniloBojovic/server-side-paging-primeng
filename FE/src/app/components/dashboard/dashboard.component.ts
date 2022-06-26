import { ChangeDetectorRef, Component, OnInit } from '@angular/core';
import { LazyLoadEvent } from 'primeng/api';
import { Customer, Representative } from 'src/app/models/customer';
import { CustomerService } from 'src/app/services/customer.service';

@Component({
  selector: 'app-dashboard',
  templateUrl: './dashboard.component.html',
  styleUrls: ['./dashboard.component.css'],
})
export class DashboardComponent implements OnInit {
  books!: Customer[];

  totalRecords!: number;

  cols!: any[];

  loading!: boolean;

  constructor(
    private customerService: CustomerService,
    private cdr: ChangeDetectorRef
  ) {}

  ngOnInit(): void {}

  loadBooks(event: LazyLoadEvent): void {
    this.loading = true;

    setTimeout(() => {
      this.customerService.getBooks({ lazyEvent: event }).then((res) => {
        this.books = res.books;
        this.totalRecords = res.totalRecords;
        this.loading = false;
      });
    }, 1000);
  }

  ngAfterViewInit() {
    this.cdr.detectChanges();
  }
}
