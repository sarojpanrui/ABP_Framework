import { RestService, Rest } from '@abp/ng.core';
import { Injectable, inject } from '@angular/core';
import type { TodoItemDto } from '../dtos/models';

@Injectable({
  providedIn: 'root',
})
export class TodoServicesService {
  private restService = inject(RestService);
  apiName = 'Default';
  

  create = (text: string, config?: Partial<Rest.Config>) =>
    this.restService.request<any, TodoItemDto>({
      method: 'POST',
      url: '/api/app/todo-services',
      params: { text },
    },
    { apiName: this.apiName,...config });
  

  delete = (id: string, config?: Partial<Rest.Config>) =>
    this.restService.request<any, void>({
      method: 'DELETE',
      url: `/api/app/todo-services/${id}`,
    },
    { apiName: this.apiName,...config });
  

  getList = (config?: Partial<Rest.Config>) =>
    this.restService.request<any, TodoItemDto[]>({
      method: 'GET',
      url: '/api/app/todo-services',
    },
    { apiName: this.apiName,...config });
}