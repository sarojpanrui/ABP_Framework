import { RestService, Rest } from '@abp/ng.core';
import { Injectable, inject } from '@angular/core';
import type { User } from '../entities/models';

@Injectable({
  providedIn: 'root',
})
export class UserService {
  private restService = inject(RestService);
  apiName = 'Default';
  

  create = (input: User, config?: Partial<Rest.Config>) =>
    this.restService.request<any, User>({
      method: 'POST',
      url: '/api/app/user',
      body: input,
    },
    { apiName: this.apiName,...config });
  

  delete = (id: string, config?: Partial<Rest.Config>) =>
    this.restService.request<any, void>({
      method: 'DELETE',
      url: `/api/app/user/${id}`,
    },
    { apiName: this.apiName,...config });
  

  getList = (config?: Partial<Rest.Config>) =>
    this.restService.request<any, User[]>({
      method: 'GET',
      url: '/api/app/user',
    },
    { apiName: this.apiName,...config });
}