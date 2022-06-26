import { ChangeDetectorRef, Component, OnInit } from '@angular/core';
import { LazyLoadEvent } from 'primeng/api';
import { Customer, Representative } from 'src/app/models/customer';
import { BookService } from 'src/app/services/book.service';

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
    private bookService: BookService,
    private cdr: ChangeDetectorRef
  ) {}

  ngOnInit(): void {}

  loadBooks(event: LazyLoadEvent): void {
    debugger;
    this.loading = true;

    setTimeout(() => {
      this.bookService.getBooks({ lazyEvent: event }).then((res) => {
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
