import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';

import { DashboardComponent } from './dashboard.component';
import { DashboardRoutingModule } from './dashboard-routing.module';

import { TableModule } from 'primeng/table';
import { ImageModule } from 'primeng/image';

@NgModule({
  declarations: [DashboardComponent],
  imports: [CommonModule, DashboardRoutingModule, TableModule, ImageModule],
})
export class DashboardModule {}
